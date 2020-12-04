﻿namespace Pulumi.X.Automation
{
    /// <summary>
    /// Description of a stack backed by pre-existing local Pulumi CLI program.
    /// </summary>
    public class LocalProgramArgs : LocalWorkspaceOptions
    {
        public string StackName { get; }

        public LocalProgramArgs(
            string stackName,
            string workDir)
        {
            this.StackName = stackName;
            this.WorkDir = workDir;
        }
    }
}
