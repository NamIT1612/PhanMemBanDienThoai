
namespace DoAn_PTPM_UDTM
{
    partial class ItemSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSanPham));
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.picThemVaoGioHang = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.picSP = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThemVaoGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.BackColor = System.Drawing.Color.Transparent;
            this.lblGia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.Red;
            this.lblGia.Location = new System.Drawing.Point(56, 284);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(53, 23);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá :";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(56, 307);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(137, 23);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "Tên sản phẩm :";
            // 
            // picThemVaoGioHang
            // 
            this.picThemVaoGioHang.AllowFocused = false;
            this.picThemVaoGioHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picThemVaoGioHang.AutoSizeHeight = true;
            this.picThemVaoGioHang.BorderRadius = 31;
            this.picThemVaoGioHang.Image = ((System.Drawing.Image)(resources.GetObject("picThemVaoGioHang.Image")));
            this.picThemVaoGioHang.IsCircle = true;
            this.picThemVaoGioHang.Location = new System.Drawing.Point(255, 13);
            this.picThemVaoGioHang.Name = "picThemVaoGioHang";
            this.picThemVaoGioHang.Size = new System.Drawing.Size(62, 62);
            this.picThemVaoGioHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThemVaoGioHang.TabIndex = 1;
            this.picThemVaoGioHang.TabStop = false;
            this.picThemVaoGioHang.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.picThemVaoGioHang.Click += new System.EventHandler(this.picThemVaoGioHang_Click);
            // 
            // picSP
            // 
            this.picSP.AllowFocused = false;
            this.picSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSP.AutoSizeHeight = true;
            this.picSP.BorderRadius = 118;
            this.picSP.Image = ((System.Drawing.Image)(resources.GetObject("picSP.Image")));
            this.picSP.IsCircle = true;
            this.picSP.Location = new System.Drawing.Point(55, 55);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(237, 237);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSP.TabIndex = 0;
            this.picSP.TabStop = false;
            this.picSP.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.picSP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSP_MouseMove);
            // 
            // ItemSanPham
            // 
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BorderRadius = 50;
            this.BorderThickness = 6;
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.picThemVaoGioHang);
            this.Controls.Add(this.picSP);
            this.Name = "ItemSanPham";
            this.Size = new System.Drawing.Size(332, 370);
            this.Load += new System.EventHandler(this.ItemSanPham_Load_1);
            this.Click += new System.EventHandler(this.ItemSanPham_Click);
            this.MouseLeave += new System.EventHandler(this.ItemSanPham_MouseLeave_1);
            ((System.ComponentModel.ISupportInitialize)(this.picThemVaoGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox picSP;
        private Bunifu.UI.WinForms.BunifuPictureBox picThemVaoGioHang;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenSP;
    }
}
