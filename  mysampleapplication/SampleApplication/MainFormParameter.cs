using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;

namespace SampleApplication
{
    public partial class MainForm
    {
        private List<RibbonPageGroup> ScannerGroups = new List<RibbonPageGroup>();
        private List<RibbonPageGroup> VRSGeneralGroups = new List<RibbonPageGroup>();
        private List<RibbonPageGroup> VRSColorGroups = new List<RibbonPageGroup>();
        
        private void SetupGroup()
        {
            
            ScannerGroups.Add(this.ribbonPageGroupDetail);
            ScannerGroups.Add(this.ribbonPageGroupFeeder);
            ScannerGroups.Add(this.ribbonPageGroupSides);
            ScannerGroups.Add(this.ribbonPageGroupPaperSize);
            ScannerGroups.Add(this.ribbonPageGroupRotation);
            ScannerGroups.Add(this.ribbonPageGroupAutoResolve);
            ScannerGroups.Add(this.ribbonPageGroupScanner);

            VRSGeneralGroups.Add(this.ribbonPageGroupAutomaticCorrections);
            VRSGeneralGroups.Add(this.ribbonPageGroupClarity);
            VRSGeneralGroups.Add(this.ribbonPageGroupBWFilters);


            VRSColorGroups.Add(this.ribbonPageGroupColorDetection);
            VRSColorGroups.Add(this.ribbonPageGroupBackground);
        }

    }
}
