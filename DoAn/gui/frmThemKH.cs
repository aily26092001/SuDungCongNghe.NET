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
    public partial class frmThemKH : Form
    {
        KhachHang kh;
        bool check;
        string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        public frmThemKH()
        {
            InitializeComponent();
        }

        internal frmThemKH(KhachHang kh, bool check)
        {
            this.kh = kh;
            this.check = check;
            InitializeComponent();
        }

        private void frmThemKH_Load(object sender, EventArgs e)
        {
            if (check)
            {
                txtTen.Text = kh.TenKH;
                txtdc.Text = kh.DiaChi;
                txtsdt.Text = kh.SdtKH;
                txtEmail.Text = kh.EmailKH;

                this.Text = "Cập nhật thông tin khách hàng";
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
                MessageBox.Show("Hãy nhập TÊN KHÁCH HÀNG không chứa ký tự đặc biệt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                //Tạo mã khách hàng tự động
                Random rd = new Random();
                int ms = rd.Next(1, 999);
                KhachHang kh = new KhachHang();
                kh.MaKH = "KH" + ms;
                kh.TenKH = txtTen.Text;
                kh.SdtKH = txtsdt.Text;
                kh.EmailKH = txtEmail.Text;
                kh.DiaChi = txtdc.Text;
                if (KhachHang_DAO.insert_kh(kh))
                {
                    Makh = kh.SdtKH;
                    MessageBox.Show("Thêm mới khách hàng thành viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thêm mới khách hàng thành viên KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                }
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = this.kh.MaKH;
                kh.TenKH = txtTen.Text;
                kh.SdtKH = txtsdt.Text;
                kh.EmailKH = txtEmail.Text;
                kh.DiaChi = txtdc.Text;
                if (KhachHang_DAO.update_kh(kh))
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng KHÔNG thành công !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
