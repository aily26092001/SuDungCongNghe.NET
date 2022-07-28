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

namespace DoAn.gui
{
    public partial class Tim_Thong_Tin : Form
    {
        bool check = false;
        public Tim_Thong_Tin()
        {
            InitializeComponent();
        }

        public Tim_Thong_Tin(bool check)
        {
            InitializeComponent();
            this.check = check;
            if (check)
            {
                this.Text = "Tìm khách hàng";
                txtTinhTrang.Visible = true;
                lblTinhTrang.Visible = true;
                lblThongTin.Text = "Nhập thông tin khách hàng:";
                lblMa.Text = "Mã khách hàng:";
                lblTen.Text = "Tên khách hàng:";

            }
            else
            {
                this.Text = "Tìm nhà cung cấp";
                txtTinhTrang.Visible = false;
                lblTinhTrang.Visible = false;
                lblThongTin.Text = "Nhập thông tin nhà cung cấp:";
                lblMa.Text = "Mã nhà cung cấp:";
                lblTen.Text = "Tên nhà cung cấp:";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (check) // true --> Tìm khách hàng
            {
                KhachHang kh = new KhachHang();
                kh = KhachHang_DAO.get_KH(txtDK.Text);
                if (kh != null)
                {
                    txtMa.Text = kh.MaKH;
                    txtTen.Text = kh.TenKH;
                    txtSdt.Text = kh.SdtKH;
                    txtEmail.Text = kh.EmailKH;
                    txtDC.Text = kh.DiaChi;
                    txtTinhTrang.Text = kh.TinhTrang;
                }
                else
                {
                    MessageBox.Show("Không thấy dữ liệu cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDK.Focus(); txtDK.SelectAll();
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtSdt.Text = "";
                    txtEmail.Text = "";
                    txtDC.Text = "";
                    txtTinhTrang.Text = "";
                }
            }
            else // false --> Tìm nhà cung cấp
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc = NhaCungCap_DAO.get_ncc(txtDK.Text);
                if (ncc != null)
                {
                    txtMa.Text = ncc.MaNCC;
                    txtTen.Text = ncc.TenNCC;
                    txtDC.Text = ncc.DiaChi;
                    txtSdt.Text = ncc.SdtNCC;
                    txtEmail.Text = ncc.EmailNCC;
                }
                else
                {
                    MessageBox.Show("Không thấy dữ liệu cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDK.Focus(); txtDK.SelectAll();
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtSdt.Text = "";
                    txtEmail.Text = "";
                    txtDC.Text = "";
                }
            }
        }
    }
}
