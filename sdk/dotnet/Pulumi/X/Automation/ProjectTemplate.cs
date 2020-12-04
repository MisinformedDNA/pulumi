﻿using System.Collections.Generic;

namespace Pulumi.X.Automation
{
    /// <summary>
    /// A template used to seed new stacks created from this project.
    /// </summary>
    public class ProjectTemplate
    {
        public string? Description { get; set; }

        public string? QuickStart { get; set; }

        public IDictionary<string, ProjectTemplateConfigValue>? Config { get; set; }

        public bool? Important { get; set; }
    }
}
