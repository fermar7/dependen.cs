using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependenCS.CodeAnalysis.API.Domain.Exceptions
{
    [Serializable]
    public class BootstrappingException : Exception
    {
        public BootstrappingError Error { get; }

        public BootstrappingException(BootstrappingError error)
        {
            this.Error = error;
        }

        public enum BootstrappingError
        {
            Solution,
            Project,
            Compilation
        }
    }
}
