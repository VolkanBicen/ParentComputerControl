namespace EbebeynPcKontrol
{
    partial class Uye
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
            this.txtUKadi = new System.Windows.Forms.TextBox();
            this.txtUpass = new System.Windows.Forms.TextBox();
            this.txtUTpass = new System.Windows.Forms.TextBox();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUKadi
            // 
            this.txtUKadi.Location = new System.Drawing.Point(332, 79);
            this.txtUKadi.Name = "txtUKadi";
            this.txtUKadi.Size = new System.Drawing.Size(138, 20);
            this.txtUKadi.TabIndex = 0;
            // 
            // txtUpass
            // 
            this.txtUpass.Location = new System.Drawing.Point(332, 121);
            this.txtUpass.Name = "txtUpass";
            this.txtUpass.Size = new System.Drawing.Size(138, 20);
            this.txtUpass.TabIndex = 1;
            // 
            // txtUTpass
            // 
            this.txtUTpass.Location = new System.Drawing.Point(332, 172);
            this.txtUTpass.Name = "txtUTpass";
            this.txtUTpass.Size = new System.Drawing.Size(138, 20);
            this.txtUTpass.TabIndex = 2;
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(357, 229);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(75, 23);
            this.btnKayıt.TabIndex = 3;
            this.btnKayıt.Text = "Kayıt Ol";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullancı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre Tekrar";
            // 
            // Uye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.txtUTpass);
            this.Controls.Add(this.txtUpass);
            this.Controls.Add(this.txtUKadi);
            this.Name = "Uye";
            this.Text = "Uye";
            this.Load += new System.EventHandler(this.Uye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUKadi;
        private System.Windows.Forms.TextBox txtUpass;
        private System.Windows.Forms.TextBox txtUTpass;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}