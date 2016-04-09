using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contacts
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 查询通讯录信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContact frmContact = new FrmContact();
            frmContact.MdiParent = this;
            frmContact.Show();
        }
    }
}
