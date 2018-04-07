using DependenCS.CodeAnalysis.API.Data.Interfaces;
using System;

namespace DependenCS.CodeAnalysis.API.Data.Models
{
    public class Parameter : IHasName, IHasType
    {
        public string Name { get; }

        public Type Type { get; }

        internal Parameter(string name, Type type)
        {
            Name = name;
            Type = type;
        }
    }
}
