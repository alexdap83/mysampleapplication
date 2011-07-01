using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;

namespace SampleApplication
{
    public partial class MainForm
    {
        private readonly List<RibbonPageGroup> ScannerGroups = new List<RibbonPageGroup>();
        private readonly List<RibbonPageGroup> VRSColorGroups = new List<RibbonPageGroup>();
        private readonly List<RibbonPageGroup> VRSGeneralGroups = new List<RibbonPageGroup>();

        private void SetupGroup()
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
        }
    }
}