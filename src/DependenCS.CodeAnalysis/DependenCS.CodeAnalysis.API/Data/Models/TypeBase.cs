using DependenCS.CodeAnalysis.API.Data.Enums;
using DependenCS.CodeAnalysis.API.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependenCS.CodeAnalysis.API.Data.Models
{
    public abstract class TypeBase : SymbolBase, IHasAccessModifier
    {
        public AccessModifier AccessModifier { get; }

        protected TypeBase(string name, AccessModifier accessModifier) 
            : base(name)
        {
            this.AccessModifier = accessModifier;
        }
    }
}
