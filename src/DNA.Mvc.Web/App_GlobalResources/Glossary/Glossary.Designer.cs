//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Glossary {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Glossary() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Glossary", global::System.Reflection.Assembly.Load("App_GlobalResources"));
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
        ///   Looks up a localized string similar to Alternative text is text associated with an image that serves the same purpose and conveys the same essential information as the image..
        /// </summary>
        internal static string Alt {
            get {
                return ResourceManager.GetString("Alt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If your site has content you don&apos;t want search engines to access, use a robots.txt file to specify how search engines should crawl your site&apos;s content..
        /// </summary>
        internal static string Robot {
            get {
                return ResourceManager.GetString("Robot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The description of the website ,this text will set in the Meta tag in each page header part. If this option set, it will make the pages more searchable..
        /// </summary>
        internal static string Web_Desc {
            get {
                return ResourceManager.GetString("Web_Desc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the web site&apos;s title,this title will display on the window title and use for search engine&apos;s search result title..
        /// </summary>
        internal static string Web_Title {
            get {
                return ResourceManager.GetString("Web_Title", resourceCulture);
            }
        }
    }
}
