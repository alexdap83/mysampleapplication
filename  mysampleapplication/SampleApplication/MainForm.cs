using System;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace SampleApplication
{
    public partial class MainForm : RibbonForm
    {
        private Sides? tempSides = null;
        private ScanProfile scanProfile = ScanProfile.CurrentSetting;

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
            SetScanSettingMode(scanProfile.CurrentScanSettingMode,false);

            LoadScanProfile();
            ribbon.Minimized = AppSetting.CurrentSetting.IsRibbonMinimized;
            ribbon.ToolbarLocation = AppSetting.CurrentSetting.ToolbarLocation;
            //SetSelectedPage(AppSetting.CurrentSetting.SelectedPageIndex);
            SetSelectedPage(0); // Allways show Home Tab
        }

        private void LoadScanProfile()
        {
            SetResolution(scanProfile.ResolutionValue,false);
            SetFeederMode(scanProfile.CurrentFeeder,false);
            SetPaperSize(scanProfile.CurrentPaperSizeValue,false);
            SetOrientation(scanProfile.CurrentOrientation,false);
            SetRotationFront(scanProfile.FontRotation,false);
            SetRotationBack(scanProfile.BackRotation,false);
            SetOutOfPaperResolve(scanProfile.OutOfPaperAutoResolve,false);
            SetPaperJamResolve(scanProfile.PaperJamAutoResolve,false);
            SetCoverOpenResolve(scanProfile.CoverOpenAutoResolve,false);
            SetMultilFeedResolve(scanProfile.MultiFeedAutoResolve,false);

            DeskewChangedState(scanProfile.Desknew,false);
            AutoCropChangedState(scanProfile.AutoCrop,false);
            BrightnessValueChanged(50);
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            AppSetting.CurrentSetting.IsRibbonMinimized = ribbon.Minimized;
            AppSetting.CurrentSetting.SelectedPageIndex = ribbon.SelectedPage.PageIndex;
            AppSetting.CurrentSetting.ToolbarLocation = ribbon.ToolbarLocation;
            AppSetting.CurrentSetting.Save();

            scanProfile.Save();
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
                    SetScanSettingMode(ScanSettingMode.Scanner,true);
                    break;
                case "barButtonItemVRSGeneral":
                    SetScanSettingMode(ScanSettingMode.VRSGeneral, true);
                    break;
                case "barButtonItemVRSColor":
                    SetScanSettingMode(ScanSettingMode.VRSColor, true);
                    break;
                case "barButtonItemBlackAndWhite":
                    SetColorSettingMode(ColorMode.BlackAndWhite, true);
                    break;
                case "barButtonItemGrayscale":
                    SetColorSettingMode(ColorMode.Grayscale, true);
                    break;
                case "barButtonItemColor":
                    SetColorSettingMode(ColorMode.Color, true);
                    break;
            }
        }

        private void SetScanSettingMode(ScanSettingMode mode, bool autoSave)
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
            if(autoSave)
                scanProfile.CurrentScanSettingMode = mode;
        }
        private void SetColorSettingMode(ColorMode mode, bool autoSave)
        {
            bool modeBlackAndWhite = mode == ColorMode.BlackAndWhite;
            bool modeGrayscale = mode == ColorMode.Grayscale;
            bool modeColor = mode == ColorMode.Color;

            SetChecked(barButtonItemBlackAndWhite, modeBlackAndWhite);
            SetChecked(barButtonItemGrayscale, modeGrayscale);
            SetChecked(barButtonItemColor, modeColor);

            if (autoSave)
                scanProfile.CurrentColorMode = mode;
        }

        private void SetResolution(int value,bool autoSave)
        {
            barEditItem2.EditValue = value;
            if (autoSave)
                scanProfile.ResolutionValue = value;
        }

        private void SetFeederMode(FeederMode mode, bool autoSave)
        {
            bool flatbedMode = mode == FeederMode.Flatbed;
            bool feederMode = mode == FeederMode.Feerder;

            SetChecked(barButtonItemFeeder, feederMode);
            SetChecked(barButtonItemFlatbed, flatbedMode);
            SetEnable(barButtonItemBothSides, feederMode);
            if (autoSave)
                scanProfile.CurrentFeeder = mode;

            if (flatbedMode) SetSides(Sides.OneSide,autoSave);
            if(feederMode && tempSides != null)SetSides(Sides.BothSides,autoSave);
            
        }
        private void SetSides(Sides mode, bool autoSave)
        {
            if (mode == Sides.OneSide && scanProfile.CurrentFeeder == FeederMode.Flatbed && scanProfile.CurrentSides == Sides.BothSides)
                tempSides = Sides.BothSides;
            else
                tempSides = null;
            SetChecked(barButtonItemOneSide, mode == Sides.OneSide);
            SetChecked(barButtonItemBothSides, mode == Sides.BothSides);
            SetVisible(barButtonItemBack, mode == Sides.BothSides);
            if (autoSave)
                scanProfile.CurrentSides = mode;
        }
        private void SetPaperSize(string size, bool autoSave)
        {
            barEditItemSize.EditValue = size;
            if (autoSave) 
                scanProfile.CurrentPaperSizeValue = size;
        }
        private void SetOrientation(Orientation mode,bool autoSave)
        {
            bool modeLandscape = mode == Orientation.Landscape;
            bool modePortrait = mode == Orientation.Portrait;
            SetChecked(barButtonItemLandscape,modeLandscape);
            SetChecked(barButtonItemPortrait,modePortrait);
            if (autoSave) 
                scanProfile.CurrentOrientation = mode;
        }

        private void BrightnessValueChanged(int value)
        {
            barEditItemBrightness.EditValue = value;
            barEditItemBrightnessValue.EditValue = value;
        }
        private void SetRotationFront(Rotation rotation, bool autoSave)
        {
            if(rotation == Rotation.Rotate0)
            {
                SetChecked(barCheckItemFront0,true);
                barButtonItemFront.Glyph = barCheckItemFront0.Glyph;
                barButtonItemFront.LargeGlyph = barCheckItemFront0.Glyph;
            }
            else if(rotation == Rotation.Rotate90Left)
            {
                SetChecked(barCheckItemFront90Left, true);
                barButtonItemFront.Glyph = barCheckItemFront90Left.Glyph;
                barButtonItemFront.LargeGlyph = barCheckItemFront90Left.Glyph;
            }
            else if(rotation == Rotation.Rotate90Right)
            {
                SetChecked(barCheckItemFront90Right, true);
                barButtonItemFront.Glyph = barCheckItemFront90Right.Glyph;
                barButtonItemFront.LargeGlyph = barCheckItemFront90Right.Glyph;
            }
            else if(rotation == Rotation.Rotate180)
            {
                SetChecked(barCheckItemFront180, true);
                barButtonItemFront.Glyph = barCheckItemFront180.Glyph;
                barButtonItemFront.LargeGlyph = barCheckItemFront180.Glyph;
            }
            scanProfile.FontRotation = rotation;

            SetRotationBack(rotation, autoSave);
            
        }

        private void SetRotationBack(Rotation rotation, bool autoSave)
        {
            if (rotation == Rotation.Rotate0)
            {
                SetChecked(barCheckItemBack0, true);
                barButtonItemBack.Glyph = barCheckItemBack0.Glyph;
                barButtonItemBack.LargeGlyph = barCheckItemBack0.Glyph;
            }
            else if (rotation == Rotation.Rotate90Left)
            {
                SetChecked(barCheckItemBack90Left, true);
                barButtonItemBack.Glyph = barCheckItemBack90Left.Glyph;
                barButtonItemBack.LargeGlyph = barCheckItemBack90Left.Glyph;
            }
            else if (rotation == Rotation.Rotate90Right)
            {
                SetChecked(barCheckItemBack90Right, true);
                barButtonItemBack.Glyph = barCheckItemBack90Right.Glyph;
                barButtonItemBack.LargeGlyph = barCheckItemBack90Right.Glyph;
            }
            else if (rotation == Rotation.Rotate180)
            {
                SetChecked(barCheckItemBack180, true);
                barButtonItemBack.Glyph = barCheckItemBack180.Glyph;
                barButtonItemBack.LargeGlyph = barCheckItemBack180.Glyph;
            }
            if(autoSave)
                scanProfile.BackRotation = rotation;
        }
        private void SetOutOfPaperResolve(bool isChecked,bool autoSave)
        {
            SetChecked(barCheckItemOutOfPaper, isChecked);
            if (autoSave) 
                scanProfile.OutOfPaperAutoResolve = isChecked;

        }
        private void SetPaperJamResolve(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemPaperJam, isChecked);
            if (autoSave)
                scanProfile.PaperJamAutoResolve = isChecked;
        }
        private void SetCoverOpenResolve(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemCoverOpen, isChecked);
            if (autoSave)
                scanProfile.CoverOpenAutoResolve = isChecked;
        }
        private void SetMultilFeedResolve(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemMultifeed, isChecked);
            if (autoSave)
                scanProfile.MultiFeedAutoResolve = isChecked;
        }

        private void DeskewChangedState(bool isChecked, bool autoSave)
        {
            barButtonItemDeskew.Down
            = barButtonItemAutoCrop.Enabled
                = barButtonItemEdgeCleanup.Enabled
                  = barButtonItemAutoRotate.Enabled
                    = isChecked;
            if (autoSave)
                scanProfile.Desknew = isChecked;
        }

        private void AutoCropChangedState(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemAutoCrop, isChecked);
            if (autoSave)
                scanProfile.AutoCrop = isChecked;
        }

        private void barButtonItemDeskew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeskewChangedState(IsChecked(e.Item), true);
        }

        private void barButtonItemAutoCrop_ItemClick(object sender, ItemClickEventArgs e)
        {
            AutoCropChangedState(IsChecked(e.Item), true);
        }

        private void repositoryItemTrackBar1_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl) sender;
            BrightnessValueChanged(control.Value);
        }

        private void barButtonItemFlatbed_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetFeederMode(FeederMode.Flatbed, true);
        }

        private void barButtonItemFeeder_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetFeederMode(FeederMode.Feerder, true);
        }

        private void repositoryItemComboBox1_EditValueChanged(object sender, EventArgs e)
        {
            var item = (ComboBoxEdit) sender;
            SetResolution(int.Parse(item.EditValue.ToString()), true);
        }

        private void barButtonItemOneSide_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetSides(Sides.OneSide, true);
        }
        private void barButtonItemBothSides_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetSides(Sides.BothSides, true);
        }

        private void repositoryItemComboBox3_EditValueChanged(object sender, EventArgs e)
        {
            var item = (ComboBoxEdit)sender;
            SetPaperSize(item.EditValue.ToString(), true);
        }

        private void barButtonItemPortrait_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetOrientation(Orientation.Portrait, true);
        }
        private void barButtonItemLandscape_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetOrientation(Orientation.Landscape, true);
        }

        private void barButtonItemResetScanSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            ScanProfile.Reload();
            scanProfile = ScanProfile.CurrentSetting;
            LoadScanProfile();
        }

        private void barCheckItemFront0_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRotationFront(Rotation.Rotate0, true);
        }

        private void barCheckItemFront90Left_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRotationFront(Rotation.Rotate90Left, true);
        } 
        private void barCheckItemFront90Right_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRotationFront(Rotation.Rotate90Right, true);
        }
        private void barCheckItemFront180_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRotationFront(Rotation.Rotate180, true);
        }
        private void barCheckItemBack0_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRotationBack(Rotation.Rotate0,true);
        }

        private void barCheckItemBack90Left_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRotationBack(Rotation.Rotate90Left, true);
        }
        private void barCheckItemBack90Right_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRotationBack(Rotation.Rotate90Right, true);
        }
        private void barCheckItemBack180_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRotationBack(Rotation.Rotate180, true);
        }

        private void barCheckItemOutOfPaper_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetOutOfPaperResolve(((BarCheckItem)e.Item).Checked,true);
        }

        private void barCheckItemPaperJam_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPaperJamResolve(((BarCheckItem)e.Item).Checked, true);
        }

        private void barCheckItemCoverOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetCoverOpenResolve(((BarCheckItem)e.Item).Checked, true);
        }

        private void barCheckItemMultifeed_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetMultilFeedResolve(((BarCheckItem)e.Item).Checked, true);
        }

        private void barButtonItemSelectScanner_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmSelectScanner();
            frm.ShowDialog();
        }
    }
}