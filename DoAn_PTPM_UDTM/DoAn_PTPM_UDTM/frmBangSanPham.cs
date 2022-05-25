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
using System.IO;

namespace DoAn_PTPM_UDTM
{
    public partial class frmBangSanPham : Form
    {
        public string tenDN { get; set; }
        public frmBangSanPham()
        {
            InitializeComponent();
        }
        public frmBangSanPham(string TenDN)
        {
            InitializeComponent();
            tenDN = TenDN;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        BLL_SanPham bllSP = new BLL_SanPham();
        BLL_HoaDon bllHD = new BLL_HoaDon();
        BLL_LoaiSanPham bllLSP = new BLL_LoaiSanPham();

        private void frmBangSanPham_Load(object sender, EventArgs e)
        {
            cbMaLoai.DataSource = bllLSP.getLoadLSP();
            cbMaLoai.DisplayMember = "TenLoai";
            cbMaLoai.ValueMember = "MaLoai";

            dataGridView1.DataSource = bllSP.getLoadTatCa();
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtTenSP.Text = row.Cells[1].Value.ToString();
                txtGiaBan.Text = row.Cells[2].Value.ToString();
                txtGiaCu.Text = row.Cells[3].Value.ToString();
                txtMoTa.Text = row.Cells[4].Value.ToString();
                cbMaLoai.Text = row.Cells[6].Value.ToString();
                txtImg.Text = row.Cells[5].Value.ToString();
                string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));// lấy đường dẫn vào project 
                if (txtImg.Text != "")
                {
                    picSP.Image = Image.FromFile(duongDanHienTai + @"\Images\" + txtImg.Text);
                }
                else
                {
                    picSP.Image = Image.FromFile(duongDanHienTai + @"\Images\" + "Rong.png");
                }
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Length==0||txtTenSP.Text.Length==0||txtGiaCu.Text.Length==0||txtGiaBan.Text.Length==0||txtMoTa.Text.Length==0||txtImg.Text.Length==0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kt = bllHD.getKTKNSanPham(txtMaSP.Text);
                if (kt == true)
                {
                    bool kq = bllSP.getThemSP(txtMaSP.Text, txtTenSP.Text, int.Parse(txtGiaBan.Text),
                        int.Parse(txtGiaCu.Text), txtMoTa.Text, txtImg.Text, cbMaLoai.SelectedValue.ToString());
                    if (kq == true)
                    {
                        MessageBox.Show(this, "Thêm thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = bllSP.getLoadTatCa();
                        dataGridView1.Columns[7].Visible = false;
                        dataGridView1.Columns[8].Visible = false;
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
            if (txtMaSP.Text.Length == 0 || txtTenSP.Text.Length == 0 || txtGiaCu.Text.Length == 0 || txtGiaBan.Text.Length == 0 || txtMoTa.Text.Length == 0 || txtImg.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kt = bllHD.getKTKNSanPham(txtMaSP.Text);
                if (kt == true)
                {
                    bool kq = bllSP.getSuaSP(txtMaSP.Text, txtTenSP.Text, int.Parse(txtGiaBan.Text),
                        int.Parse(txtGiaCu.Text), txtMoTa.Text, txtImg.Text, cbMaLoai.SelectedValue.ToString());
                    if (kq == true)
                    {
                        MessageBox.Show(this, "Sửa thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = bllSP.getLoadTatCa();
                        dataGridView1.Columns[7].Visible = false;
                        dataGridView1.Columns[8].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(this, "Sửa không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Tồn tại khóa ngoại trong Hóa Đơn !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Length == 0 )
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kt = bllHD.getKTKNSanPham(txtMaSP.Text);
                if (kt == true)
                {
                    bool kq = bllSP.getXoaSP(txtMaSP.Text);
                    if (kq == true)
                    {
                        MessageBox.Show(this, "Xóa thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = bllSP.getLoadTatCa();
                        dataGridView1.Columns[7].Visible = false;
                        dataGridView1.Columns[8].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(this, "Xóa không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Tồn tại khóa ngoại trong Hóa Đơn !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
