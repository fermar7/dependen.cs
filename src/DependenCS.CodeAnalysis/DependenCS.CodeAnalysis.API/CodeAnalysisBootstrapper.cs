using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependenCS.CodeAnalysis.API.Domain.Exceptions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace DependenCS.CodeAnalysis.API
{
    public static class CodeAnalysisBootstrapper
    {
        /// <summary>
        /// Bootstraps the code analysis service using a solution path and the id of a project
        /// </summary>
        /// <param name="solutionPath">Location of the solution</param>
        /// <param name="projectId">Id of the project to load</param>
        /// <exception cref="DependenCS.CodeAnalysis.API.Domain.Exceptions.BootstrappingException">Thrown when solution or project were not found or the compilation failed</exception>
        /// <returns></returns>
        public async static Task<Compilation> BootstrapAsync(string solutionPath, ProjectId projectId)
        {
            var msBuildWorkspace = MSBuildWorkspace.Create();
            var solution = await msBuildWorkspace.OpenSolutionAsync(solutionPath);
            if (solution == null)
            {
                throw new BootstrappingException(BootstrappingException.BootstrappingError.Solution);
            }
            var project = solution.GetProject(projectId);
            return await CompileProject(project);
        }

        /// <summary>
        /// Bootstraps the code analysis service using a project path
        /// </summary>
        /// <param name="projectPath">Location of the project</param>
        /// <exception cref="DependenCS.CodeAnalysis.API.Domain.Exceptions.BootstrappingException">Thrown when the project was not found or the compilation failed</exception>
        /// <returns></returns>
        public async static Task<Compilation> BootstrapAsync(string projectPath)
        {
            var msBuildWorkspace = MSBuildWorkspace.Create();
            var project = await msBuildWorkspace.OpenProjectAsync(projectPath);
            return await CompileProject(project);
        }

        private async static Task<Compilation> CompileProject(Project project)
        {
            if (project == null)
            {
                throw new BootstrappingException(BootstrappingException.BootstrappingError.Project);
            }

            var compilation = await project.GetCompilationAsync();
            if (compilation == null)
            {
                throw new BootstrappingException(BootstrappingException.BootstrappingError.Compilation);
            }

            return compilation;
        }
    }
}
