
namespace DoAn_PTPM_UDTM
{
    partial class frmCuaHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuaHang));
            this.flowLayoutSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnHienTatCaSP = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTimSP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.flowLayoutSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutSanPham
            // 
            this.flowLayoutSanPham.AutoScroll = true;
            this.flowLayoutSanPham.Controls.Add(this.lblThongBao);
            this.flowLayoutSanPham.Location = new System.Drawing.Point(24, 122);
            this.flowLayoutSanPham.Name = "flowLayoutSanPham";
            this.flowLayoutSanPham.Size = new System.Drawing.Size(1066, 599);
            this.flowLayoutSanPham.TabIndex = 0;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(3, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(1063, 46);
            this.lblThongBao.TabIndex = 2;
            this.lblThongBao.Text = "Không có sản phẩm nào.";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHienTatCaSP
            // 
            this.btnHienTatCaSP.ActiveBorderThickness = 1;
            this.btnHienTatCaSP.ActiveCornerRadius = 20;
            this.btnHienTatCaSP.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnHienTatCaSP.ActiveForecolor = System.Drawing.Color.White;
            this.btnHienTatCaSP.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnHienTatCaSP.BackColor = System.Drawing.SystemColors.Control;
            this.btnHienTatCaSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHienTatCaSP.BackgroundImage")));
            this.btnHienTatCaSP.ButtonText = "Hiện thị tất cả sản phẩm";
            this.btnHienTatCaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHienTatCaSP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienTatCaSP.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnHienTatCaSP.IdleBorderThickness = 1;
            this.btnHienTatCaSP.IdleCornerRadius = 20;
            this.btnHienTatCaSP.IdleFillColor = System.Drawing.Color.White;
            this.btnHienTatCaSP.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnHienTatCaSP.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnHienTatCaSP.Location = new System.Drawing.Point(24, 14);
            this.btnHienTatCaSP.Margin = new System.Windows.Forms.Padding(5);
            this.btnHienTatCaSP.Name = "btnHienTatCaSP";
            this.btnHienTatCaSP.Size = new System.Drawing.Size(288, 62);
            this.btnHienTatCaSP.TabIndex = 1;
            this.btnHienTatCaSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHienTatCaSP.Click += new System.EventHandler(this.btnHienTatCaSP_Click);
            // 
            // txtTimSP
            // 
            this.txtTimSP.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTimSP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimSP.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTimSP.BorderThickness = 3;
            this.txtTimSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimSP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimSP.isPassword = false;
            this.txtTimSP.Location = new System.Drawing.Point(639, 13);
            this.txtTimSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(395, 62);
            this.txtTimSP.TabIndex = 2;
            this.txtTimSP.Text = "Nhập sản phẩm cần tìm";
            this.txtTimSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimSP_KeyDown_1);
            // 
            // frmCuaHang
            // 
            this.ClientSize = new System.Drawing.Size(1123, 748);
            this.Controls.Add(this.txtTimSP);
            this.Controls.Add(this.btnHienTatCaSP);
            this.Controls.Add(this.flowLayoutSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCuaHang";
            this.Load += new System.EventHandler(this.frmCuaHang_Load_1);
            this.flowLayoutSanPham.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutSanPham;
        private System.Windows.Forms.Label lblThongBao;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHienTatCaSP;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimSP;
    }
}