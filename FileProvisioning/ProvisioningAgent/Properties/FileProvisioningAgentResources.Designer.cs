﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Samples.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class FileProvisioningAgentResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FileProvisioningAgentResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Samples.Properties.FileProvisioningAgentResources", typeof(FileProvisioningAgentResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FileAgnt &lt;agent base address&gt; &lt;target file path&gt;
        ///
        ///Here is an example: &quot;FileAgnt http://localhost:9000 TargetFile.csv.&quot;.
        /// </summary>
        internal static string InformationCommandLineArguments {
            get {
                return ResourceManager.GetString("InformationCommandLineArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting to a file, {0}.
        /// </summary>
        internal static string InformationConnectionStringTemplate {
            get {
                return ResourceManager.GetString("InformationConnectionStringTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing a request to create an  entry with this source identifier: {0}.
        /// </summary>
        internal static string InformationCreating {
            get {
                return ResourceManager.GetString("InformationCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing a request to delete a {0} entry with this identifier: {1}.
        /// </summary>
        internal static string InformationDeleting {
            get {
                return ResourceManager.GetString("InformationDeleting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing a request to patch a {0}  entry with this identifier: {1}.
        /// </summary>
        internal static string InformationPatching {
            get {
                return ResourceManager.GetString("InformationPatching", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Querying for a {0}  entry with this external identifier: {1}.
        /// </summary>
        internal static string InformationQuerying {
            get {
                return ResourceManager.GetString("InformationQuerying", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing a request to retrieve a  {0} entry with this identifier: {1}.
        /// </summary>
        internal static string InformationRetrieving {
            get {
                return ResourceManager.GetString("InformationRetrieving", resourceCulture);
            }
        }
    }
}
