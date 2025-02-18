﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DotNet.UpgradeAssistant.Extensions.Windows {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DotNet.UpgradeAssistant.Extensions.Windows.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Default font in Windows Forms has been changed from Microsoft Sans Serif to Seg Segoe UI, in order to change the default font use the API - Application.SetDefaultFont(Font font). For more details see here - https://devblogs.microsoft.com/dotnet/whats-new-in-windows-forms-in-net-6-0-preview-5/#application-wide-default-font..
        /// </summary>
        internal static string DefaultFontMessage {
            get {
                return ResourceManager.GetString("DefaultFontMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application.EnableVisualStyles().
        /// </summary>
        internal static string EnableVisualStylesLine {
            get {
                return ResourceManager.GetString("EnableVisualStylesLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /configuration/System.Windows.Forms.ApplicationConfigurationSection.
        /// </summary>
        internal static string HighDPIConfiguration {
            get {
                return ResourceManager.GetString("HighDPIConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SystemAware.
        /// </summary>
        internal static string HighDpiDefaultSetting {
            get {
                return ResourceManager.GetString("HighDpiDefaultSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HighDpiMode needs to set in Main() instead of app.config or app.manifest - Application.SetHighDpiMode(HighDpiMode.&lt;setting&gt;). It is recommended to use SystemAware as the HighDpiMode option for better results..
        /// </summary>
        internal static string HighDPIMessage {
            get {
                return ResourceManager.GetString("HighDPIMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DpiAwareness.
        /// </summary>
        internal static string HighDpiSettingKey {
            get {
                return ResourceManager.GetString("HighDpiSettingKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application.SetHighDpiMode(HighDpiMode.{0});.
        /// </summary>
        internal static string HighDPISettingLine {
            get {
                return ResourceManager.GetString("HighDPISettingLine", resourceCulture);
            }
        }
    }
}
