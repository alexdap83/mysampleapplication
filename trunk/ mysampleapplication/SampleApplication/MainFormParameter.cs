using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace SampleApplication
{
    public partial class MainForm
    {
        private readonly List<RibbonPageGroup> ScannerGroups = new List<RibbonPageGroup>();
        private readonly List<RibbonPageGroup> VRSColorGroups = new List<RibbonPageGroup>();
        private readonly List<RibbonPageGroup> VRSGeneralGroups = new List<RibbonPageGroup>();

        private void SetupUI()
        {
            ScannerGroups.Add(ribbonPageGroupDetail);
            ScannerGroups.Add(ribbonPageGroupFeeder);
            ScannerGroups.Add(ribbonPageGroupSides);
            ScannerGroups.Add(ribbonPageGroupPaperSize);
            ScannerGroups.Add(ribbonPageGroupRotation);
            ScannerGroups.Add(ribbonPageGroupAutoResolve);
            ScannerGroups.Add(ribbonPageGroupScanner);

            VRSGeneralGroups.Add(ribbonPageGroupAutomaticCorrections);
            VRSGeneralGroups.Add(ribbonPageGroupClarity);
            VRSGeneralGroups.Add(ribbonPageGroupBWFilters);


            VRSColorGroups.Add(ribbonPageGroupColorDetection);
            VRSColorGroups.Add(ribbonPageGroupBackground);

            DefaultQuickAccess.Add(this.barButtonItemCut);
            DefaultQuickAccess.Add(this.barButtonItemCopy);
            DefaultQuickAccess.Add(this.barButtonItemPaste);
            DefaultQuickAccess.Add(this.barButtonItemUndo);
            DefaultQuickAccess.Add(this.barButtonItemRedo);

            listBatch = new List<Batch>
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

            _listPerformances = new List<Performance>
                                    {
                                        new Performance {Title = "Document", Value = "123", IsAdvance = false},
                                        new Performance {Title = "Image", Value = "24", IsAdvance = false},
                                        new Performance {Title = "VRS Servers", Value = "2", IsAdvance = true},
                                        new Performance {Title = "VRS Servers CPU time (s)", Value = "50", IsAdvance = true},
                                    };
        
        }

        private List<BarItem> DefaultQuickAccess= new List<BarItem>();
        private List<Batch> listBatch;
        private List<Performance> _listPerformances;
    }
}