using DependenCS.CodeAnalysis.API.Data.Models;
using DependenCS.CodeAnalysis.API.Domain.SymbolProcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenCS.CodeAnalysis.API.Domain
{
    internal static class ProcessorStore
    {
        internal static ICollection<ITypeSymbolProcessor> TypeSymbolProcessors { get; } = new List<ITypeSymbolProcessor>
        {
            new ClassSymbolProcessor(),
        };

        internal static ICollection<IMemberSymbolProcessor> MemberSymbolProcessors { get; } = new List<IMemberSymbolProcessor>
        {
            new FieldSymbolProcessor(),
            new MethodSymbolProcessor(),
        };
    }
}
