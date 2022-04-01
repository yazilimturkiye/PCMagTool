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
using System.Net.NetworkInformation;
using System.DirectoryServices.ActiveDirectory;
using System.Management;

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
            treeView1.ExpandAll();
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            foreach (ManagementObject obj in myVideoObject.Get())
            {
                TreeNode dugum_bilgisayar = new TreeNode();
                treeView1.Nodes.Add(dugum_bilgisayar);
                dugum_bilgisayar.Parent.Nodes.Add("Bilgisayar Modeli :" + obj["Name"]);
                Console.WriteLine("Status  -  " + obj["Status"]);
                Console.WriteLine("Caption  -  " + obj["Caption"]);
                Console.WriteLine("DeviceID  -  " + obj["DeviceID"]);
                Console.WriteLine("AdapterRAM  -  " + obj["AdapterRAM"]);
                Console.WriteLine("AdapterDACType  -  " + obj["AdapterDACType"]);
                Console.WriteLine("Monochrome  -  " + obj["Monochrome"]);
                Console.WriteLine("InstalledDisplayDrivers  -  " + obj["InstalledDisplayDrivers"]);
                Console.WriteLine("DriverVersion  -  " + obj["DriverVersion"]);
                Console.WriteLine("VideoProcessor  -  " + obj["VideoProcessor"]);
                Console.WriteLine("VideoArchitecture  -  " + obj["VideoArchitecture"]);
                Console.WriteLine("VideoMemoryType  -  " + obj["VideoMemoryType"]);
            }
        }
    }
}
