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
    internal class ClassSymbolProcessor : ITypeSymbolProcessor
    {
        public TypeBase Process(ISymbol symbol)
        {
            var typeSymbol = symbol as INamedTypeSymbol;
            
            var memberSymbols = typeSymbol.GetMembers();
            var members = new List<MemberBase>();
            foreach (var memberSymbol in memberSymbols)
            {
                var processor = ProcessorStore.MemberSymbolProcessors.FirstOrDefault(x => x.Valid(memberSymbol));
                if (processor != null)
                {
                    members.Add(processor.Process(memberSymbol));
                }
            }
            
            // TODO: constructors, inner types and inner types of inner types and inner types of inner types of inner types and inn... you know what i mean

            return new Class(typeSymbol.Name, typeSymbol.DeclaredAccessibility.AsAccessModifier(), null);
        }

        public bool Valid(ISymbol symbol)
        {
            if (symbol is INamedTypeSymbol namedType)
            {
                return namedType.TypeKind == TypeKind.Class;
            }

            return false;
        }
    }
}
