﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFC.EnvMan.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class FrmMainSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static FrmMainSettings defaultInstance = ((FrmMainSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new FrmMainSettings())));
        
        public static FrmMainSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState FrmWindowState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["FrmWindowState"]));
            }
            set {
                this["FrmWindowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10, 10")]
        public global::System.Drawing.Point FrmWindowLocation {
            get {
                return ((global::System.Drawing.Point)(this["FrmWindowLocation"]));
            }
            set {
                this["FrmWindowLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("377, 448")]
        public global::System.Drawing.Size FrmSize {
            get {
                return ((global::System.Drawing.Size)(this["FrmSize"]));
            }
            set {
                this["FrmSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OnlyOneInstance {
            get {
                return ((bool)(this["OnlyOneInstance"]));
            }
            set {
                this["OnlyOneInstance"] = value;
            }
        }
    }
}
