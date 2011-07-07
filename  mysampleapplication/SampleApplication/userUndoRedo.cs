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

        private void listBoxControlUndoRedo_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBoxControlUndoRedo.IndexFromPoint(e.Location);
            if (index < 0) return;
            for (int i = 0; i < listBoxControlUndoRedo.ItemCount; i++)
            {
                listBoxControlUndoRedo.SetSelected(i, i <= index);
            }
            labelStatus.Text = (index + 1).ToString();
        }

        private void listBoxControlUndoRedo_MouseLeave(object sender, EventArgs e)
        {
            listBoxControlUndoRedo.UnSelectAll();
            labelStatus.Text = "Cancel";
        }

        private void listBoxControlUndoRedo_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxControlUndoRedo.IndexFromPoint(e.Location);
            if (Selected != null)
                Selected(sender, new SelectedEventArgs {SelectedIndex = index + 1});
        }
    }

    public class SelectedEventArgs : EventArgs
    {
        public int SelectedIndex { get; set; }
    }
}