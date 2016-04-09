namespace Contacts
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通讯录管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询通讯录信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入通讯录信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通讯录统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.通讯录管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 通讯录管理ToolStripMenuItem
            // 
            this.通讯录管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询通讯录信息ToolStripMenuItem,
            this.录入通讯录信息ToolStripMenuItem,
            this.通讯录统计ToolStripMenuItem});
            this.通讯录管理ToolStripMenuItem.Name = "通讯录管理ToolStripMenuItem";
            this.通讯录管理ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.通讯录管理ToolStripMenuItem.Text = "通讯录管理";
            // 
            // 查询通讯录信息ToolStripMenuItem
            // 
            this.查询通讯录信息ToolStripMenuItem.Name = "查询通讯录信息ToolStripMenuItem";
            this.查询通讯录信息ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.查询通讯录信息ToolStripMenuItem.Text = "查看通讯录信息";
            this.查询通讯录信息ToolStripMenuItem.Click += new System.EventHandler(this.查询通讯录信息ToolStripMenuItem_Click);
            // 
            // 录入通讯录信息ToolStripMenuItem
            // 
            this.录入通讯录信息ToolStripMenuItem.Name = "录入通讯录信息ToolStripMenuItem";
            this.录入通讯录信息ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.录入通讯录信息ToolStripMenuItem.Text = "录入通讯录信息";
            // 
            // 通讯录统计ToolStripMenuItem
            // 
            this.通讯录统计ToolStripMenuItem.Name = "通讯录统计ToolStripMenuItem";
            this.通讯录统计ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.通讯录统计ToolStripMenuItem.Text = "通讯录统计";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 416);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "通讯录信息管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通讯录管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询通讯录信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录入通讯录信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通讯录统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

