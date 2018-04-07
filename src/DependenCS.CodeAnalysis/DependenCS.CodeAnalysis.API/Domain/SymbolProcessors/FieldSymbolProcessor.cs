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
    internal class FieldSymbolProcessor : IMemberSymbolProcessor
    {
        public MemberBase Process(ISymbol symbol)
        {
            var fieldSymbol = symbol as IFieldSymbol;
            return new Field(fieldSymbol.Name, null, fieldSymbol.DeclaredAccessibility.AsAccessModifier());
        }

        public bool Valid(ISymbol symbol)
        {
            return symbol is IFieldSymbol;
        }
    }
}
