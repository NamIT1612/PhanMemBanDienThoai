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
    public partial class frmBangHoaDon : Form
    {
        public string tenDN { get; set; }
        public frmBangHoaDon()
        {
            InitializeComponent();
        }
        public frmBangHoaDon(string tenDN)
        {
            InitializeComponent();
            this.tenDN = tenDN;
        }
        BLL_KhachHang bllKH = new BLL_KhachHang();
        BLL_TaiKhoan bllTK = new BLL_TaiKhoan();
        BLL_SanPham bllSP = new BLL_SanPham();
        BLL_HoaDon bllHD = new BLL_HoaDon();
        private void frmBangHoaDon_Load(object sender, EventArgs e)
        {
            cbMaKhachHang.DataSource = bllKH.getloadKhachHang();
            cbMaKhachHang.DisplayMember = "MaKhachHang";
            cbMaKhachHang.ValueMember = "MaKhachHang";

            cbMaSanPham.DataSource = bllSP.getLoadTatCa();
            cbMaSanPham.DisplayMember = "TenSP";
            cbMaSanPham.ValueMember = "MaSP";

            cbTaiKhoan.DataSource = bllTK.getLoadTaiKhoan();
            cbTaiKhoan.DisplayMember = "tk";
            cbTaiKhoan.ValueMember = "tk";

            dataGridView1.DataSource = bllHD.getLoadHoaDon();
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtGiaBan.Text.Length == 0 || txtSoLuongBan.Text.Length == 0 || txtNgayBan.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kq = bllHD.getSuaHD(cbMaKhachHang.Text, cbMaSanPham.SelectedValue.ToString(), cbTaiKhoan.Text, int.Parse(txtSoLuongBan.Text), int.Parse(txtGiaBan.Text),DateTime.Parse(txtNgayBan.Text));
                if (kq == true)
                {
                    MessageBox.Show(this, "Sửa thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = bllHD.getLoadHoaDon();
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                }
                else
                {
                    MessageBox.Show(this, "Sửa không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtGiaBan.Text.Length == 0 || txtSoLuongBan.Text.Length == 0 || txtNgayBan.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kq = bllHD.getXoaHoaDon(cbMaKhachHang.Text, DateTime.Parse(txtNgayBan.Text));
                if (kq == true)
                {
                    MessageBox.Show(this, "Sửa thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = bllHD.getLoadHoaDon();
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                }
                else
                {
                    MessageBox.Show(this, "Sửa không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                cbMaKhachHang.Text = row.Cells[0].Value.ToString();
                cbMaSanPham.Text = row.Cells[1].Value.ToString();
                cbTaiKhoan.Text = row.Cells[2].Value.ToString();
                txtSoLuongBan.Text = row.Cells[3].Value.ToString();
                txtGiaBan.Text = row.Cells[4].Value.ToString();
                txtNgayBan.Text = row.Cells[5].Value.ToString();
            }    
        }
    }
}
