//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackWriter {
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
    internal class strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new SingleFileResourceManager("BlackWriter.strings", typeof(strings));
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
        ///   Looks up a localized string similar to Folder not found.
        /// </summary>
        internal static string folderNotFound {
            get {
                return ResourceManager.GetString("folderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Load answer picture.
        /// </summary>
        internal static string loadAnswerPicture {
            get {
                return ResourceManager.GetString("loadAnswerPicture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Load cover picture.
        /// </summary>
        internal static string loadCoverPicture {
            get {
                return ResourceManager.GetString("loadCoverPicture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Load question picture.
        /// </summary>
        internal static string loadQuestionPicture {
            get {
                return ResourceManager.GetString("loadQuestionPicture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This package already exists!.
        /// </summary>
        internal static string packageExists {
            get {
                return ResourceManager.GetString("packageExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Override? / Save as new package? / Cancel?.
        /// </summary>
        internal static string packageOverride {
            get {
                return ResourceManager.GetString("packageOverride", resourceCulture);
            }
        }
    }
}