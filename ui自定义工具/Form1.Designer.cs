namespace ui自定义工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.wnd = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出为ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageEditPannel = new System.Windows.Forms.Panel();
            this.ImageSize_Y = new System.Windows.Forms.TextBox();
            this.ImageSize_X = new System.Windows.Forms.TextBox();
            this.ImageLocation_Y = new System.Windows.Forms.TextBox();
            this.ImageLocation_X = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ImageEditPannel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wnd
            // 
            this.wnd.BackColor = System.Drawing.Color.Black;
            this.wnd.Location = new System.Drawing.Point(0, 100);
            this.wnd.Name = "wnd";
            this.wnd.Size = new System.Drawing.Size(1280, 800);
            this.wnd.TabIndex = 0;
            this.wnd.Click += new System.EventHandler(this.panel1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1600, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.导入ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.导出为ToolStripMenuItem,
            this.导出为ToolStripMenuItem1});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.保存ToolStripMenuItem.Text = "关闭";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.导入ToolStripMenuItem.Text = "保存";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.导出ToolStripMenuItem.Text = "导入";
            // 
            // 导出为ToolStripMenuItem
            // 
            this.导出为ToolStripMenuItem.Name = "导出为ToolStripMenuItem";
            this.导出为ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.导出为ToolStripMenuItem.Text = "导出";
            // 
            // 导出为ToolStripMenuItem1
            // 
            this.导出为ToolStripMenuItem1.Name = "导出为ToolStripMenuItem1";
            this.导出为ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.导出为ToolStripMenuItem1.Text = "导出为";
            // 
            // ImageEditPannel
            // 
            this.ImageEditPannel.BackColor = System.Drawing.Color.White;
            this.ImageEditPannel.Controls.Add(this.ImageSize_Y);
            this.ImageEditPannel.Controls.Add(this.ImageSize_X);
            this.ImageEditPannel.Controls.Add(this.ImageLocation_Y);
            this.ImageEditPannel.Controls.Add(this.ImageLocation_X);
            this.ImageEditPannel.Location = new System.Drawing.Point(1279, 100);
            this.ImageEditPannel.Name = "ImageEditPannel";
            this.ImageEditPannel.Size = new System.Drawing.Size(218, 57);
            this.ImageEditPannel.TabIndex = 2;
            // 
            // ImageSize_Y
            // 
            this.ImageSize_Y.Location = new System.Drawing.Point(113, 30);
            this.ImageSize_Y.Name = "ImageSize_Y";
            this.ImageSize_Y.Size = new System.Drawing.Size(100, 21);
            this.ImageSize_Y.TabIndex = 3;
            this.ImageSize_Y.Text = "Size_Y";
            // 
            // ImageSize_X
            // 
            this.ImageSize_X.Location = new System.Drawing.Point(7, 30);
            this.ImageSize_X.Name = "ImageSize_X";
            this.ImageSize_X.Size = new System.Drawing.Size(100, 21);
            this.ImageSize_X.TabIndex = 2;
            this.ImageSize_X.Text = "Size_X";
            // 
            // ImageLocation_Y
            // 
            this.ImageLocation_Y.Location = new System.Drawing.Point(113, 3);
            this.ImageLocation_Y.Name = "ImageLocation_Y";
            this.ImageLocation_Y.Size = new System.Drawing.Size(100, 21);
            this.ImageLocation_Y.TabIndex = 1;
            this.ImageLocation_Y.Text = "Y";
            // 
            // ImageLocation_X
            // 
            this.ImageLocation_X.Location = new System.Drawing.Point(7, 3);
            this.ImageLocation_X.Name = "ImageLocation_X";
            this.ImageLocation_X.Size = new System.Drawing.Size(100, 21);
            this.ImageLocation_X.TabIndex = 0;
            this.ImageLocation_X.Text = "X";
            this.ImageLocation_X.TextChanged += new System.EventHandler(this.ImageLocation_X_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem2.Text = "123";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem3.Text = "456";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.ImageEditPannel);
            this.Controls.Add(this.wnd);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "界面编辑器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ImageEditPannel.ResumeLayout(false);
            this.ImageEditPannel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel wnd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出为ToolStripMenuItem1;
        private System.Windows.Forms.Panel ImageEditPannel;
        private System.Windows.Forms.TextBox ImageSize_Y;
        private System.Windows.Forms.TextBox ImageSize_X;
        private System.Windows.Forms.TextBox ImageLocation_Y;
        private System.Windows.Forms.TextBox ImageLocation_X;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

