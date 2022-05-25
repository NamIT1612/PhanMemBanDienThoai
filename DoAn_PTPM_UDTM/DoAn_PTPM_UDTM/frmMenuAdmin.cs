using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace DoAn_PTPM_UDTM
{
    public partial class frmMenuAdmin : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public string tenDangNhap="";
        
        public frmMenuAdmin()
        {
            InitializeComponent();
            
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 87);
            pnMenu.Controls.Add(leftBorderBtn);
        }
        public frmMenuAdmin(string tenTK)
        {
            InitializeComponent();
            tenDangNhap = tenTK;
            btnTieuDe.Text += " - " + tenDangNhap;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 87);
            pnMenu.Controls.Add(leftBorderBtn);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(241, 151, 201);
        }

        private void ActiveButton(Object senderBtn,Color color)
        {
            if(senderBtn!=null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(58, 56, 69);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                if(pnMenu.Width > 90)
                {
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                }
                leftBorderBtn.Visible = false;
                iconButton8.BackColor = color;
            }    
        }
        private void DisableButton()
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(130, 111, 102);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }    
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            currentFormChild = childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            iconButton8.Text = "QUẢN LÍ KHÁCH HÀNG";
            loadChildForm(new frmBangKhachHang(tenDangNhap));

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            iconButton8.Text = "QUẢN LÍ HÓA ĐƠN";
            loadChildForm(new frmBangHoaDon(tenDangNhap));
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            iconButton8.Text = "QUẢN LÍ SẢN PHẨM";
            loadChildForm(new frmBangSanPham(tenDangNhap));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadChildForm(Form frmChild)
        {
            panelDesktop.Controls.Clear();
            frmChild.TopLevel = false;
            panelDesktop.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            frmChild.Show();
        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmDangNhap frmDN = new frmDangNhap();
                this.Hide();
                frmDN.Show();
            }
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            iconButton8.Text = "CÀI ĐẶT";
            loadChildForm(new frmThongTinCaNhan(this, tenDangNhap));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color7);
            iconButton8.Text = "ĐĂNG XUẤT";
            if (MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmDangNhap frmDN = new frmDangNhap();
                this.Hide();
                frmDN.Show();
            }

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            iconButton8.Text = "THỐNG KÊ";
            loadChildForm(new frmBangThongKe(tenDangNhap));
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            iconButton8.Text = "QUẢN LÍ KHO";
            loadChildForm(new frmBangKho(tenDangNhap));
        }
    }
}
