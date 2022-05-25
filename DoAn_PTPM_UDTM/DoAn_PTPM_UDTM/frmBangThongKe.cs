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
    public partial class frmBangThongKe : Form
    {
        public string tenDN { get; set; }
        public frmBangThongKe()
        {
            InitializeComponent();
        }
        public frmBangThongKe(string TenDN)
        {
            InitializeComponent();
            tenDN = TenDN;
            
        }
        BLL_HoaDon bllHD = new BLL_HoaDon();
        private void frmBangThongKe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllHD.getLoadHoaDon();
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            lbTongTien.Text = bllHD.getTongALL();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
