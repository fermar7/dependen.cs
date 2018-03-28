using DependenCS.CodeAnalysis.API.Data.Enums;
using DependenCS.CodeAnalysis.API.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependenCS.CodeAnalysis.API.Data.Models
{
    public abstract class Member : IHasName, IHasType, IHasAccessModifier
    {
        public string Name { get; }

        public Type Type { get; }

        public AccessModifier AccessModifier { get; }

        protected Member(string name, Type type, AccessModifier accessModifier)
        {
            this.Name = name;
            this.Type = type;
            this.AccessModifier = accessModifier;
        }
    }
}
