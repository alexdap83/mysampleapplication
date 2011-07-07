using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CustomCheckAndDropDownButton;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace SampleApplication
{
    public partial class MainForm : RibbonForm
    {
        private Sides? tempSides = null;
        private ScanProfile scanProfile = ScanProfile.CurrentSetting;
        private ColorMode tempColorMode;

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


            UserLookAndFeel.Default.SetSkinStyle(AppSetting.CurrentSetting.Theme);
            SetupUI();
            SetScanSettingMode(scanProfile.CurrentScanSettingMode, false);

            this.WindowState = AppSetting.CurrentSetting.WindowState;
            ribbon.Minimized = AppSetting.CurrentSetting.IsRibbonMinimized;
            ribbon.ToolbarLocation = AppSetting.CurrentSetting.ToolbarLocation;
            AddQuickAccessItem();
            SetCursorType(CursorType.Zoom);
            SetFitType(AppSetting.CurrentSetting.CurrentFitType, false);
            SetViewerType(AppSetting.CurrentSetting.CurrentViewType, false);
            SetZoomValue(AppSetting.CurrentSetting.CurrentZoomValue, false);
            LoadScanProfile();

            SetSelectedPage(0); // Allways show Home Tab
            LoadBatches();
            ribbon.ForceInitialize(); // Fix error: skin gallery not show until click on dropdown
            SkinHelper.CreateGallery(ribbonGalleryBarItemThemes);

            foreach (BarItemLink itemLink in popupMenuDocumentSeperation.ItemLinks)
            {
                if (itemLink.Item is BarCheckItem)
                {
                    itemLink.Item.ItemClick += itemLink_ItemClick;
                }
                else if (itemLink .Item is BarSubItem)
                {
                    BarSubItem subItem = (BarSubItem)itemLink.Item;
                    foreach (BarItemLink subItemLink in subItem.ItemLinks)
                    {
                        if (subItemLink.Item is BarCheckItem)
                        {
                            subItemLink.Item.ItemClick += new ItemClickEventHandler(itemLink_ItemClick);
                        }
                    }
                }
            }
            
        }

        private void LoadScanProfile()
        {
            SetColorSettingMode(scanProfile.CurrentColorMode,false);
            SetResolution(scanProfile.ResolutionValue,false);
            SetFeederMode(scanProfile.CurrentFeeder,false);
            SetSides(scanProfile.CurrentSides,false);
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
            SetEdgeCleanup(scanProfile.EdgeCleanup,false);
            SetHolePunchRemoval(scanProfile.RemoveHole,false);
            SetDeleteBlank(scanProfile.DeleteBlank,false);
            SetBlankContentSensitivityValue(scanProfile.BlankContentSensitivity,false);
            SetIgnoreHole(scanProfile.IgnoreHolePunches,false);
            SetAutoRotate(scanProfile.AutoRotate, false);
            SetAutoBrightness(scanProfile.AutoBrightness, false);
            SetAdvancedClarity(scanProfile.AdvanceClarity, false);
            SetAdvancedClarityValue(scanProfile.AdvanceClarityValue, false);
            SetAnalyzeColor(scanProfile.AnalyzeColor, false);
            SetIgnorePicture(scanProfile.IgnorePicture, false);
            SetThicknessValue(scanProfile.Thickness,false);
            SetSpeckleValue(scanProfile.Speckle,false);

            SetDetectColor(scanProfile.DetectColor, false);
            SetSmoothing(scanProfile.Smoothing,false);

            //SetRawImageType(scanProfile.RawImageType, false);
        }
        private void LoadBatches()
        {
            var list = new List<Batch>
                           {
                               new Batch
                                   {
                                       Icon = 0,
                                       BatchName = "Batch002",
                                       JobName = "Job1",
                                       Documents = 2,
                                       Pages = 5,
                                       Status = string.Empty
                                   },
                               new Batch
                                   {
                                       Icon = 1,
                                       BatchName = "Batch003",
                                       JobName = "Job1",
                                       Documents = 2,
                                       Pages = 5,
                                       Status = string.Empty
                                   },
                               new Batch
                                   {
                                       Icon = 0,
                                       BatchName = "Batch004",
                                       JobName = "Job1",
                                       Documents = 2,
                                       Pages = 5,
                                       Status = string.Empty
                                   }
                           };
            gridControl1.DataSource = list;
            gridControl2.DataSource = new List<Performance>
                                          {
                                             new Performance {Title = "Document", Value = "123"},
                                             new Performance {Title = "Image", Value = "24"}
                                          };
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            AppSetting.CurrentSetting.IsRibbonMinimized = ribbon.Minimized;
            AppSetting.CurrentSetting.SelectedPageIndex = ribbon.SelectedPage.PageIndex;
            AppSetting.CurrentSetting.ToolbarLocation = ribbon.ToolbarLocation;
            AppSetting.CurrentSetting.WindowState = this.WindowState;
            AppSetting.CurrentSetting.QuickAccessItem = GetQuickAccessItemName();
            AppSetting.CurrentSetting.Theme = UserLookAndFeel.Default.SkinName;
            AppSetting.CurrentSetting.Save();
            

            scanProfile.Save();
        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userUndoRedo1_Selected(object sender, SelectedEventArgs e)
        {
            barStaticItemStatus.Caption = string.Format("Undo count: {0}", e.SelectedIndex);
            popupControlContainerUndoRedo.HidePopup();
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
            if (modeColor)
                EnableModeColor();
            else if (modeGrayscale)
                EnableModeGrayscale();
            else if (modeBlackAndWhite)
                EnableModeBlackAndWhiteColor();
            if (autoSave)
                scanProfile.CurrentColorMode = mode;
           
            BrightnessValueChanged(scanProfile.Brightness, false);
            ContrastValueChanged(scanProfile.Contrast, false);
            GammaValueChanged(scanProfile.Gamma, false);
            SetEnable(barButtonItemSmoothing, scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barEditItemSmoothingTrackBar, scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barStaticItemSmoothing, scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barEditItemSmoothingValue, scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
        }
        private void SetAutoBrightness(bool isChecked,bool autoSave)
        {
            SetChecked(barEditItemAutoBrightness, isChecked);
            if (!scanProfile.AdvanceClarity || scanProfile.CurrentColorMode == ColorMode.Grayscale)
            {
                SetEnable(barEditItemBrightness, !isChecked);
                SetEnable(barEditItemBrightnessValue, !isChecked);
 
            }
            if(scanProfile.CurrentColorMode ==ColorMode.Grayscale)
            {
                SetEnable(barEditItemContrast,!isChecked);
                SetEnable(barEditItemContrastValue,!isChecked);
                SetEnable(barEditItemGamma,!isChecked);
                SetEnable(barEditItemGammaValue,!isChecked);
            }
            if (autoSave)
                scanProfile.AutoBrightness = isChecked;
        }

        private void SetAdvancedClarity(bool isChecked, bool autoSave)
        {
            SetChecked(barEditItemAdvancedClarity, isChecked);
            SetEnable(barButtonItemAdvancedClaritySetup, isChecked && scanProfile.CurrentColorMode == ColorMode.BlackAndWhite);
            SetEnable(barEditItemClarityValue, isChecked && scanProfile.CurrentColorMode == ColorMode.BlackAndWhite);
            SetEnable(barStaticItemHight, isChecked && scanProfile.CurrentColorMode == ColorMode.BlackAndWhite);

            SetEnable(barEditItemBrightness,!isChecked&& !scanProfile.AutoBrightness);
            SetEnable(barEditItemBrightnessValue, !isChecked && !scanProfile.AutoBrightness);
            SetEnable(barEditItemContrast,!isChecked);
            SetEnable(barEditItemContrastValue,!isChecked);
            if (autoSave)
                scanProfile.AdvanceClarity = isChecked;
        }

        private void SetAdvancedClarityValue(int value,bool autoSave)
        {
            barEditItemClarityValue.EditValue = value;
            if (autoSave)
                scanProfile.AdvanceClarityValue = value;
        }
        
        private void SetThicknessValue(int value,bool autoSave)
        {
            barEditItemThickness.EditValue = value;
            if (autoSave)
                scanProfile.Thickness = value;
        }
        
        private void SetSpeckleValue(int value, bool autoSave)
        {
            barEditItemSpeckle.EditValue = value;
            if (autoSave)
                scanProfile.Speckle = value;
        }

        private void SetBlankContentSensitivityValue(int value, bool autoSave)
        {
            barEditItemTrackBarBlankContentSensitivityValue.EditValue = value;
            barEditItemBlankContentSensitivityValue.EditValue = value;
            if (autoSave)
            {
                scanProfile.BlankContentSensitivity = value;
                SetDeleteBlank(true,true);
            }
        }
        private void SetIgnoreHole(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemIgnoreHole, isChecked);
            if (autoSave)
            {
                scanProfile.IgnoreHolePunches = isChecked;
                SetDeleteBlank(true, true);
            }
        }
        private void EnableModeBlackAndWhiteColor()
        {
            SetEnable(barEditItemBrightness, !scanProfile.AutoBrightness && !scanProfile.AdvanceClarity);
            SetEnable(barEditItemBrightnessValue, !scanProfile.AutoBrightness && !scanProfile.AdvanceClarity);
            SetEnable(barEditItemContrast, !scanProfile.AdvanceClarity);
            SetEnable(barEditItemContrastValue, !scanProfile.AdvanceClarity);
            SetEnable(barEditItemGamma, true);
            SetEnable(barEditItemGammaValue, true);
            SetEnable(barEditItemAutoBrightness, true);
            SetEnable(barEditItemAdvancedClarity, true);

            SetEnable(barEditItemClarityValue, scanProfile.AdvanceClarity);
            SetEnable(barStaticItemHight, scanProfile.AdvanceClarity);
            SetEnable(barButtonItemAdvancedClaritySetup, scanProfile.AdvanceClarity);

            SetEnable(barEditItemThickness, true);
            SetEnable(barStaticItemThickness, true);
            SetEnable(barEditItemSpeckle, true);
            SetEnable(barStaticItemSpeckle, true);
        }
        private void EnableModeGrayscale()
        {
            
            SetEnable(barEditItemBrightness, !scanProfile.AutoBrightness);
            SetEnable(barEditItemBrightnessValue, !scanProfile.AutoBrightness);
            SetEnable(barEditItemContrast, !scanProfile.AutoBrightness);
            SetEnable(barEditItemContrastValue, !scanProfile.AutoBrightness);
            SetEnable(barEditItemGamma, !scanProfile.AutoBrightness);
            SetEnable(barEditItemGammaValue, !scanProfile.AutoBrightness);

            SetEnable(barEditItemAutoBrightness, true);
            SetEnable(barEditItemAdvancedClarity, false);
            SetEnable(barEditItemClarityValue, false);
            SetEnable(barStaticItemHight, false);
            SetEnable(barButtonItemAdvancedClaritySetup, false);
            
            SetEnable(barEditItemThickness, false);
            SetEnable(barStaticItemThickness, false);
            SetEnable(barEditItemSpeckle, false);
            SetEnable(barStaticItemSpeckle, false);
            
        }
        private void EnableModeColor()
        {
            //SetChecked(barButtonItemColor, true);

            SetEnable(barEditItemBrightness, true);
            SetEnable(barEditItemBrightnessValue, true);
            SetEnable(barEditItemContrast, true);
            SetEnable(barEditItemContrastValue, true);
            SetEnable(barEditItemGamma, true);
            SetEnable(barEditItemGammaValue, true);

            SetEnable(barEditItemAutoBrightness,false);
            SetEnable(barEditItemAdvancedClarity, false);
            SetEnable(barEditItemClarityValue, false);
            SetEnable(barStaticItemHight, false);
            SetEnable(barButtonItemAdvancedClaritySetup, false);
            SetEnable(barEditItemAdvancedClarity, false);
            SetEnable(barEditItemThickness,false);
            SetEnable(barStaticItemThickness,false);
            SetEnable(barEditItemSpeckle,false);
            SetEnable(barStaticItemSpeckle,false);

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

            if (flatbedMode) 
                SetSides(Sides.OneSide,autoSave);
            else if(feederMode && tempSides != null)
                SetSides(Sides.BothSides,autoSave);
            
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

        private void BrightnessValueChanged(int value, bool autoSave)
        {
            barEditItemBrightness.EditValue = value;
            barEditItemBrightnessValue.EditValue = value;
            if (autoSave)
                scanProfile.Brightness = value;
        }
        private void ContrastValueChanged(int value, bool autoSave)
        {
            barEditItemContrast.EditValue = value;
            barEditItemContrastValue.EditValue = value;
            if (autoSave)
                scanProfile.Contrast = value;
        }
        private void GammaValueChanged(int value, bool autoSave)
        {
            barEditItemGamma.EditValue = value;
            barEditItemGammaValue.EditValue = value;
            if (autoSave)
                scanProfile.Gamma = value;
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
        private void SetEdgeCleanup(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemEdgeCleanup,isChecked);
            if (autoSave)
                scanProfile.EdgeCleanup = isChecked;
        }
        private void SetHolePunchRemoval(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemHolePunchRemoval,isChecked);
            if (autoSave)
                scanProfile.RemoveHole = isChecked;
        }
        private void SetDeleteBlank(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemDeleteBlank,isChecked);
            if (autoSave)
                scanProfile.DeleteBlank = isChecked;
        }
        private void SetAutoRotate(bool isChecked, bool autoSave)
        {
            SetChecked(barButtonItemAutoRotate,isChecked);
            if (autoSave)
                scanProfile.AutoRotate = isChecked;
        }

        private void SetDetectColor(bool isCheck, bool autoSave)
        {
            SetChecked(barButtonItemDetectColor,isCheck);
            if(isCheck)
            {
                tempColorMode = scanProfile.CurrentColorMode;
                SetColorSettingMode(ColorMode.Color,true);
            }
            else if (autoSave)
            {
                SetColorSettingMode(tempColorMode,true);
            }
            SetEnable(barButtonItemDetectSmallColorObjects, isCheck);
            SetEnable(barEditItemOverall, isCheck);
            SetEnable(barEditItemSensitivity, isCheck);
            SetEnable(barEditItemOverallValue, isCheck);
            SetEnable(barEditItemSensitivityValue, isCheck);
            SetEnable(barStaticItemOverall, isCheck);
            SetEnable(barStaticItemSensitivity, isCheck);

            SetEnable(barButtonItemBlackAndWhite,!isCheck);
            SetEnable(barButtonItemGrayscale,!isCheck);
            SetEnable(barButtonItemColor,!isCheck);
 
            SetEnable(barButtonItemSmoothing, !isCheck && scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barEditItemSmoothingTrackBar, !isCheck && scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barStaticItemSmoothing, !isCheck && scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);
            SetEnable(barEditItemSmoothingValue, !isCheck && scanProfile.CurrentColorMode != ColorMode.BlackAndWhite);

            if (autoSave)
                scanProfile.DetectColor = isCheck;
        }
        private void SetSmoothing(bool isCheck, bool autoSave)
        {
            SetChecked(barButtonItemSmoothing,isCheck);

            SetEnable(barEditItemSmoothingTrackBar, isCheck);
            SetEnable(barStaticItemSmoothing, isCheck);
            SetEnable(barEditItemSmoothingValue, isCheck);

           if (autoSave)
                scanProfile.Smoothing = isCheck;
        }

        private void barButtonItemDeskew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeskewChangedState(IsChecked(e.Item), true);
        }

        private void barButtonItemAutoCrop_ItemClick(object sender, ItemClickEventArgs e)
        {
            AutoCropChangedState(IsChecked(e.Item), true);
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

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            var item = (CheckEdit)sender;
            SetAutoBrightness(item.Checked, true);
        }

        private void repositoryItemCheckEdit2_CheckedChanged(object sender, EventArgs e)
        {
            var item = (CheckEdit)sender;
            SetAdvancedClarity(item.Checked, true);
        }

        private void repositoryItemSpinEditBrightness_EditValueChanged(object sender, EventArgs e)
        {
            var item = (SpinEdit) sender;
            BrightnessValueChanged((int) item.Value,true);
        }

        private void repositoryItemSpinEditContrast_EditValueChanged(object sender, EventArgs e)
        {
            var item = (SpinEdit)sender;
            ContrastValueChanged((int)item.Value, true);
        }

        private void repositoryItemSpinEditGamma_EditValueChanged(object sender, EventArgs e)
        {
            var item = (SpinEdit)sender;
            GammaValueChanged((int)item.Value, true);
        }

        private void repositoryItemTrackBarBrightness_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl)sender;
            BrightnessValueChanged(control.Value, true);
        }
        private void repositoryItemTrackBarContrast_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl)sender;
            ContrastValueChanged(control.Value, true);
        }

        private void repositoryItemTrackBarGamma_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl)sender;
            GammaValueChanged(control.Value, true);
        }

        private void repositoryItemTrackBarClarityValue_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl)sender;
            SetAdvancedClarityValue(control.Value,true);
        }

        private void repositoryItemTrackBarBlankContentSensitivity_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl)sender;
            SetBlankContentSensitivityValue(control.Value, true);
        }

        private void repositoryItemTrackBarThickness_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl)sender;
            SetThicknessValue(control.Value, true);
        }

        private void repositoryItemTrackBarSpeckle_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl)sender;
            SetSpeckleValue(control.Value, true);
        }

        private void barCheckItemIgnoreHole_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetIgnoreHole(((BarCheckItem)e.Item).Checked, true);
        }

        private void barButtonItemDeleteBlank_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetDeleteBlank(IsChecked((BarCheckAndDropDownButton)e.Item), true);
        }

        private void barButtonItemDetectColor_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetDetectColor(IsChecked((BarButtonItem)e.Item),true);
        }

        private void barButtonItemSmoothing_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetSmoothing(IsChecked((BarButtonItem)e.Item), true);
        }

        private void gridView1_ShowGridMenu(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuEventArgs e)
        {
            var view = (GridView) sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if(hitInfo.InRow)
                popupMenuBatch.ShowPopup(MousePosition);
        }

        private void ribbon_ShowCustomizationMenu(object sender, RibbonCustomizationMenuEventArgs e)
        {
            if (e.HitInfo !=null && e.HitInfo.Item !=null && (e.HitInfo.HitTest == DevExpress.XtraBars.Ribbon.ViewInfo.RibbonHitTest.Item || e.HitInfo.HitTest == RibbonHitTest.ItemDrop) && DefaultQuickAccess.Contains( e.HitInfo.Item.Item))
            {
                e.CustomizationMenu.ItemLinks[1].Item.Enabled = false;
                return;
            }
            e.CustomizationMenu.ItemLinks[1].Item.Enabled = true;
        }

        private void barButtonItemIndexing_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetIndexingMode(IsChecked((BarButtonItem) e.Item));
        }

        private void SetIndexingMode(bool isChecked)
        {
            ribbonPageGroupZonalOCR.Visible = isChecked;
            SetEnable(barButtonItemNewBatch,!isChecked);
            SetEnable(barButtonItemScanOne, !isChecked);
            SetEnable(barButtonItemScanAll, !isChecked);
            SetEnable(barButtonItemNewDocument, !isChecked);
            SetEnable(barButtonItemSplitDocument, !isChecked);

            
            SetVisible(barEditItemScanProfile,!isChecked);
            SetVisible(barButtonItemNewScanProfile,!isChecked);
            SetVisible(barButtonItemSaveScanProfile,!isChecked);
            SetVisible(barButtonItemSaveScanProfileAs,!isChecked);
            SetVisible(barButtonItemRenameScanProfile,!isChecked);
            SetVisible(barButtonItemDeleteScanProfile,!isChecked);
            SetVisible(barButtonItemIndexFristDocument,isChecked);
            SetVisible(barButtonItemPreviousDocument,isChecked);
            SetVisible(barButtonItemNextDocument,isChecked);
            SetVisible(barButtonItemLastDocument,isChecked);
            SetVisible(barButtonItemNextIncomplete,isChecked);

            SetViewerType(isChecked ? ViewerType.Single : AppSetting.CurrentSetting.CurrentViewType, false);
        }
        private void SetViewerType(ViewerType type,bool autoSave)
        {
            bool isCompact = type == ViewerType.CompactThumbnail;
            bool isThumbnail = type == ViewerType.Thumbnail;
            bool isSingle = type == ViewerType.Single;
            SetChecked(barButtonItemCompactThumbnailView,isCompact);
            SetChecked(barButtonItemThumbnailView,isThumbnail);
            SetChecked(barButtonItemSingleView,isSingle);
            SetVisible(barButtonItemZoom,isSingle);
            SetVisible(barButtonItemPan, isSingle);
            SetVisible(barButtonItemDrawZone, isSingle && barButtonItemIndexing.Down);
            SetVisible(barButtonItemPageFit, isSingle);
            SetVisible(barButtonItemHorizontalFit, isSingle);
            SetVisible(barButtonItemVerticalFit, isSingle);
            SetVisible(barButtonItem100View, isSingle);
            ribbonStatusBar.Refresh();
            if (autoSave)
                AppSetting.CurrentSetting.CurrentViewType = type;
        }

        private void barButtonItemCompactThumbnailView_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetViewerType(ViewerType.CompactThumbnail,true);
        }

        private void barButtonItemThumbnailView_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetViewerType(ViewerType.Thumbnail,true);
        }

        private void barButtonItemSingleView_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetViewerType(ViewerType.Single,true);
        }

        private void SetCursorType(CursorType type)
        {
            bool isZoom = type == CursorType.Zoom;
            bool isPan = type == CursorType.Pan;
            bool isDraw = type == CursorType.Draw;
            SetChecked(barButtonItemZoom, isZoom);
            SetChecked(barButtonItemPan, isPan);
            SetChecked(barButtonItemDrawZone, isDraw);
        }

        private void barButtonItemZoom_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetCursorType(CursorType.Zoom);
        }

        private void barButtonItemPan_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetCursorType(CursorType.Pan);
        }

        private void barButtonItemDrawZone_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetCursorType(CursorType.Draw);
        }

        private void SetFitType(FitType type, bool autoSave)
        {
            bool isPageFit = type == FitType.Page;
            bool isHorizonal = type == FitType.Horizonal;
            bool isVertical = type == FitType.Vertical;
            bool isView100 = type == FitType.View100;
            SetChecked(barButtonItemPageFit,isPageFit);
            SetChecked(barButtonItemHorizontalFit,isHorizonal);
            SetChecked(barButtonItemVerticalFit,isVertical);
            SetChecked(barButtonItem100View,isView100);
            if(autoSave)
                AppSetting.CurrentSetting.CurrentFitType = type;
        }
        private void SetZoomValue(int value, bool autoSave)
        {
            barEditItemZoomTrackBar.Caption = value.ToString().PadLeft(5) + " %";
            barEditItemZoomTrackBar.EditValue = value;
            if (autoSave)
                AppSetting.CurrentSetting.CurrentZoomValue = value;
        }
        private void barButtonItemPageFit_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetFitType(FitType.Page, true);
        }
        private void barButtonItemHorizonalFit_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetFitType(FitType.Horizonal, true);
        }
        private void barButtonItemVerticalFit_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetFitType(FitType.Vertical, true);
        }
        private void barButtonItem100View_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetFitType(FitType.View100, true);
        }

        private void repositoryItemZoomTrackBar1_EditValueChanged(object sender, EventArgs e)
        {
            SetZoomValue(((ZoomTrackBarControl)sender).Value,true);
        }
        private void SetAnalyzeColor(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemAnalyzeColor,isChecked);
            if (autoSave)
                scanProfile.AnalyzeColor = isChecked;
        }
        private void SetIgnorePicture(bool isChecked, bool autoSave)
        {
            SetChecked(barCheckItemIgnorePicture, isChecked);
            if (autoSave)
                scanProfile.IgnorePicture = isChecked;
        }
        private void barCheckItemAnalyzeColor_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            var item = (BarCheckItem)sender;
            SetAnalyzeColor(item.Checked, true);
        }

        private void barCheckItemIgnorePicture_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            var item = (BarCheckItem)sender;
            SetIgnorePicture(item.Checked, true);
        }
        private void SetRawImageType(RawImageType type, bool autoSave)
        {
            if(type == RawImageType.Color)
            {
                SetChecked(barButtonItemRawColorColor, true);
                barButtonItemRawColor.LargeGlyph = barButtonItemRawColorColor.Glyph;
                barButtonItemRawColor.Caption = barButtonItemRawColorColor.Caption;
            }
            else if(type == RawImageType.Grayscale)
            {
                SetChecked(barCheckItemRawColorGrayscale, true);
                barButtonItemRawColor.LargeGlyph = barCheckItemRawColorGrayscale.Glyph;
                barButtonItemRawColor.Caption = barCheckItemRawColorGrayscale.Caption;
            }
            else if(type == RawImageType.Off)
            {
                SetChecked(barCheckItemRawColorOff, true);
                barButtonItemRawColor.LargeGlyph = barCheckItemRawColorOff.Glyph;
                barButtonItemRawColor.Caption = barCheckItemRawColorOff.Caption;
            }
            //if (autoSave)
            //    scanProfile.RawImageType = type;
        }

        private void barCheckItemRawColorOff_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRawImageType(RawImageType.Off, true);
        } 
        private void barCheckItemRawColorColor_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRawImageType(RawImageType.Color, true);
        }       
        private void barCheckItemRawColorGrayscale_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetRawImageType(RawImageType.Grayscale, true);
        }
        void SetSeperationDocument(BarItem item)
        {
            barButtonItemDocumentSeperation.LargeGlyph = item.LargeGlyph;
        }

        void itemLink_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetSeperationDocument(e.Item);
        }

        private void gridView2_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            var view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
                popupMenuPerfomance.ShowPopup(MousePosition);
        }
    }
}