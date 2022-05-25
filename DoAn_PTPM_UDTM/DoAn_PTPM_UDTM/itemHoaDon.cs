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
    public partial class itemHoaDon : UserControl
    {
        private readonly frmHoaDon frmhd;
        public string tenDN { get; set; }
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string giaSP { get; set; }
        public string soLuongMua { get; set; }
        public DateTime ngayBan { get; set; }
        public string tongTien { get; set; }

        public Image PIC
        {
            set { picSanPham.Image = value; }
        }
        public itemHoaDon()
        {
            InitializeComponent();
        }
        public itemHoaDon(frmHoaDon frmHD,HOADON item,string tenDangNhap)
        {
            InitializeComponent();
           this.frmhd = frmHD;
            this.maSP = item.MaSP;
            this.giaSP = item.GiaBan.ToString() + " VNĐ";
            this.soLuongMua = item.SoLuongBan.ToString();
            this.ngayBan = item.NgayBan;
            tenDN = tenDangNhap;
           
        }
        BLL_Kho bllK = new BLL_Kho();
        BLL_SanPham bllSP = new BLL_SanPham();
        BLL_HoaDon bllHD = new BLL_HoaDon();
        BLL_KhachHang bllKH = new BLL_KhachHang();

        public bool getChecked()
        {
            return ckbChon.Checked;
        }
        public bool isChecked()
        {
            if (ckbChon.Checked)
                return true;
            else
                return false;
        }
        public void setChecked(bool check)
        {
            ckbChon.Checked = check;
        }
        private void itemHoaDon_Load(object sender, EventArgs e)
        {

            SANPHAM sp = bllSP.getLoadTheoMaSP(maSP);

            string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            this.PIC = Image.FromFile(duongDanHienTai + @"\Images\" + sp.HinhAnh);
            lblTenSP.Text = sp.TenSP;
            lblGiaBan.Text = giaSP.ToString();
            txtSoLuong.Text = soLuongMua.ToString();
            string[] gia = giaSP.Split(' ');
            lbTongTien.Text = (int.Parse(soLuongMua) * int.Parse(gia[0])).ToString();
            if(ckbChon.Checked)
            {
                tongTien = (int.Parse(soLuongMua) * int.Parse(gia[0])).ToString();
            }    
           else
            {
                tongTien = "0";
            }    
        }

        private void pnitem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuaSoLuong_Click(object sender, EventArgs e)
        {
            string soLuongTon = bllK.getLoadSoLuongKhoTheoMaSP(maSP);
            int soluong = int.Parse(soLuongTon);
            string id = bllKH.getTimMaKHBatGiaoDich();
            if(int.Parse(txtSoLuong.Text)<=soluong)
            {
                bool kq=bllHD.getSuaSoLuongMua(id, ngayBan, int.Parse(txtSoLuong.Text));
                if(kq==true)
                {
                    string[] gia = giaSP.Split(' ');
                    lbTongTien.Text = (int.Parse(txtSoLuong.Text) * int.Parse(gia[0])).ToString();
                    if (ckbChon.Checked)
                    {
                        tongTien = (int.Parse(soLuongMua) * int.Parse(gia[0])).ToString();
                    }
                    else
                    {
                        tongTien = "0";
                    }
                    MessageBox.Show(this, "Cập nhật thành công số lượng bán!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }       
                else
                {
                    MessageBox.Show(this, "Cập nhật không thành công số lượng bán!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }   
            else
            {
                MessageBox.Show(this, "Vui lòng kiểm tra số lượng hàng trong kho !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            string id = bllKH.getTimMaKHBatGiaoDich();
            bool kq = bllHD.getXoaHoaDon(id, ngayBan);
            if(kq==true)
            {
                frmhd.delItemLowlayPnGioHang(this);
                MessageBox.Show(this, "Xóa khỏi hóa đơn thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                MessageBox.Show(this, "Xóa khỏi hóa đơn không thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void ckbChon_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
        }
    }
}
