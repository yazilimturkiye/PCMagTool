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
            try
            {
                ManagementObjectSearcher CPUBilgileri = new ManagementObjectSearcher("select * from Win32_Processor"); //cpu bilgileri
                foreach (ManagementObject CPUObje in CPUBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Model : " + CPUObje["Name"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Açıklama : " + CPUObje["Description"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Kimlik : " + CPUObje["ProcessorId"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Temel Hız : " + CPUObje["MaxClockSpeed"] + " GHz");
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Çekirdek Sayısı : " + CPUObje["NumberOfCores"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Aktif Çekirdek Sayısı: " + CPUObje["NumberOfEnabledCore"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Mantıksal Çekirdek Sayısı : " + CPUObje["NumberOfLogicalProcessors"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Voltaj : " + CPUObje["CurrentVoltage"] + " V");
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Sanallaştırma Ürün Yazılımı : " + CPUObje["VirtualizationFirmwareEnabled"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("VM İzleme Modu Uzantıları : " + CPUObje["VMMonitorModeExtensions"]);
                }

                ManagementObjectSearcher GPUBilgileri = new ManagementObjectSearcher("select * from Win32_VideoController"); //gpu bilgileri
                foreach (ManagementObject GPUObje in GPUBilgileri.Get())
                {

                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Model : " + GPUObje["Name"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Açıklama : " + GPUObje["Description"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Marka : " + GPUObje["VideoProcessor"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Video Açıklama: " + GPUObje["VideoModeDescription"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Sürüm : " + GPUObje["DriverVersion"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Yatay Çözünürlük : " + GPUObje["CurrentHorizontalResolution"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Dikey Çözünürlük : " + GPUObje["CurrentVerticalResolution"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Yenileme Hızı : " + GPUObje["CurrentRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Maksimum Yenileme Hızı : " + GPUObje["MaxRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Minumum Yenileme Hızı : " + GPUObje["MinRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Bellek : " + GPUObje["AdapterRAM"] + " MB");
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Piksel Başına Geçerli Bit Sayısı : " + GPUObje["CurrentBitsPerPixel"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Adaptör Uyumluluğu : " + GPUObje["AdapterCompatibility"]);
                }

                ManagementObjectSearcher RAMBilgileri = new ManagementObjectSearcher("select * from Win32_MemoryDevice"); //ram bilgileri
                foreach (ManagementObject RAMObje in RAMBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Model : " + RAMObje["DeviceID"]);
                }

                ManagementObjectSearcher RAMBoyutu = new ManagementObjectSearcher("select * from Win32_OperatingSystem"); //ram boyutu
                foreach (ManagementObject RAMObje2 in RAMBoyutu.Get())
                {
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Toplam Görünen Bellek : " + RAMObje2["TotalVisibleMemorySize"] + " KB");
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Boştaki Fiziksel Bellek : " + RAMObje2["FreePhysicalMemory"] + " KB");
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Toplam Sanal Bellek : " + RAMObje2["TotalVirtualMemorySize"] + " KB");
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Boştaki Sanal Bellek : " + RAMObje2["FreeVirtualMemory"] + " KB");
                }

                ManagementObjectSearcher AnaKartBilgileri = new ManagementObjectSearcher("select * from Win32_BaseBoard"); //Ana Kart bilgileri
                foreach (ManagementObject AnaKartObje in AnaKartBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Üretici firma : " + AnaKartObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Açıklama : " + AnaKartObje["Description"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Model : " + AnaKartObje["Model"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("İsim : " + AnaKartObje["Name"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Altyazı : " + AnaKartObje["Caption"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Ürün : " + AnaKartObje["Product"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Seri No : " + AnaKartObje["SerialNumber"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Etiket : " + AnaKartObje["Tag"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Sürüm : " + AnaKartObje["Version"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Barındırma Kurulu : " + AnaKartObje["HostingBoard"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Çalışırken Değiştirilebilir : " + AnaKartObje["HotSwappable"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Çıkarılabilir : " + AnaKartObje["Removable"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Değiştirilebilir : " + AnaKartObje["Replaceable"]);
                }

            }
            catch (Exception)
            {
                throw;
            }
           
        }
    }
}
