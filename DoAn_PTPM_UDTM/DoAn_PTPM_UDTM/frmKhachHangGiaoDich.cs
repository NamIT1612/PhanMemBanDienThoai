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
    public partial class frmKhachHangGiaoDich : Form
    {
        public frmKhachHangGiaoDich()
        {
            InitializeComponent();
        }
        BLL_KhachHang bllKH = new BLL_KhachHang();
        private void txtTenKH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllKH.getloadKhachHang();
            dataGridView1.Columns[4].Visible = false;

            lbMaKH.Text = bllKH.getTimMaKHBatGiaoDich();
            if(bllKH.getSoLuongKHDangGiaoDich()==0)
            {
                btnGiaoDich.ButtonText = "Bật giao dịch";
            }    
            else
            {
                btnGiaoDich.ButtonText = "Tắt giao dịch";
            }    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();

            }    
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text.Length == 0)
            {
                txtTimKiem.Focus();
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = bllKH.getTimKhachHangSDT(txtTimKiem.Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text.Length==0||txtSDT.Text.Length==0||txtDiaChi.Text.Length==0||txtTen.Text.Length==0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            else
            {
                bool kq = bllKH.getThemKH(txtMaKH.Text, txtTen.Text, txtSDT.Text, txtDiaChi.Text);
                if (kq == true)
                {
                    MessageBox.Show(this, "Thêm thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = bllKH.getloadKhachHang();
                }
                else
                {
                    MessageBox.Show(this, "Thêm không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length == 0 || txtSDT.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtTen.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool kq = bllKH.getSuaKH(txtMaKH.Text, txtTen.Text, txtSDT.Text, txtDiaChi.Text);
                if (kq == true)
                {
                    MessageBox.Show(this, "Sửa thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = bllKH.getloadKhachHang();
                }
                else
                {
                    MessageBox.Show(this, "Sửa không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
            
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length == 0)
            {
                MessageBox.Show(this, "Hãy nhập thông tin dầy đủ !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnGiaoDich.ButtonText.Equals("Bật giao dịch"))
                {
                    bool kq = bllKH.getBatTTGiaoDich(txtMaKH.Text);
                    if (kq == true)
                    {
                        MessageBox.Show(this, "Đã bật trạng thái giao dịch của " + txtMaKH.Text + ".", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbMaKH.Text = txtMaKH.Text;
                        dataGridView1.DataSource = bllKH.getloadKhachHang();
                        if (bllKH.getSoLuongKHDangGiaoDich() == 0)
                        {
                            btnGiaoDich.ButtonText = "Bật giao dịch";
                        }
                        else
                        {
                            btnGiaoDich.ButtonText = "Tắt giao dịch";
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Bật trạng thái giao dịch không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string id = bllKH.getTimMaKHBatGiaoDich();
                    bool kq1 = bllKH.getTatTTGiaoDich(id);
                    if (kq1 == true)
                    {
                        lbMaKH.Text = "";
                        MessageBox.Show(this, "Đã tắt trạng thái giao dịch của " + id + ".", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = bllKH.getloadKhachHang();
                        if (bllKH.getSoLuongKHDangGiaoDich() == 0)
                        {
                            btnGiaoDich.ButtonText = "Bật giao dịch";
                        }
                        else
                        {
                            btnGiaoDich.ButtonText = "Tắt giao dịch";
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Tắt trạng thái giao dịch không thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
