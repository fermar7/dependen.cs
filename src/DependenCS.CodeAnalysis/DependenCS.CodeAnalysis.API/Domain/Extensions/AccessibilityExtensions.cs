using DependenCS.CodeAnalysis.API.Data.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenCS.CodeAnalysis.API.Domain.Extensions
{
    internal static class AccessibilityExtensions
    {
        internal static AccessModifier AsAccessModifier(this Accessibility accessibility)
        {
            switch(accessibility)
            {
                case Accessibility.Private:
                    return AccessModifier.Private;
                case Accessibility.Protected:
                    return AccessModifier.Protected;
                case Accessibility.Public:
                    return AccessModifier.Public;
                case Accessibility.Internal:
                    return AccessModifier.Internal;
                default:
                    return AccessModifier.None;
            }
        }
    }
}
