using DevExpress.XtraBars.Ribbon;

namespace SampleApplication
{
    public class AppSetting : XMLData
    {
        #region Property

        public bool IsRibbonMinimized { get; set; }
        public RibbonQuickAccessToolbarLocation ToolbarLocation { get; set; }
        public int SelectedPageIndex { get; set; }

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