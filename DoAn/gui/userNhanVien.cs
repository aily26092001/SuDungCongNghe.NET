using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.gui;
using DoAn.doi_tuong;
using DoAn.dao_xu_ly;
using System.IO;

namespace DoAn
{
    public partial class userNhanVien : UserControl
    {
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public userNhanVien()
        {
            InitializeComponent();
            load_data();
            this.ContextMenuStrip = mnuStripTTTT;
        }


        public void load_data()
        {
            dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNhanVien.AutoGenerateColumns = false;
            dataGridViewNhanVien.AllowUserToAddRows = false;

            dataGridViewNhanVien.DataSource = NhanVien_DAO.get_info_nhanvien();
            dataGridViewNhanVien.Columns[0].DataPropertyName = "maNV";
            dataGridViewNhanVien.Columns[1].DataPropertyName = "tenNV";
            dataGridViewNhanVien.Columns[2].DataPropertyName = "ngaySinh";
            dataGridViewNhanVien.Columns[3].DataPropertyName = "gioiTinh";
            dataGridViewNhanVien.Columns[4].DataPropertyName = "emailNV";
            dataGridViewNhanVien.Columns[5].DataPropertyName = "SoDT";
            dataGridViewNhanVien.Columns[6].DataPropertyName = "anhNV";

            show_md();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThemNV frmThemNV = new frmThemNV();
            frmThemNV.ShowDialog();
            load_data();
        }

        private void btnCapNhatThongTinNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.NgaySinh = txtNgaySinh.Text;
            nv.GioiTinh = txtGTinh.Text;
            nv.EmailNV = txtEmailNV.Text;
            nv.SdtNV = txtSdtNV.Text;
            nv.AnhNV = dataGridViewNhanVien.Rows[dataGridViewNhanVien.CurrentRow.Index].Cells[6].Value.ToString();

            //Truyền nhân viên vào frame Để cập nhật thông tin nhân viên
            frmThemNV frmThemNV = new frmThemNV(nv, true);
            frmThemNV.ShowDialog();
            load_data();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên [" + txtTenNV.Text + "] không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            string manv = txtMaNV.Text;
            //Xóa nhân viên trong database
            if (NhanVien_DAO.delete_nv(txtMaNV.Text))
            {
                MessageBox.Show("Xóa nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                load_data();
            }
        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rsl = dataGridViewNhanVien.CurrentRow.Index;
            txtMaNV.Text = dataGridViewNhanVien.Rows[rsl].Cells[0].Value.ToString();
            txtTenNV.Text = dataGridViewNhanVien.Rows[rsl].Cells[1].Value.ToString();
            txtNgaySinh.Text = dataGridViewNhanVien.Rows[rsl].Cells[2].Value.ToString();
            txtGTinh.Text = dataGridViewNhanVien.Rows[rsl].Cells[3].Value.ToString();
            txtEmailNV.Text = dataGridViewNhanVien.Rows[rsl].Cells[4].Value.ToString();
            txtSdtNV.Text = dataGridViewNhanVien.Rows[rsl].Cells[5].Value.ToString();
            picAnhNV.Image = Image.FromFile(projectPath + dataGridViewNhanVien.Rows[rsl].Cells[6].Value.ToString());

        }

        private void show_md()
        {
            int rsl = 0;
            txtMaNV.Text = dataGridViewNhanVien.Rows[rsl].Cells[0].Value.ToString();
            txtTenNV.Text = dataGridViewNhanVien.Rows[rsl].Cells[1].Value.ToString();
            txtNgaySinh.Text = dataGridViewNhanVien.Rows[rsl].Cells[2].Value.ToString();
            txtGTinh.Text = dataGridViewNhanVien.Rows[rsl].Cells[3].Value.ToString();
            txtEmailNV.Text = dataGridViewNhanVien.Rows[rsl].Cells[4].Value.ToString();
            txtSdtNV.Text = dataGridViewNhanVien.Rows[rsl].Cells[5].Value.ToString();
            picAnhNV.Image = Image.FromFile(projectPath + dataGridViewNhanVien.Rows[rsl].Cells[6].Value.ToString());
        }

        private void mnuStripTTTT_Click(object sender, EventArgs e)
        {
            TraCuuThongTin tt = new TraCuuThongTin(false, null);
            tt.Show();
        }
    }
}
