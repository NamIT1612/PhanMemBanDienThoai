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
    public partial class frmThongTinCaNhan : Form
    {
        public string TenDN { get; set; }
        public readonly frmMenuUser frmMeNuUS;
        public readonly frmMenuAdmin frmMeNuAD;
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }
        public frmThongTinCaNhan(frmMenuAdmin frmMN, string tenDN)
        {
            InitializeComponent();
            this.TenDN = tenDN;
            frmMeNuAD = frmMN;

        }
        public frmThongTinCaNhan(frmMenuUser frmMN,string tenDN)
        {
            InitializeComponent();
            this.TenDN = tenDN;
            frmMeNuUS = frmMN;

        }
        BLL_TaiKhoan bllTK = new BLL_TaiKhoan();
        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            TAIKHOAN tk = bllTK.getThongTinCaNhanTK(TenDN);
            lbTen.Text = tk.tk;
            lbDiaChi.Text = tk.DiaChi;
            lbSDT.Text = tk.SDT;
            lbGioiTinh.Text = tk.GioiTinh;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            TAIKHOAN tk = bllTK.getThongTinCaNhanTK(TenDN);
            if(tk.quyen==0)
            {
                frmSettingTTCN frm = new frmSettingTTCN(frmMeNuUS, TenDN);
                frm.Show();
            }    
         else
            {
                frmSettingTTCN frm = new frmSettingTTCN(frmMeNuAD, TenDN);
                frm.Show();
            }    
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            TAIKHOAN tk = bllTK.getThongTinCaNhanTK(TenDN);
            if (tk.quyen == 0)
            {
                frmDoiMatKhau frm = new frmDoiMatKhau(frmMeNuUS, TenDN);
                frm.Show();
            }
            else
            {
                frmSettingTTCN frm = new frmSettingTTCN(frmMeNuAD, TenDN);
                frm.Show();
            }
           
        }
    }
}
