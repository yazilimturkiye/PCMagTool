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
                ManagementObjectSearcher AgBilgileri = new ManagementObjectSearcher("select * from Win32_NetworkAdapter"); //Ag bilgileri
                foreach (ManagementObject AgObje in AgBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("İsim : " + AgObje["Name"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Ürün Adı : " + AgObje["ProductName"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Üretici firma : " + AgObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Altyazı : " + AgObje["Caption"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Açıklama : " + AgObje["Description"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Durum : " + AgObje["Status"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Hız : " + AgObje["Speed"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Maksimum Hız : " + AgObje["MaxSpeed"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Servis Adı : " + AgObje["ServiceName"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Adaptör Tipi : " + AgObje["AdapterType"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Adaptör Kimlik : " + AgObje["AdapterTypeID"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Aygıt Kimlik : " + AgObje["DeviceID"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("GUID : " + AgObje["GUID"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("MAC Adres : " + AgObje["MACAddress"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Ağ Bağlantısı Kimliği : " + AgObje["NetConnectionID"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Ağ Bağlantısı Durumu : " + AgObje["NetConnectionStatus"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Ağ Etkin : " + AgObje["NetEnabled"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Fiziksel Adaptör : " + AgObje["PhysicalAdapter"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher AnaKartBilgileri = new ManagementObjectSearcher("select * from Win32_BaseBoard"); //Ana Kart bilgileri
                foreach (ManagementObject AnaKartObje in AnaKartBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Üretici firma : " + AnaKartObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Açıklama : " + AnaKartObje["Description"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Model : " + AnaKartObje["Model"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("İsim : " + AnaKartObje["Name"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Altyazı : " + AnaKartObje["Caption"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Ürün : " + AnaKartObje["Product"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Seri No : " + AnaKartObje["SerialNumber"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Etiket : " + AnaKartObje["Tag"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Sürüm : " + AnaKartObje["Version"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Barındırma Kurulu : " + AnaKartObje["HostingBoard"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Çalışırken Değiştirilebilir : " + AnaKartObje["HotSwappable"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Çıkarılabilir : " + AnaKartObje["Removable"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Değiştirilebilir : " + AnaKartObje["Replaceable"]);
                }

                ManagementObjectSearcher BataryaBilgileri = new ManagementObjectSearcher("select * from Win32_Battery"); //Batarya bilgileri
                foreach (ManagementObject BataryaObje in BataryaBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("İsim : " + BataryaObje["Name"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Altyazı : " + BataryaObje["Caption"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Açıklama : " + BataryaObje["Description"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Durum: " + BataryaObje["Status"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Kimya : " + BataryaObje["Chemistry"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Aygıt Kimlik : " + BataryaObje["DeviceID"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Pil Şarj Süresi : " + BataryaObje["BatteryRechargeTime"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Pil Durumu : " + BataryaObje["BatteryStatus"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Tasarım kapasitesi : " + BataryaObje["DesignCapacity"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Tasarım Voltajı : " + BataryaObje["DesignVoltage"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Kalan Tahmini Ömür : " + BataryaObje["EstimatedChargeRemaining"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Tahmini Çalışma Süresi : " + BataryaObje["EstimatedRunTime"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Beklenen Pil Ömrü : " + BataryaObje["ExpectedBatteryLife"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Beklenen Ömür : " + BataryaObje["ExpectedLife"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Tam Şarj Kapasitesi : " + BataryaObje["FullChargeCapacity"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Akıllı Pil Sürümü : " + BataryaObje["SmartBatteryVersion"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Pilde Zaman : " + BataryaObje["TimeOnBattery"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Doldurma Süresi : " + BataryaObje["TimeToFullCharge"]);
                }

                ManagementObjectSearcher CPUBilgileri = new ManagementObjectSearcher("select * from Win32_Processor"); //cpu bilgileri
                foreach (ManagementObject CPUObje in CPUBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Model : " + CPUObje["Name"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Açıklama : " + CPUObje["Description"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Kimlik : " + CPUObje["ProcessorId"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Temel Hız : " + CPUObje["MaxClockSpeed"] + " GHz");
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Çekirdek Sayısı : " + CPUObje["NumberOfCores"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Aktif Çekirdek Sayısı: " + CPUObje["NumberOfEnabledCore"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Mantıksal Çekirdek Sayısı : " + CPUObje["NumberOfLogicalProcessors"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Voltaj : " + CPUObje["CurrentVoltage"] + " V");
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Sanallaştırma Ürün Yazılımı : " + CPUObje["VirtualizationFirmwareEnabled"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("VM İzleme Modu Uzantıları : " + CPUObje["VMMonitorModeExtensions"]);
                }

                ManagementObjectSearcher DiskBilgileri = new ManagementObjectSearcher("select * from Win32_DiskDrive"); //disk bilgileri
                foreach (ManagementObject DiskObje in DiskBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("İsim : " + DiskObje["Name"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Model : " + DiskObje["Model"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Altyazı : " + DiskObje["Caption"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Açıklama : " + DiskObje["Description"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Üretici Firma : " + DiskObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Boyut : " + DiskObje["Size"] + " KB");
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Seri Numarası : " + DiskObje["SerialNumber"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Sektör Başına Bayt : " + DiskObje["BytesPerSector"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Sıkıştırma yöntemi : " + DiskObje["CompressionMethod"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Varsayılan Blok Boyutu : " + DiskObje["DefaultBlockSize"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Aygıt Kimlik : " + DiskObje["DeviceID"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Sürüm Revizyonu : " + DiskObje["FirmwareRevision"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Arayüz Türü : " + DiskObje["InterfaceType"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Maksimum Blok Boyutu : " + DiskObje["MaxBlockSize"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Minumum Blok Boyutu : " + DiskObje["MinBlockSize"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Maksimum Ortam Boyutu : " + DiskObje["MaxMediaSize"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Yüklene Ortam : " + DiskObje["MediaLoaded"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Ortam Türü : " + DiskObje["MediaType"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Temizlik İhtiyacı : " + DiskObje["NeedsCleaning"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Desteklenen Ortam Sayısı : " + DiskObje["NumberOfMediaSupported"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Bölümler : " + DiskObje["Partitions"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Durum : " + DiskObje["Status"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Durum Bilgisi : " + DiskObje["StatusInfo"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Toplam Silindir : " + DiskObje["TotalCylinders"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Toplam Başlık : " + DiskObje["TotalHeads"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Toplam Sektör : " + DiskObje["TotalSectors"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Toplam Parça : " + DiskObje["TotalTracks"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Silindir Başına Parça : " + DiskObje["TracksPerCylinder"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("İmza : " + DiskObje["Signature"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("SCSIBus : " + DiskObje["SCSIBus"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("SCSI Lojik Birim : " + DiskObje["SCSILogicalUnit"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("SCSI Port : " + DiskObje["SCSIPort"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("SCSI Hedef Kimlik : " + DiskObje["SCSITargetId"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Parça Başına Sektör : " + DiskObje["SectorsPerTrack"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("____________________________________________________________");

                }

                ManagementObjectSearcher FanBilgileri = new ManagementObjectSearcher("select * from Win32_Fan"); //fan bilgileri
                foreach (ManagementObject FanObje in FanBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("İsim : " + FanObje["Name"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Aktif Soğutma : " + FanObje["ActiveCooling"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Altyazı : " + FanObje["Caption"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Açıklama : " + FanObje["Description"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("İstenilen Hız : " + FanObje["DesiredSpeed"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Aygıt Kimlik : " + FanObje["DeviceID"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Değişken Hız : " + FanObje["VariableSpeed"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Durum : " + FanObje["Status"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher GPUBilgileri = new ManagementObjectSearcher("select * from Win32_VideoController"); //gpu bilgileri
                foreach (ManagementObject GPUObje in GPUBilgileri.Get())
                {

                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Model : " + GPUObje["Name"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Açıklama : " + GPUObje["Description"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Marka : " + GPUObje["VideoProcessor"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Video Açıklama : " + GPUObje["VideoModeDescription"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Sürüm : " + GPUObje["DriverVersion"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Yatay Çözünürlük : " + GPUObje["CurrentHorizontalResolution"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Dikey Çözünürlük : " + GPUObje["CurrentVerticalResolution"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Yenileme Hızı : " + GPUObje["CurrentRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Maksimum Yenileme Hızı : " + GPUObje["MaxRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Minumum Yenileme Hızı : " + GPUObje["MinRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Bellek : " + GPUObje["AdapterRAM"] + " MB");
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Piksel Başına Geçerli Bit Sayısı : " + GPUObje["CurrentBitsPerPixel"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Adaptör Uyumluluğu : " + GPUObje["AdapterCompatibility"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher KlavyeBilgileri = new ManagementObjectSearcher("select * from Win32_Keyboard"); //klavye bilgileri
                foreach (ManagementObject KlavyeObje in KlavyeBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("İsim : " + KlavyeObje["Name"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Altyazı : " + KlavyeObje["Caption"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Açıklama : " + KlavyeObje["Description"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Kilit : " + KlavyeObje["IsLocked"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Düzen : " + KlavyeObje["Layout"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Fonksiyon Tuşları Sayısı : " + KlavyeObje["NumberOfFunctionKeys"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Şifre : " + KlavyeObje["Password"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher DVDBilgileri = new ManagementObjectSearcher("select * from Win32_CDROMDrive"); //dvd rom bilgileri
                foreach (ManagementObject DVDObje in DVDBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("İsim : " + DVDObje["Name"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Altyazı : " + DVDObje["Caption"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Açıklama : " + DVDObje["Description"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Ortam Türü : " + DVDObje["MediaType"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Kimlik : " + DVDObje["Id"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Üretici Firma : " + DVDObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Sürücü : " + DVDObje["Drive"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Transfer Oranı : " + DVDObje["TransferRate"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Sıkıştırma Yöntemi : " + DVDObje["CompressionMethod"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher RAMBilgileri = new ManagementObjectSearcher("select * from Win32_MemoryDevice"); //ram bilgileri
                foreach (ManagementObject RAMObje in RAMBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Model : " + RAMObje["DeviceID"]);
                }

                ManagementObjectSearcher RAMBoyutu = new ManagementObjectSearcher("select * from Win32_OperatingSystem"); //ram boyutu
                foreach (ManagementObject RAMObje2 in RAMBoyutu.Get())
                {
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Toplam Görünen Bellek : " + RAMObje2["TotalVisibleMemorySize"] + " KB");
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Boştaki Fiziksel Bellek : " + RAMObje2["FreePhysicalMemory"] + " KB");
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Toplam Sanal Bellek : " + RAMObje2["TotalVirtualMemorySize"] + " KB");
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Boştaki Sanal Bellek : " + RAMObje2["FreeVirtualMemory"] + " KB");
                }

                ManagementObjectSearcher SesBilgileri = new ManagementObjectSearcher("select * from Win32_SoundDevice"); //ses bilgileri
                foreach (ManagementObject SesObje in SesBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("İsim : " + SesObje["Name"]);
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Açıklama : " + SesObje["Description"]);
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Altyaız : " + SesObje["Caption"]);
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Üretici Firma : " + SesObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("MPU401 Adresi : " + SesObje["MPU401Address"]);
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Ürüm Adı : " + SesObje["ProductName"]);
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Durum : " + SesObje["Status"]);
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("____________________________________________________________");
                }

            }
            catch (Exception)
            {
                throw;
            }
           
        }
    }
}
