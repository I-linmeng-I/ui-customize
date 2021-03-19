using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui自定义工具
{
    class 登陆界面
    {
        PictureBox 背景图片 = new PictureBox();
        
        PictureBox logo = new PictureBox();
        
        public void DrawUi()
        {
            serchlua serchlua = new serchlua(); 

            背景图片.ImageLocation = @"\data\uinew\login\lsbg.bmp";
            背景图片.SizeMode = PictureBoxSizeMode.CenterImage;
            背景图片.Location = serchlua.GetLocation(背景图片.ImageLocation);
            背景图片.Size = serchlua.GetSize(背景图片.ImageLocation);
           
            
            logo.ImageLocation = @"\data\uinew\login\lsbg.bmp";
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.Location = serchlua.GetLocation(logo.ImageLocation);
            logo.Size = serchlua.GetSize(logo.ImageLocation);
            logo.Name = "logo";
            
        }
    }
}
