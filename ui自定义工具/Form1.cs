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
        FunctionClass fuctions = new FunctionClass();
        Images luaimages = new Images();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            luaimages.InitClass();
            fuctions.GetLuaInfo();
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
    
}
