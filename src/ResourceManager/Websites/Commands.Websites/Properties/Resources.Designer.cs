﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.WebApps.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.WebApps.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to This will modify LocalHost\Client\TrustedHosts and LocalHost\Client\Auth policy. Continue?.
        /// </summary>
        internal static string EnterPSSessionWarning {
            get {
                return ResourceManager.GetString("EnterPSSessionWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory &apos;{0}&apos; does not exist, please check the directory path and try again..
        /// </summary>
        internal static string GitDirectoryDoesNotExist {
            get {
                return ResourceManager.GetString("GitDirectoryDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To connect your website with a git repository, you must have the git executable installed. Please download and install git from https://git-scm.com/.
        /// </summary>
        internal static string GitInstallMessage {
            get {
                return ResourceManager.GetString("GitInstallMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to add git remote to directory &apos;{0}&apos; with error &apos;{1}&apos;.
        /// </summary>
        internal static string GitRemoteAddFailure {
            get {
                return ResourceManager.GetString("GitRemoteAddFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &apos;git push azure master&apos; to push local changes to this website..
        /// </summary>
        internal static string GitRemoteMessage {
            get {
                return ResourceManager.GetString("GitRemoteMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing web app slot.
        /// </summary>
        internal static string RemoveWebappSlotMessage {
            get {
                return ResourceManager.GetString("RemoveWebappSlotMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the web app slot &quot;{0}({1})&quot;.
        /// </summary>
        internal static string RemoveWebappSlotWarning {
            get {
                return ResourceManager.GetString("RemoveWebappSlotWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing web app ssl binding.
        /// </summary>
        internal static string RemoveWebAppSSLBinding {
            get {
                return ResourceManager.GetString("RemoveWebAppSSLBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing web app.
        /// </summary>
        internal static string RemoveWebsiteMessage {
            get {
                return ResourceManager.GetString("RemoveWebsiteMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the web app &quot;{0}&quot;.
        /// </summary>
        internal static string RemoveWebsiteWarning {
            get {
                return ResourceManager.GetString("RemoveWebsiteWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove app service plan &apos;{0}&apos;.
        /// </summary>
        internal static string RemovingAppServicePlan {
            get {
                return ResourceManager.GetString("RemovingAppServicePlan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the web app ssl binding for hostname &apos;{0}&apos;.
        /// </summary>
        internal static string RemovingWebAppSSLBinding {
            get {
                return ResourceManager.GetString("RemovingWebAppSSLBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove web app &apos;{0}&apos;.
        /// </summary>
        internal static string RemovingWebsite {
            get {
                return ResourceManager.GetString("RemovingWebsite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create.
        /// </summary>
        internal static string SimpleWebAppCreateAction {
            get {
                return ResourceManager.GetString("SimpleWebAppCreateAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WebApp &apos;{0}&apos;.
        /// </summary>
        internal static string SimpleWebAppCreateTarget {
            get {
                return ResourceManager.GetString("SimpleWebAppCreateTarget", resourceCulture);
            }
        }
    }
}
