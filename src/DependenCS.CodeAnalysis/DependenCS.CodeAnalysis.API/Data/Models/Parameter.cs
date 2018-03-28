using DependenCS.CodeAnalysis.API.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependenCS.CodeAnalysis.API.Data.Models
{
    public class Parameter : IHasName, IHasType
    {
        public string Name { get; }

        public Type Type { get; }
    }
}
