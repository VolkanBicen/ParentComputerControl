namespace EbebeynPcKontrol
{
    partial class AnaEkran
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
            this.components = new System.ComponentModel.Container();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAok = new System.Windows.Forms.Button();
            this.btnAclose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.message = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(604, 230);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(171, 20);
            this.txtKod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kodu Giriniz";
            // 
            // btnAok
            // 
            this.btnAok.Location = new System.Drawing.Point(669, 268);
            this.btnAok.Name = "btnAok";
            this.btnAok.Size = new System.Drawing.Size(106, 34);
            this.btnAok.TabIndex = 2;
            this.btnAok.Text = "Bilgisayarı Aç";
            this.btnAok.UseVisualStyleBackColor = true;
            this.btnAok.Click += new System.EventHandler(this.btnAok_Click);
            // 
            // btnAclose
            // 
            this.btnAclose.Location = new System.Drawing.Point(679, 322);
            this.btnAclose.Name = "btnAclose";
            this.btnAclose.Size = new System.Drawing.Size(96, 27);
            this.btnAclose.TabIndex = 3;
            this.btnAclose.Text = "Çıkış";
            this.btnAclose.UseVisualStyleBackColor = true;
            this.btnAclose.Click += new System.EventHandler(this.btnAclose_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(514, 99);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "4 DAKİKA İÇERİSİNDE BİLGİSAYARINIZ KAPATILACAK";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1023, 553);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.btnAclose);
            this.Controls.Add(this.btnAok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKod);
            this.Name = "AnaEkran";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tag = "t";
            this.Text = "AnaEkran";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaEkran_FormClosing);
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAok;
        private System.Windows.Forms.Button btnAclose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}