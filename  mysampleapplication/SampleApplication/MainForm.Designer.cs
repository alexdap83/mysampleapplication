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
            DevExpress.XtraBars.BarEditItem barEditItemSmoothingTrackBar;
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
            this.barButtonItemAutoRotate = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemBrightness = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemContrast = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemGamma = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar3 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemBrightnessValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barEditItemContrastValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barEditItemGammaValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barEditItemAutoBrightness = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barEditItemAdvancedClarity = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barEditItem11 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar4 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barStaticItemBlank = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem5 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar5 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar6 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItemThemes = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonItemDetectColor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDetectSmallColorObjects = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemOverall = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar7 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemSensitivity = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar8 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.barEditItemIgnoBackgroundColor = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem6 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItemOverallValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barEditItemSensitivityValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barButtonItemSmoothing = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem7 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItemSmoothingValue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barButtonItemSnapToWhite = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemBackgroundColorToWhite = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemAllJob = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribonPageGroupBatch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupScan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDocument = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.ribbonRescan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonVRSCorrections = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonJobSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonBarCodeSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonIndexSetup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonHelp = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup15 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonStatusBar2 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIcon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBatchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDocuments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.erPages = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barCheckItemOutOfPaper = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemPaperJam = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemCoverOpen = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItemMultifeed = new DevExpress.XtraBars.BarCheckItem();
            barEditItemSmoothingTrackBar = new DevExpress.XtraBars.BarEditItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // barEditItemSmoothingTrackBar
            // 
            barEditItemSmoothingTrackBar.Edit = this.repositoryItemTrackBar9;
            barEditItemSmoothingTrackBar.Glyph = global::SampleApplication.Properties.Resources.smoothing_low_16x16;
            barEditItemSmoothingTrackBar.Id = 207;
            barEditItemSmoothingTrackBar.Name = "barEditItemSmoothingTrackBar";
            barEditItemSmoothingTrackBar.Width = 150;
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
            this.barEditItem11,
            this.barStaticItemBlank,
            this.barStaticItem5,
            this.barButtonItem2,
            this.barEditItem3,
            this.barEditItem4,
            this.barStaticItem3,
            this.barButtonItem7,
            this.ribbonGalleryBarItemThemes,
            this.barButtonItemDetectColor,
            this.barButtonItemDetectSmallColorObjects,
            this.barEditItemOverall,
            this.barEditItemSensitivity,
            this.barEditItemIgnoBackgroundColor,
            this.barStaticItem4,
            this.barStaticItem6,
            this.barEditItemOverallValue,
            this.barEditItemSensitivityValue,
            this.barButtonItemSmoothing,
            barEditItemSmoothingTrackBar,
            this.barStaticItem7,
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
            this.barCheckItemMultifeed});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 226;
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
            this.repositoryItemTrackBar1,
            this.repositoryItemTrackBar2,
            this.repositoryItemTrackBar3,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemTrackBar4,
            this.repositoryItemTrackBar5,
            this.repositoryItemTrackBar6,
            this.repositoryItemTrackBar7,
            this.repositoryItemTrackBar8,
            this.repositoryItemCheckEdit4,
            this.repositoryItemSpinEdit4,
            this.repositoryItemSpinEdit5,
            this.repositoryItemTrackBar9,
            this.repositoryItemSpinEdit6});
            this.ribbon.SelectedPage = this.ribbonScanSettings;
            this.ribbon.Size = new System.Drawing.Size(1063, 148);
            this.ribbon.StatusBar = this.ribbonStatusBar2;
            this.ribbon.Toolbar.ItemLinks.Add(this.barButtonItemScanOne);
            this.ribbon.TransparentEditors = true;
            this.ribbon.SelectedPageChanged += new System.EventHandler(this.ribbon_SelectedPageChanged);
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
            this.barButtonItemIndexing.Caption = "Indexing";
            this.barButtonItemIndexing.Glyph = global::SampleApplication.Properties.Resources.key_from_image_16x16;
            this.barButtonItemIndexing.Id = 143;
            this.barButtonItemIndexing.LargeGlyph = global::SampleApplication.Properties.Resources.key_from_image_32x32;
            this.barButtonItemIndexing.Name = "barButtonItemIndexing";
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
            this.barButtonItemDrawZone.Caption = "Draw Zone";
            this.barButtonItemDrawZone.Glyph = global::SampleApplication.Properties.Resources.rubber_band_ocr_16x16;
            this.barButtonItemDrawZone.Id = 145;
            this.barButtonItemDrawZone.LargeGlyph = global::SampleApplication.Properties.Resources.rubber_band_ocr_32x32;
            this.barButtonItemDrawZone.Name = "barButtonItemDrawZone";
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
            this.barButtonItemAutoResolve.DropDownControl = this.popupMenu1;
            this.barButtonItemAutoResolve.Glyph = global::SampleApplication.Properties.Resources.import_scanner_profiles_16x16;
            this.barButtonItemAutoResolve.Id = 165;
            this.barButtonItemAutoResolve.LargeGlyph = global::SampleApplication.Properties.Resources.import_scanner_profiles_32x32;
            this.barButtonItemAutoResolve.Name = "barButtonItemAutoResolve";
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
            this.barButtonItemDeleteBlank.DropDownControl = this.appMenu;
            this.barButtonItemDeleteBlank.Glyph = global::SampleApplication.Properties.Resources.delete_batch_16x16;
            this.barButtonItemDeleteBlank.Id = 174;
            this.barButtonItemDeleteBlank.LargeGlyph = global::SampleApplication.Properties.Resources.delete_blank_sides_32x32;
            this.barButtonItemDeleteBlank.Name = "barButtonItemDeleteBlank";
            this.barButtonItemDeleteBlank.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
                        | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
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
            this.barEditItemBrightness.Edit = this.repositoryItemTrackBar1;
            this.barEditItemBrightness.Glyph = global::SampleApplication.Properties.Resources.brightness_16x16;
            this.barEditItemBrightness.Id = 176;
            this.barEditItemBrightness.Name = "barEditItemBrightness";
            this.barEditItemBrightness.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barEditItemBrightness.Width = 100;
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar1.Maximum = 100;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            this.repositoryItemTrackBar1.TickFrequency = 10;
            this.repositoryItemTrackBar1.UseParentBackground = true;
            this.repositoryItemTrackBar1.EditValueChanged += new System.EventHandler(this.repositoryItemTrackBar1_EditValueChanged);
            // 
            // barEditItemContrast
            // 
            this.barEditItemContrast.Edit = this.repositoryItemTrackBar2;
            this.barEditItemContrast.Glyph = global::SampleApplication.Properties.Resources.contrast_16x16;
            this.barEditItemContrast.Id = 177;
            this.barEditItemContrast.Name = "barEditItemContrast";
            this.barEditItemContrast.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.barEditItemContrast.Width = 100;
            // 
            // repositoryItemTrackBar2
            // 
            this.repositoryItemTrackBar2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar2.Maximum = 100;
            this.repositoryItemTrackBar2.Name = "repositoryItemTrackBar2";
            this.repositoryItemTrackBar2.TickFrequency = 10;
            this.repositoryItemTrackBar2.UseParentBackground = true;
            // 
            // barEditItemGamma
            // 
            this.barEditItemGamma.Edit = this.repositoryItemTrackBar3;
            this.barEditItemGamma.Glyph = global::SampleApplication.Properties.Resources.gamma_16x16;
            this.barEditItemGamma.Id = 178;
            this.barEditItemGamma.Name = "barEditItemGamma";
            this.barEditItemGamma.Width = 100;
            // 
            // repositoryItemTrackBar3
            // 
            this.repositoryItemTrackBar3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar3.Maximum = 100;
            this.repositoryItemTrackBar3.Minimum = -100;
            this.repositoryItemTrackBar3.Name = "repositoryItemTrackBar3";
            this.repositoryItemTrackBar3.TickFrequency = 20;
            this.repositoryItemTrackBar3.UseParentBackground = true;
            // 
            // barEditItemBrightnessValue
            // 
            this.barEditItemBrightnessValue.Edit = this.repositoryItemSpinEdit1;
            this.barEditItemBrightnessValue.Id = 179;
            this.barEditItemBrightnessValue.Name = "barEditItemBrightnessValue";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.UseParentBackground = true;
            // 
            // barEditItemContrastValue
            // 
            this.barEditItemContrastValue.Edit = this.repositoryItemSpinEdit2;
            this.barEditItemContrastValue.Id = 180;
            this.barEditItemContrastValue.Name = "barEditItemContrastValue";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            this.repositoryItemSpinEdit2.UseParentBackground = true;
            // 
            // barEditItemGammaValue
            // 
            this.barEditItemGammaValue.Edit = this.repositoryItemSpinEdit3;
            this.barEditItemGammaValue.Id = 181;
            this.barEditItemGammaValue.Name = "barEditItemGammaValue";
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            this.repositoryItemSpinEdit3.UseParentBackground = true;
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
            this.repositoryItemCheckEdit1.UseParentBackground = true;
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
            this.repositoryItemCheckEdit2.UseParentBackground = true;
            // 
            // barEditItem11
            // 
            this.barEditItem11.Caption = "Low";
            this.barEditItem11.Edit = this.repositoryItemTrackBar4;
            this.barEditItem11.Id = 184;
            this.barEditItem11.Name = "barEditItem11";
            this.barEditItem11.Width = 90;
            // 
            // repositoryItemTrackBar4
            // 
            this.repositoryItemTrackBar4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar4.LargeChange = 1;
            this.repositoryItemTrackBar4.Maximum = 4;
            this.repositoryItemTrackBar4.Name = "repositoryItemTrackBar4";
            this.repositoryItemTrackBar4.UseParentBackground = true;
            // 
            // barStaticItemBlank
            // 
            this.barStaticItemBlank.Id = 185;
            this.barStaticItemBlank.Name = "barStaticItemBlank";
            this.barStaticItemBlank.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem5
            // 
            this.barStaticItem5.Caption = "High";
            this.barStaticItem5.Id = 187;
            this.barStaticItem5.Name = "barStaticItem5";
            this.barStaticItem5.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.ActAsDropDown = true;
            this.barButtonItem2.Caption = "Advanced Clarity Setup";
            this.barButtonItem2.Glyph = global::SampleApplication.Properties.Resources.setup_16x16;
            this.barButtonItem2.Id = 189;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = " ";
            this.barEditItem3.Edit = this.repositoryItemTrackBar5;
            this.barEditItem3.Glyph = global::SampleApplication.Properties.Resources.thin_16x16;
            this.barEditItem3.Id = 191;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.Width = 100;
            // 
            // repositoryItemTrackBar5
            // 
            this.repositoryItemTrackBar5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar5.Name = "repositoryItemTrackBar5";
            this.repositoryItemTrackBar5.UseParentBackground = true;
            // 
            // barEditItem4
            // 
            this.barEditItem4.Edit = this.repositoryItemTrackBar6;
            this.barEditItem4.Glyph = global::SampleApplication.Properties.Resources.blank_sensitivity4_16x16;
            this.barEditItem4.Id = 192;
            this.barEditItem4.Name = "barEditItem4";
            this.barEditItem4.Width = 100;
            // 
            // repositoryItemTrackBar6
            // 
            this.repositoryItemTrackBar6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar6.Name = "repositoryItemTrackBar6";
            this.repositoryItemTrackBar6.UseParentBackground = true;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Glyph = global::SampleApplication.Properties.Resources.thick_16x16;
            this.barStaticItem3.Id = 194;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Glyph = global::SampleApplication.Properties.Resources.blank_sensitivity1_16x16;
            this.barButtonItem7.Id = 195;
            this.barButtonItem7.Name = "barButtonItem7";
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
            // barStaticItem4
            // 
            this.barStaticItem4.Glyph = global::SampleApplication.Properties.Resources.color_lots_16x16;
            this.barStaticItem4.Id = 202;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem6
            // 
            this.barStaticItem6.Glyph = global::SampleApplication.Properties.Resources.color_small_16x16;
            this.barStaticItem6.Id = 203;
            this.barStaticItem6.Name = "barStaticItem6";
            this.barStaticItem6.TextAlignment = System.Drawing.StringAlignment.Near;
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
            this.barButtonItemSmoothing.Caption = "Smoothing";
            this.barButtonItemSmoothing.Glyph = global::SampleApplication.Properties.Resources.smoothing_16x16;
            this.barButtonItemSmoothing.Id = 206;
            this.barButtonItemSmoothing.LargeGlyph = global::SampleApplication.Properties.Resources.smoothing_32x32;
            this.barButtonItemSmoothing.Name = "barButtonItemSmoothing";
            // 
            // barStaticItem7
            // 
            this.barStaticItem7.Glyph = global::SampleApplication.Properties.Resources.smoothing_high_16x16;
            this.barStaticItem7.Id = 208;
            this.barStaticItem7.Name = "barStaticItem7";
            this.barStaticItem7.TextAlignment = System.Drawing.StringAlignment.Near;
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
            // ribbonHome
            // 
            this.ribbonHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribonPageGroupBatch,
            this.ribbonPageGroupScan,
            this.ribbonPageGroupDocument,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
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
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItemLanguage);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItemDrawZone, true);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItemRemoveZone);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Zonal OCR";
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
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barStaticItem4);
            this.ribbonPageGroupColorDetection.ItemLinks.Add(this.barStaticItem6);
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
            this.ribbonPageGroupBackground.ItemLinks.Add(barEditItemSmoothingTrackBar, false, "", "", true);
            this.ribbonPageGroupBackground.ItemLinks.Add(this.barStaticItem7);
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
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barEditItem11);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barStaticItemBlank);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barStaticItemBlank);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barStaticItem5);
            this.ribbonPageGroupClarity.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroupClarity.Name = "ribbonPageGroupClarity";
            this.ribbonPageGroupClarity.ShowCaptionButton = false;
            this.ribbonPageGroupClarity.Text = "Clarity";
            // 
            // ribbonPageGroupBWFilters
            // 
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barEditItem3);
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barEditItem4);
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barStaticItemBlank);
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barStaticItem3);
            this.ribbonPageGroupBWFilters.ItemLinks.Add(this.barButtonItem7);
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
            this.ribbonDocument.Name = "ribbonDocument";
            this.ribbonDocument.Text = "Document";
            // 
            // ribbonRescan
            // 
            this.ribbonRescan.Name = "ribbonRescan";
            this.ribbonRescan.Text = "Rescan";
            // 
            // ribbonVRSCorrections
            // 
            this.ribbonVRSCorrections.Name = "ribbonVRSCorrections";
            this.ribbonVRSCorrections.Text = "VRS Corrections";
            // 
            // ribbonJobSetup
            // 
            this.ribbonJobSetup.Name = "ribbonJobSetup";
            this.ribbonJobSetup.Text = "Job Setup";
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItemScanOne);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 565);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1063, 23);
            // 
            // ribbonStatusBar2
            // 
            this.ribbonStatusBar2.Dock = System.Windows.Forms.DockStyle.None;
            this.ribbonStatusBar2.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonStatusBar2.ItemLinks.Add(this.barButtonItemAllJob);
            this.ribbonStatusBar2.Location = new System.Drawing.Point(2, 204);
            this.ribbonStatusBar2.Name = "ribbonStatusBar2";
            this.ribbonStatusBar2.Ribbon = this.ribbon;
            this.ribbonStatusBar2.Size = new System.Drawing.Size(311, 23);
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
            this.dockPanel1.Location = new System.Drawing.Point(0, 148);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.AllowDockBottom = false;
            this.dockPanel1.Options.AllowDockFill = false;
            this.dockPanel1.Options.AllowDockRight = false;
            this.dockPanel1.Options.AllowDockTop = false;
            this.dockPanel1.Options.AllowFloating = false;
            this.dockPanel1.Options.FloatOnDblClick = false;
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.Options.ShowMaximizeButton = false;
            this.dockPanel1.Size = new System.Drawing.Size(320, 417);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(314, 385);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.ribbonStatusBar2);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.propertyGridControl1);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(314, 385);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(311, 179);
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
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumnIcon
            // 
            this.gridColumnIcon.Caption = " ";
            this.gridColumnIcon.FieldName = "Icon";
            this.gridColumnIcon.Name = "gridColumnIcon";
            this.gridColumnIcon.Visible = true;
            this.gridColumnIcon.VisibleIndex = 0;
            this.gridColumnIcon.Width = 20;
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
            this.gridColumnJobName.Visible = true;
            this.gridColumnJobName.VisibleIndex = 2;
            this.gridColumnJobName.Width = 104;
            // 
            // gridColumnDocuments
            // 
            this.gridColumnDocuments.Caption = "Documents";
            this.gridColumnDocuments.FieldName = "Documents";
            this.gridColumnDocuments.Name = "gridColumnDocuments";
            this.gridColumnDocuments.Visible = true;
            this.gridColumnDocuments.VisibleIndex = 3;
            this.gridColumnDocuments.Width = 36;
            // 
            // gridColumnPages
            // 
            this.gridColumnPages.Caption = "Pages";
            this.gridColumnPages.FieldName = "Pages";
            this.gridColumnPages.Name = "gridColumnPages";
            this.gridColumnPages.Visible = true;
            this.gridColumnPages.VisibleIndex = 4;
            this.gridColumnPages.Width = 36;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "Status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.VisibleIndex = 5;
            this.gridColumnStatus.Width = 32;
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Location = new System.Drawing.Point(7, 272);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.OptionsBehavior.Editable = false;
            this.propertyGridControl1.OptionsBehavior.UseDefaultEditorsCollection = false;
            this.propertyGridControl1.OptionsView.ShowButtons = false;
            this.propertyGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.erPages,
            this.editorRow2,
            this.editorRow3,
            this.editorRow4,
            this.editorRow5});
            this.propertyGridControl1.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowOnlyInEditor;
            this.propertyGridControl1.Size = new System.Drawing.Size(301, 107);
            this.propertyGridControl1.TabIndex = 8;
            // 
            // erPages
            // 
            this.erPages.Name = "erPages";
            this.erPages.Properties.Caption = "Pages";
            // 
            // editorRow2
            // 
            this.editorRow2.Height = 16;
            this.editorRow2.Name = "editorRow2";
            // 
            // editorRow3
            // 
            this.editorRow3.Height = 16;
            this.editorRow3.Name = "editorRow3";
            // 
            // editorRow4
            // 
            this.editorRow4.Name = "editorRow4";
            // 
            // editorRow5
            // 
            this.editorRow5.Name = "editorRow5";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(7, 239);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(301, 22);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "simpleButton2";
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
            this.layoutControlItem5,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(314, 385);
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
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 232);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(312, 33);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(0, 226);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(312, 6);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.propertyGridControl1;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 265);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(312, 118);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
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
            this.layoutControlGroup3.Size = new System.Drawing.Size(312, 201);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(312, 180);
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
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 180);
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
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barCheckItemOutOfPaper);
            this.popupMenu1.ItemLinks.Add(this.barCheckItemPaperJam);
            this.popupMenu1.ItemLinks.Add(this.barCheckItemCoverOpen);
            this.popupMenu1.ItemLinks.Add(this.barCheckItemMultifeed);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // barCheckItemOutOfPaper
            // 
            this.barCheckItemOutOfPaper.Caption = "Out Of Paper";
            this.barCheckItemOutOfPaper.Id = 222;
            this.barCheckItemOutOfPaper.Name = "barCheckItemOutOfPaper";
            // 
            // barCheckItemPaperJam
            // 
            this.barCheckItemPaperJam.Caption = "Paper jam";
            this.barCheckItemPaperJam.Id = 223;
            this.barCheckItemPaperJam.Name = "barCheckItemPaperJam";
            // 
            // barCheckItemCoverOpen
            // 
            this.barCheckItemCoverOpen.Caption = "Cover Open";
            this.barCheckItemCoverOpen.Id = 224;
            this.barCheckItemCoverOpen.Name = "barCheckItemCoverOpen";
            // 
            // barCheckItemMultifeed
            // 
            this.barCheckItemMultifeed.Caption = "Multifeed";
            this.barCheckItemMultifeed.Id = 225;
            this.barCheckItemMultifeed.Name = "barCheckItemMultifeed";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1063, 588);
            this.Controls.Add(this.popupControlContainerLanguages);
            this.Controls.Add(this.popupControlContainerRightPanel);
            this.Controls.Add(this.popupControlContainerBottomMenu);
            this.Controls.Add(this.dockPanel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
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
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow erPages;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private BarEditItem barEditItemContrast;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar2;
        private BarEditItem barEditItemGamma;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar3;
        private RibbonPageGroup ribbonPageGroupClarity;
        private BarEditItem barEditItemBrightnessValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private BarEditItem barEditItemContrastValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private BarEditItem barEditItemGammaValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private BarEditItem barEditItemAutoBrightness;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private BarEditItem barEditItemAdvancedClarity;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private BarEditItem barEditItem11;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar4;
        private BarStaticItem barStaticItemBlank;
        private BarStaticItem barStaticItem5;
        private BarButtonItem barButtonItem2;
        private RibbonPageGroup ribbonPageGroupBWFilters;
        private BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar5;
        private BarEditItem barEditItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar6;
        private BarStaticItem barStaticItem3;
        private BarButtonItem barButtonItem7;
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
        private BarStaticItem barStaticItem4;
        private BarStaticItem barStaticItem6;
        private BarEditItem barEditItemOverallValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit4;
        private BarEditItem barEditItemSensitivityValue;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit5;
        private BarButtonItem barButtonItemSmoothing;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar9;
        private RibbonPageGroup ribbonPageGroupBackground;
        private BarStaticItem barStaticItem7;
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
        private PopupMenu popupMenu1;
        private BarCheckItem barCheckItemOutOfPaper;
        private BarCheckItem barCheckItemPaperJam;
        private BarCheckItem barCheckItemCoverOpen;
        private BarCheckItem barCheckItemMultifeed;
    }
}