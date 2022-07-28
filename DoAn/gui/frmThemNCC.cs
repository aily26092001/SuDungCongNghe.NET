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
using DoAn.doi_tuong;
using DoAn.Validation;

namespace DoAn.gui
{
    public partial class frmThemNCC : Form
    {
        NhaCungCap ncc;
        bool check;
        public frmThemNCC()
        {
            InitializeComponent();
        }

        internal frmThemNCC(NhaCungCap nhaCungCap, bool check)
        {
            this.ncc = nhaCungCap;
            this.check = check;

            InitializeComponent();
        }
        private void frmThemNCC_Load(object sender, EventArgs e)
        {
            if (check)
            {
                txtTen.Text = ncc.TenNCC;
                txtsdt.Text = ncc.SdtNCC;
                txtdc.Text = ncc.DiaChi;
                txtEmail.Text = ncc.EmailNCC;

                this.Text = "Cập nhật thông tin nhà cung cấp";
                label1.Text = this.Text.ToUpper();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng cửa sổ ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            this.Hide();
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            if (!IsValid_Name(txtTen.Text))
            {
                MessageBox.Show("Hãy nhập TÊN NHÀ CUNG CẤP không chứa ký tự đặc biệt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                txtTen.SelectAll();
                return;
            }
            if (!IsValid_DC(txtdc.Text))
            {
                MessageBox.Show("Hãy nhập Địa chỉ không chứa ký tự đặc biệt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                txtTen.SelectAll();
                return;
            }
            if (!IsValid_NUMBER_PHONE(txtsdt.Text))
            {
                MessageBox.Show("Số điện thoại không chính xác - Hãy nhập định dạng số điện thoại Việt Nam (09.., 086.., 089.., 088.., 01...) !", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsdt.Focus();
                txtsdt.SelectAll();
                return;
            }
            if (!IsValid_EMAIL(txtEmail.Text))
            {
                MessageBox.Show("Sai định dạng Email. *Example@gmail.com !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }
            if (!check)
            {
                if (MessageBox.Show("Bạn có muốn thêm nhà cung cấp [" + txtTen.Text + "] không ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                //Tạo mã nhà cung cấp tự động
                Random rd = new Random();
                int ms = rd.Next(1, 999);
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNCC = "NCC" + ms;
                ncc.TenNCC = txtTen.Text;
                ncc.SdtNCC = txtsdt.Text;
                ncc.EmailNCC = txtEmail.Text;
                ncc.DiaChi = txtdc.Text;

                if (NhaCungCap_DAO.insert_ncc(ncc))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn Cập nhật thông tin nhà cung cấp [" + txtTen.Text + "] không ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNCC = this.ncc.MaNCC;
                ncc.TenNCC = txtTen.Text;
                ncc.SdtNCC = txtsdt.Text;
                ncc.EmailNCC = txtEmail.Text;
                ncc.DiaChi = txtdc.Text;

                if (NhaCungCap_DAO.update_ncc(ncc))
                {
                    MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhà cung cấp KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                }
            }

        }

        private bool IsValid_Name(string name)
        {
            if (!check_valid.IsValid_HoTen(name))
                return false;
            return true;
        }

        private bool IsValid_NUMBER_PHONE(string number)
        {
            if (!check_valid.IsNumberPhone_VN(number))
                return false;
            return true;
        }

        private bool IsValid_EMAIL(string email)
        {
            if (!check_valid.IsValidEmail(email))
                return false;
            return true;
        }

        private bool IsValid_DC(string dc)
        {
            if (!check_valid.IsValid_DC(dc))
                return false;
            return true;
        }

    }
}
