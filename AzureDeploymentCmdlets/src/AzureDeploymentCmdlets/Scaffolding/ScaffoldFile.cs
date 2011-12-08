﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AzureDeploymentCmdlets.Scaffolding
{
    /// <summary>
    /// Represents an individual scaffolding file to copy and/or transform.
    /// </summary>
    public class ScaffoldFile
    {
        /// <summary>
        /// Gets or sets the relative path to the scaffold file.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets an optional directory to use when resolving the
        /// relative Path.
        /// </summary>
        /// <remarks>
        /// The value of the SourceDirectory is currently expected to be a
        /// string value in the parameters dictionary passed in for the
        /// generation of scaffolding.  We would like to change this at some
        /// point in the future.
        /// </remarks>
        public string SourceDirectory { get; set; }

        /// <summary>
        /// Gets or sets a .NET regular expression that will be matched against
        /// every file in the directory to determine a set of files to act
        /// upon.
        /// </summary>
        /// <remarks>
        /// If a PathExpression is provided, it will be used instead of any
        /// provided Path.
        /// </remarks>
        public string PathExpression { get; set; }

        /// <summary>
        /// Gets or sets the relative target path of the file.  This is useful
        /// if you want to change the name of a file when copying it.
        /// </summary>
        public string TargetPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the file should be
        /// copied.
        /// </summary>
        /// <remarks>
        /// The default value is true.  It's only useful to turn this off when
        /// combined with custom rules.
        /// </remarks>
        public bool Copy { get; set; }

        /// <summary>
        /// Gets a collection of rules to apply to the file.  The rules are
        /// applied in sequence.
        /// </summary>
        public List<ScaffoldRule> Rules { get; private set; }

        /// <summary>
        /// Initializes a new instance of the ScaffoldFile class.
        /// </summary>
        public ScaffoldFile()
        {
            Copy = true;
            Rules = new List<ScaffoldRule>();
        }
    }
}
