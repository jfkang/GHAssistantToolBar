using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.ADF.BaseClasses;

namespace GHAssistantToolbar
{
    /// <summary>
    /// Summary description for GAToolbar.
    /// </summary>
    [Guid("c2b717ec-aaeb-476e-a379-fdb9ebe49f79")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("GHAssistantToolbar.GAToolbar")]
    public sealed class GAToolbar : BaseToolbar
    {
        #region COM Registration Function(s)
        [ComRegisterFunction()]
        [ComVisible(false)]
        static void RegisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryRegistration(registerType);

            //
            // TODO: Add any COM registration code here
            //
        }

        [ComUnregisterFunction()]
        [ComVisible(false)]
        static void UnregisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryUnregistration(registerType);

            //
            // TODO: Add any COM unregistration code here
            //
        }

        #region ArcGIS Component Category Registrar generated code
        /// <summary>
        /// Required method for ArcGIS Component Category registration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryRegistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            ControlsToolbars.Register(regKey);
        }
        /// <summary>
        /// Required method for ArcGIS Component Category unregistration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryUnregistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            ControlsToolbars.Unregister(regKey);
        }

        #endregion
        #endregion

        public GAToolbar()
        {
            //
            // TODO: Define your toolbar here by adding items
            //
            //AddItem("esriControls.ControlsMapZoomInTool");
            //BeginGroup(); //Separator
            //AddItem("{380FB31E-6C24-4F5C-B1DF-47F33586B885}"); //undo command
            //AddItem(new Guid("B0675372-0271-4680-9A2C-269B3F0C01E8")); //redo command
        }

        public override string Caption
        {
            get
            {
                //TODO: Replace bar caption
                return "My C# Toolbar";
            }
        }
        public override string Name
        {
            get
            {
                //TODO: Replace bar ID
                return "GAToolbar";
            }
        }
    }
}