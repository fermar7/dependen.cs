using DependenCS.CodeAnalysis.API.Data.Enums;
using DependenCS.CodeAnalysis.API.Data.Interfaces;
using System.Collections.Generic;

namespace DependenCS.CodeAnalysis.API.Data.Models
{
    public class Constructor : IHasAccessModifier, IHasParameters
    {
        public AccessModifier AccessModifier { get; }

        public IEnumerable<Parameter> Parameters { get; }
    }
}
