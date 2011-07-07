using System;
using System.ComponentModel;
using System.Linq;
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
        private readonly AppSetting appSetting = AppSetting.CurrentSetting;
        private ScanProfile scanProfile = ScanProfile.CurrentSetting;
        private ColorMode tempColorMode;
        private Sides? tempSides;


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


            UserLookAndFeel.Default.SetSkinStyle(appSetting.Theme);
            SetupUI();
            SetScanSettingMode(scanProfile.CurrentScanSettingMode, false);

            WindowState = appSetting.WindowState;
            ribbon.Minimized = appSetting.IsRibbonMinimized;
            ribbon.ToolbarLocation = appSetting.ToolbarLocation;
            AddQuickAccessItem();
            SetCursorType(CursorType.Zoom);
            SetFitType(appSetting.CurrentFitType, false);
            SetViewerType(appSetting.CurrentViewType, false);
            SetZoomValue(appSetting.CurrentZoomValue, false);


            SetSelectedPage(0); // Allways show Home Tab
            LoadBatch();
            LoadPerfomance(false);
            ribbon.ForceInitialize(); // Fix error: skin gallery not show until click on dropdown
            SkinHelper.CreateGallery(ribbonGalleryBarItemThemes);

            foreach (BarItemLink itemLink in popupMenuDocumentSeperation.ItemLinks)
            {
                if (itemLink.Item is BarCheckItem)
                {
                    itemLink.Item.ItemClick += itemLink_ItemClick;
                }
                else if (itemLink.Item is BarSubItem)
                {
                    var subItem = (BarSubItem) itemLink.Item;
                    foreach (BarItemLink subItemLink in subItem.ItemLinks)
                    {
                        if (subItemLink.Item is BarCheckItem)
                        {
                            subItemLink.Item.ItemClick += itemLink_ItemClick;
                        }
                    }
                }
            }

            LoadScanProfile();
            LoadJob();
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            appSetting.IsRibbonMinimized = ribbon.Minimized;
            appSetting.SelectedPageIndex = ribbon.SelectedPage.PageIndex;
            appSetting.ToolbarLocation = ribbon.ToolbarLocation;
            appSetting.WindowState = WindowState;
            appSetting.QuickAccessItem = GetQuickAccessItemName();
            appSetting.Theme = UserLookAndFeel.Default.SkinName;
            appSetting.Save();


            scanProfile.Save();
        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            Close();
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

        private void barButtonItemScannerSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = (BarButtonItem) e.Item;
            switch (item.Name)
            {
                case "barButtonItemScanner":
                    SetScanSettingMode(ScanSettingMode.Scanner, true);
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
            var item = (ComboBoxEdit) sender;
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
            SetRotationBack(Rotation.Rotate0, true);
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
            SetOutOfPaperResolve(((BarCheckItem) e.Item).Checked, true);
        }

        private void barCheckItemPaperJam_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetPaperJamResolve(((BarCheckItem) e.Item).Checked, true);
        }

        private void barCheckItemCoverOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetCoverOpenResolve(((BarCheckItem) e.Item).Checked, true);
        }

        private void barCheckItemMultifeed_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetMultilFeedResolve(((BarCheckItem) e.Item).Checked, true);
        }

        private void barButtonItemSelectScanner_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmSelectScanner();
            frm.ShowDialog();
        }

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            var item = (CheckEdit) sender;
            SetAutoBrightness(item.Checked, true);
        }

        private void repositoryItemCheckEdit2_CheckedChanged(object sender, EventArgs e)
        {
            var item = (CheckEdit) sender;
            SetAdvancedClarity(item.Checked, true);
        }

        private void repositoryItemSpinEditBrightness_EditValueChanged(object sender, EventArgs e)
        {
            var item = (SpinEdit) sender;
            BrightnessValueChanged((int) item.Value, true);
        }

        private void repositoryItemSpinEditContrast_EditValueChanged(object sender, EventArgs e)
        {
            var item = (SpinEdit) sender;
            ContrastValueChanged((int) item.Value, true);
        }

        private void repositoryItemSpinEditGamma_EditValueChanged(object sender, EventArgs e)
        {
            var item = (SpinEdit) sender;
            GammaValueChanged((int) item.Value, true);
        }

        private void repositoryItemTrackBarBrightness_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl) sender;
            BrightnessValueChanged(control.Value, true);
        }

        private void repositoryItemTrackBarContrast_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl) sender;
            ContrastValueChanged(control.Value, true);
        }

        private void repositoryItemTrackBarGamma_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl) sender;
            GammaValueChanged(control.Value, true);
        }

        private void repositoryItemTrackBarClarityValue_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl) sender;
            SetAdvancedClarityValue(control.Value, true);
        }

        private void repositoryItemTrackBarBlankContentSensitivity_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl) sender;
            SetBlankContentSensitivityValue(control.Value, true);
        }

        private void repositoryItemTrackBarThickness_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl) sender;
            SetThicknessValue(control.Value, true);
        }

        private void repositoryItemTrackBarSpeckle_EditValueChanged(object sender, EventArgs e)
        {
            var control = (TrackBarControl) sender;
            SetSpeckleValue(control.Value, true);
        }

        private void barCheckItemIgnoreHole_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetIgnoreHole(((BarCheckItem) e.Item).Checked, true);
        }

        private void barButtonItemDeleteBlank_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetDeleteBlank(IsChecked((BarCheckAndDropDownButton) e.Item), true);
        }

        private void barButtonItemDetectColor_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetDetectColor(IsChecked((BarButtonItem) e.Item), true);
        }

        private void barButtonItemSmoothing_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetSmoothing(IsChecked((BarButtonItem) e.Item), true);
        }

        private void gridView1_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            var view = (GridView) sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
                popupMenuBatch.ShowPopup(MousePosition);
        }

        private void ribbon_ShowCustomizationMenu(object sender, RibbonCustomizationMenuEventArgs e)
        {
            if (e.HitInfo != null && e.HitInfo.Item != null &&
                (e.HitInfo.HitTest == RibbonHitTest.Item || e.HitInfo.HitTest == RibbonHitTest.ItemDrop) &&
                DefaultQuickAccess.Contains(e.HitInfo.Item.Item))
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


        private void barButtonItemCompactThumbnailView_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetViewerType(ViewerType.CompactThumbnail, true);
        }

        private void barButtonItemThumbnailView_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetViewerType(ViewerType.Thumbnail, true);
        }

        private void barButtonItemSingleView_ItemClick(object sender, ItemClickEventArgs e)
        {
            SetViewerType(ViewerType.Single, true);
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
            SetZoomValue(((ZoomTrackBarControl) sender).Value, true);
        }

  
        private void barCheckItemAnalyzeColor_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            var item = (BarCheckItem) sender;
            SetAnalyzeColor(item.Checked, true);
        }

        private void barCheckItemIgnorePicture_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            var item = (BarCheckItem) sender;
            SetIgnorePicture(item.Checked, true);
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

        private void itemLink_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "barCheckItemBarAztec":
                    SetBarCode(BarCodeType.Aztec, true);
                    break;
                case "barCheckItemCodabar":
                    SetBarCode(BarCodeType.Codabar, true);
                    break;
                case "barCheckItemCode39":
                    SetBarCode(BarCodeType.Code39, true);
                    break;
                case "barCheckItemCode93":
                    SetBarCode(BarCodeType.Code93, true);
                    break;
                case "barCheckItemCode128":
                    SetBarCode(BarCodeType.Code128, true);
                    break;
                case "barCheckItemDataMatrix":
                    SetBarCode(BarCodeType.DataMatrix, true);
                    break;
                case "barCheckItemEAN":
                    SetBarCode(BarCodeType.EAN, true);
                    break;
                case "barCheckItemInterLeaved2of5":
                    SetBarCode(BarCodeType.InterLeaved2of5, true);
                    break;
                case "barCheckItemPdf417":
                    SetBarCode(BarCodeType.PDF417, true);
                    break;
                case "barCheckItemPostNet":
                    SetBarCode(BarCodeType.PostNet, true);
                    break;
                case "barCheckItemQR":
                    SetBarCode(BarCodeType.QR, true);
                    break;
                case "barCheckItemUPC_A":
                    SetBarCode(BarCodeType.UPC_A, true);
                    break;
                case "barCheckItemUPC_E":
                    SetBarCode(BarCodeType.UPC_E, true);
                    break;
                case "barCheckItemPatchII":
                    SetPatchCode(PatchCodeType.PatchII, true);
                    break;
                case "barCheckItemPatchIII":
                    SetPatchCode(PatchCodeType.PatchIII, true);
                    break;
                case "barCheckItemPatchT":
                    SetPatchCode(PatchCodeType.PatchT, true);
                    break;
                case "barCheckItemDeletePatchCodeSepetator":
                    //SetDeletePatchPatchCodeSeperator(PatchCodeType.PatchII, true);
                    break;
                    ;
                case "barCheckItemUsingBarCodes":
                    SetDocumentSeperation(DocumentSeparationMode.BarCode, true);
                    break;
                case "barCheckItemEveryNSheets":
                    SetDocumentSeperation(DocumentSeparationMode.EveryNSheets, true);
                    break;
                case "barCheckItemUsingPatchCodes":
                    SetDocumentSeperation(DocumentSeparationMode.PatchCode, true);
                    break;
                case "barCheckItemUsingBlankSheets":
                    SetDocumentSeperation(DocumentSeparationMode.BlankSheet, true);
                    break;
            }
        }

        private void gridView2_ShowGridMenu(object sender, GridMenuEventArgs e)
        {
            var view = (GridView) sender;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Point);
            if (hitInfo.InRow)
                popupMenuPerfomance.ShowPopup(MousePosition);
        }

        private void barCheckItemShowAdvanInfomation_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadPerfomance(IsChecked(e.Item));
        }

        private void repositoryItemCheckEdit5_CheckedChanged(object sender, EventArgs e)
        {
            var item = (CheckEdit) sender;
            SetWhenValueChanges(item.Checked, true);
        }
    }
}