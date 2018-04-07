﻿using DependenCS.CodeAnalysis.API.Data.Models;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenCS.CodeAnalysis.API.Domain.SymbolProcessors
{
    interface IMemberSymbolProcessor : ISymbolProcessor
    {
        MemberBase Process(ISymbol symbol);
    }
}
