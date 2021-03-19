using ItpClientProtype;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui自定义工具.Properties;

namespace ui自定义工具
{
    public partial class addimage : Form
    {
        public addimage()
        {
            InitializeComponent();
        }
        private Bitmap bmp = new Bitmap(1280, 800);
        private Color backcolor = Color.FromArgb(255, 255, 255);
        private Image image = null;
        public Image BackGroundImage = null;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择一个图片";
            dialog.Filter = "图片文件(*.png,*.jpg,*.bmp,*.jpeg)|*.png;*.jpg;*.bmp;*.jpeg";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file1 = dialog.FileName;
                pictureBox2.Image = Image.FromFile(file1);
                image = Image.FromFile(file1);
                creatimage();
                //image = Image.FromFile(file1);
                //creatimage();
            }
        }

        private void addimage_Load(object sender, EventArgs e)
        {

            Graphics g = Graphics.FromImage(bmp);
            g.Clear(backcolor);
            g.Save();
            pictureBox1.Image = bmp;
            pictureBox2.Image = bmp;
            DragResizeControl.RegisterControl(this.pictureBox2);
            listBox1.SelectedItem = "平铺";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                backcolor = dialog.Color;
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(backcolor);
                g.Save();
                pictureBox1.Image = bmp;
            }
        }
        private void creatimage()
        {
            if (listBox1.SelectedItem == "平铺")
            {
                float scale = float.Parse(image.Width.ToString()) / float.Parse(image.Height.ToString());
                if (scale < 1.6)
                {
                    pictureBox2.Location = new Point((640 - (image.Width * 800 / image.Height) / 2)/2, 0);
                    pictureBox2.Size = new Size((image.Width * 800 / image.Height)/2, 400);
                }
                if (scale >= 1.6)
                {
                    pictureBox2.Location = new Point(0, (400 - (image.Height * 1280 / image.Width) / 2)/2);
                    pictureBox2.Size = new Size(640, (image.Height * 1280 / image.Width)/2);
                }
                GC.Collect();
                pictureBox1.Image = bmp;
            }
            if (listBox1.SelectedItem == "拉伸")
            {
                pictureBox2.Location=new Point(0,0);
                pictureBox2.Size = new Size(640, 400);
            }
            if (listBox1.SelectedItem == "填充")
            {
                float scale = float.Parse(image.Width.ToString()) / float.Parse(image.Height.ToString());
                if (scale > 1.6)
                {
                    pictureBox2.Location = new Point((640 - (image.Width * 800 / image.Height) / 2) / 2, 0);
                    pictureBox2.Size = new Size((image.Width * 800 / image.Height) / 2, 400);
                }
                if (scale <= 1.6)
                {
                    pictureBox2.Location = new Point(0, (400 - (image.Height * 1280 / image.Width) / 2) / 2);
                    pictureBox2.Size = new Size(640, (image.Height * 1280 / image.Width) / 2);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (image != null)
            {
                creatimage();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(image != null)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(backcolor);
                g.DrawImage(image, pictureBox2.Location.X*2, pictureBox2.Location.Y*2, pictureBox2.Size.Width*2, pictureBox2.Size.Height*2);
                GC.Collect();
                FileInfo[] wenjianming = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory + @"\wallpaper").GetFiles();
                int filenumber = 0;
                for (int i = 0; i < wenjianming.Length; i++)
                {
                    if (wenjianming[i].Extension == ".bmp")
                    {
                        filenumber = filenumber + 1;
                    }
                }
                filenumber = filenumber + 1;
                bmp.Save(System.AppDomain.CurrentDomain.BaseDirectory + @"\wallpaper\" + filenumber+".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"\wallpaper\linmeng.txt",filenumber.ToString());
                MessageBox.Show("u1s1,应该可以了，记得点一下刷新");
                g.Clear(backcolor);
                GC.Collect();
            }
        }

    }
}
