namespace EbebeynPcKontrol
{
    partial class HomePage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblKadi = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnUye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(236, 170);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Giriş";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(236, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Çıkış";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(152, 81);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(159, 20);
            this.txtKadi.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(152, 127);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(159, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblKadi
            // 
            this.lblKadi.AutoSize = true;
            this.lblKadi.Location = new System.Drawing.Point(82, 88);
            this.lblKadi.Name = "lblKadi";
            this.lblKadi.Size = new System.Drawing.Size(62, 13);
            this.lblKadi.TabIndex = 4;
            this.lblKadi.Text = "Kullancı Adi";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(82, 134);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(28, 13);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Şifre";
            // 
            // btnUye
            // 
            this.btnUye.Location = new System.Drawing.Point(236, 261);
            this.btnUye.Name = "btnUye";
            this.btnUye.Size = new System.Drawing.Size(75, 23);
            this.btnUye.TabIndex = 6;
            this.btnUye.Text = "Üye Ol";
            this.btnUye.UseVisualStyleBackColor = true;
            this.btnUye.Click += new System.EventHandler(this.btnUye_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 392);
            this.Controls.Add(this.btnUye);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblKadi);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblKadi;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnUye;
    }
}

