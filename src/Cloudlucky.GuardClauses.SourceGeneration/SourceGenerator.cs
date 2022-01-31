using Microsoft.CodeAnalysis;
using System.Diagnostics;

namespace Cloudlucky.GuardClauses.SourceGeneration;

[Generator]
public class SourceGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
        // No initialization required for this one
    }

    public void Execute(GeneratorExecutionContext context)
    {
        //if (!Debugger.IsAttached)
        //{
        //    Debugger.Launch();
        //}

        InterpolatedStringHandlerSourceGenerator.Execute(context);
    }
}
