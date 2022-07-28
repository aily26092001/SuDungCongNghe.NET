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
    public partial class userKhachHang : UserControl
    {
        public userKhachHang()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            dataGridView_KhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_KhachHang.AutoGenerateColumns = false;
            dataGridView_KhachHang.AllowUserToAddRows = false;

            dataGridView_KhachHang.DataSource = KhachHang_DAO.get_info_khachhang();
            dataGridView_KhachHang.Columns[0].DataPropertyName = "maKH";
            dataGridView_KhachHang.Columns[1].DataPropertyName = "tenKH";
            dataGridView_KhachHang.Columns[2].DataPropertyName = "sdt";
            dataGridView_KhachHang.Columns[3].DataPropertyName = "email";
            dataGridView_KhachHang.Columns[4].DataPropertyName = "diaChi";
            dataGridView_KhachHang.Columns[5].DataPropertyName = "tinhTrang";

            show_MD();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThemKH themKH = new frmThemKH();
            themKH.ShowDialog();
            load_data();
        }

        private void btnCapNhatThongTinKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.DiaChi = txtDCKH.Text;
            kh.SdtKH = txtSdtKH.Text;
            kh.EmailKH = txtEmailKH.Text;
            frmThemKH themKH = new frmThemKH(kh, true);
            themKH.ShowDialog();
            load_data();
        }

        private void dataGridView_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rsl = dataGridView_KhachHang.CurrentRow.Index;
            txtMaKH.Text = dataGridView_KhachHang.Rows[rsl].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView_KhachHang.Rows[rsl].Cells[1].Value.ToString();
            txtSdtKH.Text = dataGridView_KhachHang.Rows[rsl].Cells[2].Value.ToString();
            txtEmailKH.Text = dataGridView_KhachHang.Rows[rsl].Cells[3].Value.ToString();
            txtDCKH.Text = dataGridView_KhachHang.Rows[rsl].Cells[4].Value.ToString();
            txtTinhTrang.Text = dataGridView_KhachHang.Rows[rsl].Cells[5].Value.ToString();
        }

        private void show_MD()
        {
            int rsl = 0;
            txtMaKH.Text = dataGridView_KhachHang.Rows[rsl].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView_KhachHang.Rows[rsl].Cells[1].Value.ToString();
            txtSdtKH.Text = dataGridView_KhachHang.Rows[rsl].Cells[2].Value.ToString();
            txtEmailKH.Text = dataGridView_KhachHang.Rows[rsl].Cells[3].Value.ToString();
            txtDCKH.Text = dataGridView_KhachHang.Rows[rsl].Cells[4].Value.ToString();
            txtTinhTrang.Text = dataGridView_KhachHang.Rows[rsl].Cells[5].Value.ToString();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng [" + txtTenKH.Text + "] không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            if (KhachHang_DAO.delete_kh(txtMaKH.Text))
            {
                MessageBox.Show("Xóa khách hàng thành viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thành viên KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                load_data();
            }
        }

        private void mnuStripTT_Click(object sender, EventArgs e)
        {
            Tim_Thong_Tin tt = new Tim_Thong_Tin(true);
            tt.Show();
        }
    }
}
