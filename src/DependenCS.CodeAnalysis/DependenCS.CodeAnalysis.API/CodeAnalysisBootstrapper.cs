using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace DependenCS.CodeAnalysis.API
{
    public static class CodeAnalysisBootstrapper
    {
        public async static Task<Compilation> BootstrapAsync(string solutionPath, ProjectId projectId)
        {
            var msBuildWorkspace = MSBuildWorkspace.Create();
            var solution = await msBuildWorkspace.OpenSolutionAsync(solutionPath);
            if (solution == null)
            {

            }
            var project = solution.GetProject(projectId);
            return await CompileProject(project);
        }

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

            }
            return await project.GetCompilationAsync();
        }
    }
}
