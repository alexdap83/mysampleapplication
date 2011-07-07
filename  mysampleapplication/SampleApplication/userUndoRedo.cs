using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SampleApplication
{
    public partial class UserUndoRedo : XtraUserControl
    {
        #region Delegates

        public delegate void OnSelectedClickHandler(object sender, SelectedEventArgs e);

        #endregion

        public UserUndoRedo()
        {
            InitializeComponent();
        }

        public event OnSelectedClickHandler Selected;

        private void listBoxControl1_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBoxControl1.IndexFromPoint(e.Location);
            if (index < 0) return;
            for (int i = 0; i < listBoxControl1.ItemCount; i++)
            {
                listBoxControl1.SetSelected(i, i <= index);
            }
            labelControl1.Text = (index + 1).ToString();
        }

        private void listBoxControl1_MouseLeave(object sender, EventArgs e)
        {
            listBoxControl1.UnSelectAll();
            labelControl1.Text = "Cancel";
        }

        private void listBoxControl1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxControl1.IndexFromPoint(e.Location);
            if (Selected != null)
                Selected(sender, new SelectedEventArgs {SelectedIndex = index + 1});
        }
    }

    public class SelectedEventArgs : EventArgs
    {
        public int SelectedIndex { get; set; }
    }
}