using System; //29.03.2022 yazilimturkiye.com
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;

namespace PCMagTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try //bilgisayar bilgileri alınıyor
            {
                string bilgisayarAdi = Dns.GetHostName();
                textBox_hostname.Text = bilgisayarAdi;

                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        textBox_ipadres.Text = ip.ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
