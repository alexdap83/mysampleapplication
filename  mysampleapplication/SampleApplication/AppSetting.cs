using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace SampleApplication
{
    public class AppSetting : XMLData
    {
        #region Property

        public bool IsRibbonMinimized { get; set; }
        public RibbonQuickAccessToolbarLocation ToolbarLocation { get; set; }
        public int SelectedPageIndex { get; set; }
        public List<string> QuickAccessItem { get; set; }
        public string Theme { get; set; }
        public ViewerType CurrentViewType { get; set; }
        public FitType CurrentFitType { get; set; }
        public int CurrentZoomValue { get; set; }
        private FormWindowState _windowState;
        public FormWindowState WindowState
        {
            get { return _windowState; }
            set {
                _windowState = value == FormWindowState.Minimized ? FormWindowState.Normal : value;
            }
        }
        

        #endregion

        #region Job

        public RawImageType RawImageType { get; set; }
        public List<string> Jobs { get; set; }
        public string BatchPath { get; set; }
        public string NextbatchName { get; set; }
        public bool UseDocumentSeperation { get; set; }
        public DocumentSeparationMode DocumentSeparation { get; set; }
        public int BlankSheetSensitivityvalue { get; set; }
        public int EveryNSheetsCount { get; set; }
        public bool DeletepatchCodeSeperator{ get; set; }
        public PatchCodeType PatchCode { get; set; }
        public bool WhenBarCodeChange { get; set; }
        public BarCodeType BarCode { get; set; }
        public List<BarCodeType> BarCodeTypes { get; set; }
        public bool Checksum { get; set; }
        public int MinimumLength { get; set; }
        #endregion

        private static AppSetting _currentSetting;

        public static AppSetting CurrentSetting
        {
            get
            {
                if (_currentSetting == null)
                {
                    try
                    {
                        _currentSetting = Load<AppSetting>("AppSetting.xml");
                    }
                    catch
                    {
                        _currentSetting = new AppSetting();
                    }
                }
                return _currentSetting;
            }
        }

        
    }
}