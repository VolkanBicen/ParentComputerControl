using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace EbebeynPcKontrol
{
    public partial class Uye : Form
    {
        
        public Uye()
        {
            InitializeComponent();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
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

                Properties.Settings.Default.sayac++;
                Properties.Settings.Default.Save();

                string url = "https://e-kontrol.volkanbicen.xyz/user/register?" +
                "&username=" + txtUKadi.Text + "&password=" + txtUpass.Text +
                "&password_confirmation=" + txtUTpass.Text +
                "&type=" + "pc" +
                "&mac=" + mac.ToString() +
                "&pc_name=" + bilgisayarAdi;
               // Debug.WriteLine(url);
                var request = (HttpWebRequest)WebRequest.Create(url);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                //kullanıcı adı ve şifreyi txt kaydet

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var output = JObject.Parse(responseString);
                // Debug.WriteLine(responseString);
                //  Debug.WriteLine(output["data"]["token"]);
                string path = Application.StartupPath.ToString();
               // StreamWriter sw;
                //sw = File.CreateText(path + "\\" + "log.txt");
                //sw.Close();
                try
                {
                    StreamReader Dosya = File.OpenText("log.txt");//Dosyayı açmaya çalış olmaz ise catch bloğuan geç
                    Dosya.Close();
                }
                catch
                {
                    StreamWriter Dosya = File.CreateText(path+"//"+"log.txt");// yeni dosya oluştur.
                    Dosya.Close();
                }
                try
                {
                    StreamWriter Dosya = File.AppendText("log.txt");//Dosyayı appendText ile yazmak için açtık

                    Dosya.WriteLine(txtUKadi.Text + "\n" + txtUpass.Text); // Dosya.WriteLine ile dosyaya isim ve soyisim text kutularındaki değerleri aralrına bir tab boşluk bırakarak ekledik.

                    Dosya.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DialogResult = MessageBox.Show("Başarılı bir şekilde üye oldunuz.", "Bilgilendirme",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (DialogResult == DialogResult.OK)
                {
                    HomePage home = new HomePage();
                    this.Visible = false;
                    home.ShowDialog();
                }
                else
                {
                    this.Close();
                    Application.Exit();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Tamamlanamadı\n"
                    +"Şifreler aynı değil veya Yukarıdaki Kullanıcı Adına ait başka bir kayıt var"+
                    "Wrong request ! " + ex.Message, "Error");
            }
        }

        private void Uye_Load(object sender, EventArgs e)
        {
           
           
        }

    }
}
