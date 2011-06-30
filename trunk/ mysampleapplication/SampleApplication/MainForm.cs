using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace SampleApplication
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            ribbon.ForceInitialize(); // Fix error: skin gallery not show until click on dropdown
            SkinHelper.CreateGallery(ribbonGalleryBarItemThemes);
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            if(ribbon.SelectedPage.Name == "ribbonScanSettings")
            {
                barButtonItemScanOne.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
                barButtonItemScanAll.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
                barButtonItemStop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            }
            else
            {
                barButtonItemScanOne.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Default;
                barButtonItemScanAll.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Default;
                barButtonItemStop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Default;
            }
        }
    }
}