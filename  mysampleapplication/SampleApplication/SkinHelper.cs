using System.Drawing;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace SampleApplication
{
    public class SkinHelper
    {
        private static RibbonGalleryBarItem _ribbonGalleryBarItemThemes;
        public static void CreateGallery(RibbonGalleryBarItem ribbonGalleryBarItemThemes)
        {
            if (_ribbonGalleryBarItemThemes == null) _ribbonGalleryBarItemThemes = ribbonGalleryBarItemThemes;
            var imageButton = new SimpleButton();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName);
                var gItem = new GalleryItem();
                int groupIndex = 0;
                ribbonGalleryBarItemThemes.Gallery.Groups[groupIndex].Items.Add(gItem);
                gItem.Caption = cnt.SkinName;

                gItem.Image = GetSkinImage(imageButton, 17, 17, 2);
                gItem.HoverImage = GetSkinImage(imageButton, 41, 41, 5);
                gItem.Caption = cnt.SkinName;
                gItem.Hint = cnt.SkinName;
            }
            ribbonGalleryBarItemThemes.Gallery.InitDropDownGallery += Gallery_InitDropDownGallery;

            ribbonGalleryBarItemThemes.Gallery.ItemClick += Gallery_ItemClick;
        }

        private static void Gallery_InitDropDownGallery(object sender, InplaceGalleryEventArgs e)
        {
            e.PopupGallery.CreateFrom(_ribbonGalleryBarItemThemes.Gallery);
            e.PopupGallery.AllowFilter = false;
            e.PopupGallery.ShowItemText = true;
            e.PopupGallery.ShowGroupCaption = true;
            e.PopupGallery.AllowHoverImages = false;
            foreach (GalleryItemGroup galleryGroup in e.PopupGallery.Groups)
                foreach (GalleryItem item in galleryGroup.Items)
                    item.Image = item.HoverImage;
            e.PopupGallery.ColumnCount = 2;
            e.PopupGallery.ImageSize = new Size(41, 41);
        }

        private static void Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption);
        }

        private static Bitmap GetSkinImage(SimpleButton button, int width, int height, int indent)
        {
            var image = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(image))
            {
                var info = new StyleObjectInfoArgs(new GraphicsCache(g));
                info.Bounds = new Rectangle(0, 0, width, height);
                button.LookAndFeel.Painter.GroupPanel.DrawObject(info);
                button.LookAndFeel.Painter.Border.DrawObject(info);
                info.Bounds = new Rectangle(indent, indent, width - indent*2, height - indent*2);
                button.LookAndFeel.Painter.Button.DrawObject(info);
            }
            return image;
        }
    }
}