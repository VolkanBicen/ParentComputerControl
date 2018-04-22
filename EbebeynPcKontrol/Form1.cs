using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbebeynPcKontrol
{

    public partial class HomePage : Form
    {
      
        public HomePage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtPass.ForeColor = Color.Black;
            txtPass.PasswordChar = '*';
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!",
             MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                //mac
                NetworkInterface[] arayuz;
                arayuz = NetworkInterface.GetAllNetworkInterfaces();
                PhysicalAddress mac;
                mac = arayuz[0].GetPhysicalAddress();
                //PcName
                string bilgisayarAdi = Dns.GetHostName();
                string url = "https://e-kontrol.volkanbicen.xyz/user/login?" +
                   "&username=" + txtKadi.Text + "&password=" + txtPass.Text +
                   "&type=" +"pc" +
                   "&mac=" + mac.ToString() +
                   "&pc_name=" + bilgisayarAdi.ToString();
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/x-www-form-urlencoded";
                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var output = JObject.Parse(responseString);
               /* MessageBox.Show(responseString);*/
                string a = (output["data"]["token"]).ToString();
                MessageBox.Show(a);
                try
                {
                    StreamWriter Dosya = File.AppendText("log.txt");//Dosyayı appendText ile yazmak için açtık

                    Dosya.WriteLine(a); // Dosya.WriteLine ile dosyaya isim ve soyisim text kutularındaki değerleri aralrına bir tab boşluk bırakarak ekledik.

                    Dosya.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AnaEkran ana = new AnaEkran();
                this.Visible = false;
                ana.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Adı şifre hatalı\n"+ ex.Message);
            }

        }

        private void btnUye_Click(object sender, EventArgs e)
        {
            Uye uyeol = new Uye();
            this.Visible = false;
            uyeol.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.sayac=0;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.sayac==3)
            {
                AnaEkran ana = new AnaEkran();
                this.Visible = false;
                ana.ShowDialog();
            }
            else
            {
                Properties.Settings.Default.sayac ++;
                Properties.Settings.Default.Save();

            }

        }
    }
}
