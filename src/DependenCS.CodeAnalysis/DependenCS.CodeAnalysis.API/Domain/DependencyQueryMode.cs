using System;

namespace DependenCS.CodeAnalysis.API.Domain
{
    [Flags]
    public enum DependencyQueryMode
    {
        None = 0,
        Classes = 1,
        Structs = 2,
        Interfaces = 4,
        Delegates = 8,
        Properties = 16,
        Fields = 32,
        Methods = 64,
        Indexers = 128,
        Constructors = 256,
        Types = Classes | Structs | Interfaces | Delegates,
        TypesAndMembers = Types | Properties | Fields | Methods | Indexers | Constructors
    }
}
