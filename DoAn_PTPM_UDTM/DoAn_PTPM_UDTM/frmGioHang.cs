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
    public partial class frmGioHang : Form
    {
        public frmGioHang()
        {
            InitializeComponent();
        }
        public string TenDN { get; set; }
        public string maSanPham { get; set; }
        public string giaBan { get; set; }
        public frmGioHang(string TenDangNhap,string maSP,string giaBan)
        {
            InitializeComponent();
            this.TenDN = TenDangNhap;
            this.maSanPham = maSP;
            this.giaBan = giaBan;
        }
        BLL_Kho bllK = new BLL_Kho();
        BLL_KhachHang bllKH = new BLL_KhachHang();
        BLL_HoaDon bllHD = new BLL_HoaDon();
        private void frmGioHang_Load(object sender, EventArgs e)
        {
            lbSoLuongTonKho.Text= bllK.getLoadSoLuongKhoTheoMaSP(maSanPham);
            lbGia.Text = giaBan;
        }

        private void txtSoLuongMua_TextChanged(object sender, EventArgs e)
        {
            if(txtSoLuongMua.Text.Length!=0)
            {
                int soluongBan = int.Parse(txtSoLuongMua.Text);
                string[] g = giaBan.Split(' ');
                int gia = int.Parse(g[0]);
                lbTongTien.Text = (soluongBan * gia).ToString()+" VND";
            }    
            else
            {
                lbTongTien.Text = "00000 VND";
            }    
           
        }

        private void txtSoLuongMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnThemGioHang_Click(object sender, EventArgs e)

        {
            if (txtSoLuongMua.Text.Length != 0)
            {
                DateTime date = DateTime.Now;
                string[] g = giaBan.Split(' ');
                int gia = int.Parse(g[0]);
                string id = bllKH.getTimMaKHBatGiaoDich();
                if(id!=null)
                {
                    bool kq = bllHD.getThemHD(id, maSanPham, TenDN, int.Parse(txtSoLuongMua.Text), gia, date, 0);
                    if (kq == true)
                    {

                        MessageBox.Show(this, "Thêm hóa đơn thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Thêm hóa đơn không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
                else
                {
                    MessageBox.Show(this, "Vui lòng chọn khách hàng giao dịch !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
              
            }
            else
            {
                MessageBox.Show(this, "Vui lòng nhập số lượng !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
