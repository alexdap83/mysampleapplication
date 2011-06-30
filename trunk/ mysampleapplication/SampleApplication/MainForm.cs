using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace SampleApplication
{
    public partial class MainForm : RibbonForm
    {
//        private ScanSettingMode CurrentScanSettingMode;
        public MainForm()
        {
            InitializeComponent();
            ribbon.ForceInitialize(); // Fix error: skin gallery not show until click on dropdown
            SkinHelper.CreateGallery(ribbonGalleryBarItemThemes);

            SetupGroup();
            SetScanSettingMode(ScanSettingMode.Scanner);
//            CurrentScanSettingMode = ScanSettingMode.Scanner;
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

            foreach (var ribbonPageGroup in ScannerGroups)
            {
                ribbonPageGroup.Visible = modeScanner;
            }

            foreach (var ribbonPageGroup in VRSGeneralGroups)
            {
                ribbonPageGroup.Visible = modeVRSGeneral;
            }
            foreach (var ribbonPageGroup in VRSColorGroups)
            {
                ribbonPageGroup.Visible = modeVRSColor;
            }

        }
    }
}