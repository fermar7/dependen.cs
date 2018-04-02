﻿using DependenCS.CodeAnalysis.API.Data.Models;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenCS.CodeAnalysis.API.Domain
{
    public class DependecyCodeAnalyzer
    {
        private Compilation Compilation { get; }

        internal DependecyCodeAnalyzer(Compilation compilation)
        {
            this.Compilation = compilation;
        }

        public IEnumerable<SymbolBase> Analyze(DependencyQueryMode dependencyQueryMode)
        {
            var symbols = this.Compilation.GetSymbolsWithName(x => true);
        }
    }
}
