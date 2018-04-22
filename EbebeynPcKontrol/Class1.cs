using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbebeynPcKontrol
{
    public class Class1
    {
        //mac adresi
     public static string mac { get; set; }
   //
   //İnternet kontrol
      static public bool kontrol ()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                return true;
            }
            catch (Exception )
            {
                
                return false;

            }
        }
        //

    }
}
