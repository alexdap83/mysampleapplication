using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace SampleApplication
{
    public partial class MainForm : RibbonForm
    {
        private Sides? tempSides = null;

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
            SetResolution(ScanProfile.CurrentSetting.ResolutionValue);
            SetFeederMode(ScanProfile.CurrentSetting.CurrentFeeder);
            SetPaperSize(ScanProfile.CurrentSetting.CurrentPaperSizeValue);
            DeskewChangedState(ScanProfile.CurrentSetting.Desknew);
            AutoCropChangedState(ScanProfile.CurrentSetting.AutoCrop);
            BrightnessValueChanged(50);
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

        private void SetResolution(int value)
        {
            barEditItem2.EditValue = value;
            ScanProfile.CurrentSetting.ResolutionValue = value;
        }

        private void SetFeederMode(FeederMode mode)
        {
            bool flatbedMode = mode == FeederMode.Flatbed;
            bool feederMode = mode == FeederMode.Feerder;

            SetChecked(barButtonItemFeeder, feederMode);
            SetChecked(barButtonItemFlatbed, flatbedMode);
            SetEnable(barButtonItemBothSides, feederMode);
            ScanProfile.CurrentSetting.CurrentFeeder = mode;

            if (flatbedMode) SetSides(Sides.OneSide);
            if(feederMode && tempSides != null)SetSides(Sides.BothSides);
            
        }
        private void SetSides(Sides mode)
        {
            if (mode == Sides.OneSide && ScanProfile.CurrentSetting.CurrentFeeder == FeederMode.Flatbed && ScanProfile.CurrentSetting.CurrentSides == Sides.BothSides)
                tempSides = Sides.BothSides;
            else
                tempSides = null;
            SetChecked(barButtonItemOneSide, mode == Sides.OneSide);
            SetChecked(barButtonItemBothSides, mode == Sides.BothSides);
            SetVisible(barButtonItemBack, mode == Sides.BothSides);
            ScanProfile.CurrentSetting.CurrentSides = mode;
        }
        private void SetPaperSize(string size)
        {
            barEditItemSize.EditValue = size;
            ScanProfile.CurrentSetting.CurrentPaperSizeValue = size;
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

        private void BrightnessValueChanged(int value)
        {
            barEditItemBrightness.EditValue = value;
            barEditItemBrightnessValue.EditValue = value;
        }
        private void barButtonItemDeskew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeskewChangedState(IsChecked(e.Item));
        }

        private void barButtonItemAutoCrop_ItemClick(object sender, ItemClickEventArgs e)
        {
            AutoCropChangedState(IsChecked(e.Item));
        }

        private void repositoryItemTrackBar1_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl) sender;
            BrightnessValueChanged(control.Value);
        }

        private void barButtonItemFlatbed_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetFeederMode(FeederMode.Flatbed);
        }

        private void barButtonItemFeeder_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetFeederMode(FeederMode.Feerder);
        }

        private void repositoryItemComboBox1_EditValueChanged(object sender, EventArgs e)
        {
            var item = (ComboBoxEdit) sender;
            SetResolution(int.Parse(item.EditValue.ToString()));
        }

        private void barButtonItemOneSide_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetSides(Sides.OneSide);
        }
        private void barButtonItemBothSides_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetSides(Sides.BothSides);
        }

        private void repositoryItemComboBox3_EditValueChanged(object sender, EventArgs e)
        {
            var item = (ComboBoxEdit)sender;
            SetPaperSize(item.EditValue.ToString());
        }
    }
}