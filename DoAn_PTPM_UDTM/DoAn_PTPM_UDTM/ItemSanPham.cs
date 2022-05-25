using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DoAn_PTPM_UDTM
{
    public partial class ItemSanPham : Bunifu.UI.WinForms.BunifuUserControl
    {
        public string TenDangNhap { get; set; }
        public string MaSP { get; set; }
        public string moTa { get; set; }
        public string tenSP { get; set; }
        public string giaSP { get; set; }

        public Image PIC
        {
            set { picSP.Image = value; }
        }

        public ItemSanPham(SANPHAM item,string tenDN,String duongDanHienTai)
        {
            InitializeComponent();
            this.MaSP = item.MaSP;
            this.tenSP = item.TenSP;
            this.moTa = item.MoTa;
            this.giaSP = item.GiaBan.ToString() + " VNĐ";
            TenDangNhap = tenDN;
            this.PIC = Image.FromFile(duongDanHienTai + @"\Images\" + item.HinhAnh);
        }

        private void picSP_MouseMove(object sender, MouseEventArgs e)
        {
            picSP.Size = new Size(213, 213);
        }

        private void ItemSanPham_Click(object sender, EventArgs e)
        {

        }

        private void ItemSanPham_MouseLeave_1(object sender, EventArgs e)
        {
            picSP.Size = new Size(211, 211);
        }

        private void ItemSanPham_Load_1(object sender, EventArgs e)
        {
            lblGia.Text = giaSP;

            //nếu độ dài tên sản phẩm > 20
            //thì chỉ lấy kí tự từ 0 đến 20
            if (tenSP.Length > 20)
                lblTenSP.Text = tenSP.Substring(0, 20) + "...";
            else
                lblTenSP.Text = tenSP;

            //hiện đầy đủ tên sản phẩm
            ToolTip tipTenSP = new ToolTip();
            tipTenSP.BackColor = Color.White;
            tipTenSP.ForeColor = Color.DodgerBlue;
            tipTenSP.IsBalloon = true;
            string[] mota = moTa.Trim().Split('.');
            string mt = "";
            foreach (string item in mota)
            {
                mt += item + "\n";
            }
            tipTenSP.SetToolTip(lblTenSP, tenSP + "\n" + mt);
        }

        private void picThemVaoGioHang_Click(object sender, EventArgs e)
        {
            frmGioHang gh = new frmGioHang(TenDangNhap,MaSP,giaSP);
            gh.Show();
        }
    }
}
