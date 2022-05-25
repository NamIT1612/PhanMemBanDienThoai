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
    public partial class frmHoaDon : Form
    {
        public string tenDN { get; set; }
        public int tongTien { get; set; }
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public frmHoaDon(string tenDangNhap)
        {
            InitializeComponent();
            tenDN = tenDangNhap;
        }
        BLL_HoaDon bllHD = new BLL_HoaDon();
        BLL_KhachHang bllKH = new BLL_KhachHang();
        BLL_Kho bllK = new BLL_Kho();
        private void frmHoaDon_Load(object sender, EventArgs e)
        {

            fowlayPnGioHang.Controls.Clear();
            string id = bllKH.getTimMaKHBatGiaoDich();
            lbMaKH.Text = id;
            List<HOADON> lstHD= bllHD.getLoadTheoMaKHVaTT(id, 0);
            if (lstHD.Count == 0)
                fowlayPnGioHang.Controls.Add(lblThongBao);
            else
                loadGioHang(lstHD);
            loadTongTien();
        }

        private void loadGioHang(List<HOADON> listHD)

        {
            itemHoaDon HD;
            foreach (HOADON item in listHD)
            {
                HD = new itemHoaDon(this,item, tenDN);
                fowlayPnGioHang.Controls.Add(HD);
            }

        }
        public void delItemLowlayPnGioHang(itemHoaDon item)
        {
            fowlayPnGioHang.Controls.Remove(item);
            if (fowlayPnGioHang.Controls.Count == 0)
            {
                fowlayPnGioHang.Controls.Add(lblThongBao);
            }
        }
        private void ckbChonALL_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (ckbChonALL.Checked)
            {
                lblChonALL.Text = "Bỏ Chọn Tất Cả";
                foreach (itemHoaDon item in fowlayPnGioHang.Controls.OfType<itemHoaDon>().ToList())
                {
                    item.setChecked(true);
                    loadTongTien();
                }
            }
            else
            {
                lblChonALL.Text = "Chọn Tất Cả";
                foreach (itemHoaDon item in fowlayPnGioHang.Controls.OfType<itemHoaDon>().ToList())
                {
                    item.setChecked(false);
                    loadTongTien();
                }
            }
        }
        void loadTongTien()
        {
            int tong = 0;
            foreach (itemHoaDon item in fowlayPnGioHang.Controls.OfType<itemHoaDon>().ToList())
            {
                if(item.isChecked()==true)
                {
                    tong = tong + int.Parse(item.tongTien);
                }
            }
            lbTongTien.Text = tong.ToString();
        }

        private void btnXuatBill_Click(object sender, EventArgs e)
        {
           
            string id = bllKH.getTimMaKHBatGiaoDich();
            List<HOADON> lstHD = bllHD.getLoadTheoMaKHVaTT(id, 0);
            int tt = 0;
            frmInHoaDon frm = new frmInHoaDon(lstHD, id, tt);
            frm.Show();
            bool kq = bllHD.getCapNhatTT(id);
            fowlayPnGioHang.Controls.Clear();
            foreach (HOADON t in lstHD)
            {
                bool kq1 = bllK.getCapNhatSoLuongGioHang(t.MaSP, (int)t.SoLuongBan);
            }
            loadTongTien();

        }
    }
}
