using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace SlangNet.Pretty.SourceGenerator;

[Generator]
public class ThrowingMethodGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        if (context.SyntaxContextReceiver is not SyntaxReceiver receiver)
            return;

        foreach (var clazz in receiver.Classes)
            ProcessClass(context, clazz);
    }

    private void ProcessClass(GeneratorExecutionContext context, ITypeSymbol clazz)
    {
        var source = new StringBuilder();
        source.AppendLine("#nullable enable");
        source.AppendLine($"namespace {clazz.ContainingNamespace.ToDisplayString()};");
        source.AppendLine($"partial class {clazz.Name}");
        source.AppendLine("{");

        foreach (var method in clazz.GetMembers().OfType<IMethodSymbol>())
        {
            if (method.DeclaredAccessibility != Accessibility.Public ||
                !method.Name.StartsWith("Try") ||
                method.ReturnType.ToDisplayString() != "SlangNet.SlangResult" ||
                method.GetAttributes().Any(a => a.AttributeClass.ToDisplayString() == "SlangNet.IgnoreThrowingMethodAttribute"))
                continue;

            var returnType = "void";
            var parameters = method.Parameters.ToList();
            var outputParam = parameters.LastOrDefault();
            if (outputParam?.RefKind == RefKind.Out)
            {
                parameters.RemoveAt(parameters.Count - 1);
                returnType = outputParam.Type.ToDisplayString().TrimEnd('?');
            }
            else
                outputParam = null;

            source.Append("    public ");
            if (method.IsStatic)
                source.Append("static ");
            source.Append(returnType);
            source.Append(' ');
            source.Append(method.Name.Substring(3));
            source.Append('(');

            foreach (var param in parameters)
            {
                if (!ReferenceEquals(param, parameters.First()))
                    source.Append(", ");
                source.Append(param.ToDisplayString());
            }
            source.AppendLine(")");
            source.AppendLine("    {");

            source.Append("        ");
            source.Append(method.Name);
            source.Append("(");

            foreach (var param in parameters)
            {
                if (!ReferenceEquals(param, parameters.First()))
                    source.Append(", ");
                source.Append(param.Name);
            }
            if (outputParam != null)
            {
                if (parameters.Any())
                    source.Append(", ");
                source.Append("out var ");
                source.Append(outputParam.Name);
            }
            source.AppendLine(").ThrowIfFailed();");

            if (outputParam != null)
            {
                source.Append("        return ");
                source.Append(outputParam.Name);
                source.AppendLine("!;");
            }

            source.AppendLine("    }");
        }

        source.AppendLine("}");
        context.AddSource($"{clazz.Name}_throwing.g.cs", SourceText.From(source.ToString(), Encoding.UTF8));
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
    }

    private class SyntaxReceiver : ISyntaxContextReceiver
    {
        public HashSet<ITypeSymbol> Classes { get; } = new(SymbolEqualityComparer.Default);

        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is not ClassDeclarationSyntax classSyntax ||
                context.SemanticModel.GetDeclaredSymbol(classSyntax) is not ITypeSymbol classSymbol)
                return;

            var attributeData = classSymbol
                .GetAttributes()
                .FirstOrDefault(a => a.AttributeClass?.ToDisplayString() == "SlangNet.GenerateThrowingMethodsAttribute");
            if (attributeData == null)
                return;

            Classes.Add(classSymbol);
        }
    }
}
