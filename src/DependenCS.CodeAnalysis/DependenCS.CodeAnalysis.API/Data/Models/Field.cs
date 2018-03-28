using System;
using System.Collections.Generic;
using System.Text;
using DependenCS.CodeAnalysis.API.Data.Enums;

namespace DependenCS.CodeAnalysis.API.Data.Models
{
    public class Field : Member
    {
        internal Field(string name, Type type, AccessModifier accessModifier) 
            : base(name, type, accessModifier)
        {
        }
    }
}
