using CustomCheckAndDropDownButton;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace SampleApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.repositoryItemTrackBar9 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.ribbon = new CustomCheckAndDropDownButton.MyRibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.popupControlContainerBottomMenu = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.simpleButtonOption = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonExit = new DevExpress.XtraEditors.SimpleButton();
            this.barButtonItemNewBatch = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemScanOne = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemScanAll = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemStop = new DevExpress.XtraBars.BarButtonItem();
            this.popupControlContainerRightPanel = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.pcAppRecentJobs = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemSize = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonGroupLongSheet = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItemScanLong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroupOrientation = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItemPortrait = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLandscape = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barButtonItemNewDocument = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSplitDocument = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMergePre = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMergeNext = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemMergeSeleted = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemIndexing = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLanguage = new DevExpress.XtraBars.BarButtonItem();
            this.popupControlContainerLanguages = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barButtonItemDrawZone = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRemoveZone = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemExport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemScanner = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemVRSGeneral = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemVRSColor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemBlackAndWhite = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGrayscale = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemColor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFlatbed = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemFeeder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemOneSide = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemBothSides = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemFront = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuFrontRotate = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barCheckItemFront0 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemFront90Left = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemFront90Right = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemFront180 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItemBack = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuBackRotate = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barCheckItemBack0 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemBack90Left = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemBack90Right = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemBack180 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItemAutoResolve = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuAutoResolve = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barCheckItemOutOfPaper = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemPaperJam = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemCoverOpen = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemMultifeed = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItemResetScanSetting = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSelectScanner = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemDeskew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAutoCrop = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdgeCleanup = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemHolePunchRemoval = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteBlank = new CustomCheckAndDropDownButton.BarCheckAndDropDownButton();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItemTrackBarBlankContentSensitivityValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBarBlankContentSensitivity = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemBlankContentSensitivityValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEditBlankContentSensitivityValue = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barCheckItemIgnoreHole = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItemAutoRotate = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemBrightness = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBarBrightness = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemContrast = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBarContrast = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemGamma = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBarGamma = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemBrightnessValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEditBrightness = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barEditItemContrastValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEditContrast = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barEditItemGammaValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEditGamma = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barEditItemAutoBrightness = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barEditItemAdvancedClarity = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barEditItemClarityValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBarClarityValue = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barStaticItemBlank = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemHight = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemAdvancedClaritySetup = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barCheckItemAnalyzeColor = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemIgnorePicture = new DevExpress.XtraBars.BarCheckItem();
            this.barEditItemThickness = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBarThickness = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemSpeckle = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBarSpeckle = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barStaticItemThickness = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonGalleryBarItemThemes = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonItemDetectColor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDetectSmallColorObjects = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemOverall = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar7 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemSensitivity = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar8 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemIgnoBackgroundColor = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barStaticItemOverall = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemSensitivity = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItemOverallValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barEditItemSensitivityValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barButtonItemSmoothing = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItemSmoothing = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItemSmoothingValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barButtonItemSnapToWhite = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemBackgroundColorToWhite = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAllJob = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItemSpeckle = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItemSmoothingTrackBar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemDocument = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItemImage = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem5 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem6 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteToEnd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRescan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRescanMultiFeed = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemInsert = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRescanFlatbed = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRescanFeeder = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemJob = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItemBatchPath = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItemNextBatchName = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem7 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem8 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem9 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem10 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem11 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemCountDocument = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemCountBatch = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemZoom = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPageFit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemHorizontalFit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemVerticalFit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem100View = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCompactThumbnailView = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemThumbnailView = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSingleView = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemZoomTrackBar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.barStaticItemStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItemCurentSanner = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItemAdvanceScanSetting = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemScanProfile = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItemNewScanProfile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSaveScanProfile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSaveScanProfileAs = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRenameScanProfile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteScanProfile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemIndexFristDocument = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPreviousDocument = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNextDocument = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemLastDocument = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNextIncomplete = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem12 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribonPageGroupBatch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupScan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDocument = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupZonalOCR = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonScanSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupSetting = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupScan_ScanSettings = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDetail = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupFeeder = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupSides = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupPaperSize = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupRotation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupAutoResolve = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupColorDetection = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupBackground = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupAutomaticCorrections = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupClarity = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupBWFilters = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupReset = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupScanner = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonDocument = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCurent = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonRescan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonVRSCorrections = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonJobSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonBarCodeSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonIndexSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonHelp = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup15 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar2 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIcon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageListBatchIcon = new System.Windows.Forms.ImageList(this.components);
            this.gridColumnBatchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDocuments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainerBottomMenu)).BeginInit();
            this.popupControlContainerBottomMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainerRightPanel)).BeginInit();
            this.popupControlContainerRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAppRecentJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainerLanguages)).BeginInit();
            this.popupControlContainerLanguages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuFrontRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuBackRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAutoResolve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarBlankContentSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditBlankContentSensitivityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarClarityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarSpeckle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemTrackBar9
            // 
            this.repositoryItemTrackBar9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar9.Maximum = 100;
            this.repositoryItemTrackBar9.Name = "repositoryItemTrackBar9";
            this.repositoryItemTrackBar9.TickFrequency = 10;
            this.repositoryItemTrackBar9.UseParentBackground = true;
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbon.ApplicationIcon = global::SampleApplication.Properties.Resources.application_menu;
            this.ribbon.AutoSizeItems = true;
            this.ribbon.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Scan", new System.Guid("eee77f20-0ece-4690-93c6-2c9a8b289b5f")),
            new DevExpress.XtraBars.BarManagerCategory("Batch", new System.Guid("3c1e2dec-58a5-487b-bc48-06c0d4a25bf4"))});
            this.ribbon.Images = this.imageList1;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemNewBatch,
            this.barButtonItemScanOne,
            this.barButtonItemScanAll,
            this.barButtonItemStop,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barEditItemSize,
            this.barButtonGroupLongSheet,
            this.barButtonItemScanLong,
            this.barButtonGroupOrientation,
            this.barButtonItemPortrait,
            this.barButtonItemLandscape,
            this.barEditItem1,
            this.barButtonItemNewDocument,
            this.barButtonItemSplitDocument,
            this.barButtonItemMergePre,
            this.barButtonItemMergeNext,
            this.barButtonItemMergeSeleted,
            this.barButtonItemIndexing,
            this.barButtonItemLanguage,
            this.barButtonItemDrawZone,
            this.barButtonItemRemoveZone,
            this.barButtonItemExport,
            this.barButtonItemScanner,
            this.barButtonItemVRSGeneral,
            this.barButtonItemVRSColor,
            this.barButtonItemBlackAndWhite,
            this.barButtonItemGrayscale,
            this.barButtonItemColor,
            this.barButtonItemFlatbed,
            this.barButtonItemFeeder,
            this.barButtonItemOneSide,
            this.barButtonItemBothSides,
            this.barStaticItem1,
            this.barButtonItemFront,
            this.barButtonItemBack,
            this.barButtonItemAutoResolve,
            this.barButtonItemResetScanSetting,
            this.barButtonItemSelectScanner,
            this.barEditItem2,
            this.barStaticItem2,
            this.barButtonItemDeskew,
            this.barButtonItemAutoCrop,
            this.barButtonItemEdgeCleanup,
            this.barButtonItemHolePunchRemoval,
            this.barButtonItemDeleteBlank,
            this.barButtonItemAutoRotate,
            this.barEditItemBrightness,
            this.barEditItemContrast,
            this.barEditItemGamma,
            this.barEditItemBrightnessValue,
            this.barEditItemContrastValue,
            this.barEditItemGammaValue,
            this.barEditItemAutoBrightness,
            this.barEditItemAdvancedClarity,
            this.barEditItemClarityValue,
            this.barStaticItemBlank,
            this.barStaticItemHight,
            this.barButtonItemAdvancedClaritySetup,
            this.barEditItemThickness,
            this.barEditItemSpeckle,
            this.barStaticItemThickness,
            this.ribbonGalleryBarItemThemes,
            this.barButtonItemDetectColor,
            this.barButtonItemDetectSmallColorObjects,
            this.barEditItemOverall,
            this.barEditItemSensitivity,
            this.barEditItemIgnoBackgroundColor,
            this.barStaticItemOverall,
            this.barStaticItemSensitivity,
            this.barEditItemOverallValue,
            this.barEditItemSensitivityValue,
            this.barButtonItemSmoothing,
            this.barStaticItemSmoothing,
            this.barEditItemSmoothingValue,
            this.barButtonItemSnapToWhite,
            this.barButtonItemBackgroundColorToWhite,
            this.barButtonItemRefresh,
            this.barButtonItemAllJob,
            this.barCheckItemFront0,
            this.barCheckItemFront90Left,
            this.barCheckItemFront90Right,
            this.barCheckItemFront180,
            this.barCheckItemBack0,
            this.barCheckItemBack90Left,
            this.barCheckItemBack90Right,
            this.barCheckItemBack180,
            this.barCheckItemOutOfPaper,
            this.barCheckItemPaperJam,
            this.barCheckItemCoverOpen,
            this.barCheckItemMultifeed,
            this.barStaticItemSpeckle,
            this.barCheckItemAnalyzeColor,
            this.barCheckItemIgnorePicture,
            this.barStaticItem3,
            this.barEditItemTrackBarBlankContentSensitivityValue,
            this.barEditItemBlankContentSensitivityValue,
            this.barCheckItemIgnoreHole,
            this.barEditItemSmoothingTrackBar,
            this.barEditItemDocument,
            this.barEditItemImage,
            this.barStaticItem4,
            this.barButtonItem2,
            this.barStaticItem5,
            this.barStaticItem6,
            this.barButtonItemDelete,
            this.barButtonItemDeleteToEnd,
            this.barButtonItemRescan,
            this.barButtonItemRescanMultiFeed,
            this.barButtonItemInsert,
            this.barButtonItemRescanFlatbed,
            this.barButtonItemRescanFeeder,
            this.barEditItemJob,
            this.barEditItemBatchPath,
            this.barEditItemNextBatchName,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barStaticItem7,
            this.barButtonItem9,
            this.barStaticItem8,
            this.barStaticItem9,
            this.barButtonItem10,
            this.barStaticItem10,
            this.barStaticItem11,
            this.barStaticItemCountDocument,
            this.barStaticItemCountBatch,
            this.barButtonItemZoom,
            this.barButtonItemPan,
            this.barButtonItemPageFit,
            this.barButtonItemHorizontalFit,
            this.barButtonItemVerticalFit,
            this.barButtonItem100View,
            this.barButtonItemCompactThumbnailView,
            this.barButtonItemThumbnailView,
            this.barButtonItemSingleView,
            this.barEditItemZoomTrackBar,
            this.barStaticItemStatus,
            this.barStaticItemCurentSanner,
            this.barButtonItemAdvanceScanSetting,
            this.barEditItemScanProfile,
            this.barButtonItemNewScanProfile,
            this.barButtonItemSaveScanProfile,
            this.barButtonItemSaveScanProfileAs,
            this.barButtonItemRenameScanProfile,
            this.barButtonItemDeleteScanProfile,
            this.barButtonItemIndexFristDocument,
            this.barButtonItemPreviousDocument,
            this.barButtonItemNextDocument,
            this.barButtonItemLastDocument,
            this.barButtonItemNextIncomplete,
            this.barStaticItem12});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 286;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonHome,
            this.ribbonScanSettings,
            this.ribbonDocument,
            this.ribbonRescan,
            this.ribbonVRSCorrections,
            this.ribbonJobSetup,
            this.ribbonBarCodeSetup,
            this.ribbonIndexSetup,
            this.ribbonHelp});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox3,
            this.repositoryItemCheckEdit3,
            this.repositoryItemComboBox1,
            this.repositoryItemTrackBarBrightness,
            this.repositoryItemTrackBarContrast,
            this.repositoryItemTrackBarGamma,
            this.repositoryItemSpinEditBrightness,
            this.repositoryItemSpinEditContrast,
            this.repositoryItemSpinEditGamma,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemTrackBarClarityValue,
            this.repositoryItemTrackBarThickness,
            this.repositoryItemTrackBarSpeckle,
            this.repositoryItemTrackBar7,
            this.repositoryItemTrackBar8,
            this.repositoryItemCheckEdit4,
            this.repositoryItemSpinEdit4,
            this.repositoryItemSpinEdit5,
            this.repositoryItemTrackBar9,
            this.repositoryItemSpinEdit6,
            this.repositoryItemTrackBarBlankContentSensitivity,
            this.repositoryItemSpinEditBlankContentSensitivityValue,
            this.repositoryItemTrackBar1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5,
            this.repositoryItemZoomTrackBar1,
            this.repositoryItemComboBox2});
            this.ribbon.SelectedPage = this.ribbonHome;
            this.ribbon.Size = new System.Drawing.Size(1059, 148);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
            this.ribbon.Toolbar.ItemLinks.Add(this.barButtonItemScanOne);
            this.ribbon.TransparentEditors = true;
            this.ribbon.SelectedPageChanged += new System.EventHandler(this.ribbon_SelectedPageChanged);
            this.ribbon.ShowCustomizationMenu += new DevExpress.XtraBars.Ribbon.RibbonCustomizationMenuEventHandler(this.ribbon_ShowCustomizationMenu);
            // 
            // appMenu
            // 
            this.appMenu.BottomPaneControlContainer = this.popupControlContainerBottomMenu;
            this.appMenu.ItemLinks.Add(this.barButtonItemNewBatch);
            this.appMenu.ItemLinks.Add(this.barButtonItemScanOne);
            this.appMenu.ItemLinks.Add(this.barButtonItemScanAll);
            this.appMenu.ItemLinks.Add(this.barButtonItemStop);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbon;
            this.appMenu.RightPaneControlContainer = this.popupControlContainerRightPanel;
            this.appMenu.ShowRightPane = true;
            // 
            // popupControlContainerBottomMenu
            // 
            this.popupControlContainerBottomMenu.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainerBottomMenu.Appearance.Options.UseBackColor = true;
            this.popupControlContainerBottomMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainerBottomMenu.Controls.Add(this.simpleButtonOption);
            this.popupControlContainerBottomMenu.Controls.Add(this.simpleButtonExit);
            this.popupControlContainerBottomMenu.Location = new System.Drawing.Point(504, 209);
            this.popupControlContainerBottomMenu.Margin = new System.Windows.Forms.Padding(0);
            this.popupControlContainerBottomMenu.Name = "popupControlContainerBottomMenu";
            this.popupControlContainerBottomMenu.Ribbon = this.ribbon;
            this.popupControlContainerBottomMenu.Size = new System.Drawing.Size(237, 23);
            this.popupControlContainerBottomMenu.TabIndex = 3;
            this.popupControlContainerBottomMenu.Visible = false;
            // 
            // simpleButtonOption
            // 
            this.simpleButtonOption.Image = global::SampleApplication.Properties.Resources.setup_16x16;
            this.simpleButtonOption.Location = new System.Drawing.Point(72, -1);
            this.simpleButtonOption.Name = "simpleButtonOption";
            this.simpleButtonOption.Size = new System.Drawing.Size(80, 23);
            this.simpleButtonOption.TabIndex = 1;
            this.simpleButtonOption.Text = "Option";
            // 
            // simpleButtonExit
            // 
            this.simpleButtonExit.Image = global::SampleApplication.Properties.Resources.exit_16x16;
            this.simpleButtonExit.Location = new System.Drawing.Point(158, -1);
            this.simpleButtonExit.Name = "simpleButtonExit";
            this.simpleButtonExit.Size = new System.Drawing.Size(80, 23);
            this.simpleButtonExit.TabIndex = 0;
            this.simpleButtonExit.Text = "Exit";
            // 
            // barButtonItemNewBatch
            // 
            this.barButtonItemNewBatch.Caption = "New";
            this.barButtonItemNewBatch.CategoryGuid = new System.Guid("3c1e2dec-58a5-487b-bc48-06c0d4a25bf4");
            this.barButtonItemNewBatch.Glyph = global::SampleApplication.Properties.Resources.new_batch_16x16;
            this.barButtonItemNewBatch.Id = 2;
            this.barButtonItemNewBatch.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            this.barButtonItemNewBatch.LargeGlyph = global::SampleApplication.Properties.Resources.new_batch_32x32;
            this.barButtonItemNewBatch.Name = "barButtonItemNewBatch";
            toolTipItem1.Text = "Create a new batch (Ctrl+B)";
            superToolTip1.Items.Add(toolTipItem1);
            this.barButtonItemNewBatch.SuperTip = superToolTip1;
            // 
            // barButtonItemScanOne
            // 
            this.barButtonItemScanOne.Caption = "Scan One";
            this.barButtonItemScanOne.CategoryGuid = new System.Guid("eee77f20-0ece-4690-93c6-2c9a8b289b5f");
            this.barButtonItemScanOne.Glyph = global::SampleApplication.Properties.Resources.scan_page_16x16;
            this.barButtonItemScanOne.Id = 7;
            this.barButtonItemScanOne.LargeGlyph = global::SampleApplication.Properties.Resources.scan_page_32x32;
            this.barButtonItemScanOne.Name = "barButtonItemScanOne";
            // 
            // barButtonItemScanAll
            // 
            this.barButtonItemScanAll.Caption = "Scan All";
            this.barButtonItemScanAll.CategoryGuid = new System.Guid("eee77f20-0ece-4690-93c6-2c9a8b289b5f");
            this.barButtonItemScanAll.Glyph = global::SampleApplication.Properties.Resources.scan_batch_16x16;
            this.barButtonItemScanAll.Id = 8;
            this.barButtonItemScanAll.LargeGlyph = global::SampleApplication.Properties.Resources.scan_batch_32x32;
            this.barButtonItemScanAll.Name = "barButtonItemScanAll";
            // 
            // barButtonItemStop
            // 
            this.barButtonItemStop.Caption = "Stop";
            this.barButtonItemStop.CategoryGuid = new System.Guid("eee77f20-0ece-4690-93c6-2c9a8b289b5f");
            this.barButtonItemStop.Enabled = false;
            this.barButtonItemStop.Glyph = global::SampleApplication.Properties.Resources.stop_scanner_16x16;
            this.barButtonItemStop.Id = 9;
            this.barButtonItemStop.LargeGlyph = global::SampleApplication.Properties.Resources.stop_scanner_32x32;
            this.barButtonItemStop.Name = "barButtonItemStop";
            // 
            // popupControlContainerRightPanel
            // 
            this.popupControlContainerRightPanel.AutoSize = true;
            this.popupControlContainerRightPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainerRightPanel.Controls.Add(this.pcAppRecentJobs);
            this.popupControlContainerRightPanel.Controls.Add(this.labelControl1);
            this.popupControlContainerRightPanel.Controls.Add(this.panelControl1);
            this.popupControlContainerRightPanel.Location = new System.Drawing.Point(585, 316);
            this.popupControlContainerRightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.popupControlContainerRightPanel.Name = "popupControlContainerRightPanel";
            this.popupControlContainerRightPanel.Ribbon = this.ribbon;
            this.popupControlContainerRightPanel.Size = new System.Drawing.Size(284, 200);
            this.popupControlContainerRightPanel.TabIndex = 4;
            this.popupControlContainerRightPanel.Visible = false;
            // 
            // pcAppRecentJobs
            // 
            this.pcAppRecentJobs.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcAppRecentJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcAppRecentJobs.Location = new System.Drawing.Point(10, 22);
            this.pcAppRecentJobs.Name = "pcAppRecentJobs";
            this.pcAppRecentJobs.Size = new System.Drawing.Size(274, 178);
            this.pcAppRecentJobs.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(274, 22);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Recent Jobs:";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(10, 200);
            this.panelControl1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "vrs_rotate_90_16x16.png");
            this.imageList1.Images.SetKeyName(1, "vrs_rotate_180_16x16.png");
            this.imageList1.Images.SetKeyName(2, "vrs_rotate_270_16x16.png");
            this.imageList1.Images.SetKeyName(3, "warning_16x16.png");
            this.imageList1.Images.SetKeyName(4, "zoom_on_rectangle_16x16.png");
            this.imageList1.Images.SetKeyName(5, "rectangle_16x16.png");
            this.imageList1.Images.SetKeyName(6, "redo_16x16.png");
            this.imageList1.Images.SetKeyName(7, "register_16x16.png");
            this.imageList1.Images.SetKeyName(8, "remove_rubber_band_ocr_16x16.png");
            this.imageList1.Images.SetKeyName(9, "rename_16x16.png");
            this.imageList1.Images.SetKeyName(10, "required_16x16.png");
            this.imageList1.Images.SetKeyName(11, "rescan_multi_feed_16x16.png");
            this.imageList1.Images.SetKeyName(12, "rescan_multi_page_16x16.png");
            this.imageList1.Images.SetKeyName(13, "reset_16x16.png");
            this.imageList1.Images.SetKeyName(14, "reset_vrs_16x16.png");
            this.imageList1.Images.SetKeyName(15, "rotate_00_16x16.png");
            this.imageList1.Images.SetKeyName(16, "rotate_90_16x16.png");
            this.imageList1.Images.SetKeyName(17, "rotate_180_16x16.png");
            this.imageList1.Images.SetKeyName(18, "rotate_270_16x16.png");
            this.imageList1.Images.SetKeyName(19, "rubber_band_ocr_16x16.png");
            this.imageList1.Images.SetKeyName(20, "sans_serif_16x16.png");
            this.imageList1.Images.SetKeyName(21, "save_16x16.png");
            this.imageList1.Images.SetKeyName(22, "save_as_16x16.png");
            this.imageList1.Images.SetKeyName(23, "save_job_16x16.png");
            this.imageList1.Images.SetKeyName(24, "save_job_as_16x16.png");
            this.imageList1.Images.SetKeyName(25, "save_job_as_template_16x16.png");
            this.imageList1.Images.SetKeyName(26, "save_scan_profile_16x16.png");
            this.imageList1.Images.SetKeyName(27, "save_scan_profile_as_16x16.png");
            this.imageList1.Images.SetKeyName(28, "scan_batch_16x16.png");
            this.imageList1.Images.SetKeyName(29, "scan_page_16x16.png");
            this.imageList1.Images.SetKeyName(30, "scanner_button_16x16.png");
            this.imageList1.Images.SetKeyName(31, "screw_tool_16x16.png");
            this.imageList1.Images.SetKeyName(32, "select_16x16.png");
            this.imageList1.Images.SetKeyName(33, "send_raw_to_server_16x16.png");
            this.imageList1.Images.SetKeyName(34, "serif_16x16.png");
            this.imageList1.Images.SetKeyName(35, "setup_16x16.png");
            this.imageList1.Images.SetKeyName(36, "simplex_16x16.png");
            this.imageList1.Images.SetKeyName(37, "single_sheet_16x16.png");
            this.imageList1.Images.SetKeyName(38, "slow_16x16.png");
            this.imageList1.Images.SetKeyName(39, "smoothing_16x16.png");
            this.imageList1.Images.SetKeyName(40, "smoothing_high_16x16.png");
            this.imageList1.Images.SetKeyName(41, "smoothing_low_16x16.png");
            this.imageList1.Images.SetKeyName(42, "snap_to_white_16x16.png");
            this.imageList1.Images.SetKeyName(43, "split_document_16x16.png");
            this.imageList1.Images.SetKeyName(44, "start_16x16.png");
            this.imageList1.Images.SetKeyName(45, "step_16x16.png");
            this.imageList1.Images.SetKeyName(46, "sticky_value_16x16.png");
            this.imageList1.Images.SetKeyName(47, "stop_multifeed_16x16.png");
            this.imageList1.Images.SetKeyName(48, "stop_scanner_16x16.png");
            this.imageList1.Images.SetKeyName(49, "support_16x16.png");
            this.imageList1.Images.SetKeyName(50, "suspendbatch_16x16.png");
            this.imageList1.Images.SetKeyName(51, "swap_front_back_16x16.png");
            this.imageList1.Images.SetKeyName(52, "switch_to_bw_16x16.png");
            this.imageList1.Images.SetKeyName(53, "switch_to_color_16x16.png");
            this.imageList1.Images.SetKeyName(54, "switch_to_gray_16x16.png");
            this.imageList1.Images.SetKeyName(55, "template_ocr_16x16.png");
            this.imageList1.Images.SetKeyName(56, "thick_16x16.png");
            this.imageList1.Images.SetKeyName(57, "thin_16x16.png");
            this.imageList1.Images.SetKeyName(58, "time_out_16x16.png");
            this.imageList1.Images.SetKeyName(59, "top_offset_16x16.png");
            this.imageList1.Images.SetKeyName(60, "tutorial_16x16.png");
            this.imageList1.Images.SetKeyName(61, "undo_16x16.png");
            this.imageList1.Images.SetKeyName(62, "view_one_image_16x16.png");
            this.imageList1.Images.SetKeyName(63, "view_thumbnails_16x16.png");
            this.imageList1.Images.SetKeyName(64, "view_two_images_16x16.png");
            this.imageList1.Images.SetKeyName(65, "vrs_16x16.png");
            this.imageList1.Images.SetKeyName(66, "invert_16x16.png");
            this.imageList1.Images.SetKeyName(67, "job_16x16.png");
            this.imageList1.Images.SetKeyName(68, "key_from_image_16x16.png");
            this.imageList1.Images.SetKeyName(69, "landscape_16x16.png");
            this.imageList1.Images.SetKeyName(70, "landscape_orientation_landscapetext_0_degrees_16x16.png");
            this.imageList1.Images.SetKeyName(71, "landscape_orientation_landscapetext_180_degrees_16x16.png");
            this.imageList1.Images.SetKeyName(72, "landscape_orientation_portraittext_0_degrees_16x16.png");
            this.imageList1.Images.SetKeyName(73, "landscape_orientation_portraittext_180_degrees_16x16.png");
            this.imageList1.Images.SetKeyName(74, "lasso_ocr_16x16.png");
            this.imageList1.Images.SetKeyName(75, "last_16x16.png");
            this.imageList1.Images.SetKeyName(76, "learn_more_16x16.png");
            this.imageList1.Images.SetKeyName(77, "left_offset_16x16.png");
            this.imageList1.Images.SetKeyName(78, "level1_16x16.png");
            this.imageList1.Images.SetKeyName(79, "level2_16x16.png");
            this.imageList1.Images.SetKeyName(80, "level3_16x16.png");
            this.imageList1.Images.SetKeyName(81, "lock_16x16.png");
            this.imageList1.Images.SetKeyName(82, "long_paper_16x16.png");
            this.imageList1.Images.SetKeyName(83, "magnifier_16x16.png");
            this.imageList1.Images.SetKeyName(84, "merge_documents_16x16.png");
            this.imageList1.Images.SetKeyName(85, "merge_with_next_16x16.png");
            this.imageList1.Images.SetKeyName(86, "merge_with_previous_16x16.png");
            this.imageList1.Images.SetKeyName(87, "multifeed_detect_16x16.png");
            this.imageList1.Images.SetKeyName(88, "multifeed_off_16x16.png");
            this.imageList1.Images.SetKeyName(89, "new_16x16.png");
            this.imageList1.Images.SetKeyName(90, "new_batch_16x16.png");
            this.imageList1.Images.SetKeyName(91, "new_document_16x16.png");
            this.imageList1.Images.SetKeyName(92, "new_job_16x16.png");
            this.imageList1.Images.SetKeyName(93, "new_scan_profile_16x16.png");
            this.imageList1.Images.SetKeyName(94, "next_16x16.png");
            this.imageList1.Images.SetKeyName(95, "next_incomplete_16x16.png");
            this.imageList1.Images.SetKeyName(96, "nextbatch_16x16.png");
            this.imageList1.Images.SetKeyName(97, "ocr_language_16x16.png");
            this.imageList1.Images.SetKeyName(98, "off_16x16.png");
            this.imageList1.Images.SetKeyName(99, "ok_16x16.png");
            this.imageList1.Images.SetKeyName(100, "on_16x16.png");
            this.imageList1.Images.SetKeyName(101, "open_16x16.png");
            this.imageList1.Images.SetKeyName(102, "page_count_separation_16x16.png");
            this.imageList1.Images.SetKeyName(103, "pan_hand_16x16.png");
            this.imageList1.Images.SetKeyName(104, "paste_16x16.png");
            this.imageList1.Images.SetKeyName(105, "patch_code_ii_16x16.png");
            this.imageList1.Images.SetKeyName(106, "patch_code_iii_16x16.png");
            this.imageList1.Images.SetKeyName(107, "patch_code_t_16x16.png");
            this.imageList1.Images.SetKeyName(108, "performance_16x16.png");
            this.imageList1.Images.SetKeyName(109, "portrait_16x16.png");
            this.imageList1.Images.SetKeyName(110, "portrait_orientation_landscapetext_0_degrees_16x16.png");
            this.imageList1.Images.SetKeyName(111, "portrait_orientation_landscapetext_180_degrees_16x16.png");
            this.imageList1.Images.SetKeyName(112, "portrait_orientation_portrait_text_0_degrees_16x16.png");
            this.imageList1.Images.SetKeyName(113, "portrait_orientation_portrait_text_180_degrees_16x16.png");
            this.imageList1.Images.SetKeyName(114, "previous_16x16.png");
            this.imageList1.Images.SetKeyName(115, "print_16x16.png");
            this.imageList1.Images.SetKeyName(116, "properties_16x16.png");
            this.imageList1.Images.SetKeyName(117, "publish_16x16.png");
            this.imageList1.Images.SetKeyName(118, "publishjob_16x16.png");
            this.imageList1.Images.SetKeyName(119, "publishjobas_16x16.png");
            this.imageList1.Images.SetKeyName(120, "publishscanprofile_16x16.png");
            this.imageList1.Images.SetKeyName(121, "raw_off_16x16.png");
            this.imageList1.Images.SetKeyName(122, "color_mode_color_16x16.png");
            this.imageList1.Images.SetKeyName(123, "color_mode_gray_16x16.png");
            this.imageList1.Images.SetKeyName(124, "color_photographic_16x16.png");
            this.imageList1.Images.SetKeyName(125, "color_small_16x16.png");
            this.imageList1.Images.SetKeyName(126, "color_some_16x16.png");
            this.imageList1.Images.SetKeyName(127, "color_very_small_16x16.png");
            this.imageList1.Images.SetKeyName(128, "compact_view_16x16.png");
            this.imageList1.Images.SetKeyName(129, "compress_color_16x16.png");
            this.imageList1.Images.SetKeyName(130, "compress_gray_16x16.png");
            this.imageList1.Images.SetKeyName(131, "continuous_paper_16x16.png");
            this.imageList1.Images.SetKeyName(132, "contrast_16x16.png");
            this.imageList1.Images.SetKeyName(133, "copy_16x16.png");
            this.imageList1.Images.SetKeyName(134, "counter_16x16.png");
            this.imageList1.Images.SetKeyName(135, "counter_length_16x16.png");
            this.imageList1.Images.SetKeyName(136, "crop_16x16.png");
            this.imageList1.Images.SetKeyName(137, "cut_16x16.png");
            this.imageList1.Images.SetKeyName(138, "deactivate 16x16.png");
            this.imageList1.Images.SetKeyName(139, "deactivate_16x16.png");
            this.imageList1.Images.SetKeyName(140, "delete_batch_16x16.png");
            this.imageList1.Images.SetKeyName(141, "delete_blank_sides_16x16.png");
            this.imageList1.Images.SetKeyName(142, "delete_document_16x16.png");
            this.imageList1.Images.SetKeyName(143, "delete_end_of_document_16x16.png");
            this.imageList1.Images.SetKeyName(144, "delete_job_16x16.png");
            this.imageList1.Images.SetKeyName(145, "delete_job_template_16x16.png");
            this.imageList1.Images.SetKeyName(146, "delete_object_16x16.png");
            this.imageList1.Images.SetKeyName(147, "deskew_16x16.png");
            this.imageList1.Images.SetKeyName(148, "drop_down_16x16.png");
            this.imageList1.Images.SetKeyName(149, "drop_out_blue_16x16.png");
            this.imageList1.Images.SetKeyName(150, "drop_out_green_16x16.png");
            this.imageList1.Images.SetKeyName(151, "drop_out_off_16x16.png");
            this.imageList1.Images.SetKeyName(152, "drop_out_red_16x16.png");
            this.imageList1.Images.SetKeyName(153, "duplex_16x16.png");
            this.imageList1.Images.SetKeyName(154, "edge_cleanup_16x16.png");
            this.imageList1.Images.SetKeyName(155, "exit_16x16.png");
            this.imageList1.Images.SetKeyName(156, "export_16x16.png");
            this.imageList1.Images.SetKeyName(157, "export_job_16x16.png");
            this.imageList1.Images.SetKeyName(158, "export_scanner_profiles_16x16.png");
            this.imageList1.Images.SetKeyName(159, "fast_16x16.png");
            this.imageList1.Images.SetKeyName(160, "first_16x16.png");
            this.imageList1.Images.SetKeyName(161, "fit_horizontal_16x16.png");
            this.imageList1.Images.SetKeyName(162, "fit_page_16x16.png");
            this.imageList1.Images.SetKeyName(163, "fit_vertical_16x16.png");
            this.imageList1.Images.SetKeyName(164, "flatbed_16x16.png");
            this.imageList1.Images.SetKeyName(165, "gamma_16x16.png");
            this.imageList1.Images.SetKeyName(166, "help_contents_16x16.png");
            this.imageList1.Images.SetKeyName(167, "help_index_16x16.png");
            this.imageList1.Images.SetKeyName(168, "help_search_16x16.png");
            this.imageList1.Images.SetKeyName(169, "help_website_16x16.png");
            this.imageList1.Images.SetKeyName(170, "hole_punch_removal_16x16.png");
            this.imageList1.Images.SetKeyName(171, "hole_punches_16x16.png");
            this.imageList1.Images.SetKeyName(172, "import_16x16.png");
            this.imageList1.Images.SetKeyName(173, "import_job_16x16.png");
            this.imageList1.Images.SetKeyName(174, "import_scanner_profiles_16x16.png");
            this.imageList1.Images.SetKeyName(175, "imprinter_16x16.png");
            this.imageList1.Images.SetKeyName(176, "imprinter_bold_16x16.png");
            this.imageList1.Images.SetKeyName(177, "imprinter_down_16x16.png");
            this.imageList1.Images.SetKeyName(178, "imprinter_left_16x16.png");
            this.imageList1.Images.SetKeyName(179, "imprinter_right_16x16.png");
            this.imageList1.Images.SetKeyName(180, "imprinter_up_16x16.png");
            this.imageList1.Images.SetKeyName(181, "increment_across_batches_off_16x16.png");
            this.imageList1.Images.SetKeyName(182, "increment_across_batches_on_16x16.png");
            this.imageList1.Images.SetKeyName(183, "index_16x16.png");
            this.imageList1.Images.SetKeyName(184, "index_bar_code_types_16x16.png");
            this.imageList1.Images.SetKeyName(185, "index_delete_16x16.png");
            this.imageList1.Images.SetKeyName(186, "index_new_16x16.png");
            this.imageList1.Images.SetKeyName(187, "insert_new_document_16x16.png");
            this.imageList1.Images.SetKeyName(188, "insert_scan_multi_16x16.png");
            this.imageList1.Images.SetKeyName(189, "100_display_16x16.png");
            this.imageList1.Images.SetKeyName(190, "about_16x16.png");
            this.imageList1.Images.SetKeyName(191, "activate 16x16.png");
            this.imageList1.Images.SetKeyName(192, "activate_16x16.png");
            this.imageList1.Images.SetKeyName(193, "adf_16x16.png");
            this.imageList1.Images.SetKeyName(194, "annotate_16x16.png");
            this.imageList1.Images.SetKeyName(195, "annotate_font_size_8_16x16.png");
            this.imageList1.Images.SetKeyName(196, "annotate_font_size_10_16x16.png");
            this.imageList1.Images.SetKeyName(197, "annotate_font_size_12_16x16.png");
            this.imageList1.Images.SetKeyName(198, "annotate_horizontal_down_16x16.png");
            this.imageList1.Images.SetKeyName(199, "annotate_horizontal_left_16x16.png");
            this.imageList1.Images.SetKeyName(200, "annotate_horizontal_right_16x16.png");
            this.imageList1.Images.SetKeyName(201, "annotate_horizontal_up_16x16.png");
            this.imageList1.Images.SetKeyName(202, "annotate_vertical_down_16x16.png");
            this.imageList1.Images.SetKeyName(203, "annotate_vertical_left_16x16.png");
            this.imageList1.Images.SetKeyName(204, "annotate_vertical_right_16x16.png");
            this.imageList1.Images.SetKeyName(205, "annotate_vertical_up_16x16.png");
            this.imageList1.Images.SetKeyName(206, "annotation_background_transparent_16x16.png");
            this.imageList1.Images.SetKeyName(207, "annotation_background_white_16x16.png");
            this.imageList1.Images.SetKeyName(208, "auto_crop_16x16.png");
            this.imageList1.Images.SetKeyName(209, "auto_rotate_16x16.png");
            this.imageList1.Images.SetKeyName(210, "autoexport_16x16.png");
            this.imageList1.Images.SetKeyName(211, "bar_code_16x16.png");
            this.imageList1.Images.SetKeyName(212, "bar_code_39_16x16.png");
            this.imageList1.Images.SetKeyName(213, "bar_code_93_16x16.png");
            this.imageList1.Images.SetKeyName(214, "bar_code_128_16x16.png");
            this.imageList1.Images.SetKeyName(215, "bar_code_aztec_16x16.png");
            this.imageList1.Images.SetKeyName(216, "bar_code_codabar_16x16.png");
            this.imageList1.Images.SetKeyName(217, "bar_code_data_matrix_16x16.png");
            this.imageList1.Images.SetKeyName(218, "bar_code_ean_16x16.png");
            this.imageList1.Images.SetKeyName(219, "bar_code_i25_16x16.png");
            this.imageList1.Images.SetKeyName(220, "bar_code_maxi_code_16x16.png");
            this.imageList1.Images.SetKeyName(221, "bar_code_orientation_000_16x16.png");
            this.imageList1.Images.SetKeyName(222, "bar_code_orientation_090_16x16.png");
            this.imageList1.Images.SetKeyName(223, "bar_code_orientation_180_16x16.png");
            this.imageList1.Images.SetKeyName(224, "bar_code_orientation_270_16x16.png");
            this.imageList1.Images.SetKeyName(225, "bar_code_pdf_417_16x16.png");
            this.imageList1.Images.SetKeyName(226, "bar_code_postnet_16x16.png");
            this.imageList1.Images.SetKeyName(227, "bar_code_qr_16x16.png");
            this.imageList1.Images.SetKeyName(228, "bar_code_upc_16x16.png");
            this.imageList1.Images.SetKeyName(229, "batch_16x16.png");
            this.imageList1.Images.SetKeyName(230, "batch_release_16x16.png");
            this.imageList1.Images.SetKeyName(231, "beep_16x16.png");
            this.imageList1.Images.SetKeyName(232, "blank_sensitivity1_16x16.png");
            this.imageList1.Images.SetKeyName(233, "blank_sensitivity2_16x16.png");
            this.imageList1.Images.SetKeyName(234, "blank_sensitivity3_16x16.png");
            this.imageList1.Images.SetKeyName(235, "blank_sensitivity4_16x16.png");
            this.imageList1.Images.SetKeyName(236, "blank_sensitivity5_16x16.png");
            this.imageList1.Images.SetKeyName(237, "blank_sheet_separation_16x16.png");
            this.imageList1.Images.SetKeyName(238, "brightness_16x16.png");
            this.imageList1.Images.SetKeyName(239, "browse_16x16.png");
            this.imageList1.Images.SetKeyName(240, "calibrate_16x16.png");
            this.imageList1.Images.SetKeyName(241, "check_red_16x16.png");
            this.imageList1.Images.SetKeyName(242, "cleaner_16x16.png");
            this.imageList1.Images.SetKeyName(243, "close_16x16.png");
            this.imageList1.Images.SetKeyName(244, "closebatch_16x16.png");
            this.imageList1.Images.SetKeyName(245, "color_background_to_white_16x16.png");
            this.imageList1.Images.SetKeyName(246, "color_business_16x16.png");
            this.imageList1.Images.SetKeyName(247, "color_detect_16x16.png");
            this.imageList1.Images.SetKeyName(248, "color_lots_16x16.png");
            this.imageList1.Images.SetKeyName(249, "color_mode_bw_16x16.png");
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 120;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 122;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 125;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 126;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barEditItemSize
            // 
            this.barEditItemSize.Caption = "Size";
            this.barEditItemSize.Edit = this.repositoryItemComboBox3;
            this.barEditItemSize.Id = 127;
            this.barEditItemSize.Name = "barEditItemSize";
            this.barEditItemSize.Width = 80;
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.DropDownRows = 18;
            this.repositoryItemComboBox3.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "B",
            "B0",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "B6",
            "Legal",
            "Letter",
            "Maximum",
            "Minimum"});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            this.repositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemComboBox3.UseParentBackground = true;
            this.repositoryItemComboBox3.EditValueChanged += new System.EventHandler(this.repositoryItemComboBox3_EditValueChanged);
            // 
            // barButtonGroupLongSheet
            // 
            this.barButtonGroupLongSheet.Caption = "Long Sheet";
            this.barButtonGroupLongSheet.Id = 128;
            this.barButtonGroupLongSheet.ItemLinks.Add(this.barButtonItemScanLong);
            this.barButtonGroupLongSheet.Name = "barButtonGroupLongSheet";
            // 
            // barButtonItemScanLong
            // 
            this.barButtonItemScanLong.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemScanLong.Caption = "Scan Long Sheets";
            this.barButtonItemScanLong.Enabled = false;
            this.barButtonItemScanLong.Glyph = global::SampleApplication.Properties.Resources.long_paper_16x16;
            this.barButtonItemScanLong.Id = 129;
            this.barButtonItemScanLong.Name = "barButtonItemScanLong";
            this.barButtonItemScanLong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroupOrientation
            // 
            this.barButtonGroupOrientation.Caption = "Orientation";
            this.barButtonGroupOrientation.Id = 130;
            this.barButtonGroupOrientation.ItemLinks.Add(this.barButtonItemPortrait);
            this.barButtonGroupOrientation.ItemLinks.Add(this.barButtonItemLandscape);
            this.barButtonGroupOrientation.Name = "barButtonGroupOrientation";
            // 
            // barButtonItemPortrait
            // 
            this.barButtonItemPortrait.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemPortrait.Caption = "Portrait";
            this.barButtonItemPortrait.Glyph = global::SampleApplication.Properties.Resources.portrait_16x16;
            this.barButtonItemPortrait.Id = 131;
            this.barButtonItemPortrait.Name = "barButtonItemPortrait";
            this.barButtonItemPortrait.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemPortrait.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPortrait_ItemClick);
            // 
            // barButtonItemLandscape
            // 
            this.barButtonItemLandscape.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemLandscape.Caption = "Landscape";
            this.barButtonItemLandscape.Glyph = global::SampleApplication.Properties.Resources.landscape_16x16;
            this.barButtonItemLandscape.Id = 132;
            this.barButtonItemLandscape.Name = "barButtonItemLandscape";
            this.barButtonItemLandscape.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemLandscape.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemLandscape_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = this.repositoryItemCheckEdit3;
            this.barEditItem1.Id = 137;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 120;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Caption = "Show in Document";
            this.repositoryItemCheckEdit3.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            this.repositoryItemCheckEdit3.UseParentBackground = true;
            // 
            // barButtonItemNewDocument
            // 
            this.barButtonItemNewDocument.Caption = "New";
            this.barButtonItemNewDocument.Glyph = global::SampleApplication.Properties.Resources.new_document_16x16;
            this.barButtonItemNewDocument.Id = 138;
            this.barButtonItemNewDocument.LargeGlyph = global::SampleApplication.Properties.Resources.new_document_32x32;
            this.barButtonItemNewDocument.Name = "barButtonItemNewDocument";
            // 
            // barButtonItemSplitDocument
            // 
            this.barButtonItemSplitDocument.Caption = "Split";
            this.barButtonItemSplitDocument.Enabled = false;
            this.barButtonItemSplitDocument.Glyph = global::SampleApplication.Properties.Resources.split_document_16x16;
            this.barButtonItemSplitDocument.Id = 139;
            this.barButtonItemSplitDocument.LargeGlyph = global::SampleApplication.Properties.Resources.split_document_32x32;
            this.barButtonItemSplitDocument.Name = "barButtonItemSplitDocument";
            // 
            // barButtonItemMergePre
            // 
            this.barButtonItemMergePre.Caption = "Merge with Previous";
            this.barButtonItemMergePre.Enabled = false;
            this.barButtonItemMergePre.Glyph = global::SampleApplication.Properties.Resources.merge_with_previous_16x16;
            this.barButtonItemMergePre.Id = 140;
            this.barButtonItemMergePre.LargeGlyph = global::SampleApplication.Properties.Resources.merge_with_previous_32x32;
            this.barButtonItemMergePre.Name = "barButtonItemMergePre";
            // 
            // barButtonItemMergeNext
            // 
            this.barButtonItemMergeNext.Caption = "Merge with Next";
            this.barButtonItemMergeNext.Enabled = false;
            this.barButtonItemMergeNext.Glyph = global::SampleApplication.Properties.Resources.merge_with_next_16x16;
            this.barButtonItemMergeNext.Id = 141;
            this.barButtonItemMergeNext.LargeGlyph = global::SampleApplication.Properties.Resources.merge_with_next_32x32;
            this.barButtonItemMergeNext.Name = "barButtonItemMergeNext";
            // 
            // barButtonItemMergeSeleted
            // 
            this.barButtonItemMergeSeleted.Caption = "Merge Selected";
            this.barButtonItemMergeSeleted.Enabled = false;
            this.barButtonItemMergeSeleted.Glyph = global::SampleApplication.Properties.Resources.merge_documents_16x16;
            this.barButtonItemMergeSeleted.Id = 142;
            this.barButtonItemMergeSeleted.LargeGlyph = global::SampleApplication.Properties.Resources.merge_documents_32x32;
            this.barButtonItemMergeSeleted.Name = "barButtonItemMergeSeleted";
            // 
            // barButtonItemIndexing
            // 
            this.barButtonItemIndexing.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemIndexing.Caption = "Indexing";
            this.barButtonItemIndexing.Glyph = global::SampleApplication.Properties.Resources.key_from_image_16x16;
            this.barButtonItemIndexing.Id = 143;
            this.barButtonItemIndexing.LargeGlyph = global::SampleApplication.Properties.Resources.key_from_image_32x32;
            this.barButtonItemIndexing.Name = "barButtonItemIndexing";
            this.barButtonItemIndexing.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemIndexing_ItemClick);
            // 
            // barButtonItemLanguage
            // 
            this.barButtonItemLanguage.ActAsDropDown = true;
            this.barButtonItemLanguage.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemLanguage.Caption = "Languages";
            this.barButtonItemLanguage.DropDownControl = this.popupControlContainerLanguages;
            this.barButtonItemLanguage.Glyph = global::SampleApplication.Properties.Resources.ocr_language_16x16;
            this.barButtonItemLanguage.Id = 144;
            this.barButtonItemLanguage.LargeGlyph = global::SampleApplication.Properties.Resources.ocr_language_32x32;
            this.barButtonItemLanguage.Name = "barButtonItemLanguage";
            // 
            // popupControlContainerLanguages
            // 
            this.popupControlContainerLanguages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainerLanguages.Controls.Add(this.layoutControl3);
            this.popupControlContainerLanguages.Location = new System.Drawing.Point(338, 272);
            this.popupControlContainerLanguages.Name = "popupControlContainerLanguages";
            this.popupControlContainerLanguages.Ribbon = this.ribbon;
            this.popupControlContainerLanguages.Size = new System.Drawing.Size(196, 225);
            this.popupControlContainerLanguages.TabIndex = 8;
            this.popupControlContainerLanguages.Visible = false;
            // 
            // layoutControl3
            // 
            this.layoutControl3.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl3.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl3.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl3.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl3.Controls.Add(this.checkedListBoxControl1);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup4;
            this.layoutControl3.Size = new System.Drawing.Size(196, 225);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.CheckOnClick = true;
            this.checkedListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null)});
            this.checkedListBoxControl1.Location = new System.Drawing.Point(2, 2);
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.Size = new System.Drawing.Size(193, 222);
            this.checkedListBoxControl1.StyleController = this.layoutControl3;
            this.checkedListBoxControl1.TabIndex = 4;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(196, 225);
            this.layoutControlGroup4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup4.Text = "layoutControlGroup4";
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.checkedListBoxControl1;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem6.Size = new System.Drawing.Size(194, 223);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // barButtonItemDrawZone
            // 
            this.barButtonItemDrawZone.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemDrawZone.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemDrawZone.Caption = "Draw Zone";
            this.barButtonItemDrawZone.Glyph = global::SampleApplication.Properties.Resources.rubber_band_ocr_16x16;
            this.barButtonItemDrawZone.Id = 145;
            this.barButtonItemDrawZone.LargeGlyph = global::SampleApplication.Properties.Resources.rubber_band_ocr_32x32;
            this.barButtonItemDrawZone.Name = "barButtonItemDrawZone";
            this.barButtonItemDrawZone.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItemDrawZone.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDrawZone_ItemClick);
            // 
            // barButtonItemRemoveZone
            // 
            this.barButtonItemRemoveZone.Caption = "Remove Zone";
            this.barButtonItemRemoveZone.Enabled = false;
            this.barButtonItemRemoveZone.Glyph = global::SampleApplication.Properties.Resources.remove_rubber_band_ocr_16x16;
            this.barButtonItemRemoveZone.Id = 146;
            this.barButtonItemRemoveZone.LargeGlyph = global::SampleApplication.Properties.Resources.remove_rubber_band_ocr_32x32;
            this.barButtonItemRemoveZone.Name = "barButtonItemRemoveZone";
            // 
            // barButtonItemExport
            // 
            this.barButtonItemExport.Caption = "Export";
            this.barButtonItemExport.Glyph = global::SampleApplication.Properties.Resources.batch_release_16x16;
            this.barButtonItemExport.Id = 147;
            this.barButtonItemExport.LargeGlyph = global::SampleApplication.Properties.Resources.batch_release_32x32;
            this.barButtonItemExport.Name = "barButtonItemExport";
            // 
            // barButtonItemScanner
            // 
            this.barButtonItemScanner.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemScanner.Caption = "Scanner";
            this.barButtonItemScanner.Down = true;
            this.barButtonItemScanner.Glyph = global::SampleApplication.Properties.Resources.setup_16x16;
            this.barButtonItemScanner.Id = 148;
            this.barButtonItemScanner.Name = "barButtonItemScanner";
            this.barButtonItemScanner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemScannerSetting_ItemClick);
            // 
            // barButtonItemVRSGeneral
            // 
            this.barButtonItemVRSGeneral.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemVRSGeneral.Caption = "General";
            this.barButtonItemVRSGeneral.Glyph = global::SampleApplication.Properties.Resources.vrs_16x16;
            this.barButtonItemVRSGeneral.Id = 149;
            this.barButtonItemVRSGeneral.Name = "barButtonItemVRSGeneral";
            this.barButtonItemVRSGeneral.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemScannerSetting_ItemClick);
            // 
            // barButtonItemVRSColor
            // 
            this.barButtonItemVRSColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemVRSColor.Caption = "Color";
            this.barButtonItemVRSColor.Glyph = global::SampleApplication.Properties.Resources.vrs_16x16;
            this.barButtonItemVRSColor.Id = 150;
            this.barButtonItemVRSColor.Name = "barButtonItemVRSColor";
            this.barButtonItemVRSColor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemScannerSetting_ItemClick);
            // 
            // barButtonItemBlackAndWhite
            // 
            this.barButtonItemBlackAndWhite.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemBlackAndWhite.Caption = "Black and White";
            this.barButtonItemBlackAndWhite.Down = true;
            this.barButtonItemBlackAndWhite.Glyph = global::SampleApplication.Properties.Resources.color_mode_bw_16x16;
            this.barButtonItemBlackAndWhite.Id = 151;
            this.barButtonItemBlackAndWhite.LargeGlyph = global::SampleApplication.Properties.Resources.color_mode_bw_32x32;
            this.barButtonItemBlackAndWhite.Name = "barButtonItemBlackAndWhite";
            this.barButtonItemBlackAndWhite.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemBlackAndWhite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemScannerSetting_ItemClick);
            // 
            // barButtonItemGrayscale
            // 
            this.barButtonItemGrayscale.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemGrayscale.Caption = "Grayscale";
            this.barButtonItemGrayscale.Glyph = global::SampleApplication.Properties.Resources.color_mode_gray_16x16;
            this.barButtonItemGrayscale.Id = 152;
            this.barButtonItemGrayscale.LargeGlyph = global::SampleApplication.Properties.Resources.color_mode_gray_32x32;
            this.barButtonItemGrayscale.Name = "barButtonItemGrayscale";
            this.barButtonItemGrayscale.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemGrayscale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemScannerSetting_ItemClick);
            // 
            // barButtonItemColor
            // 
            this.barButtonItemColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemColor.Caption = "Color";
            this.barButtonItemColor.Glyph = global::SampleApplication.Properties.Resources.color_mode_color_16x16;
            this.barButtonItemColor.Id = 153;
            this.barButtonItemColor.LargeGlyph = global::SampleApplication.Properties.Resources.color_mode_color_32x32;
            this.barButtonItemColor.Name = "barButtonItemColor";
            this.barButtonItemColor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemColor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemScannerSetting_ItemClick);
            // 
            // barButtonItemFlatbed
            // 
            this.barButtonItemFlatbed.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemFlatbed.Caption = "Flatbed";
            this.barButtonItemFlatbed.Glyph = global::SampleApplication.Properties.Resources.flatbed_16x16;
            this.barButtonItemFlatbed.Id = 154;
            this.barButtonItemFlatbed.LargeGlyph = global::SampleApplication.Properties.Resources.flatbed_32x32;
            this.barButtonItemFlatbed.Name = "barButtonItemFlatbed";
            this.barButtonItemFlatbed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFlatbed_ItemClick);
            // 
            // barButtonItemFeeder
            // 
            this.barButtonItemFeeder.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemFeeder.Caption = "&Feeder";
            this.barButtonItemFeeder.Down = true;
            this.barButtonItemFeeder.Glyph = global::SampleApplication.Properties.Resources.adf_16x16;
            this.barButtonItemFeeder.Id = 155;
            this.barButtonItemFeeder.LargeGlyph = global::SampleApplication.Properties.Resources.adf_32x32;
            this.barButtonItemFeeder.Name = "barButtonItemFeeder";
            this.barButtonItemFeeder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFeeder_ItemClick);
            // 
            // barButtonItemOneSide
            // 
            this.barButtonItemOneSide.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemOneSide.Caption = "One Side";
            this.barButtonItemOneSide.Glyph = global::SampleApplication.Properties.Resources.simplex_16x16;
            this.barButtonItemOneSide.Id = 156;
            this.barButtonItemOneSide.LargeGlyph = global::SampleApplication.Properties.Resources.simplex_32x32;
            this.barButtonItemOneSide.Name = "barButtonItemOneSide";
            this.barButtonItemOneSide.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemOneSide_ItemClick);
            // 
            // barButtonItemBothSides
            // 
            this.barButtonItemBothSides.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemBothSides.Caption = "Both Sides";
            this.barButtonItemBothSides.Down = true;
            this.barButtonItemBothSides.Glyph = global::SampleApplication.Properties.Resources.duplex_16x16;
            this.barButtonItemBothSides.Id = 157;
            this.barButtonItemBothSides.LargeGlyph = global::SampleApplication.Properties.Resources.duplex_32x32;
            this.barButtonItemBothSides.Name = "barButtonItemBothSides";
            this.barButtonItemBothSides.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemBothSides_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "                           ";
            this.barStaticItem1.Id = 162;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItemFront
            // 
            this.barButtonItemFront.ActAsDropDown = true;
            this.barButtonItemFront.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemFront.Caption = "Front";
            this.barButtonItemFront.DropDownControl = this.popupMenuFrontRotate;
            this.barButtonItemFront.Glyph = global::SampleApplication.Properties.Resources.rotate_00_16x16;
            this.barButtonItemFront.Id = 163;
            this.barButtonItemFront.LargeGlyph = global::SampleApplication.Properties.Resources.rotate_00_32x32;
            this.barButtonItemFront.Name = "barButtonItemFront";
            // 
            // popupMenuFrontRotate
            // 
            this.popupMenuFrontRotate.ItemLinks.Add(this.barCheckItemFront0);
            this.popupMenuFrontRotate.ItemLinks.Add(this.barCheckItemFront90Left);
            this.popupMenuFrontRotate.ItemLinks.Add(this.barCheckItemFront90Right);
            this.popupMenuFrontRotate.ItemLinks.Add(this.barCheckItemFront180);
            this.popupMenuFrontRotate.Name = "popupMenuFrontRotate";
            this.popupMenuFrontRotate.Ribbon = this.ribbon;
            // 
            // barCheckItemFront0
            // 
            this.barCheckItemFront0.Caption = "0°";
            this.barCheckItemFront0.Glyph = global::SampleApplication.Properties.Resources.rotate_00_32x32;
            this.barCheckItemFront0.GroupIndex = 1;
            this.barCheckItemFront0.Id = 214;
            this.barCheckItemFront0.LargeGlyph = global::SampleApplication.Properties.Resources.rotate_00_32x32;
            this.barCheckItemFront0.Name = "barCheckItemFront0";
            this.barCheckItemFront0.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemFront0_ItemClick);
            // 
            // barCheckItemFront90Left
            // 
            this.barCheckItemFront90Left.Caption = "90° Left";
            this.barCheckItemFront90Left.Glyph = global::SampleApplication.Properties.Resources.rotate_270_32x32;
            this.barCheckItemFront90Left.GroupIndex = 1;
            this.barCheckItemFront90Left.Id = 215;
            this.barCheckItemFront90Left.Name = "barCheckItemFront90Left";
            this.barCheckItemFront90Left.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemFront90Left_ItemClick);
            // 
            // barCheckItemFront90Right
            // 
            this.barCheckItemFront90Right.Caption = "90° Right";
            this.barCheckItemFront90Right.Glyph = global::SampleApplication.Properties.Resources.rotate_90_32x32;
            this.barCheckItemFront90Right.GroupIndex = 1;
            this.barCheckItemFront90Right.Id = 216;
            this.barCheckItemFront90Right.Name = "barCheckItemFront90Right";
            this.barCheckItemFront90Right.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemFront90Right_ItemClick);
            // 
            // barCheckItemFront180
            // 
            this.barCheckItemFront180.Caption = "180°";
            this.barCheckItemFront180.Glyph = global::SampleApplication.Properties.Resources.rotate_180_32x32;
            this.barCheckItemFront180.GroupIndex = 1;
            this.barCheckItemFront180.Id = 217;
            this.barCheckItemFront180.Name = "barCheckItemFront180";
            this.barCheckItemFront180.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemFront180_ItemClick);
            // 
            // barButtonItemBack
            // 
            this.barButtonItemBack.ActAsDropDown = true;
            this.barButtonItemBack.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemBack.Caption = "Back";
            this.barButtonItemBack.DropDownControl = this.popupMenuBackRotate;
            this.barButtonItemBack.Glyph = global::SampleApplication.Properties.Resources.rotate_00_16x16;
            this.barButtonItemBack.Id = 164;
            this.barButtonItemBack.LargeGlyph = global::SampleApplication.Properties.Resources.rotate_00_32x32;
            this.barButtonItemBack.Name = "barButtonItemBack";
            // 
            // popupMenuBackRotate
            // 
            this.popupMenuBackRotate.ItemLinks.Add(this.barCheckItemBack0);
            this.popupMenuBackRotate.ItemLinks.Add(this.barCheckItemBack90Left);
            this.popupMenuBackRotate.ItemLinks.Add(this.barCheckItemBack90Right);
            this.popupMenuBackRotate.ItemLinks.Add(this.barCheckItemBack180);
            this.popupMenuBackRotate.Name = "popupMenuBackRotate";
            this.popupMenuBackRotate.Ribbon = this.ribbon;
            // 
            // barCheckItemBack0
            // 
            this.barCheckItemBack0.Caption = "0°";
            this.barCheckItemBack0.Glyph = global::SampleApplication.Properties.Resources.rotate_00_32x32;
            this.barCheckItemBack0.GroupIndex = 2;
            this.barCheckItemBack0.Id = 218;
            this.barCheckItemBack0.Name = "barCheckItemBack0";
            this.barCheckItemBack0.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemBack0_ItemClick);
            // 
            // barCheckItemBack90Left
            // 
            this.barCheckItemBack90Left.Caption = "90° Left";
            this.barCheckItemBack90Left.Glyph = global::SampleApplication.Properties.Resources.rotate_270_32x32;
            this.barCheckItemBack90Left.GroupIndex = 2;
            this.barCheckItemBack90Left.Id = 219;
            this.barCheckItemBack90Left.Name = "barCheckItemBack90Left";
            this.barCheckItemBack90Left.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemBack90Left_ItemClick);
            // 
            // barCheckItemBack90Right
            // 
            this.barCheckItemBack90Right.Caption = "90° Right";
            this.barCheckItemBack90Right.Glyph = global::SampleApplication.Properties.Resources.rotate_90_32x32;
            this.barCheckItemBack90Right.GroupIndex = 2;
            this.barCheckItemBack90Right.Id = 220;
            this.barCheckItemBack90Right.Name = "barCheckItemBack90Right";
            this.barCheckItemBack90Right.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemBack90Right_ItemClick);
            // 
            // barCheckItemBack180
            // 
            this.barCheckItemBack180.Caption = "180°";
            this.barCheckItemBack180.Glyph = global::SampleApplication.Properties.Resources.rotate_180_32x32;
            this.barCheckItemBack180.GroupIndex = 2;
            this.barCheckItemBack180.Id = 221;
            this.barCheckItemBack180.Name = "barCheckItemBack180";
            this.barCheckItemBack180.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemBack180_ItemClick);
            // 
            // barButtonItemAutoResolve
            // 
            this.barButtonItemAutoResolve.ActAsDropDown = true;
            this.barButtonItemAutoResolve.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemAutoResolve.Caption = "Auto Resolve";
            this.barButtonItemAutoResolve.DropDownControl = this.popupMenuAutoResolve;
            this.barButtonItemAutoResolve.Glyph = global::SampleApplication.Properties.Resources.import_scanner_profiles_16x16;
            this.barButtonItemAutoResolve.Id = 165;
            this.barButtonItemAutoResolve.LargeGlyph = global::SampleApplication.Properties.Resources.import_scanner_profiles_32x32;
            this.barButtonItemAutoResolve.Name = "barButtonItemAutoResolve";
            // 
            // popupMenuAutoResolve
            // 
            this.popupMenuAutoResolve.ItemLinks.Add(this.barCheckItemOutOfPaper);
            this.popupMenuAutoResolve.ItemLinks.Add(this.barCheckItemPaperJam);
            this.popupMenuAutoResolve.ItemLinks.Add(this.barCheckItemCoverOpen);
            this.popupMenuAutoResolve.ItemLinks.Add(this.barCheckItemMultifeed);
            this.popupMenuAutoResolve.Name = "popupMenuAutoResolve";
            this.popupMenuAutoResolve.Ribbon = this.ribbon;
            // 
            // barCheckItemOutOfPaper
            // 
            this.barCheckItemOutOfPaper.Caption = "Out Of Paper";
            this.barCheckItemOutOfPaper.Id = 222;
            this.barCheckItemOutOfPaper.Name = "barCheckItemOutOfPaper";
            this.barCheckItemOutOfPaper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemOutOfPaper_ItemClick);
            // 
            // barCheckItemPaperJam
            // 
            this.barCheckItemPaperJam.Caption = "Paper jam";
            this.barCheckItemPaperJam.Id = 223;
            this.barCheckItemPaperJam.Name = "barCheckItemPaperJam";
            this.barCheckItemPaperJam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemPaperJam_ItemClick);
            // 
            // barCheckItemCoverOpen
            // 
            this.barCheckItemCoverOpen.Caption = "Cover Open";
            this.barCheckItemCoverOpen.Id = 224;
            this.barCheckItemCoverOpen.Name = "barCheckItemCoverOpen";
            this.barCheckItemCoverOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemCoverOpen_ItemClick);
            // 
            // barCheckItemMultifeed
            // 
            this.barCheckItemMultifeed.Caption = "Multifeed";
            this.barCheckItemMultifeed.Id = 225;
            this.barCheckItemMultifeed.Name = "barCheckItemMultifeed";
            this.barCheckItemMultifeed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemMultifeed_ItemClick);
            // 
            // barButtonItemResetScanSetting
            // 
            this.barButtonItemResetScanSetting.Caption = "Original Settings";
            this.barButtonItemResetScanSetting.Glyph = global::SampleApplication.Properties.Resources.reset_vrs_16x16;
            this.barButtonItemResetScanSetting.Id = 166;
            this.barButtonItemResetScanSetting.LargeGlyph = global::SampleApplication.Properties.Resources.reset_vrs_32x32;
            this.barButtonItemResetScanSetting.Name = "barButtonItemResetScanSetting";
            this.barButtonItemResetScanSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemResetScanSetting_ItemClick);
            // 
            // barButtonItemSelectScanner
            // 
            this.barButtonItemSelectScanner.Caption = "Select        ";
            this.barButtonItemSelectScanner.Glyph = global::SampleApplication.Properties.Resources.adf_16x16;
            this.barButtonItemSelectScanner.Id = 167;
            this.barButtonItemSelectScanner.LargeGlyph = global::SampleApplication.Properties.Resources.adf_32x32;
            this.barButtonItemSelectScanner.Name = "barButtonItemSelectScanner";
            this.barButtonItemSelectScanner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSelectScanner_ItemClick);
            // 
            // barEditItem2
            // 
            this.barEditItem2.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barEditItem2.Edit = this.repositoryItemComboBox1;
            this.barEditItem2.Id = 168;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Width = 60;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.DropDownRows = 8;
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "75",
            "100",
            "150",
            "200",
            "240",
            "300",
            "400",
            "500"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemComboBox1.UseParentBackground = true;
            this.repositoryItemComboBox1.EditValueChanged += new System.EventHandler(this.repositoryItemComboBox1_EditValueChanged);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Resolution";
            this.barStaticItem2.Id = 169;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItemDeskew
            // 
            this.barButtonItemDeskew.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemDeskew.Caption = "Deskew";
            this.barButtonItemDeskew.Glyph = global::SampleApplication.Properties.Resources.deskew_16x16;
            this.barButtonItemDeskew.Id = 170;
            this.barButtonItemDeskew.LargeGlyph = global::SampleApplication.Properties.Resources.deskew_32x32;
            this.barButtonItemDeskew.Name = "barButtonItemDeskew";
            this.barButtonItemDeskew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeskew_ItemClick);
            // 
            // barButtonItemAutoCrop
            // 
            this.barButtonItemAutoCrop.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemAutoCrop.Caption = "Auto  Crop";
            this.barButtonItemAutoCrop.Glyph = global::SampleApplication.Properties.Resources.auto_crop_16x16;
            this.barButtonItemAutoCrop.Id = 171;
            this.barButtonItemAutoCrop.LargeGlyph = global::SampleApplication.Properties.Resources.auto_crop_32x32;
            this.barButtonItemAutoCrop.Name = "barButtonItemAutoCrop";
            this.barButtonItemAutoCrop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAutoCrop_ItemClick);
            // 
            // barButtonItemEdgeCleanup
            // 
            this.barButtonItemEdgeCleanup.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemEdgeCleanup.Caption = "Edge  Cleanup";
            this.barButtonItemEdgeCleanup.Glyph = global::SampleApplication.Properties.Resources.edge_cleanup_16x16;
            this.barButtonItemEdgeCleanup.Id = 172;
            this.barButtonItemEdgeCleanup.LargeGlyph = global::SampleApplication.Properties.Resources.edge_cleanup_32x32;
            this.barButtonItemEdgeCleanup.Name = "barButtonItemEdgeCleanup";
            // 
            // barButtonItemHolePunchRemoval
            // 
            this.barButtonItemHolePunchRemoval.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemHolePunchRemoval.Caption = "Hole Punch Removal";
            this.barButtonItemHolePunchRemoval.Down = true;
            this.barButtonItemHolePunchRemoval.Glyph = global::SampleApplication.Properties.Resources.hole_punch_removal_16x16;
            this.barButtonItemHolePunchRemoval.Id = 173;
            this.barButtonItemHolePunchRemoval.LargeGlyph = global::SampleApplication.Properties.Resources.hole_punch_removal_32x32;
            this.barButtonItemHolePunchRemoval.Name = "barButtonItemHolePunchRemoval";
            // 
            // barButtonItemDeleteBlank
            // 
            this.barButtonItemDeleteBlank.ActAsCheck = true;
            this.barButtonItemDeleteBlank.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemDeleteBlank.Caption = "Delete Blank";
            this.barButtonItemDeleteBlank.DropDownControl = this.popupMenu2;
            this.barButtonItemDeleteBlank.Glyph = global::SampleApplication.Properties.Resources.delete_batch_16x16;
            this.barButtonItemDeleteBlank.Id = 174;
            this.barButtonItemDeleteBlank.LargeGlyph = global::SampleApplication.Properties.Resources.delete_blank_sides_32x32;
            this.barButtonItemDeleteBlank.Name = "barButtonItemDeleteBlank";
            this.barButtonItemDeleteBlank.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItemDeleteBlank.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeleteBlank_ItemClick);
            // 
            // popupMenu2
            // 
            this.popupMenu2.ItemLinks.Add(this.barStaticItem3);
            this.popupMenu2.ItemLinks.Add(this.barEditItemTrackBarBlankContentSensitivityValue);
            this.popupMenu2.ItemLinks.Add(this.barEditItemBlankContentSensitivityValue);
            this.popupMenu2.ItemLinks.Add(this.barCheckItemIgnoreHole, true);
            this.popupMenu2.Name = "popupMenu2";
            this.popupMenu2.Ribbon = this.ribbon;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "      Very Noisy                Clean              Very Clean    ";
            this.barStaticItem3.Glyph = global::SampleApplication.Properties.Resources.blank_sensitivity5_16x16;
            this.barStaticItem3.Id = 229;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItemTrackBarBlankContentSensitivityValue
            // 
            this.barEditItemTrackBarBlankContentSensitivityValue.Edit = this.repositoryItemTrackBarBlankContentSensitivity;
            this.barEditItemTrackBarBlankContentSensitivityValue.Id = 230;
            this.barEditItemTrackBarBlankContentSensitivityValue.Name = "barEditItemTrackBarBlankContentSensitivityValue";
            // 
            // repositoryItemTrackBarBlankContentSensitivity
            // 
            this.repositoryItemTrackBarBlankContentSensitivity.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBarBlankContentSensitivity.Maximum = 100;
            this.repositoryItemTrackBarBlankContentSensitivity.Name = "repositoryItemTrackBarBlankContentSensitivity";
            this.repositoryItemTrackBarBlankContentSensitivity.TickFrequency = 5;
            this.repositoryItemTrackBarBlankContentSensitivity.EditValueChanged += new System.EventHandler(this.repositoryItemTrackBarBlankContentSensitivity_EditValueChanged);
            // 
            // barEditItemBlankContentSensitivityValue
            // 
            this.barEditItemBlankContentSensitivityValue.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItemBlankContentSensitivityValue.Caption = "              Content Sensitivity";
            this.barEditItemBlankContentSensitivityValue.Edit = this.repositoryItemSpinEditBlankContentSensitivityValue;
            this.barEditItemBlankContentSensitivityValue.Id = 231;
            this.barEditItemBlankContentSensitivityValue.Name = "barEditItemBlankContentSensitivityValue";
            // 
            // repositoryItemSpinEditBlankContentSensitivityValue
            // 
            this.repositoryItemSpinEditBlankContentSensitivityValue.AutoHeight = false;
            this.repositoryItemSpinEditBlankContentSensitivityValue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEditBlankContentSensitivityValue.Name = "repositoryItemSpinEditBlankContentSensitivityValue";
            this.repositoryItemSpinEditBlankContentSensitivityValue.EditValueChanged += new System.EventHandler(this.repositoryItemTrackBarBlankContentSensitivity_EditValueChanged);
            // 
            // barCheckItemIgnoreHole
            // 
            this.barCheckItemIgnoreHole.Caption = "Ignore Hole Puntches";
            this.barCheckItemIgnoreHole.Glyph = global::SampleApplication.Properties.Resources.hole_punches_16x16;
            this.barCheckItemIgnoreHole.Id = 232;
            this.barCheckItemIgnoreHole.Name = "barCheckItemIgnoreHole";
            this.barCheckItemIgnoreHole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItemIgnoreHole_ItemClick);
            // 
            // barButtonItemAutoRotate
            // 
            this.barButtonItemAutoRotate.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemAutoRotate.Caption = "Auto  Rotate";
            this.barButtonItemAutoRotate.Glyph = global::SampleApplication.Properties.Resources.auto_rotate_16x16;
            this.barButtonItemAutoRotate.Id = 175;
            this.barButtonItemAutoRotate.LargeGlyph = global::SampleApplication.Properties.Resources.auto_rotate_32x32;
            this.barButtonItemAutoRotate.Name = "barButtonItemAutoRotate";
            // 
            // barEditItemBrightness
            // 
            this.barEditItemBrightness.Edit = this.repositoryItemTrackBarBrightness;
            this.barEditItemBrightness.Glyph = global::SampleApplication.Properties.Resources.brightness_16x16;
            this.barEditItemBrightness.Id = 176;
            this.barEditItemBrightness.Name = "barEditItemBrightness";
            this.barEditItemBrightness.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barEditItemBrightness.Width = 100;
            // 
            // repositoryItemTrackBarBrightness
            // 
            this.repositoryItemTrackBarBrightness.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBarBrightness.Maximum = 100;
            this.repositoryItemTrackBarBrightness.Name = "repositoryItemTrackBarBrightness";
            this.repositoryItemTrackBarBrightness.TickFrequency = 10;
            this.repositoryItemTrackBarBrightness.UseParentBackground = true;
            this.repositoryItemTrackBarBrightness.EditValueChanged += new System.EventHandler(this.repositoryItemTrackBarBrightness_EditValueChanged);
            // 
            // barEditItemContrast
            // 
            this.barEditItemContrast.Edit = this.repositoryItemTrackBarContrast;
            this.barEditItemContrast.Glyph = global::SampleApplication.Properties.Resources.contrast_16x16;
            this.barEditItemContrast.Id = 177;
            this.barEditItemContrast.Name = "barEditItemContrast";
            this.barEditItemContrast.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barEditItemContrast.Width = 100;
            // 
            // repositoryItemTrackBarContrast
            // 
            this.repositoryItemTrackBarContrast.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBarContrast.Maximum = 100;
            this.repositoryItemTrackBarContrast.Name = "repositoryItemTrackBarContrast";
            this.repositoryItemTrackBarContrast.TickFrequency = 10;
            this.repositoryItemTrackBarContrast.UseParentBackground = true;
            this.repositoryItemTrackBarContrast.EditValueChanged += new System.EventHandler(this.repositoryItemTrackBarContrast_EditValueChanged);
            // 
            // barEditItemGamma
            // 
            this.barEditItemGamma.Edit = this.repositoryItemTrackBarGamma;
            this.barEditItemGamma.Glyph = global::SampleApplication.Properties.Resources.gamma_16x16;
            this.barEditItemGamma.Id = 178;
            this.barEditItemGamma.Name = "barEditItemGamma";
            this.barEditItemGamma.Width = 100;
            // 
            // repositoryItemTrackBarGamma
            // 
            this.repositoryItemTrackBarGamma.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBarGamma.Maximum = 100;
            this.repositoryItemTrackBarGamma.Name = "repositoryItemTrackBarGamma";
            this.repositoryItemTrackBarGamma.TickFrequency = 20;
            this.repositoryItemTrackBarGamma.UseParentBackground = true;
            this.repositoryItemTrackBarGamma.EditValueChanged += new System.EventHandler(this.repositoryItemTrackBarGamma_EditValueChanged);
            // 
            // barEditItemBrightnessValue
            // 
            this.barEditItemBrightnessValue.Edit = this.repositoryItemSpinEditBrightness;
            this.barEditItemBrightnessValue.Id = 179;
            this.barEditItemBrightnessValue.Name = "barEditItemBrightnessValue";
            // 
            // repositoryItemSpinEditBrightness
            // 
            this.repositoryItemSpinEditBrightness.AutoHeight = false;
            this.repositoryItemSpinEditBrightness.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEditBrightness.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSpinEditBrightness.Name = "repositoryItemSpinEditBrightness";
            this.repositoryItemSpinEditBrightness.UseParentBackground = true;
            this.repositoryItemSpinEditBrightness.EditValueChanged += new System.EventHandler(this.repositoryItemSpinEditBrightness_EditValueChanged);
            // 
            // barEditItemContrastValue
            // 
            this.barEditItemContrastValue.Edit = this.repositoryItemSpinEditContrast;
            this.barEditItemContrastValue.Id = 180;
            this.barEditItemContrastValue.Name = "barEditItemContrastValue";
            // 
            // repositoryItemSpinEditContrast
            // 
            this.repositoryItemSpinEditContrast.AutoHeight = false;
            this.repositoryItemSpinEditContrast.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEditContrast.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSpinEditContrast.Name = "repositoryItemSpinEditContrast";
            this.repositoryItemSpinEditContrast.UseParentBackground = true;
            this.repositoryItemSpinEditContrast.EditValueChanged += new System.EventHandler(this.repositoryItemSpinEditContrast_EditValueChanged);
            // 
            // barEditItemGammaValue
            // 
            this.barEditItemGammaValue.Edit = this.repositoryItemSpinEditGamma;
            this.barEditItemGammaValue.Id = 181;
            this.barEditItemGammaValue.Name = "barEditItemGammaValue";
            // 
            // repositoryItemSpinEditGamma
            // 
            this.repositoryItemSpinEditGamma.AutoHeight = false;
            this.repositoryItemSpinEditGamma.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEditGamma.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSpinEditGamma.Name = "repositoryItemSpinEditGamma";
            this.repositoryItemSpinEditGamma.UseParentBackground = true;
            this.repositoryItemSpinEditGamma.EditValueChanged += new System.EventHandler(this.repositoryItemSpinEditGamma_EditValueChanged);
            // 
            // barEditItemAutoBrightness
            // 
            this.barEditItemAutoBrightness.Edit = this.repositoryItemCheckEdit1;
            this.barEditItemAutoBrightness.Id = 182;
            this.barEditItemAutoBrightness.Name = "barEditItemAutoBrightness";
            this.barEditItemAutoBrightness.Width = 100;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Auto Brightness";
            this.repositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.UseParentBackground = true;
            this.repositoryItemCheckEdit1.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckedChanged);
            // 
            // barEditItemAdvancedClarity
            // 
            this.barEditItemAdvancedClarity.Edit = this.repositoryItemCheckEdit2;
            this.barEditItemAdvancedClarity.Id = 183;
            this.barEditItemAdvancedClarity.Name = "barEditItemAdvancedClarity";
            this.barEditItemAdvancedClarity.Width = 100;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Advanced Clarity";
            this.repositoryItemCheckEdit2.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.UseParentBackground = true;
            this.repositoryItemCheckEdit2.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit2_CheckedChanged);
            // 
            // barEditItemClarityValue
            // 
            this.barEditItemClarityValue.Caption = "Low";
            this.barEditItemClarityValue.Edit = this.repositoryItemTrackBarClarityValue;
            this.barEditItemClarityValue.Id = 184;
            this.barEditItemClarityValue.Name = "barEditItemClarityValue";
            this.barEditItemClarityValue.Width = 90;
            // 
            // repositoryItemTrackBarClarityValue
            // 
            this.repositoryItemTrackBarClarityValue.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBarClarityValue.LargeChange = 1;
            this.repositoryItemTrackBarClarityValue.Maximum = 4;
            this.repositoryItemTrackBarClarityValue.Name = "repositoryItemTrackBarClarityValue";
            this.repositoryItemTrackBarClarityValue.UseParentBackground = true;
            this.repositoryItemTrackBarClarityValue.EditValueChanged += new System.EventHandler(this.repositoryItemTrackBarClarityValue_EditValueChanged);
            // 
            // barStaticItemBlank
            // 
            this.barStaticItemBlank.Id = 185;
            this.barStaticItemBlank.Name = "barStaticItemBlank";
            this.barStaticItemBlank.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItemHight
            // 
            this.barStaticItemHight.Caption = "High";
            this.barStaticItemHight.Id = 187;
            this.barStaticItemHight.Name = "barStaticItemHight";
            this.barStaticItemHight.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItemAdvancedClaritySetup
            // 
            this.barButtonItemAdvancedClaritySetup.ActAsDropDown = true;
            this.barButtonItemAdvancedClaritySetup.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItemAdvancedClaritySetup.Caption = "Advanced Clarity Setup";
            this.barButtonItemAdvancedClaritySetup.DropDownControl = this.popupMenu1;
            this.barButtonItemAdvancedClaritySetup.Glyph = global::SampleApplication.Properties.Resources.setup_16x16;
            this.barButtonItemAdvancedClaritySetup.Id = 189;
            this.barButtonItemAdvancedClaritySetup.Name = "barButtonItemAdvancedClaritySetup";
            this.barButtonItemAdvancedClaritySetup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barCheckItemAnalyzeColor);
            this.popupMenu1.ItemLinks.Add(this.barCheckItemIgnorePicture);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // barCheckItemAnalyzeColor
            // 
            this.barCheckItemAnalyzeColor.Caption = "Analyze Color";
            this.barCheckItemAnalyzeColor.Id = 227;
            this.barCheckItemAnalyzeColor.Name = "barCheckItemAnalyzeColor";
            // 
            // barCheckItemIgnorePicture
            // 
            this.barCheckItemIgnorePicture.Caption = "Ignore Picture";
            this.barCheckItemIgnorePicture.Id = 228;
            this.barCheckItemIgnorePicture.Name = "barCheckItemIgnorePicture";
            // 
            // barEditItemThickness
            // 
            this.barEditItemThickness.Caption = " ";
            this.barEditItemThickness.Edit = this.repositoryItemTrackBarThickness;
            this.barEditItemThickness.Glyph = global::SampleApplication.Properties.Resources.thin_16x16;
            this.barEditItemThickness.Id = 191;
            this.barEditItemThickness.Name = "barEditItemThickness";
            this.barEditItemThickness.Width = 100;
            // 
            // repositoryItemTrackBarThickness
            // 
            this.repositoryItemTrackBarThickness.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBarThickness.Name = "repositoryItemTrackBarThickness";
            this.repositoryItemTrackBarThickness.UseParentBackground = true;
            this.repositoryItemTrackBarThickness.EditValueChanged += new System.EventHandler(this.repositoryItemTrackBarThickness_EditValueChanged);
            // 
            // barEditItemSpeckle
            // 
            this.barEditItemSpeckle.Edit = this.repositoryItemTrackBarSpeckle;
            this.barEditItemSpeckle.Glyph = global::SampleApplication.Properties.Resources.blank_sensitivity4_16x16;
            this.barEditItemSpeckle.Id = 192;
            this.barEditItemSpeckle.Name = "barEditItemSpeckle";
            this.barEditItemSpeckle.Width = 100;
            // 
            // repositoryItemTrackBarSpeckle
            // 
            this.repositoryItemTrackBarSpeckle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBarSpeckle.Name = "repositoryItemTrackBarSpeckle";
            this.repositoryItemTrackBarSpeckle.UseParentBackground = true;
            this.repositoryItemTrackBarSpeckle.EditValueChanged += new System.EventHandler(this.repositoryItemTrackBarSpeckle_EditValueChanged);
            // 
            // barStaticItemThickness
            // 
            this.barStaticItemThickness.Glyph = global::SampleApplication.Properties.Resources.thick_16x16;
            this.barStaticItemThickness.Id = 194;
            this.barStaticItemThickness.Name = "barStaticItemThickness";
            this.barStaticItemThickness.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonGalleryBarItemThemes
            // 
            this.ribbonGalleryBarItemThemes.Caption = "Themes";
            // 
            // 
            // 
            this.ribbonGalleryBarItemThemes.Gallery.AllowHoverImages = true;
            this.ribbonGalleryBarItemThemes.Gallery.ColumnCount = 4;
            this.ribbonGalleryBarItemThemes.Gallery.FixedHoverImageSize = false;
            galleryItemGroup1.Caption = "Themes";
            this.ribbonGalleryBarItemThemes.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.ribbonGalleryBarItemThemes.Gallery.ImageSize = new System.Drawing.Size(17, 17);
            this.ribbonGalleryBarItemThemes.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.ribbonGalleryBarItemThemes.Gallery.RowCount = 4;
            this.ribbonGalleryBarItemThemes.Id = 196;
            this.ribbonGalleryBarItemThemes.Name = "ribbonGalleryBarItemThemes";
            // 
            // barButtonItemDetectColor
            // 
            this.barButtonItemDetectColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemDetectColor.Caption = "Detect Color";
            this.barButtonItemDetectColor.Glyph = global::SampleApplication.Properties.Resources.color_lots_16x16;
            this.barButtonItemDetectColor.Id = 197;
            this.barButtonItemDetectColor.LargeGlyph = global::SampleApplication.Properties.Resources.color_lots_32x32;
            this.barButtonItemDetectColor.Name = "barButtonItemDetectColor";
            this.barButtonItemDetectColor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDetectColor_ItemClick);
            // 
            // barButtonItemDetectSmallColorObjects
            // 
            this.barButtonItemDetectSmallColorObjects.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemDetectSmallColorObjects.Caption = "Detect Small Color Objects";
            this.barButtonItemDetectSmallColorObjects.Glyph = global::SampleApplication.Properties.Resources.color_very_small_16x16;
            this.barButtonItemDetectSmallColorObjects.Id = 198;
            this.barButtonItemDetectSmallColorObjects.LargeGlyph = global::SampleApplication.Properties.Resources.color_very_small_32x32;
            this.barButtonItemDetectSmallColorObjects.Name = "barButtonItemDetectSmallColorObjects";
            // 
            // barEditItemOverall
            // 
            this.barEditItemOverall.Edit = this.repositoryItemTrackBar7;
            this.barEditItemOverall.Glyph = global::SampleApplication.Properties.Resources.color_some_16x16;
            this.barEditItemOverall.Id = 199;
            this.barEditItemOverall.Name = "barEditItemOverall";
            this.barEditItemOverall.Width = 140;
            // 
            // repositoryItemTrackBar7
            // 
            this.repositoryItemTrackBar7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar7.Maximum = 100;
            this.repositoryItemTrackBar7.Name = "repositoryItemTrackBar7";
            this.repositoryItemTrackBar7.TickFrequency = 10;
            this.repositoryItemTrackBar7.UseParentBackground = true;
            // 
            // barEditItemSensitivity
            // 
            this.barEditItemSensitivity.Edit = this.repositoryItemTrackBar8;
            this.barEditItemSensitivity.Glyph = global::SampleApplication.Properties.Resources.color_very_small_16x16;
            this.barEditItemSensitivity.Id = 200;
            this.barEditItemSensitivity.Name = "barEditItemSensitivity";
            this.barEditItemSensitivity.Width = 140;
            // 
            // repositoryItemTrackBar8
            // 
            this.repositoryItemTrackBar8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar8.Maximum = 100;
            this.repositoryItemTrackBar8.Name = "repositoryItemTrackBar8";
            this.repositoryItemTrackBar8.TickFrequency = 10;
            this.repositoryItemTrackBar8.UseParentBackground = true;
            // 
            // barEditItemIgnoBackgroundColor
            // 
            this.barEditItemIgnoBackgroundColor.Edit = this.repositoryItemCheckEdit4;
            this.barEditItemIgnoBackgroundColor.Id = 201;
            this.barEditItemIgnoBackgroundColor.Name = "barEditItemIgnoBackgroundColor";
            this.barEditItemIgnoBackgroundColor.Width = 160;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Caption = "Ignore Background Color";
            this.repositoryItemCheckEdit4.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            this.repositoryItemCheckEdit4.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit4.UseParentBackground = true;
            // 
            // barStaticItemOverall
            // 
            this.barStaticItemOverall.Glyph = global::SampleApplication.Properties.Resources.color_lots_16x16;
            this.barStaticItemOverall.Id = 202;
            this.barStaticItemOverall.Name = "barStaticItemOverall";
            this.barStaticItemOverall.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItemSensitivity
            // 
            this.barStaticItemSensitivity.Glyph = global::SampleApplication.Properties.Resources.color_small_16x16;
            this.barStaticItemSensitivity.Id = 203;
            this.barStaticItemSensitivity.Name = "barStaticItemSensitivity";
            this.barStaticItemSensitivity.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItemOverallValue
            // 
            this.barEditItemOverallValue.Edit = this.repositoryItemSpinEdit4;
            this.barEditItemOverallValue.Id = 204;
            this.barEditItemOverallValue.Name = "barEditItemOverallValue";
            // 
            // repositoryItemSpinEdit4
            // 
            this.repositoryItemSpinEdit4.AutoHeight = false;
            this.repositoryItemSpinEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit4.Name = "repositoryItemSpinEdit4";
            this.repositoryItemSpinEdit4.UseParentBackground = true;
            // 
            // barEditItemSensitivityValue
            // 
            this.barEditItemSensitivityValue.Edit = this.repositoryItemSpinEdit5;
            this.barEditItemSensitivityValue.Id = 205;
            this.barEditItemSensitivityValue.Name = "barEditItemSensitivityValue";
            // 
            // repositoryItemSpinEdit5
            // 
            this.repositoryItemSpinEdit5.AutoHeight = false;
            this.repositoryItemSpinEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit5.Name = "repositoryItemSpinEdit5";
            this.repositoryItemSpinEdit5.UseParentBackground = true;
            // 
            // barButtonItemSmoothing
            // 
            this.barButtonItemSmoothing.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemSmoothing.Caption = "Smoothing";
            this.barButtonItemSmoothing.Glyph = global::SampleApplication.Properties.Resources.smoothing_16x16;
            this.barButtonItemSmoothing.Id = 206;
            this.barButtonItemSmoothing.LargeGlyph = global::SampleApplication.Properties.Resources.smoothing_32x32;
            this.barButtonItemSmoothing.Name = "barButtonItemSmoothing";
            this.barButtonItemSmoothing.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSmoothing_ItemClick);
            // 
            // barStaticItemSmoothing
            // 
            this.barStaticItemSmoothing.Glyph = global::SampleApplication.Properties.Resources.smoothing_high_16x16;
            this.barStaticItemSmoothing.Id = 208;
            this.barStaticItemSmoothing.Name = "barStaticItemSmoothing";
            this.barStaticItemSmoothing.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItemSmoothingValue
            // 
            this.barEditItemSmoothingValue.Edit = this.repositoryItemSpinEdit6;
            this.barEditItemSmoothingValue.Id = 209;
            this.barEditItemSmoothingValue.Name = "barEditItemSmoothingValue";
            // 
            // repositoryItemSpinEdit6
            // 
            this.repositoryItemSpinEdit6.AutoHeight = false;
            this.repositoryItemSpinEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit6.Name = "repositoryItemSpinEdit6";
            this.repositoryItemSpinEdit6.UseParentBackground = true;
            // 
            // barButtonItemSnapToWhite
            // 
            this.barButtonItemSnapToWhite.Caption = "Snap to White";
            this.barButtonItemSnapToWhite.Glyph = global::SampleApplication.Properties.Resources.snap_to_white_16x16;
            this.barButtonItemSnapToWhite.Id = 210;
            this.barButtonItemSnapToWhite.LargeGlyph = global::SampleApplication.Properties.Resources.snap_to_white_32x32;
            this.barButtonItemSnapToWhite.Name = "barButtonItemSnapToWhite";
            // 
            // barButtonItemBackgroundColorToWhite
            // 
            this.barButtonItemBackgroundColorToWhite.Caption = "Background Color to White";
            this.barButtonItemBackgroundColorToWhite.Glyph = global::SampleApplication.Properties.Resources.color_background_to_white_16x16;
            this.barButtonItemBackgroundColorToWhite.Id = 211;
            this.barButtonItemBackgroundColorToWhite.LargeGlyph = global::SampleApplication.Properties.Resources.color_background_to_white_32x32;
            this.barButtonItemBackgroundColorToWhite.Name = "barButtonItemBackgroundColorToWhite";
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Refresh";
            this.barButtonItemRefresh.Id = 212;
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            // 
            // barButtonItemAllJob
            // 
            this.barButtonItemAllJob.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemAllJob.Caption = "All Jobs";
            this.barButtonItemAllJob.Id = 213;
            this.barButtonItemAllJob.Name = "barButtonItemAllJob";
            // 
            // barStaticItemSpeckle
            // 
            this.barStaticItemSpeckle.AccessibleDescription = "";
            this.barStaticItemSpeckle.Glyph = global::SampleApplication.Properties.Resources.blank_sensitivity1_16x16;
            this.barStaticItemSpeckle.Id = 226;
            this.barStaticItemSpeckle.Name = "barStaticItemSpeckle";
            this.barStaticItemSpeckle.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItemSmoothingTrackBar
            // 
            this.barEditItemSmoothingTrackBar.Edit = this.repositoryItemTrackBar1;
            this.barEditItemSmoothingTrackBar.Glyph = global::SampleApplication.Properties.Resources.smoothing_low_16x16;
            this.barEditItemSmoothingTrackBar.Id = 233;
            this.barEditItemSmoothingTrackBar.Name = "barEditItemSmoothingTrackBar";
            this.barEditItemSmoothingTrackBar.Width = 100;
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar1.Maximum = 100;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            this.repositoryItemTrackBar1.TickFrequency = 10;
            this.repositoryItemTrackBar1.UseParentBackground = true;
            // 
            // barEditItemDocument
            // 
            this.barEditItemDocument.Caption = "Document";
            this.barEditItemDocument.Edit = this.repositoryItemTextEdit1;
            this.barEditItemDocument.Id = 234;
            this.barEditItemDocument.Name = "barEditItemDocument";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.UseParentBackground = true;
            // 
            // barEditItemImage
            // 
            this.barEditItemImage.Caption = "Image";
            this.barEditItemImage.Edit = this.repositoryItemTextEdit2;
            this.barEditItemImage.Id = 235;
            this.barEditItemImage.Name = "barEditItemImage";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit2.UseParentBackground = true;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Id = 236;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Create";
            this.barButtonItem2.Glyph = global::SampleApplication.Properties.Resources.new_document_16x16;
            this.barButtonItem2.Id = 237;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barStaticItem5
            // 
            this.barStaticItem5.Id = 238;
            this.barStaticItem5.Name = "barStaticItem5";
            this.barStaticItem5.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem6
            // 
            this.barStaticItem6.Id = 239;
            this.barStaticItem6.Name = "barStaticItem6";
            this.barStaticItem6.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Delete";
            this.barButtonItemDelete.Glyph = global::SampleApplication.Properties.Resources.delete_document_16x16;
            this.barButtonItemDelete.Id = 240;
            this.barButtonItemDelete.LargeGlyph = global::SampleApplication.Properties.Resources.delete_document_32x32;
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            // 
            // barButtonItemDeleteToEnd
            // 
            this.barButtonItemDeleteToEnd.Caption = "Delete to End";
            this.barButtonItemDeleteToEnd.Glyph = global::SampleApplication.Properties.Resources.delete_end_of_document_16x16;
            this.barButtonItemDeleteToEnd.Id = 241;
            this.barButtonItemDeleteToEnd.LargeGlyph = global::SampleApplication.Properties.Resources.delete_end_of_document_32x32;
            this.barButtonItemDeleteToEnd.Name = "barButtonItemDeleteToEnd";
            // 
            // barButtonItemRescan
            // 
            this.barButtonItemRescan.Caption = "Rescan";
            this.barButtonItemRescan.Glyph = global::SampleApplication.Properties.Resources.rescan_multi_page_16x16;
            this.barButtonItemRescan.Id = 242;
            this.barButtonItemRescan.LargeGlyph = global::SampleApplication.Properties.Resources.rescan_multi_page_32x32;
            this.barButtonItemRescan.Name = "barButtonItemRescan";
            // 
            // barButtonItemRescanMultiFeed
            // 
            this.barButtonItemRescanMultiFeed.Caption = "Rescan Multifeed";
            this.barButtonItemRescanMultiFeed.Glyph = global::SampleApplication.Properties.Resources.rescan_multi_feed_16x16;
            this.barButtonItemRescanMultiFeed.Id = 243;
            this.barButtonItemRescanMultiFeed.LargeGlyph = global::SampleApplication.Properties.Resources.rescan_multi_feed_32x32;
            this.barButtonItemRescanMultiFeed.Name = "barButtonItemRescanMultiFeed";
            // 
            // barButtonItemInsert
            // 
            this.barButtonItemInsert.Caption = "Insert";
            this.barButtonItemInsert.Glyph = global::SampleApplication.Properties.Resources.insert_scan_multi_16x16;
            this.barButtonItemInsert.Id = 244;
            this.barButtonItemInsert.LargeGlyph = global::SampleApplication.Properties.Resources.insert_scan_multi_32x32;
            this.barButtonItemInsert.Name = "barButtonItemInsert";
            // 
            // barButtonItemRescanFlatbed
            // 
            this.barButtonItemRescanFlatbed.Caption = "Flatbed";
            this.barButtonItemRescanFlatbed.Glyph = global::SampleApplication.Properties.Resources.flatbed_16x16;
            this.barButtonItemRescanFlatbed.Id = 245;
            this.barButtonItemRescanFlatbed.LargeGlyph = global::SampleApplication.Properties.Resources.flatbed_32x32;
            this.barButtonItemRescanFlatbed.Name = "barButtonItemRescanFlatbed";
            // 
            // barButtonItemRescanFeeder
            // 
            this.barButtonItemRescanFeeder.Caption = "Feeder";
            this.barButtonItemRescanFeeder.Glyph = global::SampleApplication.Properties.Resources.adf_16x16;
            this.barButtonItemRescanFeeder.Id = 246;
            this.barButtonItemRescanFeeder.LargeGlyph = global::SampleApplication.Properties.Resources.adf_32x32;
            this.barButtonItemRescanFeeder.Name = "barButtonItemRescanFeeder";
            // 
            // barEditItemJob
            // 
            this.barEditItemJob.Caption = "Job";
            this.barEditItemJob.Edit = this.repositoryItemTextEdit3;
            this.barEditItemJob.Id = 247;
            this.barEditItemJob.Name = "barEditItemJob";
            this.barEditItemJob.Width = 150;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.repositoryItemTextEdit3.UseParentBackground = true;
            // 
            // barEditItemBatchPath
            // 
            this.barEditItemBatchPath.Caption = "Batch Path";
            this.barEditItemBatchPath.Edit = this.repositoryItemTextEdit4;
            this.barEditItemBatchPath.Id = 248;
            this.barEditItemBatchPath.Name = "barEditItemBatchPath";
            this.barEditItemBatchPath.Width = 150;
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            this.repositoryItemTextEdit4.UseParentBackground = true;
            // 
            // barEditItemNextBatchName
            // 
            this.barEditItemNextBatchName.Caption = "Next Batch Name";
            this.barEditItemNextBatchName.Edit = this.repositoryItemTextEdit5;
            this.barEditItemNextBatchName.Id = 249;
            this.barEditItemNextBatchName.Name = "barEditItemNextBatchName";
            this.barEditItemNextBatchName.Width = 150;
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            this.repositoryItemTextEdit5.UseParentBackground = true;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 250;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 251;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barStaticItem7
            // 
            this.barStaticItem7.Caption = "barStaticItem7";
            this.barStaticItem7.Id = 252;
            this.barStaticItem7.Name = "barStaticItem7";
            this.barStaticItem7.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 253;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barStaticItem8
            // 
            this.barStaticItem8.Caption = "barStaticItem8";
            this.barStaticItem8.Id = 254;
            this.barStaticItem8.Name = "barStaticItem8";
            this.barStaticItem8.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem9
            // 
            this.barStaticItem9.Caption = "barStaticItem9";
            this.barStaticItem9.Id = 255;
            this.barStaticItem9.Name = "barStaticItem9";
            this.barStaticItem9.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 256;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barStaticItem10
            // 
            this.barStaticItem10.Caption = "barStaticItem10";
            this.barStaticItem10.Id = 257;
            this.barStaticItem10.Name = "barStaticItem10";
            this.barStaticItem10.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem11
            // 
            this.barStaticItem11.Caption = "barStaticItem11";
            this.barStaticItem11.Id = 258;
            this.barStaticItem11.Name = "barStaticItem11";
            this.barStaticItem11.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItemCountDocument
            // 
            this.barStaticItemCountDocument.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItemCountDocument.Caption = "Documents: {0}";
            this.barStaticItemCountDocument.Id = 259;
            this.barStaticItemCountDocument.Name = "barStaticItemCountDocument";
            this.barStaticItemCountDocument.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItemCountBatch
            // 
            this.barStaticItemCountBatch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItemCountBatch.Caption = "Images in Batch: {0}";
            this.barStaticItemCountBatch.Id = 260;
            this.barStaticItemCountBatch.Name = "barStaticItemCountBatch";
            this.barStaticItemCountBatch.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItemZoom
            // 
            this.barButtonItemZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemZoom.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemZoom.Caption = "Zoom";
            this.barButtonItemZoom.DropDownEnabled = false;
            this.barButtonItemZoom.Glyph = global::SampleApplication.Properties.Resources.zoom_on_rectangle_16x16;
            this.barButtonItemZoom.Id = 261;
            this.barButtonItemZoom.Name = "barButtonItemZoom";
            this.barButtonItemZoom.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemZoom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemZoom_ItemClick);
            // 
            // barButtonItemPan
            // 
            this.barButtonItemPan.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemPan.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemPan.Caption = "Pan";
            this.barButtonItemPan.Glyph = global::SampleApplication.Properties.Resources.pan_hand_16x16;
            this.barButtonItemPan.Id = 262;
            this.barButtonItemPan.Name = "barButtonItemPan";
            this.barButtonItemPan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemPan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPan_ItemClick);
            // 
            // barButtonItemPageFit
            // 
            this.barButtonItemPageFit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemPageFit.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemPageFit.Caption = "Page Fit";
            this.barButtonItemPageFit.Glyph = global::SampleApplication.Properties.Resources.fit_page_16x16;
            this.barButtonItemPageFit.Id = 263;
            this.barButtonItemPageFit.Name = "barButtonItemPageFit";
            this.barButtonItemPageFit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemPageFit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPageFit_ItemClick);
            // 
            // barButtonItemHorizontalFit
            // 
            this.barButtonItemHorizontalFit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemHorizontalFit.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemHorizontalFit.Caption = "Horizontal Fit";
            this.barButtonItemHorizontalFit.Glyph = global::SampleApplication.Properties.Resources.fit_horizontal_16x16;
            this.barButtonItemHorizontalFit.Id = 264;
            this.barButtonItemHorizontalFit.Name = "barButtonItemHorizontalFit";
            this.barButtonItemHorizontalFit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemHorizontalFit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemHorizonalFit_ItemClick);
            // 
            // barButtonItemVerticalFit
            // 
            this.barButtonItemVerticalFit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemVerticalFit.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemVerticalFit.Caption = "Vertical Fit";
            this.barButtonItemVerticalFit.Glyph = global::SampleApplication.Properties.Resources.fit_vertical_16x16;
            this.barButtonItemVerticalFit.Id = 265;
            this.barButtonItemVerticalFit.Name = "barButtonItemVerticalFit";
            this.barButtonItemVerticalFit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemVerticalFit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemVerticalFit_ItemClick);
            // 
            // barButtonItem100View
            // 
            this.barButtonItem100View.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem100View.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItem100View.Caption = "100% View";
            this.barButtonItem100View.Glyph = global::SampleApplication.Properties.Resources._100_display_16x16;
            this.barButtonItem100View.Id = 266;
            this.barButtonItem100View.Name = "barButtonItem100View";
            this.barButtonItem100View.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItem100View.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem100View_ItemClick);
            // 
            // barButtonItemCompactThumbnailView
            // 
            this.barButtonItemCompactThumbnailView.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemCompactThumbnailView.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemCompactThumbnailView.Caption = "Compact Thumbnail View";
            this.barButtonItemCompactThumbnailView.Glyph = global::SampleApplication.Properties.Resources.compact_view_16x16;
            this.barButtonItemCompactThumbnailView.Id = 267;
            this.barButtonItemCompactThumbnailView.Name = "barButtonItemCompactThumbnailView";
            this.barButtonItemCompactThumbnailView.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemCompactThumbnailView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCompactThumbnailView_ItemClick);
            // 
            // barButtonItemThumbnailView
            // 
            this.barButtonItemThumbnailView.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemThumbnailView.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemThumbnailView.Caption = "Thumbnail View";
            this.barButtonItemThumbnailView.Glyph = global::SampleApplication.Properties.Resources.view_thumbnails_16x16;
            this.barButtonItemThumbnailView.Id = 268;
            this.barButtonItemThumbnailView.Name = "barButtonItemThumbnailView";
            this.barButtonItemThumbnailView.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemThumbnailView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemThumbnailView_ItemClick);
            // 
            // barButtonItemSingleView
            // 
            this.barButtonItemSingleView.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemSingleView.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItemSingleView.Caption = "Single View";
            this.barButtonItemSingleView.Glyph = global::SampleApplication.Properties.Resources.view_one_image_16x16;
            this.barButtonItemSingleView.Id = 269;
            this.barButtonItemSingleView.Name = "barButtonItemSingleView";
            this.barButtonItemSingleView.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemSingleView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSingleView_ItemClick);
            // 
            // barEditItemZoomTrackBar
            // 
            this.barEditItemZoomTrackBar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItemZoomTrackBar.Edit = this.repositoryItemZoomTrackBar1;
            this.barEditItemZoomTrackBar.EditValue = "50";
            this.barEditItemZoomTrackBar.Id = 270;
            this.barEditItemZoomTrackBar.Name = "barEditItemZoomTrackBar";
            this.barEditItemZoomTrackBar.Width = 150;
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar1.Maximum = 100;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.repositoryItemZoomTrackBar1.UseParentBackground = true;
            this.repositoryItemZoomTrackBar1.EditValueChanged += new System.EventHandler(this.repositoryItemZoomTrackBar1_EditValueChanged);
            // 
            // barStaticItemStatus
            // 
            this.barStaticItemStatus.Caption = "Ready";
            this.barStaticItemStatus.Id = 271;
            this.barStaticItemStatus.Name = "barStaticItemStatus";
            this.barStaticItemStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItemCurentSanner
            // 
            this.barStaticItemCurentSanner.Caption = "Current Scanner: {0}";
            this.barStaticItemCurentSanner.Id = 272;
            this.barStaticItemCurentSanner.Name = "barStaticItemCurentSanner";
            this.barStaticItemCurentSanner.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItemAdvanceScanSetting
            // 
            this.barButtonItemAdvanceScanSetting.Caption = "Scan Setting";
            this.barButtonItemAdvanceScanSetting.Glyph = global::SampleApplication.Properties.Resources.setup_16x16;
            this.barButtonItemAdvanceScanSetting.Id = 273;
            this.barButtonItemAdvanceScanSetting.Name = "barButtonItemAdvanceScanSetting";
            this.barButtonItemAdvanceScanSetting.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barEditItemScanProfile
            // 
            this.barEditItemScanProfile.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItemScanProfile.Caption = "Scan Profile";
            this.barEditItemScanProfile.Edit = this.repositoryItemComboBox2;
            this.barEditItemScanProfile.Id = 274;
            this.barEditItemScanProfile.Name = "barEditItemScanProfile";
            this.barEditItemScanProfile.Width = 200;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "Ctrl+1 Default",
            "Ctrl+2 Automatic"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.repositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemComboBox2.UseParentBackground = true;
            // 
            // barButtonItemNewScanProfile
            // 
            this.barButtonItemNewScanProfile.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemNewScanProfile.Caption = "New";
            this.barButtonItemNewScanProfile.Glyph = global::SampleApplication.Properties.Resources.new_scan_profile_16x16;
            this.barButtonItemNewScanProfile.Id = 275;
            this.barButtonItemNewScanProfile.Name = "barButtonItemNewScanProfile";
            this.barButtonItemNewScanProfile.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemSaveScanProfile
            // 
            this.barButtonItemSaveScanProfile.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemSaveScanProfile.Caption = "Save";
            this.barButtonItemSaveScanProfile.Glyph = global::SampleApplication.Properties.Resources.save_scan_profile_16x16;
            this.barButtonItemSaveScanProfile.Id = 276;
            this.barButtonItemSaveScanProfile.Name = "barButtonItemSaveScanProfile";
            this.barButtonItemSaveScanProfile.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemSaveScanProfileAs
            // 
            this.barButtonItemSaveScanProfileAs.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemSaveScanProfileAs.Caption = "Save As";
            this.barButtonItemSaveScanProfileAs.Glyph = global::SampleApplication.Properties.Resources.save_scan_profile_as_16x16;
            this.barButtonItemSaveScanProfileAs.Id = 277;
            this.barButtonItemSaveScanProfileAs.Name = "barButtonItemSaveScanProfileAs";
            this.barButtonItemSaveScanProfileAs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemRenameScanProfile
            // 
            this.barButtonItemRenameScanProfile.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemRenameScanProfile.Caption = "Rename";
            this.barButtonItemRenameScanProfile.Glyph = global::SampleApplication.Properties.Resources.rename_16x16;
            this.barButtonItemRenameScanProfile.Id = 278;
            this.barButtonItemRenameScanProfile.Name = "barButtonItemRenameScanProfile";
            this.barButtonItemRenameScanProfile.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemDeleteScanProfile
            // 
            this.barButtonItemDeleteScanProfile.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemDeleteScanProfile.Caption = "Delete";
            this.barButtonItemDeleteScanProfile.Glyph = global::SampleApplication.Properties.Resources.delete_object_16x16;
            this.barButtonItemDeleteScanProfile.Id = 279;
            this.barButtonItemDeleteScanProfile.Name = "barButtonItemDeleteScanProfile";
            this.barButtonItemDeleteScanProfile.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonItemIndexFristDocument
            // 
            this.barButtonItemIndexFristDocument.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemIndexFristDocument.Caption = "First Document";
            this.barButtonItemIndexFristDocument.Glyph = global::SampleApplication.Properties.Resources.first_16x16;
            this.barButtonItemIndexFristDocument.Id = 280;
            this.barButtonItemIndexFristDocument.Name = "barButtonItemIndexFristDocument";
            this.barButtonItemIndexFristDocument.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemIndexFristDocument.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItemPreviousDocument
            // 
            this.barButtonItemPreviousDocument.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemPreviousDocument.Caption = "Previous Document";
            this.barButtonItemPreviousDocument.Glyph = global::SampleApplication.Properties.Resources.previous_16x16;
            this.barButtonItemPreviousDocument.Id = 281;
            this.barButtonItemPreviousDocument.Name = "barButtonItemPreviousDocument";
            this.barButtonItemPreviousDocument.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemPreviousDocument.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItemNextDocument
            // 
            this.barButtonItemNextDocument.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemNextDocument.Caption = "Next";
            this.barButtonItemNextDocument.Glyph = global::SampleApplication.Properties.Resources.next_16x16;
            this.barButtonItemNextDocument.Id = 282;
            this.barButtonItemNextDocument.Name = "barButtonItemNextDocument";
            this.barButtonItemNextDocument.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemNextDocument.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItemLastDocument
            // 
            this.barButtonItemLastDocument.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemLastDocument.Caption = "Last";
            this.barButtonItemLastDocument.Glyph = global::SampleApplication.Properties.Resources.last_16x16;
            this.barButtonItemLastDocument.Id = 283;
            this.barButtonItemLastDocument.Name = "barButtonItemLastDocument";
            this.barButtonItemLastDocument.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemLastDocument.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItemNextIncomplete
            // 
            this.barButtonItemNextIncomplete.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemNextIncomplete.Caption = "Next";
            this.barButtonItemNextIncomplete.Glyph = global::SampleApplication.Properties.Resources.publish_16x16;
            this.barButtonItemNextIncomplete.Id = 284;
            this.barButtonItemNextIncomplete.Name = "barButtonItemNextIncomplete";
            this.barButtonItemNextIncomplete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barButtonItemNextIncomplete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barStaticItem12
            // 
            this.barStaticItem12.Caption = " ";
            this.barStaticItem12.Id = 285;
            this.barStaticItem12.Name = "barStaticItem12";
            this.barStaticItem12.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonHome
            // 
            this.ribbonHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribonPageGroupBatch,
            this.ribbonPageGroupScan,
            this.ribbonPageGroupDocument,
            this.ribbonPageGroup5,
            this.ribbonPageGroupZonalOCR,
            this.ribbonPageGroup7});
            this.ribbonHome.Name = "ribbonHome";
            this.ribbonHome.Text = "Home";
            // 
            // ribonPageGroupBatch
            // 
            this.ribonPageGroupBatch.ItemLinks.Add(this.barButtonItemNewBatch, true);
            this.ribonPageGroupBatch.Name = "ribonPageGroupBatch";
            this.ribonPageGroupBatch.ShowCaptionButton = false;
            this.ribonPageGroupBatch.Text = "Batch";
            // 
            // ribbonPageGroupScan
            // 
            this.ribbonPageGroupScan.ItemLinks.Add(this.barButtonItemScanOne);
            this.ribbonPageGroupScan.ItemLinks.Add(this.barButtonItemScanAll);
            this.ribbonPageGroupScan.ItemLinks.Add(this.barButtonItemStop);
            this.ribbonPageGroupScan.Name = "ribbonPageGroupScan";
            this.ribbonPageGroupScan.ShowCaptionButton = false;
            this.ribbonPageGroupScan.Text = "Scan";
            // 
            // ribbonPageGroupDocument
            // 
            this.ribbonPageGroupDocument.ItemLinks.Add(this.barButtonItemNewDocument);
            this.ribbonPageGroupDocument.ItemLinks.Add(this.barButtonItemSplitDocument);
            this.ribbonPageGroupDocument.ItemLinks.Add(this.barButtonItemMergePre);
            this.ribbonPageGroupDocument.ItemLinks.Add(this.barButtonItemMergeNext);
            this.ribbonPageGroupDocument.ItemLinks.Add(this.barButtonItemMergeSeleted);
            this.ribbonPageGroupDocument.Name = "ribbonPageGroupDocument";
            this.ribbonPageGroupDocument.ShowCaptionButton = false;
            this.ribbonPageGroupDocument.Text = "Document";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemIndexing);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Index";
            // 
            // ribbonPageGroupZonalOCR
            // 
            this.ribbonPageGroupZonalOCR.ItemLinks.Add(this.barButtonItemLanguage);
            this.ribbonPageGroupZonalOCR.ItemLinks.Add(this.barButtonItemDrawZone, true);
            this.ribbonPageGroupZonalOCR.ItemLinks.Add(this.barButtonItemRemoveZone);
            this.ribbonPageGroupZonalOCR.Name = "ribbonPageGroupZonalOCR";
            this.ribbonPageGroupZonalOCR.ShowCaptionButton = false;
            this.ribbonPageGroupZonalOCR.Text = "Zonal OCR";
            this.ribbonPageGroupZonalOCR.Visible = false;
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItemExport);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            this.ribbonPageGroup7.Text = "Export";
            // 
            // ribbonScanSettings
            // 
            this.ribbonScanSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupSetting,
            this.ribbonPageGroupScan_ScanSettings,
            this.ribbonPageGroupDetail,
            this.ribbonPageGroupFeeder,
            this.ribbonPageGroupSides,
            this.ribbonPageGroupPaperSize,
            this.ribbonPageGroupRotation,
            this.ribbonPageGroupAutoResolve,
            this.ribbonPageGroupColorDetection,
            this.ribbonPageGroupBackground,
            this.ribbonPageGroupAutomaticCorrections,
            this.ribbonPageGroupClarity,
            this.ribbonPageGroupBWFilters,
            this.ribbonPageGroupReset,
            this.ribbonPageGroupScanner});
            this.ribbonScanSettings.Name = "ribbonScanSettings";
            this.ribbonScanSettings.Text = "Scan Settings";
            // 
            // ribbonPageGroupSetting
            // 
            this.ribbonPageGroupSetting.ItemLinks.Add(this.barButtonItemScanner);
            this.ribbonPageGroupSetting.ItemLinks.Add(this.barButtonItemVRSGeneral);
            this.ribbonPageGroupSetting.ItemLinks.Add(this.barButtonItemVRSColor);
            this.ribbonPageGroupSetting.Name = "ribbonPageGroupSetting";
            this.ribbonPageGroupSetting.ShowCaptionButton = false;
            this.ribbonPageGroupSetting.Text = "Settings";
            // 
            // ribbonPageGroupScan_ScanSettings
            // 
            this.ribbonPageGroupScan_ScanSettings.ItemLinks.Add(this.barButtonItemScanOne);
            this.ribbonPageGroupScan_ScanSettings.ItemLinks.Add(this.barButtonItemScanAll);
            this.ribbonPageGroupScan_ScanSettings.ItemLinks.Add(this.barButtonItemStop);
            this.ribbonPageGroupScan_ScanSettings.ItemLinks.Add(this.barButtonItemBlackAndWhite, true);
            this.ribbonPageGroupScan_ScanSettings.ItemLinks.Add(this.barButtonItemGrayscale);
            this.ribbonPageGroupScan_ScanSettings.ItemLinks.Add(this.barButtonItemColor);
            this.ribbonPageGroupScan_ScanSettings.Name = "ribbonPageGroupScan_ScanSettings";
            this.ribbonPageGroupScan_ScanSettings.ShowCaptionButton = false;
            this.ribbonPageGroupScan_ScanSettings.Text = "Scan";
            // 
            // ribbonPageGroupDetail
            // 
            this.ribbonPageGroupDetail.ItemLinks.Add(this.barStaticItem2);
            this.ribbonPageGroupDetail.ItemLinks.Add(this.barEditItem2);
            this.ribbonPageGroupDetail.Name = "ribbonPageGroupDetail";
            this.ribbonPageGroupDetail.ShowCaptionButton = false;
            this.ribbonPageGroupDetail.Text = "Detail";
            // 
            // ribbonPageGroupFeeder
            // 
            this.ribbonPageGroupFeeder.ItemLinks.Add(this.barButtonItemFlatbed);
            this.ribbonPageGroupFeeder.ItemLinks.Add(this.barButtonItemFeeder);
            this.ribbonPageGroupFeeder.Name = "ribbonPageGroupFeeder";
            this.ribbonPageGroupFeeder.ShowCaptionButton = false;
            this.ribbonPageGroupFeeder.Text = "Feeder";
            // 
            // ribbonPageGroupSides
            // 
            this.ribbonPageGroupSides.ItemLinks.Add(this.barButtonItemOneSide);
            this.ribbonPageGroupSides.ItemLinks.Add(this.barButtonItemBothSides);
            this.ribbonPageGroupSides.Name = "ribbonPageGroupSides";
            this.ribbonPageGroupSides.ShowCaptionButton = false;
            this.ribbonPageGroupSides.Text = "Sides";
            // 
            // ribbonPageGroupPaperSize
            // 
            this.ribbonPageGroupPaperSize.ItemLinks.Add(this.barEditItemSize, false, "", "", true);
            this.ribbonPageGroupPaperSize.ItemLinks.Add(this.barButtonGroupLongSheet);
            this.ribbonPageGroupPaperSize.ItemLinks.Add(this.barButtonGroupOrientation);
            this.ribbonPageGroupPaperSize.ItemLinks.Add(this.barStaticItem1, false, "", "", true);
            this.ribbonPageGroupPaperSize.Name = "ribbonPageGroupPaperSize";
            this.ribbonPageGroupPaperSize.ShowCaptionButton = false;
            this.ribbonPageGroupPaperSize.Text = "Paper Size";
            // 
            // ribbonPageGroupRotation
            // 
            this.ribbonPageGroupRotation.ItemLinks.Add(this.barButtonItemFront);
            this.ribbonPageGroupRotation.ItemLinks.Add(this.barButtonItemBack);
            this.ribbonPageGroupRotation.Name = "ribbonPageGroupRotation";
            this.ribbonPageGroupRotation.ShowCaptionButton = false;
            this.ribbonPageGroupRotation.Text = "Rotation";
            // 
            // ribbonPageGroupAutoResolve
            // 
            this.ribbonPageGroupAutoResolve.ItemLinks.Add(this.barButtonItemAutoResolve);
            this.ribbonPageGroupAutoResolve.Name = "ribbonPageGroupAutoResolve";
            this.ribbonPageGroupAutoResolve.ShowCaptionButton = false;
            this.ribbonPageGroupAutoResolve.Text = "Auto Resolve";
            // 
            // ribbonPageGroupColorDetection
            // 
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barButtonItemDetectColor);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barButtonItemDetectSmallColorObjects);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barEditItemOverall, true);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barEditItemSensitivity);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barEditItemIgnoBackgroundColor);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barStaticItemOverall);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barStaticItemSensitivity);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barStaticItemBlank);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barEditItemOverallValue);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barEditItemSensitivityValue);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barStaticItemBlank);
            this.ribbonPageGroupColorDetection.Name = "ribbonPageGroupColorDetection";
            this.ribbonPageGroupColorDetection.ShowCaptionButton = false;
            this.ribbonPageGroupColorDetection.Text = "Color Detection";
            // 
            // ribbonPageGroupBackground
            // 
            this.ribbonPageGroupBackground.ItemLinks.Add(this.barButtonItemSmoothing);
            this.ribbonPageGroupBackground.ItemLinks.Add(this.barEditItemSmoothingTrackBar, false, "", "", true);
            this.ribbonPageGroupBackground.ItemLinks.Add(this.barStaticItemSmoothing);
            this.ribbonPageGroupBackground.ItemLinks.Add(this.barEditItemSmoothingValue, false, "", "", true);
            this.ribbonPageGroupBackground.ItemLinks.Add(this.barButtonItemSnapToWhite, true);
            this.ribbonPageGroupBackground.ItemLinks.Add(this.barButtonItemBackgroundColorToWhite);
            this.ribbonPageGroupBackground.Name = "ribbonPageGroupBackground";
            this.ribbonPageGroupBackground.ShowCaptionButton = false;
            this.ribbonPageGroupBackground.Text = "Background";
            // 
            // ribbonPageGroupAutomaticCorrections
            // 
            this.ribbonPageGroupAutomaticCorrections.ItemLinks.Add(this.barButtonItemDeskew);
            this.ribbonPageGroupAutomaticCorrections.ItemLinks.Add(this.barButtonItemAutoCrop);
            this.ribbonPageGroupAutomaticCorrections.ItemLinks.Add(this.barButtonItemEdgeCleanup);
            this.ribbonPageGroupAutomaticCorrections.ItemLinks.Add(this.barButtonItemHolePunchRemoval, true);
            this.ribbonPageGroupAutomaticCorrections.ItemLinks.Add(this.barButtonItemDeleteBlank);
            this.ribbonPageGroupAutomaticCorrections.ItemLinks.Add(this.barButtonItemAutoRotate, true);
            this.ribbonPageGroupAutomaticCorrections.Name = "ribbonPageGroupAutomaticCorrections";
            this.ribbonPageGroupAutomaticCorrections.ShowCaptionButton = false;
            this.ribbonPageGroupAutomaticCorrections.Text = "Automatic Corrections";
            // 
            // ribbonPageGroupClarity
            // 
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barEditItemBrightness);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barEditItemContrast);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barEditItemGamma);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barEditItemBrightnessValue);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barEditItemContrastValue);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barEditItemGammaValue);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barEditItemAutoBrightness, true);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barEditItemAdvancedClarity);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barEditItemClarityValue);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barStaticItemBlank);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barStaticItemBlank);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barStaticItemHight);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barButtonItemAdvancedClaritySetup);
            this.ribbonPageGroupClarity.Name = "ribbonPageGroupClarity";
            this.ribbonPageGroupClarity.ShowCaptionButton = false;
            this.ribbonPageGroupClarity.Text = "Clarity";
            // 
            // ribbonPageGroupBWFilters
            // 
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barEditItemThickness);
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barEditItemSpeckle);
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barStaticItemBlank);
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barStaticItemThickness);
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barStaticItemSpeckle);
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barStaticItemBlank);
            this.ribbonPageGroupBWFilters.Name = "ribbonPageGroupBWFilters";
            this.ribbonPageGroupBWFilters.ShowCaptionButton = false;
            this.ribbonPageGroupBWFilters.Text = "B && W Filters";
            // 
            // ribbonPageGroupReset
            // 
            this.ribbonPageGroupReset.ItemLinks.Add(this.barButtonItemResetScanSetting);
            this.ribbonPageGroupReset.Name = "ribbonPageGroupReset";
            this.ribbonPageGroupReset.ShowCaptionButton = false;
            this.ribbonPageGroupReset.Text = "Reset";
            // 
            // ribbonPageGroupScanner
            // 
            this.ribbonPageGroupScanner.ItemLinks.Add(this.barButtonItemSelectScanner);
            this.ribbonPageGroupScanner.Name = "ribbonPageGroupScanner";
            this.ribbonPageGroupScanner.ShowCaptionButton = false;
            this.ribbonPageGroupScanner.Text = "Scanner";
            // 
            // ribbonDocument
            // 
            this.ribbonDocument.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCurent,
            this.ribbonPageGroup1});
            this.ribbonDocument.Name = "ribbonDocument";
            this.ribbonDocument.Text = "Document";
            // 
            // ribbonPageGroupCurent
            // 
            this.ribbonPageGroupCurent.ItemLinks.Add(this.barEditItemDocument);
            this.ribbonPageGroupCurent.ItemLinks.Add(this.barEditItemImage);
            this.ribbonPageGroupCurent.ItemLinks.Add(this.barStaticItem4);
            this.ribbonPageGroupCurent.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroupCurent.ItemLinks.Add(this.barStaticItem5);
            this.ribbonPageGroupCurent.ItemLinks.Add(this.barStaticItem6);
            this.ribbonPageGroupCurent.Name = "ribbonPageGroupCurent";
            this.ribbonPageGroupCurent.ShowCaptionButton = false;
            this.ribbonPageGroupCurent.Text = "Current";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDeleteToEnd);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Corrections";
            // 
            // ribbonRescan
            // 
            this.ribbonRescan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonRescan.Name = "ribbonRescan";
            this.ribbonRescan.Text = "Rescan";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemRescan);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemRescanMultiFeed);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemInsert);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemStop);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Rescan";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemRescanFlatbed);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemRescanFeeder);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Rescan Settings";
            // 
            // ribbonVRSCorrections
            // 
            this.ribbonVRSCorrections.Name = "ribbonVRSCorrections";
            this.ribbonVRSCorrections.Text = "VRS Corrections";
            // 
            // ribbonJobSetup
            // 
            this.ribbonJobSetup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonJobSetup.Name = "ribbonJobSetup";
            this.ribbonJobSetup.Text = "Job Setup";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barEditItemJob);
            this.ribbonPageGroup4.ItemLinks.Add(this.barEditItemBatchPath);
            this.ribbonPageGroup4.ItemLinks.Add(this.barEditItemNextBatchName);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup4.ItemLinks.Add(this.barStaticItem7);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup4.ItemLinks.Add(this.barStaticItem8);
            this.ribbonPageGroup4.ItemLinks.Add(this.barStaticItem9);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup4.ItemLinks.Add(this.barStaticItem10);
            this.ribbonPageGroup4.ItemLinks.Add(this.barStaticItem11);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Destination";
            // 
            // ribbonBarCodeSetup
            // 
            this.ribbonBarCodeSetup.Name = "ribbonBarCodeSetup";
            this.ribbonBarCodeSetup.Text = "Bar Code Setup";
            // 
            // ribbonIndexSetup
            // 
            this.ribbonIndexSetup.Name = "ribbonIndexSetup";
            this.ribbonIndexSetup.Text = "Index Setup";
            // 
            // ribbonHelp
            // 
            this.ribbonHelp.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup15});
            this.ribbonHelp.Name = "ribbonHelp";
            this.ribbonHelp.Text = "Help";
            // 
            // ribbonPageGroup15
            // 
            this.ribbonPageGroup15.ItemLinks.Add(this.ribbonGalleryBarItemThemes);
            this.ribbonPageGroup15.Name = "ribbonPageGroup15";
            this.ribbonPageGroup15.ShowCaptionButton = false;
            this.ribbonPageGroup15.Text = "Themes";
            // 
            // ribbonStatusBar2
            // 
            this.ribbonStatusBar2.Dock = System.Windows.Forms.DockStyle.None;
            this.ribbonStatusBar2.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonStatusBar2.ItemLinks.Add(this.barButtonItemAllJob);
            this.ribbonStatusBar2.Location = new System.Drawing.Point(2, 141);
            this.ribbonStatusBar2.Name = "ribbonStatusBar2";
            this.ribbonStatusBar2.Ribbon = this.ribbon;
            this.ribbonStatusBar2.Size = new System.Drawing.Size(311, 23);
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItemCountDocument);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItemCountBatch, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemZoom, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemPan);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemDrawZone);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemPageFit, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemHorizontalFit);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemVerticalFit);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem100View);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemCompactThumbnailView, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemThumbnailView);
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemSingleView);
            this.ribbonStatusBar.ItemLinks.Add(this.barEditItemZoomTrackBar);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem12);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItemStatus, true);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 565);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1059, 23);
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItemCurentSanner);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemAdvanceScanSetting);
            this.ribbonStatusBar1.ItemLinks.Add(this.barEditItemScanProfile);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemNewScanProfile);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemSaveScanProfile);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemSaveScanProfileAs);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemRenameScanProfile);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemDeleteScanProfile);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemIndexFristDocument);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemPreviousDocument);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemNextDocument);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemLastDocument);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItemNextIncomplete);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 148);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbon;
            this.ribbonStatusBar1.ShowSizeGrip = false;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1059, 23);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.Images = this.imageList1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "CustomCheckAndDropDownButton.MyRibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("97d439b4-e7ca-49e7-bcc5-3ba323b00c13");
            this.dockPanel1.ImageIndex = 29;
            this.dockPanel1.Location = new System.Drawing.Point(0, 171);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.AllowDockBottom = false;
            this.dockPanel1.Options.AllowDockFill = false;
            this.dockPanel1.Options.AllowDockRight = false;
            this.dockPanel1.Options.AllowDockTop = false;
            this.dockPanel1.Options.AllowFloating = false;
            this.dockPanel1.Options.FloatOnDblClick = false;
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.Options.ShowMaximizeButton = false;
            this.dockPanel1.Size = new System.Drawing.Size(320, 394);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(314, 362);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.gridControl2);
            this.layoutControl1.Controls.Add(this.ribbonStatusBar2);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(314, 362);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(2, 196);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(311, 165);
            this.gridControl2.TabIndex = 10;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView2.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView2.OptionsSelection.InvertSelection = true;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowColumnHeaders = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Title";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "Value";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(311, 116);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIcon,
            this.gridColumnBatchName,
            this.gridColumnJobName,
            this.gridColumnDocuments,
            this.gridColumnPages,
            this.gridColumnStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Images = this.imageListBatchIcon;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.ShowGridMenu += new DevExpress.XtraGrid.Views.Grid.GridMenuEventHandler(this.gridView1_ShowGridMenu);
            // 
            // gridColumnIcon
            // 
            this.gridColumnIcon.Caption = " ";
            this.gridColumnIcon.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumnIcon.FieldName = "Icon";
            this.gridColumnIcon.Name = "gridColumnIcon";
            this.gridColumnIcon.OptionsColumn.AllowEdit = false;
            this.gridColumnIcon.OptionsColumn.AllowFocus = false;
            this.gridColumnIcon.OptionsColumn.ReadOnly = true;
            this.gridColumnIcon.Visible = true;
            this.gridColumnIcon.VisibleIndex = 0;
            this.gridColumnIcon.Width = 20;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageListBatchIcon;
            // 
            // imageListBatchIcon
            // 
            this.imageListBatchIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBatchIcon.ImageStream")));
            this.imageListBatchIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBatchIcon.Images.SetKeyName(0, "adf_32x32.png");
            this.imageListBatchIcon.Images.SetKeyName(1, "key_from_image_32x32.png");
            // 
            // gridColumnBatchName
            // 
            this.gridColumnBatchName.Caption = "Batch Name";
            this.gridColumnBatchName.FieldName = "BatchName";
            this.gridColumnBatchName.Name = "gridColumnBatchName";
            this.gridColumnBatchName.Visible = true;
            this.gridColumnBatchName.VisibleIndex = 1;
            this.gridColumnBatchName.Width = 79;
            // 
            // gridColumnJobName
            // 
            this.gridColumnJobName.Caption = "Job Name";
            this.gridColumnJobName.FieldName = "JobName";
            this.gridColumnJobName.Name = "gridColumnJobName";
            this.gridColumnJobName.OptionsColumn.AllowEdit = false;
            this.gridColumnJobName.OptionsColumn.AllowFocus = false;
            this.gridColumnJobName.OptionsColumn.ReadOnly = true;
            this.gridColumnJobName.Visible = true;
            this.gridColumnJobName.VisibleIndex = 2;
            this.gridColumnJobName.Width = 104;
            // 
            // gridColumnDocuments
            // 
            this.gridColumnDocuments.Caption = "Documents";
            this.gridColumnDocuments.FieldName = "Documents";
            this.gridColumnDocuments.Name = "gridColumnDocuments";
            this.gridColumnDocuments.OptionsColumn.AllowEdit = false;
            this.gridColumnDocuments.OptionsColumn.AllowFocus = false;
            this.gridColumnDocuments.OptionsColumn.ReadOnly = true;
            this.gridColumnDocuments.Visible = true;
            this.gridColumnDocuments.VisibleIndex = 3;
            this.gridColumnDocuments.Width = 36;
            // 
            // gridColumnPages
            // 
            this.gridColumnPages.Caption = "Pages";
            this.gridColumnPages.FieldName = "Pages";
            this.gridColumnPages.Name = "gridColumnPages";
            this.gridColumnPages.OptionsColumn.AllowEdit = false;
            this.gridColumnPages.OptionsColumn.AllowFocus = false;
            this.gridColumnPages.OptionsColumn.ReadOnly = true;
            this.gridColumnPages.Visible = true;
            this.gridColumnPages.VisibleIndex = 4;
            this.gridColumnPages.Width = 36;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.OptionsColumn.AllowEdit = false;
            this.gridColumnStatus.OptionsColumn.AllowFocus = false;
            this.gridColumnStatus.OptionsColumn.ReadOnly = true;
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.VisibleIndex = 5;
            this.gridColumnStatus.Width = 32;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton2.Image = global::SampleApplication.Properties.Resources.performance_16x16;
            this.simpleButton2.Location = new System.Drawing.Point(2, 171);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(311, 24);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Performance";
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton1.ImageIndex = 229;
            this.simpleButton1.ImageList = this.imageList1;
            this.simpleButton1.Location = new System.Drawing.Point(2, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(311, 24);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Batches";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.splitterItem1,
            this.layoutControlGroup3,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(314, 362);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(312, 25);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 169);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(312, 25);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(0, 163);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(312, 6);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = " ";
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 25);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.ShowInCustomizationForm = false;
            this.layoutControlGroup3.Size = new System.Drawing.Size(312, 138);
            this.layoutControlGroup3.Text = " ";
            this.layoutControlGroup3.TextLocation = DevExpress.Utils.Locations.Default;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(312, 117);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ribbonStatusBar2;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 117);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 21);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(101, 21);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem4.Size = new System.Drawing.Size(312, 21);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl2;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 194);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem5.Size = new System.Drawing.Size(312, 166);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 2);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(241, 112);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(241, 2);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1059, 588);
            this.Controls.Add(this.popupControlContainerLanguages);
            this.Controls.Add(this.popupControlContainerRightPanel);
            this.Controls.Add(this.popupControlContainerBottomMenu);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.ribbonStatusBar);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sample Application";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainerBottomMenu)).EndInit();
            this.popupControlContainerBottomMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainerRightPanel)).EndInit();
            this.popupControlContainerRightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcAppRecentJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainerLanguages)).EndInit();
            this.popupControlContainerLanguages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuFrontRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuBackRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAutoResolve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarBlankContentSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditBlankContentSensitivityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarClarityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBarSpeckle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyRibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribonPageGroupBatch;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonScanSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonDocument;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonRescan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonVRSCorrections;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonJobSetup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonBarCodeSetup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonIndexSetup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonHelp;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNewBatch;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupScan;
        private DevExpress.XtraBars.BarButtonItem barButtonItemScanOne;
        private DevExpress.XtraBars.BarButtonItem barButtonItemScanAll;
        private DevExpress.XtraBars.BarButtonItem barButtonItemStop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSetting;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupScan_ScanSettings;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private PopupControlContainer popupControlContainerBottomMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOption;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExit;
        private PopupControlContainer popupControlContainerRightPanel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupPaperSize;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem4;
        private BarButtonItem barButtonItem5;
        private BarButtonItem barButtonItem6;
        private BarEditItem barEditItemSize;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private BarButtonGroup barButtonGroupLongSheet;
        private BarButtonItem barButtonItemScanLong;
        private BarButtonGroup barButtonGroupOrientation;
        private BarButtonItem barButtonItemPortrait;
        private BarButtonItem barButtonItemLandscape;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIcon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBatchName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnJobName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDocuments;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPages;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private BarButtonItem barButtonItemNewDocument;
        private BarButtonItem barButtonItemSplitDocument;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDocument;
        private BarButtonItem barButtonItemMergePre;
        private BarButtonItem barButtonItemMergeNext;
        private BarButtonItem barButtonItemMergeSeleted;
        private BarButtonItem barButtonItemIndexing;
        private BarButtonItem barButtonItemLanguage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupZonalOCR;
        private BarButtonItem barButtonItemDrawZone;
        private BarButtonItem barButtonItemRemoveZone;
        private BarButtonItem barButtonItemExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private BarButtonItem barButtonItemScanner;
        private BarButtonItem barButtonItemVRSGeneral;
        private BarButtonItem barButtonItemVRSColor;
        private BarButtonItem barButtonItemBlackAndWhite;
        private BarButtonItem barButtonItemGrayscale;
        private BarButtonItem barButtonItemColor;
        private BarButtonItem barButtonItemFlatbed;
        private BarButtonItem barButtonItemFeeder;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupFeeder;
        private BarButtonItem barButtonItemOneSide;
        private BarButtonItem barButtonItemBothSides;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSides;
        private BarStaticItem barStaticItem1;
        private BarButtonItem barButtonItemFront;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupRotation;
        private BarButtonItem barButtonItemBack;
        private BarButtonItem barButtonItemAutoResolve;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAutoResolve;
        private BarButtonItem barButtonItemResetScanSetting;
        private BarButtonItem barButtonItemSelectScanner;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupReset;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupScanner;
        private BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDetail;
        private BarButtonItem barButtonItemDeskew;
        private BarButtonItem barButtonItemAutoCrop;
        private BarButtonItem barButtonItemEdgeCleanup;
        private BarButtonItem barButtonItemHolePunchRemoval;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAutomaticCorrections;
        private BarCheckAndDropDownButton barButtonItemDeleteBlank;
        private BarButtonItem barButtonItemAutoRotate;
        private BarEditItem barEditItemBrightness;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBarBrightness;
        private BarEditItem barEditItemContrast;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBarContrast;
        private BarEditItem barEditItemGamma;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBarGamma;
        private RibbonPageGroup ribbonPageGroupClarity;
        private BarEditItem barEditItemBrightnessValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditBrightness;
        private BarEditItem barEditItemContrastValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditContrast;
        private BarEditItem barEditItemGammaValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditGamma;
        private BarEditItem barEditItemAutoBrightness;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BarEditItem barEditItemAdvancedClarity;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private BarEditItem barEditItemClarityValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBarClarityValue;
        private BarStaticItem barStaticItemBlank;
        private BarStaticItem barStaticItemHight;
        private BarButtonItem barButtonItemAdvancedClaritySetup;
        private RibbonPageGroup ribbonPageGroupBWFilters;
        private BarEditItem barEditItemThickness;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBarThickness;
        private BarEditItem barEditItemSpeckle;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBarSpeckle;
        private BarStaticItem barStaticItemThickness;
        private RibbonGalleryBarItem ribbonGalleryBarItemThemes;
        private RibbonPageGroup ribbonPageGroup15;
        private PopupControlContainer popupControlContainerLanguages;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private BarButtonItem barButtonItemDetectColor;
        private RibbonPageGroup ribbonPageGroupColorDetection;
        private BarButtonItem barButtonItemDetectSmallColorObjects;
        private BarEditItem barEditItemOverall;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar7;
        private BarEditItem barEditItemSensitivity;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar8;
        private BarEditItem barEditItemIgnoBackgroundColor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private BarStaticItem barStaticItemOverall;
        private BarStaticItem barStaticItemSensitivity;
        private BarEditItem barEditItemOverallValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit4;
        private BarEditItem barEditItemSensitivityValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit5;
        private BarButtonItem barButtonItemSmoothing;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar9;
        private RibbonPageGroup ribbonPageGroupBackground;
        private BarStaticItem barStaticItemSmoothing;
        private BarEditItem barEditItemSmoothingValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit6;
        private BarButtonItem barButtonItemSnapToWhite;
        private BarButtonItem barButtonItemBackgroundColorToWhite;
        private BarButtonItem barButtonItemRefresh;
        private BarButtonItem barButtonItemAllJob;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl pcAppRecentJobs;
        private PopupMenu popupMenuFrontRotate;
        private BarCheckItem barCheckItemFront0;
        private BarCheckItem barCheckItemFront90Left;
        private BarCheckItem barCheckItemFront90Right;
        private BarCheckItem barCheckItemFront180;
        private BarCheckItem barCheckItemBack0;
        private BarCheckItem barCheckItemBack90Left;
        private BarCheckItem barCheckItemBack90Right;
        private BarCheckItem barCheckItemBack180;
        private PopupMenu popupMenuBackRotate;
        private PopupMenu popupMenuAutoResolve;
        private BarCheckItem barCheckItemOutOfPaper;
        private BarCheckItem barCheckItemPaperJam;
        private BarCheckItem barCheckItemCoverOpen;
        private BarCheckItem barCheckItemMultifeed;
        private BarStaticItem barStaticItemSpeckle;
        private BarCheckItem barCheckItemAnalyzeColor;
        private PopupMenu popupMenu1;
        private BarCheckItem barCheckItemIgnorePicture;
        private BarStaticItem barStaticItem3;
        private PopupMenu popupMenu2;
        private BarEditItem barEditItemTrackBarBlankContentSensitivityValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBarBlankContentSensitivity;
        private BarEditItem barEditItemBlankContentSensitivityValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditBlankContentSensitivityValue;
        private BarCheckItem barCheckItemIgnoreHole;
        private BarEditItem barEditItemSmoothingTrackBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private BarEditItem barEditItemDocument;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarEditItem barEditItemImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private BarStaticItem barStaticItem4;
        private BarButtonItem barButtonItem2;
        private BarStaticItem barStaticItem5;
        private BarStaticItem barStaticItem6;
        private RibbonPageGroup ribbonPageGroupCurent;
        private BarButtonItem barButtonItemDelete;
        private BarButtonItem barButtonItemDeleteToEnd;
        private BarButtonItem barButtonItemRescan;
        private BarButtonItem barButtonItemRescanMultiFeed;
        private BarButtonItem barButtonItemInsert;
        private BarButtonItem barButtonItemRescanFlatbed;
        private RibbonPageGroup ribbonPageGroup1;
        private RibbonPageGroup ribbonPageGroup2;
        private RibbonPageGroup ribbonPageGroup3;
        private BarButtonItem barButtonItemRescanFeeder;
        private BarEditItem barEditItemJob;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private BarEditItem barEditItemBatchPath;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private BarEditItem barEditItemNextBatchName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private RibbonPageGroup ribbonPageGroup4;
        private BarButtonItem barButtonItem7;
        private BarButtonItem barButtonItem8;
        private BarStaticItem barStaticItem7;
        private BarButtonItem barButtonItem9;
        private BarStaticItem barStaticItem8;
        private BarStaticItem barStaticItem9;
        private BarButtonItem barButtonItem10;
        private BarStaticItem barStaticItem10;
        private BarStaticItem barStaticItem11;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList imageListBatchIcon;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private BarStaticItem barStaticItemCountDocument;
        private BarStaticItem barStaticItemCountBatch;
        private BarButtonItem barButtonItemZoom;
        private BarButtonItem barButtonItemPan;
        private BarButtonItem barButtonItemPageFit;
        private BarButtonItem barButtonItemHorizontalFit;
        private BarButtonItem barButtonItemVerticalFit;
        private BarButtonItem barButtonItem100View;
        private BarButtonItem barButtonItemCompactThumbnailView;
        private BarButtonItem barButtonItemThumbnailView;
        private BarButtonItem barButtonItemSingleView;
        private BarEditItem barEditItemZoomTrackBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private BarStaticItem barStaticItemStatus;
        private RibbonStatusBar ribbonStatusBar1;
        private BarStaticItem barStaticItemCurentSanner;
        private BarButtonItem barButtonItemAdvanceScanSetting;
        private BarEditItem barEditItemScanProfile;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private BarButtonItem barButtonItemNewScanProfile;
        private BarButtonItem barButtonItemSaveScanProfile;
        private BarButtonItem barButtonItemSaveScanProfileAs;
        private BarButtonItem barButtonItemRenameScanProfile;
        private BarButtonItem barButtonItemDeleteScanProfile;
        private BarButtonItem barButtonItemIndexFristDocument;
        private BarButtonItem barButtonItemPreviousDocument;
        private BarButtonItem barButtonItemNextDocument;
        private BarButtonItem barButtonItemLastDocument;
        private BarButtonItem barButtonItemNextIncomplete;
        private BarStaticItem barStaticItem12;
    }
}