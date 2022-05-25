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

namespace DoAn_PTPM_UDTM
{
    public partial class frmInHoaDon : Form
    {

        public string maKhachHang { get; set; }
        public int trangThai { get; set; }
        public List<HOADON> lstHD { get; set; }
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        public frmInHoaDon(List<HOADON> lst,string maKH,int tt)
        {
            InitializeComponent();
            lstHD = lst;
            maKhachHang = maKH;
            trangThai = tt;
        }
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_BanDienThoaiDataSet.HOADON' table. You can move, or remove it, as needed.
            this.HOADONTableAdapter.Fill(this.QL_BanDienThoaiDataSet.HOADON,maKhachHang,trangThai);
            // TODO: This line of code loads data into the 'QL_BanDienThoaiDataSet.SANPHAM' table. You can move, or remove it, as needed.
                this.SANPHAMTableAdapter.Fill(this.QL_BanDienThoaiDataSet.SANPHAM,maKhachHang,trangThai);



            this.reportViewer1.RefreshReport();
        }
    }
}
