using System;
using System.Collections.Generic;
using System.Text;
using DependenCS.CodeAnalysis.API.Data.Enums;
using DependenCS.CodeAnalysis.API.Data.Interfaces;

namespace DependenCS.CodeAnalysis.API.Data.Models
{
    public class Class : TypeBase, IInstantiable
    {
        public IEnumerable<Constructor> Constructors { get; }

        internal Class(string name, AccessModifier accessModifier, IEnumerable<Constructor> constructors) 
            : base(name, accessModifier)
        {
            this.Constructors = constructors;
        }
    }
}
