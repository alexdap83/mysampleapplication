using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace SampleApplication
{
    public partial class MainForm
    {
        #region MostRecentJobs
        MRUArrayList arMRUList = null;
       
        //private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    SaveMostRecentJobs(arMRUList);
        //}

        void InitMostRecentJobs(MRUArrayList arList)
        {
            AddToMostRecentJobs("The First Jobs", arList);
                return;
         
        }

        void SaveMostRecentJobs(MRUArrayList arList)
        {
            try
            {
                //System.IO.StreamWriter sw = System.IO.File.CreateText(Application.StartupPath + "\\" + mrfFileName);
                //for (int i = arList.Count - 1; i >= 0; i--) sw.WriteLine(string.Format("{0},{1}", arList[i].ToString(), arList.GetLabelChecked(arList[i].ToString())));
                //sw.Close();
            }
            catch { }
        }

        void AddToMostRecentJobs(string name, MRUArrayList arList)
        {
            arList.InsertElement(name);
        }
        void OnLabelClicked(object sender, EventArgs e)
        {
            appMenu.HidePopup();
            this.Refresh();
        }
        class MRUArrayList : ArrayList
        {
            PanelControl container;
            int maxRecentJobs = 9;
            Image imgChecked, imgUncheked;
            public event EventHandler LabelClicked;
            public MRUArrayList(PanelControl cont, Image iChecked, Image iUnchecked)
                : base()
            {
                this.imgChecked = iChecked;
                this.imgUncheked = iUnchecked;
                this.container = cont;
            }
            public void InsertElement(object value)
            {
                string[] names = value.ToString().Split(',');
                string name = names[0];
                bool checkedLabel = false;
                if (names.Length > 1) checkedLabel = names[1].ToLower().Equals("true");
                foreach (AppMenuFileLabel ml in container.Controls)
                {
                    if (ml.Tag.Equals(name))
                    {
                        checkedLabel = ml.Checked;
                        base.Remove(name);
                        ml.LabelClick -= new EventHandler(OnLabelClick);
                        ml.Dispose();
                        break;
                    }
                }
                bool access = true;
                if (base.Count >= maxRecentJobs)
                    access = RemoveLastElement();
                if (access)
                {
                    base.Insert(0, name);
                    AppMenuFileLabel ml = new AppMenuFileLabel();
                    container.Controls.Add(ml);
                    ml.Tag = name;
                    ml.Text = GetFileName(name);
                    ml.Checked = checkedLabel;
                    ml.AutoHeight = true;
                    ml.Dock = DockStyle.Top;
                    ml.Image = imgUncheked;
                    ml.SelectedImage = imgChecked;
                    ml.LabelClick += new EventHandler(OnLabelClick);
                    SetElementsRange();
                }
            }
            void OnLabelClick(object sender, EventArgs e)
            {
                if (LabelClicked != null)
                    LabelClicked(((AppMenuFileLabel)sender).Tag.ToString(), e);
            }
            public bool RemoveLastElement()
            {
                for (int i = 0; i < container.Controls.Count; i++)
                {
                    AppMenuFileLabel ml = container.Controls[i] as AppMenuFileLabel;
                    if (!ml.Checked)
                    {
                        base.Remove(ml.Tag);
                        ml.LabelClick -= new EventHandler(OnLabelClick);
                        ml.Dispose();
                        return true;
                    }
                }
                return false;
            }
            string GetFileName(object obj)
            {
                FileInfo fi = new FileInfo(obj.ToString());
                return fi.Name;
            }
            void SetElementsRange()
            {
                int i = 0;
                foreach (AppMenuFileLabel ml in container.Controls)
                {
                    ml.Caption = string.Format("&{0}", container.Controls.Count - i);
                    i++;
                }
            }
            public bool GetLabelChecked(string name)
            {
                foreach (AppMenuFileLabel ml in container.Controls)
                {
                    if (ml.Tag.Equals(name)) return ml.Checked;
                }
                return false;
            }
        }
        #endregion
    }
}
