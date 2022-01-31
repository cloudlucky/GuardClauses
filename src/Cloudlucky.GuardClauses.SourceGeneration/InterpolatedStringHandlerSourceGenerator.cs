using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using Scriban;

namespace Cloudlucky.GuardClauses.SourceGeneration;

internal class InterpolatedStringHandlerSourceGenerator
{
    private static readonly string InterpolatedStringHandlerFullName = typeof(InterpolatedStringHandler).Name;
    private const string InterpolatedStringHandlerTemplateName = "InterpolatedStringHandlerTemplate";

    /// <summary>
    /// Gets all struct with the attribute InterpolatedStringHandler and generates all the methods 
    /// </summary>
    public static void Execute(GeneratorExecutionContext context)
    {
        var language = context.Compilation.Language.Replace("#", "sharp").ToLowerInvariant();
        var attributeSymbol = context.Compilation.GetTypeByMetadataName(InterpolatedStringHandlerFullName);

        var classWithAttributes = context.Compilation.SyntaxTrees.Where(st => st.GetRoot().DescendantNodes().OfType<StructDeclarationSyntax>()
                .Any(p => p.DescendantNodes().OfType<AttributeSyntax>().Any(x => x.Name.ToString() == InterpolatedStringHandlerFullName)));

        foreach (var tree in classWithAttributes)
        {
            var fileScopedNamespaceDeclarationSyntax = tree.GetRoot().DescendantNodes().OfType<FileScopedNamespaceDeclarationSyntax>().First();
            var structDeclarationSyntaxList = tree.GetRoot().DescendantNodes().OfType<StructDeclarationSyntax>().ToList();

            foreach (var structDeclarationSyntax in structDeclarationSyntaxList)
            {
                var templateString = ResourceReader.GetResource($"{InterpolatedStringHandlerTemplateName}.{language}.scriban");
                var template = Template.Parse(templateString);
                var result = template.Render(new
                {
                    Namespace = fileScopedNamespaceDeclarationSyntax.Name.ToString(),
                    Name = $"{structDeclarationSyntax.Identifier}{structDeclarationSyntax.TypeParameterList}"
                });

                var typeParameters = structDeclarationSyntax.TypeParameterList is null
                    ? string.Empty
                    : string.Join(string.Empty, structDeclarationSyntax.TypeParameterList.Parameters);
                context.AddSource($"{structDeclarationSyntax.Identifier}{typeParameters}", result);
            }
        }
    }

    private class InterpolatedStringHandler
    {
    }
}
