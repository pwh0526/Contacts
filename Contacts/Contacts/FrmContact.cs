using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Contacts
{
    public partial class FrmContact : Form
    {
        private DataSet ds;
        private SqlDataAdapter Adapter;
        StringBuilder condition;

        public FrmContact()
        {
            InitializeComponent();
        }

        private void FrmContact_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void  FillData()
        { 
            DBHelper dbhelper = new DBHelper();
            string sql = "SELECT [ContactId],[ContactName],[ContactPhone],[ContactAddress],[ContactRelation]FROM [Contacts]";

            ds = new DataSet();
            Adapter = new SqlDataAdapter(sql, dbhelper.Connection);

            Adapter.Fill(ds, "Contacts");
            dgvInfo.DataSource = ds.Tables["Contacts"];

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name.Length > 0)
            {
                condition = new StringBuilder();
                condition.AppendFormat("contactName like '%{0}%'",name );
                DataView dvContact = ds.Tables["Contacts"].DefaultView;
                dvContact.RowFilter = condition.ToString();

                dgvInfo.DataSource = dvContact;
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中联系人");
                return;
            }
            if (MessageBox.Show("确定要删除该记录么？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            int id = (int)dgvInfo.SelectedRows[0].Cells[0].Value;

            string sql = "delete from contacts where ContactId= " + id;
            DBHelper dbHelper = new DBHelper();
            SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);


            try
            {
                dbHelper.OpenConnection();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("删除成功！");

                }
            }
            finally
            {
                dbHelper.CloseConnection();
                FillData();

            }

        }

     

       
    }
}
