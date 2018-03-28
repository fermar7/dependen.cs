using System;
using System.Collections.Generic;
using System.Text;
using DependenCS.CodeAnalysis.API.Data.Enums;

namespace DependenCS.CodeAnalysis.API.Data.Models
{
    public class Method : Member
    {
        public IEnumerable<Parameter> Parameters { get; }

        internal Method(string name, Type type, AccessModifier accessModifier, IEnumerable<Parameter> parameters) 
            : base(name, type, accessModifier)
        {
            this.Parameters = parameters;
        }
    }
}
