using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui自定义工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            List<LuaImage> AllLuaImage = new List<LuaImage>();
            for(int i =0;i<100;i++)
            {
                AllLuaImage.Add(new LuaImage());
                AllLuaImage[i].InitializeUI(this, panel1);
            }

            //pickBox.WireControl(button1);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
        }

        private void ImageLocation_X_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class serchlua
    {

        public Point GetLocation(string imagelocation)
        {
            return (new Point(123,123));
        }

        public Size GetSize(string imagelocation)
        {
            return (new Size(124, 124));
        }
    }
    public class LuaImage
    {
        public string ImageName;
        public string ImagePath;
        public int ImageLocation_X;
        public int ImageLocation_Y;
        public int ImageSize_X;
        public int ImageSize_Y;
        public Image RealImage = Image.FromFile(@"1.png");
        private Form1 form1;

        PictureBox pictureBox = new PictureBox();
        PickBox pickBox = new PickBox();
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

        public void InitializeUI(Form form, Panel panel)
        {
            form1 = (Form1)form;
            pictureBox.Image = RealImage;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Parent = panel;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(100, 100);
            clickmenuinitialize();
            pickBox.WireControl(pictureBox);
            panel.Controls.Add(pictureBox);
        }

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

    }
}
