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
            SetScanSettingMode(ScanProfile.CurrentSetting.CurrentScanSettingMode);
            DeskewChangedState(ScanProfile.CurrentSetting.Desknew);
            AutoCropChangedState(ScanProfile.CurrentSetting.AutoCrop);

            ribbon.Minimized = AppSetting.CurrentSetting.IsRibbonMinimized;
            ribbon.ToolbarLocation = AppSetting.CurrentSetting.ToolbarLocation;
            //SetSelectedPage(AppSetting.CurrentSetting.SelectedPageIndex);
            SetSelectedPage(0); // Allways show Home Tab
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
            switch (item.Name)
            {
                case "barButtonItemScanner":
                    SetScanSettingMode(ScanSettingMode.Scanner);
                    break;
                case "barButtonItemVRSGeneral":
                    SetScanSettingMode(ScanSettingMode.VRSGeneral);
                    break;
                case "barButtonItemVRSColor":
                    SetScanSettingMode(ScanSettingMode.VRSColor);
                    break;
                case "barButtonItemBlackAndWhite":
                    SetColorSettingMode(ColorMode.BlackAndWhite);
                    break;
                case "barButtonItemGrayscale":
                    SetColorSettingMode(ColorMode.Grayscale);
                    break;
                case "barButtonItemColor":
                    SetColorSettingMode(ColorMode.Color);
                    break;
            }
        }

        private void SetScanSettingMode(ScanSettingMode mode)
        {
            bool modeScanner = mode == ScanSettingMode.Scanner;
            bool modeVRSColor = mode == ScanSettingMode.VRSColor;
            bool modeVRSGeneral = mode == ScanSettingMode.VRSGeneral;

            SetChecked(barButtonItemScanner, modeScanner);
            SetChecked(barButtonItemVRSColor, modeVRSColor);
            SetChecked(barButtonItemVRSGeneral, modeVRSGeneral);

            ScannerGroups.ForEach(p => p.Visible = modeScanner);
            VRSGeneralGroups.ForEach(p => p.Visible = modeVRSGeneral);
            VRSColorGroups.ForEach(p => p.Visible = modeVRSColor);

            ScanProfile.CurrentSetting.CurrentScanSettingMode = mode;
        }

        private void SetColorSettingMode(ColorMode mode)
        {
            bool modeBlackAndWhite = mode == ColorMode.BlackAndWhite;
            bool modeGrayscale = mode == ColorMode.Grayscale;
            bool modeColor = mode == ColorMode.Color;

            SetChecked(barButtonItemBlackAndWhite, modeBlackAndWhite);
            SetChecked(barButtonItemGrayscale, modeGrayscale);
            SetChecked(barButtonItemColor, modeColor);

            ScanProfile.CurrentSetting.CurrentColorMode = mode;
        }

        private void DeskewChangedState(bool isChecked)
        {
            barButtonItemDeskew.Down
            = barButtonItemAutoCrop.Enabled
                = barButtonItemEdgeCleanup.Enabled
                  = barButtonItemAutoRotate.Enabled
                    =isChecked;
            ScanProfile.CurrentSetting.Desknew = isChecked;
        }

        private void AutoCropChangedState(bool isChecked)
        {
            SetChecked(barButtonItemAutoCrop,isChecked);
            ScanProfile.CurrentSetting.AutoCrop = isChecked;
        }

        private void barButtonItemDeskew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeskewChangedState(IsChecked(e.Item));
        }

        private void barButtonItemAutoCrop_ItemClick(object sender, ItemClickEventArgs e)
        {
            AutoCropChangedState(IsChecked(e.Item));
        }
    }
}