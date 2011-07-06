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

            DefaultQuickAccess.Add(this.barButtonItemScanOne);
        }

        private List<BarItem> DefaultQuickAccess= new List<BarItem>();
    }
}