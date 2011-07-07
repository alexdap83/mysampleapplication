using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomCheckAndDropDownButton;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace SampleApplication
{
    public partial class MainForm
    {
        void SetChecked(BarButtonItem item, bool isChecked)
        {
            item.Down = isChecked;
        }
        void SetChecked(BarCheckAndDropDownButton item, bool isChecked)
        {
            item.Down = isChecked;
        }

        bool IsChecked(BarItem item)
        {
            if(item is BarButtonItem)
                return ((BarButtonItem)item).Down;
            if (item is BarCheckItem)
                return ((BarCheckItem) item).Checked;
            return false;
        }
        bool IsChecked(BarCheckAndDropDownButton item)
        {
                return item.Down;

        } 
        bool IsChecked(BarButtonItem item)
        {
                return item.Down;
        }
        //bool IsChecked(object item)
        //{
        //    if(item is BarButtonItem)
        //        return item.Down;
        //}

        void SetEnable(BarItem item, bool isEnable)
        {
            item.Enabled = isEnable;
        }
        bool IsEnable(BarButtonItem item)
        {
            return item.Down;

        }

        private void SetChecked(BarCheckItem item, bool isChecked)
        {
            item.Checked = isChecked;
        }

        private void SetChecked(BarEditItem item, bool isChecked)
        {
            if (item.Edit is RepositoryItemCheckEdit)
            {
                item.EditValue = isChecked;
            }
        }

        void SetVisible(RibbonPageGroup group, bool isVisible)
        {
            group.Visible = isVisible;
        }

        private void SetVisible(BarItem item, bool isVisible)
        {
            item.Visibility = isVisible ? BarItemVisibility.Always : BarItemVisibility.Never;
        }
        bool IsVisible(RibbonPageGroup group)
        {
            return group.Visible;
        }

        void SetSelectedPage(int pageIndex)
        {
            ribbon.SelectedPage = ribbon.Pages[pageIndex];
        }

        private BarItem GetItemFromName(string name)
        {
            return ribbon.Items.Cast<BarItem>().FirstOrDefault(item => item.Name == name);
            //foreach (BarItem item in ribbon.Items)
            //{
            //    if (item.Name == name)
            //        return item;
            //}
            //return null;
        }
        private List<string> GetQuickAccessItemName()
        {
            return (from BarButtonItemLink item in ribbon.Toolbar.ItemLinks
                    where !DefaultQuickAccess.Contains(item.Item)
                    select item.Item.Name).ToList();
        }
        private void AddQuickAccessItem()
        {
            if (AppSetting.CurrentSetting.QuickAccessItem == null) return;
            foreach (string s in AppSetting.CurrentSetting.QuickAccessItem)
            {
                ribbon.Toolbar.ItemLinks.Add(GetItemFromName(s));
            }
        }

    }
}
