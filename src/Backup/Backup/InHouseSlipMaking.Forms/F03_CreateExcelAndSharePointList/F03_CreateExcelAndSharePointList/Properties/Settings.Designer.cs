﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace F03_CreateExcelAndSharePointList.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:51046/InHouseSlipMaking.Web/Webservices/CreateExcelAndUpdateShar" +
            "ePointListWS.asmx")]
        public string F03_CreateExcelAndSharePointList_CreateExcelAndUpdateSharePointListWS_CreateExcelAndUpdateSharePointListWS {
            get {
                return ((string)(this["F03_CreateExcelAndSharePointList_CreateExcelAndUpdateSharePointListWS_CreateExcel" +
                    "AndUpdateSharePointListWS"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Setting.ini")]
        public string PATH_SETTING_FILE {
            get {
                return ((string)(this["PATH_SETTING_FILE"]));
            }
            set {
                this["PATH_SETTING_FILE"] = value;
            }
        }
    }
}
