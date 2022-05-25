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
    public partial class itemLichSuBan : UserControl
    {
       

        public string tenDN { get; set; }
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string giaSP { get; set; }
        public string soLuongMua { get; set; }
        public string ngayBan { get; set; }
        public string tongTien { get; set; }

        public Image PIC
        {
            set { picSanPham.Image = value; }
        }
        public itemLichSuBan()
        {
            InitializeComponent();
        }
        public itemLichSuBan(HOADON item,String TenDN)
        {
            InitializeComponent();
            this.tenDN = TenDN;
            this.maSP = item.MaSP;
            this.giaSP = item.GiaBan +" VND";
            this.ngayBan = item.NgayBan.ToString();
            this.soLuongMua = item.SoLuongBan.ToString();

        }
        BLL_SanPham bllSP = new BLL_SanPham();
        private void itemLichSuBan_Load(object sender, EventArgs e)
        {
            SANPHAM item = bllSP.getLoadTheoMaSP(maSP);
            string duongDanHienTai = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            this.PIC = Image.FromFile(duongDanHienTai + @"\Images\" + item.HinhAnh);
            lblTenSP.Text = item.TenSP;
            lblGiaBan.Text = giaSP.ToString();
            lbSoLuongBan.Text = soLuongMua.ToString();
            lbNgayBan.Text = ngayBan;
            string[] gia = giaSP.Split(' ');
            lbTongTien.Text = (int.Parse(soLuongMua) * int.Parse(gia[0])).ToString();
        }

    }
}
