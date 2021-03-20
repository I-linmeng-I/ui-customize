using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui自定义工具
{
    class Images
    {
        //lua图片信息合集
        public List<LuaImageInfo> luaImageInfos = new List<LuaImageInfo>();
        //用来存储图片控件
        public List<PictureBox> LuaImages = new List<PictureBox>();

        private PickBox pickBox = new PickBox();
        private ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        private PictureBox selectedimage = new PictureBox();

        /// <summary>
        /// 绘制某个界面图片控件
        /// </summary>
        /// <param name="要绘制的面板"></param>
        public void DrawLuaInformation(Control panel)
        {
            panel.Click += ClickPanel;
            //右键菜单内容
            {
                ToolStripMenuItem abc = new ToolStripMenuItem();
                abc.DropDownItems.Add("测试");
                //右键选项文字
                contextMenuStrip.Items.Add(abc);

                //选项函数
                contextMenuStrip.Opening += this.OpenningRightClickMenu;
                abc.DropDownItems[0].Click += this.RightClickMenuClick;
            }
            //获得lua信息
            //getinfo(获得了lua的信息）
            for(int i = 0; i < 100; i++)
            {
                //添加进图片信息list
                LuaImageInfo info = new LuaImageInfo();
                info.ImageName = "控件名";
                info.Image = Image.FromFile(@"1.png");
                info.ImageLocation_X = 0;
                info.ImageLocation_Y = 0;
                info.ImagePath = "1.png";
                info.ImageSize_X = 100;
                info.ImageSize_Y = 100;
                info.parent = panel;
                luaImageInfos.Add(info);

                //生成picturebox
                PictureBox chache = info.InitializePictureBox();
                chache.ContextMenuStrip = contextMenuStrip;

                //添加事件函数和右键菜单
                chache.Click += this.ImageClick;


                //添加图片控件进list
                LuaImages.Add(chache);

                //生成
                info.parent.Controls.Add(LuaImages[i]);
            }
            
        }
        

        private void ImageClick(object sender, EventArgs e)
        {
            if(pickBox.m_control != null)
            {
                pickBox.Remove();
            }
            pickBox.WireControl((sender as PictureBox));
        }

        private void OpenningRightClickMenu(object sender, EventArgs e)
        {
            selectedimage = (PictureBox)(sender as ContextMenuStrip).SourceControl;
        }

        private void ClickPanel(object sender, EventArgs e)
        {
            if (pickBox.m_control != null)
            {
                pickBox.Remove();
            }
        }

        private void RightClickMenuClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择一个图片";
            dialog.Filter = "图片文件(*.png,*.jpg,*.bmp,*.jpeg)|*.png;*.jpg;*.bmp;*.jpeg";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file1 = dialog.FileName;
                //PictureBox change = (PictureBox)(sender as ContextMenuStrip).SourceControl;
                selectedimage.Image = Image.FromFile(file1);
                //image = Image.FromFile(file1);
                //creatimage();
            }
        }
    }
}
