using DependenCS.CodeAnalysis.API.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependenCS.CodeAnalysis.API.Data.Models
{
    public abstract class SymbolBase : IHasName
    {
        public string Name { get; }

        protected SymbolBase(string name)
        {
            this.Name = name;
        }
    }
}
