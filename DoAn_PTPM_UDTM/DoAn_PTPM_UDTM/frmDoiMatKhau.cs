using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace DoAn_PTPM_UDTM
{
    public partial class frmDoiMatKhau : Form
    {
        public string tenDN { get; set; }
        public readonly frmMenuUser frmMNUS;
        public readonly frmMenuAdmin frmMNAD;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public frmDoiMatKhau(frmMenuUser frm,string TenDN)
        {
            InitializeComponent();
            this.tenDN = TenDN;
            this.frmMNUS = frm;
        }
        public frmDoiMatKhau(frmMenuAdmin frm, string TenDN)
        {
            InitializeComponent();
            this.tenDN = TenDN;
            this.frmMNAD = frm;
        }
        BLL_TaiKhoan bllTK = new BLL_TaiKhoan();
        private void iconButton1_Click(object sender, EventArgs e)
        {

            TAIKHOAN tk = bllTK.getThongTinCaNhanTK(tenDN);
            if (txtTen.Text.Length == 0 || txtMatKhau.Text.Length == 0 || txtMatKhauMoi.Text.Length == 0 || txtMatKhauLap.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập đầy đủ thông tin sửa !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!txtMatKhauMoi.Text.Equals(txtMatKhauLap.Text))
            {
                MessageBox.Show(this, "Nhập mật khẩu lặp trùng mật khẩu mới !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                bool kq = bllTK.getUpdateMK(tenDN, txtMatKhauMoi.Text);
                if (kq == true&& tk.quyen==0)
                {
                    MessageBox.Show(this, tenDN + " Sửa thông tin thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDangNhap frm = new frmDangNhap();
                    frm.Show();
                    frmMNUS.Hide();
                    this.Hide();
                }
                else if (kq == true && tk.quyen == 1)
                {
                    MessageBox.Show(this, tenDN + " Sửa thông tin thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDangNhap frm = new frmDangNhap();
                    frm.Show();
                    frmMNAD.Hide();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(this, tenDN + " Sửa thông tin Thất bại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            TAIKHOAN taiKhoan = bllTK.getThongTinCaNhanTK(tenDN);
            txtTen.Text = taiKhoan.tk;
            txtTen.Enabled = false;
        }
    }
}
