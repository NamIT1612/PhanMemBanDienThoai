using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace DoAn_PTPM_UDTM
{
    public partial class frmCuaHang : Form
    {
        BLL_SanPham bllSP = new BLL_SanPham();
       public string TenDangNhap { get; set; }
        public frmCuaHang()
        {
            InitializeComponent();
        }
        public frmCuaHang(string ten)
        {
            InitializeComponent();
            TenDangNhap = ten;
        }
        private void loadDuLieu(List<SANPHAM> ListSP)
        {
            flowLayoutSanPham.Controls.Clear();
            string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            foreach (SANPHAM item in ListSP)
            {
                ItemSanPham iSP = new ItemSanPham(item,TenDangNhap, duongDanHienTai);
                flowLayoutSanPham.Controls.Add(iSP);
            }
        }

        private void btnHienTatCaSP_Click(object sender, EventArgs e)
        {
            List<SANPHAM> ListSP = bllSP.getLoadTatCa();
            loadDuLieu(ListSP);
        }
        private void txtTimSP_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (txtTimSP.Text.Length == 0)
            {
                txtTimSP.Focus();
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                List<SANPHAM> ListSP = bllSP.getListTimTheoTen(txtTimSP.Text);
                if (ListSP.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm có tên " + txtTimSP.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTimSP.Focus();
                }
                else
                {
                    loadDuLieu(ListSP);
                    btnHienTatCaSP.Visible = true;
                }
            }
        }

        private void frmCuaHang_Load_1(object sender, EventArgs e)
        {
            List<SANPHAM> ListSP = bllSP.getLoadTatCa();
            if (ListSP.Count == 0)
                flowLayoutSanPham.Controls.Add(lblThongBao);
            else
                loadDuLieu(ListSP);
        }
    }
}
