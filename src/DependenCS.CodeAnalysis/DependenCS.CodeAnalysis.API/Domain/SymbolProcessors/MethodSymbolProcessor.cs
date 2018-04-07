using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependenCS.CodeAnalysis.API.Data.Models;
using DependenCS.CodeAnalysis.API.Domain.Extensions;
using Microsoft.CodeAnalysis;

namespace DependenCS.CodeAnalysis.API.Domain.SymbolProcessors
{
    public class MethodSymbolProcessor : IMemberSymbolProcessor
    {
        public MemberBase Process(ISymbol symbol)
        {
            var methodSymbol = symbol as IMethodSymbol;
            var parameters = methodSymbol.Parameters.Select(x => new Parameter(x.Name, null));
            return new Method(methodSymbol.Name, null, methodSymbol.DeclaredAccessibility.AsAccessModifier(), parameters);
        }

        public bool Valid(ISymbol symbol)
        {
            return symbol is IMethodSymbol;
        }
    }
}
