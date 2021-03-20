using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui自定义工具
{
    public class LuaImageInfo
    {
        //lua图片信息类
        public string ImageName;
        public string ImagePath;
        public int ImageLocation_X;
        public int ImageLocation_Y;
        public int ImageSize_X;
        public int ImageSize_Y;
        public Image Image;
        public Control parent;

        PictureBox pictureBox = new PictureBox();

        public PictureBox InitializePictureBox()
        {
            pictureBox.Name = ImageName;
            pictureBox.Image = Image;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(ImageLocation_X, ImageLocation_Y);
            pictureBox.Size = new Size(ImageSize_X, ImageSize_Y);
            return pictureBox;
        }
        /*
        private void clickmenuinitialize()
        {
            contextMenuStrip.Items.Add("更换图片");
            contextMenuStrip.Items.Add("测试");

            contextMenuStrip.Items[0].ToolTipText = "只支持变换图片，修改图片请用专业的修改工具如ps等";

            contextMenuStrip.Items[0].Click += this.EditPicture;
            pictureBox.ContextMenuStrip = contextMenuStrip;
        }

        private void EditPicture(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择一个图片";
            dialog.Filter = "图片文件(*.png,*.jpg,*.bmp,*.jpeg)|*.png;*.jpg;*.bmp;*.jpeg";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file1 = dialog.FileName;
                pictureBox.Image = Image.FromFile(file1);
                //image = Image.FromFile(file1);
                //creatimage();
            }
        }
        */
    }
}
