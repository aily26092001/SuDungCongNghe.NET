using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.doi_tuong;
using DoAn.dao_xu_ly;

namespace DoAn.gui
{
    public partial class userNhaCungCap : UserControl
    {
        public userNhaCungCap()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            dataGridView_NCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_NCC.AutoGenerateColumns = false;
            dataGridView_NCC.AllowUserToAddRows = false;

            dataGridView_NCC.DataSource = NhaCungCap_DAO.get_info_nhacungcap();
            dataGridView_NCC.Columns[0].DataPropertyName = "maNCC";
            dataGridView_NCC.Columns[1].DataPropertyName = "tenNCC";
            dataGridView_NCC.Columns[2].DataPropertyName = "sdt";
            dataGridView_NCC.Columns[3].DataPropertyName = "email";
            dataGridView_NCC.Columns[4].DataPropertyName = "diaChi";
            show_MD();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmThemNCC ncc = new frmThemNCC();
            ncc.ShowDialog();
            load_data();
        }

        private void btnCapNhatThongTinNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.DiaChi = txtDCNCC.Text;
            ncc.EmailNCC = txtEmailNCC.Text;
            ncc.SdtNCC = txtSdtNCC.Text;
            frmThemNCC frm = new frmThemNCC(ncc, true);
            frm.ShowDialog();
            load_data();
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp [" + txtTenNCC.Text + "] không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            if (NhaCungCap_DAO.delete_ncc(txtMaNCC.Text))
            {
                MessageBox.Show("Xóa nhà cung cấp thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            else
            {
                MessageBox.Show("Xóa nhà cung cấp KHÔNG thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                load_data();
            }
        }

        private void dataGridView_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rsl = dataGridView_NCC.CurrentRow.Index;
            txtMaNCC.Text = dataGridView_NCC.Rows[rsl].Cells[0].Value.ToString();
            txtTenNCC.Text = dataGridView_NCC.Rows[rsl].Cells[1].Value.ToString();
            txtSdtNCC.Text = dataGridView_NCC.Rows[rsl].Cells[2].Value.ToString();
            txtEmailNCC.Text = dataGridView_NCC.Rows[rsl].Cells[3].Value.ToString();
            txtDCNCC.Text = dataGridView_NCC.Rows[rsl].Cells[4].Value.ToString();
        }

        private void show_MD()
        {
            int rsl = 0;
            txtMaNCC.Text = dataGridView_NCC.Rows[rsl].Cells[0].Value.ToString();
            txtTenNCC.Text = dataGridView_NCC.Rows[rsl].Cells[1].Value.ToString();
            txtSdtNCC.Text = dataGridView_NCC.Rows[rsl].Cells[2].Value.ToString();
            txtEmailNCC.Text = dataGridView_NCC.Rows[rsl].Cells[3].Value.ToString();
            txtDCNCC.Text = dataGridView_NCC.Rows[rsl].Cells[4].Value.ToString();
        }

        private void mnuStripTTNCC_Click(object sender, EventArgs e)
        {
            Tim_Thong_Tin tt = new Tim_Thong_Tin(false);
            tt.Show();
        }
    }
}
