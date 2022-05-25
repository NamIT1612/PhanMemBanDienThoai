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
    public partial class frmBangKhachHang : Form
    {
        public string tenDangNhap { get; set; }
        public frmBangKhachHang()
        {
            InitializeComponent();
        }
        public frmBangKhachHang(string tenDN)
        {
            InitializeComponent();
            tenDangNhap = tenDN;
        }
        BLL_KhachHang bllKH = new BLL_KhachHang();
        BLL_HoaDon bllHD = new BLL_HoaDon();
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void frmBangKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllKH.getloadKhachHang();
            dataGridView1.Columns[4].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length == 0 || txtSDT.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtTen.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kt = bllHD.getKTKNKhachHang(txtMaKH.Text);
                if(kt==true)
                {
                    bool kq = bllKH.getThemKH(txtMaKH.Text, txtTen.Text, txtSDT.Text, txtDiaChi.Text);
                    if (kq == true)
                    {
                        MessageBox.Show(this, "Thêm thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = bllKH.getloadKhachHang();
                    }
                    else
                    {
                        MessageBox.Show(this, "Thêm không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
                else
                {
                    MessageBox.Show(this, "Tồn tại khóa ngoại trong Hóa Đơn !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
              
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length == 0 || txtSDT.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtTen.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kq = bllKH.getSuaKH(txtMaKH.Text, txtTen.Text, txtSDT.Text, txtDiaChi.Text);
                if (kq == true)
                {
                    MessageBox.Show(this, "Sửa thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = bllKH.getloadKhachHang();
                }
                else
                {
                    MessageBox.Show(this, "Sửa không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kt = bllHD.getKTKNKhachHang(txtMaKH.Text);
                if(kt==true)
                {
                    bool kq = bllKH.getXoaKH(txtMaKH.Text);
                    if (kq == true)
                    {
                        MessageBox.Show(this, "Xóa thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = bllKH.getloadKhachHang();
                    }
                    else
                    {
                        MessageBox.Show(this, "Xóa không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
               else
                {
                    MessageBox.Show(this, "Tổn tại khóa ngoại bên Hóa đơn !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
        }
    }
}
