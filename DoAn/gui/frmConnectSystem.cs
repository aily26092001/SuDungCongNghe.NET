using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.dao_xu_ly;
using DoAn.connect_database;
using DoAn.doi_tuong;
using System.Data.SqlClient;

namespace DoAn.gui
{
    public partial class frmConnectSystem : Form
    {
        frmDangNhap dn = new frmDangNhap();
        AppSetting appset = new AppSetting();

        SQLProvider db = new SQLProvider();
        SqlConnection connect = null;

        string connectionString = "";

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public frmConnectSystem()
        {
            InitializeComponent();
            pnCN.BackColor = Color.FromArgb(100, 0, 0, 0);
            lbSN.BackColor = Color.Transparent;
            lbDN.BackColor = Color.Transparent;
            lbUID.BackColor = Color.Transparent;
            lbP.BackColor = Color.Transparent;

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (txtSN.Text == "" || txtDN.Text == "")
                MessageBox.Show("Can not be empty!");
            else
            {
                if (txtUID.Text == "")
                    ConnectionString = string.Format("server={0};database={1};Integrated Security = true;", txtSN.Text, txtDN.Text);
                else
                    ConnectionString = string.Format("server={0};database={1};Integrated Security = true;uid={2};pwd={3}", txtSN.Text, txtDN.Text, txtUID.Text, txtP.Text);
                
                if (db.testConnection(ConnectionString))
                    MessageBox.Show("Lưu kết nối thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lưu kết nối KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ConnectionString != "")
            {
                appset.setConnectionString("DoAn.Properties.Settings.QL_BSach_DoAn_DOTNETConnectionString", ConnectionString);
                connect = new SqlConnection(ConnectionString);
                MessageBox.Show("Lưu kết nối thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDangNhap dn = new frmDangNhap();
                this.Hide();
                dn.Show();
            }
        }


    }
}
