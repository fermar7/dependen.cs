using DependenCS.CodeAnalysis.API.Data.Models;
using System.Collections.Generic;

namespace DependenCS.CodeAnalysis.API.Data.Interfaces
{
    public interface IHasParameters
    {
        IEnumerable<Parameter> Parameters { get; }
    }
}
