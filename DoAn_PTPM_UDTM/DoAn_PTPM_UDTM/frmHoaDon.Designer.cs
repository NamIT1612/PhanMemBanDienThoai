
namespace DoAn_PTPM_UDTM
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.lblChonALL = new System.Windows.Forms.Label();
            this.fowlayPnGioHang = new System.Windows.Forms.FlowLayoutPanel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.btnXuatBill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ckbChonALL = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.fowlayPnGioHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChonALL
            // 
            this.lblChonALL.AutoSize = true;
            this.lblChonALL.Font = new System.Drawing.Font("Segoe UI", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonALL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblChonALL.Location = new System.Drawing.Point(98, 30);
            this.lblChonALL.Name = "lblChonALL";
            this.lblChonALL.Size = new System.Drawing.Size(161, 30);
            this.lblChonALL.TabIndex = 16;
            this.lblChonALL.Text = "Bỏ chọn Tất Cả";
            // 
            // fowlayPnGioHang
            // 
            this.fowlayPnGioHang.AutoScroll = true;
            this.fowlayPnGioHang.Controls.Add(this.lblThongBao);
            this.fowlayPnGioHang.Location = new System.Drawing.Point(24, 82);
            this.fowlayPnGioHang.Name = "fowlayPnGioHang";
            this.fowlayPnGioHang.Size = new System.Drawing.Size(1070, 567);
            this.fowlayPnGioHang.TabIndex = 0;
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(3, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(1019, 46);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Không có sản phẩm trong giỏ hàng";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(711, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã khách hàng :";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(867, 37);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(49, 23);
            this.lbMaKH.TabIndex = 22;
            this.lbMaKH.Text = "XXX";
            // 
            // btnXuatBill
            // 
            this.btnXuatBill.ActiveBorderThickness = 1;
            this.btnXuatBill.ActiveCornerRadius = 20;
            this.btnXuatBill.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnXuatBill.ActiveForecolor = System.Drawing.Color.White;
            this.btnXuatBill.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnXuatBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnXuatBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatBill.BackgroundImage")));
            this.btnXuatBill.ButtonText = "Xuất hóa đơn";
            this.btnXuatBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBill.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXuatBill.IdleBorderThickness = 1;
            this.btnXuatBill.IdleCornerRadius = 20;
            this.btnXuatBill.IdleFillColor = System.Drawing.Color.White;
            this.btnXuatBill.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnXuatBill.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnXuatBill.Location = new System.Drawing.Point(785, 657);
            this.btnXuatBill.Margin = new System.Windows.Forms.Padding(5);
            this.btnXuatBill.Name = "btnXuatBill";
            this.btnXuatBill.Size = new System.Drawing.Size(261, 77);
            this.btnXuatBill.TabIndex = 19;
            this.btnXuatBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuatBill.Click += new System.EventHandler(this.btnXuatBill_Click);
            // 
            // ckbChonALL
            // 
            this.ckbChonALL.AllowBindingControlAnimation = true;
            this.ckbChonALL.AllowBindingControlColorChanges = false;
            this.ckbChonALL.AllowBindingControlLocation = true;
            this.ckbChonALL.AllowCheckBoxAnimation = false;
            this.ckbChonALL.AllowCheckmarkAnimation = true;
            this.ckbChonALL.AllowOnHoverStates = true;
            this.ckbChonALL.AutoCheck = true;
            this.ckbChonALL.BackColor = System.Drawing.Color.Transparent;
            this.ckbChonALL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ckbChonALL.BackgroundImage")));
            this.ckbChonALL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ckbChonALL.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.ckbChonALL.BorderRadius = 12;
            this.ckbChonALL.Checked = true;
            this.ckbChonALL.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.ckbChonALL.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckbChonALL.CustomCheckmarkImage = null;
            this.ckbChonALL.Location = new System.Drawing.Point(50, 30);
            this.ckbChonALL.MinimumSize = new System.Drawing.Size(17, 17);
            this.ckbChonALL.Name = "ckbChonALL";
            this.ckbChonALL.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ckbChonALL.OnCheck.BorderRadius = 12;
            this.ckbChonALL.OnCheck.BorderThickness = 2;
            this.ckbChonALL.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.ckbChonALL.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.ckbChonALL.OnCheck.CheckmarkThickness = 2;
            this.ckbChonALL.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.ckbChonALL.OnDisable.BorderRadius = 12;
            this.ckbChonALL.OnDisable.BorderThickness = 2;
            this.ckbChonALL.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckbChonALL.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.ckbChonALL.OnDisable.CheckmarkThickness = 2;
            this.ckbChonALL.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ckbChonALL.OnHoverChecked.BorderRadius = 12;
            this.ckbChonALL.OnHoverChecked.BorderThickness = 2;
            this.ckbChonALL.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ckbChonALL.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.ckbChonALL.OnHoverChecked.CheckmarkThickness = 2;
            this.ckbChonALL.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ckbChonALL.OnHoverUnchecked.BorderRadius = 12;
            this.ckbChonALL.OnHoverUnchecked.BorderThickness = 1;
            this.ckbChonALL.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckbChonALL.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.ckbChonALL.OnUncheck.BorderRadius = 12;
            this.ckbChonALL.OnUncheck.BorderThickness = 1;
            this.ckbChonALL.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckbChonALL.Size = new System.Drawing.Size(30, 30);
            this.ckbChonALL.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.ckbChonALL.TabIndex = 18;
            this.ckbChonALL.ThreeState = false;
            this.ckbChonALL.ToolTipText = null;
            this.ckbChonALL.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.ckbChonALL_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 681);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tổng tiền :";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(151, 685);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(0, 20);
            this.lbTongTien.TabIndex = 24;
            // 
            // frmHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1123, 748);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMaKH);
            this.Controls.Add(this.fowlayPnGioHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXuatBill);
            this.Controls.Add(this.lblChonALL);
            this.Controls.Add(this.ckbChonALL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Text = "frmHoDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.fowlayPnGioHang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChonALL;
        private Bunifu.UI.WinForms.BunifuCheckBox ckbChonALL;
        private System.Windows.Forms.FlowLayoutPanel fowlayPnGioHang;
        private System.Windows.Forms.Label lblThongBao;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXuatBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTongTien;
    }
}