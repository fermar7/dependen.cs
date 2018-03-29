using DependenCS.CodeAnalysis.API.Data.Enums;
using DependenCS.CodeAnalysis.API.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependenCS.CodeAnalysis.API.Data.Models
{
    public abstract class MemberBase : SymbolBase, IHasType, IHasAccessModifier
    {
        public Type Type { get; }

        public AccessModifier AccessModifier { get; }

        protected MemberBase(string name, Type type, AccessModifier accessModifier)
            : base(name)
        {
            this.Type = type;
            this.AccessModifier = accessModifier;
        }
    }
}
