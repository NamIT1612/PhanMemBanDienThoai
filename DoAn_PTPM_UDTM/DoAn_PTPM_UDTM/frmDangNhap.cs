using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DoAn_PTPM_UDTM
{
    public partial class frmDangNhap : Form
    {
        BLL_KiemTraTaiKhoanDangNhap bllKiemTraTK = new BLL_KiemTraTaiKhoanDangNhap();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public frmDangNhap(string tenTaiKhoan)
        {
            InitializeComponent();
            tenTaiKhoan = txtUser.Text;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (bllKiemTraTK.kiemTraTaiKhoan(txtUser.Text,txtPass.Text) == 1)
                {
                    MessageBox.Show(this, "đăng nhập Admin thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenuAdmin mn = new frmMenuAdmin(txtUser.Text);
                    mn.Show();
                    this.Hide();
                    return;
                } 
            else if(bllKiemTraTK.kiemTraTaiKhoan(txtUser.Text, txtPass.Text) == 2)
                {
                    MessageBox.Show(this, "đăng nhập thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenuUser mn = new frmMenuUser(txtUser.Text);
                    mn.Show();
                    this.Hide();
                    return;
                }
            else
                MessageBox.Show(this, "đăng nhập thất bại !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(this, "Thoát thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
               
            }
       }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
