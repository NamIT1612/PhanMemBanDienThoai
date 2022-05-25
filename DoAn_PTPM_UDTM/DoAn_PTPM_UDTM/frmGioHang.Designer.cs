
namespace DoAn_PTPM_UDTM
{
    partial class frmGioHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGioHang));
            this.label1 = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuongMua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSoLuongTonKho = new System.Windows.Forms.Label();
            this.btnThemGioHang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(213, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá :";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(351, 99);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(39, 20);
            this.lbGia.TabIndex = 1;
            this.lbGia.Text = "Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng mua :";
            // 
            // txtSoLuongMua
            // 
            this.txtSoLuongMua.Location = new System.Drawing.Point(355, 222);
            this.txtSoLuongMua.Name = "txtSoLuongMua";
            this.txtSoLuongMua.Size = new System.Drawing.Size(89, 26);
            this.txtSoLuongMua.TabIndex = 3;
            this.txtSoLuongMua.TextChanged += new System.EventHandler(this.txtSoLuongMua_TextChanged);
            this.txtSoLuongMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongMua_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền :";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(361, 286);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(83, 20);
            this.lbTongTien.TabIndex = 5;
            this.lbTongTien.Text = "0000 VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng tồn kho :";
            // 
            // lbSoLuongTonKho
            // 
            this.lbSoLuongTonKho.AutoSize = true;
            this.lbSoLuongTonKho.Location = new System.Drawing.Point(351, 161);
            this.lbSoLuongTonKho.Name = "lbSoLuongTonKho";
            this.lbSoLuongTonKho.Size = new System.Drawing.Size(72, 20);
            this.lbSoLuongTonKho.TabIndex = 7;
            this.lbSoLuongTonKho.Text = "Số lượng";
            // 
            // btnThemGioHang
            // 
            this.btnThemGioHang.ActiveBorderThickness = 1;
            this.btnThemGioHang.ActiveCornerRadius = 20;
            this.btnThemGioHang.ActiveFillColor = System.Drawing.Color.Blue;
            this.btnThemGioHang.ActiveForecolor = System.Drawing.Color.White;
            this.btnThemGioHang.ActiveLineColor = System.Drawing.Color.Blue;
            this.btnThemGioHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemGioHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemGioHang.BackgroundImage")));
            this.btnThemGioHang.ButtonText = "Thêm vào hóa đơn";
            this.btnThemGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemGioHang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGioHang.ForeColor = System.Drawing.Color.Black;
            this.btnThemGioHang.IdleBorderThickness = 1;
            this.btnThemGioHang.IdleCornerRadius = 20;
            this.btnThemGioHang.IdleFillColor = System.Drawing.Color.Aqua;
            this.btnThemGioHang.IdleForecolor = System.Drawing.Color.Black;
            this.btnThemGioHang.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemGioHang.Location = new System.Drawing.Point(174, 392);
            this.btnThemGioHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemGioHang.Name = "btnThemGioHang";
            this.btnThemGioHang.Size = new System.Drawing.Size(249, 60);
            this.btnThemGioHang.TabIndex = 8;
            this.btnThemGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemGioHang.Click += new System.EventHandler(this.btnThemGioHang_Click);
            // 
            // frmGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 539);
            this.Controls.Add(this.btnThemGioHang);
            this.Controls.Add(this.lbSoLuongTonKho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoLuongMua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn đã chọn";
            this.Load += new System.EventHandler(this.frmGioHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuongMua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSoLuongTonKho;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThemGioHang;
    }
}