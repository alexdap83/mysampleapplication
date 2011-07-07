using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SampleApplication
{
    public sealed partial class frmSelectScanner : XtraForm
    {
        public frmSelectScanner()
        {
            InitializeComponent();
        }

        private void frmSelectScanner_Load(object sender, EventArgs e)
        {
            listBoxControlScanner.SetSelected(0,true);
        }

        private void listBoxControlScanner_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}