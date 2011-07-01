using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace SampleApplication
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
//            CurrentScanSettingMode = ScanSettingMode.Scanner;
        }

        protected override void OnLoad(EventArgs e)
        {
            arMRUList = new MRUArrayList(pcAppRecentJobs, imageList1.Images[0], imageList1.Images[1]);
            arMRUList.LabelClicked += OnLabelClicked;
            InitMostRecentJobs(arMRUList);

            ribbon.ForceInitialize(); // Fix error: skin gallery not show until click on dropdown
            SkinHelper.CreateGallery(ribbonGalleryBarItemThemes);

            SetupGroup();
            //SetScanSettingMode(AppSetting.CurrentSetting.CurrentScanSettingMode);
            ribbon.Minimized = AppSetting.CurrentSetting.IsRibbonMinimized;
            ribbon.ToolbarLocation = AppSetting.CurrentSetting.ToolbarLocation;
            SetSelectedPage(AppSetting.CurrentSetting.SelectedPageIndex);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            AppSetting.CurrentSetting.IsRibbonMinimized = ribbon.Minimized;
            AppSetting.CurrentSetting.SelectedPageIndex = ribbon.SelectedPage.PageIndex;
            AppSetting.CurrentSetting.ToolbarLocation = ribbon.ToolbarLocation;
            AppSetting.CurrentSetting.Save();

            ScanProfile.CurrentSetting.Save();
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ribbon.SelectedPage.Name == "ribbonScanSettings")
            {
                barButtonItemScanOne.RibbonStyle = RibbonItemStyles.SmallWithoutText;
                barButtonItemScanAll.RibbonStyle = RibbonItemStyles.SmallWithoutText;
                barButtonItemStop.RibbonStyle = RibbonItemStyles.SmallWithoutText;
            }
            else
            {
                barButtonItemScanOne.RibbonStyle = RibbonItemStyles.Default;
                barButtonItemScanAll.RibbonStyle = RibbonItemStyles.Default;
                barButtonItemStop.RibbonStyle = RibbonItemStyles.Default;
            }
        }

        private void barButtonItemScannerSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = (BarButtonItem) e.Item;
            if (item.Name == "barButtonItemScanner")
                SetScanSettingMode(ScanSettingMode.Scanner);
            else if (item.Name == "barButtonItemVRSGeneral")
                SetScanSettingMode(ScanSettingMode.VRSGeneral);
            else if (item.Name == "barButtonItemVRSColor")
                SetScanSettingMode(ScanSettingMode.VRSColor);
        }

        void SetScanSettingMode(ScanSettingMode mode)
        {
            bool modeScanner = mode == ScanSettingMode.Scanner;
            bool modeVRSColor = mode == ScanSettingMode.VRSColor;
            bool modeVRSGeneral = mode == ScanSettingMode.VRSGeneral;

            SetChecked(barButtonItemScanner,modeScanner);
            SetChecked(barButtonItemVRSColor,modeVRSColor);
            SetChecked(barButtonItemVRSGeneral, modeVRSGeneral);

            ScannerGroups.ForEach( p => p.Visible = modeScanner);
            VRSGeneralGroups.ForEach(p => p.Visible = modeVRSGeneral);
            VRSColorGroups.ForEach(p => p.Visible = modeVRSColor);
        }


    }
}