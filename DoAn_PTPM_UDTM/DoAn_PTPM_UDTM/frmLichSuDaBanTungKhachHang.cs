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
    public partial class frmLichSuDaBanTungKhachHang : Form
    {
        public string tenDN { get; set; }
        public frmLichSuDaBanTungKhachHang()
        {
            InitializeComponent();
        }
        public frmLichSuDaBanTungKhachHang(string TenDN)
        {
            InitializeComponent();
            tenDN = TenDN;
        }

        private void flowLayoutSanPhamDaBan_Paint(object sender, PaintEventArgs e)
        {

        }
        BLL_HoaDon bllHD = new BLL_HoaDon();
        KHACHHANG kh = new KHACHHANG();
        private void frmLichSuDaBanTungKhachHang_Load(object sender, EventArgs e)
        {
            flowLayoutSanPhamDaBan.Controls.Clear();
            List<HOADON> lstHD = bllHD.getLoadTheoTKVaTT(tenDN, 1);
            lbTongTien.Text = bllHD.getTinhTongSanPhamDaBan(tenDN);
            if (lstHD.Count == 0)
                flowLayoutSanPhamDaBan.Controls.Add(lblThongBao);
            else
                loadDuLieu(lstHD);
        }

        void loadDuLieu(List<HOADON> lstHD)
        {
            itemLichSuBan HD;
            foreach (HOADON item in lstHD)
            {
                HD = new itemLichSuBan(item, tenDN);
                flowLayoutSanPhamDaBan.Controls.Add(HD);
            }
        }
    }
}
