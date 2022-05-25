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
    public partial class frmBangKho : Form
    {

        public string TenDN { get; set; }
        public frmBangKho()
        {
            InitializeComponent();
        }
        public frmBangKho(string tenDN)
        {
            InitializeComponent();
            TenDN = tenDN;
        }
        BLL_Kho bllK = new BLL_Kho();
        BLL_SanPham bllSP = new BLL_SanPham();
        private void frmBangKho_Load(object sender, EventArgs e)
        {
            cbMaSP.DataSource = bllSP.getLoadTatCa();
            cbMaSP.DisplayMember = "TenSP";
            cbMaSP.ValueMember = "MaSP";

            dataGridView1.DataSource = bllK.getLoadKho();
            dataGridView1.Columns[2].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtSoLuongTonKho.Text.Length==0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                bool kq = bllK.getThemKho(cbMaSP.SelectedValue.ToString(), int.Parse(txtSoLuongTonKho.Text));

                if (kq==true)
                {
                    dataGridView1.DataSource = bllK.getLoadKho();
                    dataGridView1.Columns[2].Visible = false;
                    MessageBox.Show(this, "Thêm thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
                else
                {
                    MessageBox.Show(this, "Thêm không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoLuongTonKho.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kq = bllK.getSuaKho(cbMaSP.SelectedValue.ToString(), int.Parse(txtSoLuongTonKho.Text));

                if (kq == true)
                {
                    dataGridView1.DataSource = bllK.getLoadKho();
                    dataGridView1.Columns[2].Visible = false;
                    MessageBox.Show(this, "Sửa thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Sửa không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoLuongTonKho.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kq = bllK.getXoaKho(cbMaSP.SelectedValue.ToString());

                if (kq == true)
                {
                    dataGridView1.DataSource = bllK.getLoadKho();
                    dataGridView1.Columns[2].Visible = false;
                    MessageBox.Show(this, "Sửa thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Sửa không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
