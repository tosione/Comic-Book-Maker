﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comic_Book_Maker.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool create_from_folders {
            get {
                return ((bool)(this["create_from_folders"]));
            }
            set {
                this["create_from_folders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool create_from_archives {
            get {
                return ((bool)(this["create_from_archives"]));
            }
            set {
                this["create_from_archives"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\WinRAR\\Rar.exe")]
        public string rar_path {
            get {
                return ((string)(this["rar_path"]));
            }
            set {
                this["rar_path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool convert_comics {
            get {
                return ((bool)(this["convert_comics"]));
            }
            set {
                this["convert_comics"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool clean_files_enable {
            get {
                return ((bool)(this["clean_files_enable"]));
            }
            set {
                this["clean_files_enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("zzz*.*|*.url")]
        public string clean_files_string {
            get {
                return ((string)(this["clean_files_string"]));
            }
            set {
                this["clean_files_string"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public decimal clean_files_limit_n {
            get {
                return ((decimal)(this["clean_files_limit_n"]));
            }
            set {
                this["clean_files_limit_n"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool multi_core_enable {
            get {
                return ((bool)(this["multi_core_enable"]));
            }
            set {
                this["multi_core_enable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool close_after_complete {
            get {
                return ((bool)(this["close_after_complete"]));
            }
            set {
                this["close_after_complete"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool delete_input_files {
            get {
                return ((bool)(this["delete_input_files"]));
            }
            set {
                this["delete_input_files"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(" (\\n)")]
        public string file_exist_suffix {
            get {
                return ((string)(this["file_exist_suffix"]));
            }
            set {
                this["file_exist_suffix"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int output_type_selection {
            get {
                return ((int)(this["output_type_selection"]));
            }
            set {
                this["output_type_selection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("340")]
        public int column_width_input {
            get {
                return ((int)(this["column_width_input"]));
            }
            set {
                this["column_width_input"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int column_width_type {
            get {
                return ((int)(this["column_width_type"]));
            }
            set {
                this["column_width_type"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("320")]
        public int column_width_output {
            get {
                return ((int)(this["column_width_output"]));
            }
            set {
                this["column_width_output"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int column_width_state {
            get {
                return ((int)(this["column_width_state"]));
            }
            set {
                this["column_width_state"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int file_exist_selection {
            get {
                return ((int)(this["file_exist_selection"]));
            }
            set {
                this["file_exist_selection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100, 100")]
        public global::System.Drawing.Point form_location {
            get {
                return ((global::System.Drawing.Point)(this["form_location"]));
            }
            set {
                this["form_location"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1100, 600")]
        public global::System.Drawing.Size form_size {
            get {
                return ((global::System.Drawing.Size)(this["form_size"]));
            }
            set {
                this["form_size"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Gabriel\\Desktop\\Out\\")]
        public string output_path {
            get {
                return ((string)(this["output_path"]));
            }
            set {
                this["output_path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool use_ouput_folder {
            get {
                return ((bool)(this["use_ouput_folder"]));
            }
            set {
                this["use_ouput_folder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int remove_folder_structure_selection {
            get {
                return ((int)(this["remove_folder_structure_selection"]));
            }
            set {
                this["remove_folder_structure_selection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool go_after_file_add {
            get {
                return ((bool)(this["go_after_file_add"]));
            }
            set {
                this["go_after_file_add"] = value;
            }
        }
    }
}
