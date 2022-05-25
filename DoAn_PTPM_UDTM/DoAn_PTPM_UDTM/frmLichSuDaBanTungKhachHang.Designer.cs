
namespace DoAn_PTPM_UDTM
{
    partial class frmLichSuDaBanTungKhachHang
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
            this.flowLayoutSanPhamDaBan = new System.Windows.Forms.FlowLayoutPanel();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.flowLayoutSanPhamDaBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutSanPhamDaBan
            // 
            this.flowLayoutSanPhamDaBan.AutoScroll = true;
            this.flowLayoutSanPhamDaBan.Controls.Add(this.lblThongBao);
            this.flowLayoutSanPhamDaBan.Location = new System.Drawing.Point(36, 25);
            this.flowLayoutSanPhamDaBan.Name = "flowLayoutSanPhamDaBan";
            this.flowLayoutSanPhamDaBan.Size = new System.Drawing.Size(1066, 655);
            this.flowLayoutSanPhamDaBan.TabIndex = 1;
            this.flowLayoutSanPhamDaBan.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutSanPhamDaBan_Paint);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 703);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền :";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(206, 707);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(18, 20);
            this.lbTongTien.TabIndex = 3;
            this.lbTongTien.Text = "0";
            // 
            // frmLichSuDaBanTungKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1130, 769);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutSanPhamDaBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLichSuDaBanTungKhachHang";
            this.Text = "frmLichSuDaBanTungKhachHang";
            this.Load += new System.EventHandler(this.frmLichSuDaBanTungKhachHang_Load);
            this.flowLayoutSanPhamDaBan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutSanPhamDaBan;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTongTien;
    }
}