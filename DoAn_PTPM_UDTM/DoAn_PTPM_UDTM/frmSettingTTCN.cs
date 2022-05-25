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
    public partial class frmSettingTTCN : Form
    {
        public string tenDN { get; set; }
        public readonly frmMenuUser frmMNUS;
        public readonly frmMenuAdmin frmMNAD;
        public frmSettingTTCN()
        {
            InitializeComponent();
        }
        public frmSettingTTCN(frmMenuUser frm,string TenDN)
        {
            InitializeComponent();
            tenDN = TenDN;
            frmMNUS = frm;
        }
        public frmSettingTTCN(frmMenuAdmin frm, string TenDN)
        {
            InitializeComponent();
            tenDN = TenDN;
            frmMNAD = frm;
        }
        BLL_TaiKhoan bllTK = new BLL_TaiKhoan();
        private void iconButton1_Click(object sender, EventArgs e)
        {

            TAIKHOAN tk = bllTK.getThongTinCaNhanTK(tenDN);
            if(txtTen.Text.Length==0||txtDC.Text.Length==0||txtSDT.Text.Length==0||cbGT.Text.Length==0)
            {
                MessageBox.Show(this,"Hãy nhập đầy đủ thông tin sửa !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                bool kq = bllTK.getUpDateTK(tenDN, txtSDT.Text, txtDC.Text, cbGT.Text);
                if(kq==true&&tk.quyen==0)
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

        private void frmSettingTTCN_Load(object sender, EventArgs e)
        {
            TAIKHOAN taiKhoan = bllTK.getThongTinCaNhanTK(tenDN);
            txtTen.Text = taiKhoan.tk;
            txtTen.Enabled = false;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
