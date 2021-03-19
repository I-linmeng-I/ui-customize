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
        public ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LuaImage luaImage = new LuaImage();
            luaImage.InitializeUI(this,panel1);
            //pickBox.WireControl(button1);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
        }

        public void ImageClick(object sender, EventArgs e)
        {
            ImageEditPannel.Visible = true;
        }

        private void EditImage_Click(object sender, EventArgs e)
        {
            Form f2 = new addimage();
            f2.Show();
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
        private Form1 form1;

        PictureBox pictureBox = new PictureBox();
        PickBox pickBox = new PickBox();

        public void InitializeUI(Form form,Panel panel)
        {
            form1 = (Form1)form;
            pictureBox.ImageLocation = @"1.png";
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Parent = panel;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(100, 100);
            pictureBox.Click += new EventHandler(form1.ImageClick);
            pickBox.WireControl(pictureBox);
            panel.Controls.Add(pictureBox);
        }
    }
}
