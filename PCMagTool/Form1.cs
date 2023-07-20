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
using System.Net; //ağ sınıfı
using System.Net.Sockets; //ağ soketi sınıfı
using System.Net.NetworkInformation; //ağ sınıfı
using System.DirectoryServices.ActiveDirectory; //activedirectory sınıfı
using System.Management; //yönetim sınıfı
using System.ServiceProcess; //servisler sınıfı

namespace PCMagTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PerformanceCounter performansCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter performansRAM = new PerformanceCounter("Memory", "% Committed Bytes In Use"); //Available MBytes
        PerformanceCounter performansDisk = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
        PerformanceCounter performansSistem = new PerformanceCounter("System", "System Up Time");

        public void islemler() //işlemler sekmesinde bulunan çalışan işlemleri gösteren kod bloğu.
        {
            Process[] islem = Process.GetProcesses();
            listView_islemler.Items.Clear();
            foreach (Process islemitem in islem)
            {
                string islemAdi = islemitem.ProcessName.ToString();
                string islemPID = islemitem.Id.ToString();
                string islemtest = islemitem.MainWindowTitle.ToString();
                string[] islemleriEkle = { islemAdi, islemPID, islemtest };
                listView_islemler.Items.Add(new ListViewItem(islemleriEkle));
            }
        }

        public void hizmetler() //hizmetler sekmesinde bulunan çalışan hizmetleri gösteren kod bloğu.
        {
            ServiceController[] hizmet = ServiceController.GetServices();
            listView_hizmetler.Items.Clear();
            foreach (ServiceController servisitem in hizmet)
            {
                string hizmetadi = servisitem.ServiceName;
                string hizmetdurumu = servisitem.Status.ToString();
                string hizmetaciklama = servisitem.DisplayName;
                string[] hizmetleriEkle = { hizmetadi, hizmetdurumu, hizmetaciklama };
                listView_hizmetler.Items.Add(new ListViewItem(hizmetleriEkle));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher AgBilgileri = new ManagementObjectSearcher("select * from Win32_NetworkAdapter"); //Ag bilgileri.
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

                ManagementObjectSearcher AnaKartBilgileri = new ManagementObjectSearcher("select * from Win32_BaseBoard"); //Ana Kart bilgileri.
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

                ManagementObjectSearcher BataryaBilgileri = new ManagementObjectSearcher("select * from Win32_Battery"); //Batarya bilgileri.
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

                ManagementObjectSearcher CPUBilgileri = new ManagementObjectSearcher("select * from Win32_Processor"); //cpu bilgileri.
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

                ManagementObjectSearcher DiskBilgileri = new ManagementObjectSearcher("select * from Win32_DiskDrive"); //disk bilgileri.
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

                ManagementObjectSearcher EkranBilgileri = new ManagementObjectSearcher("select * from Win32_DesktopMonitor"); //ekran bilgileri.
                foreach (ManagementObject EkranObje in EkranBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("İsim : " + EkranObje["Name"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Altyazı : " + EkranObje["Caption"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Açıklama : " + EkranObje["Description"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Üretici Firma : " + EkranObje["MonitorManufacturer"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Ekran Türü : " + EkranObje["DisplayType"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Monitör Türü : " + EkranObje["MonitorType"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Bant Genişliği : " + EkranObje["Bandwidth"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("X Piksel Başına Mantıksal İnç : " + EkranObje["PixelsPerXLogicalInch"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Y Piksel Başına Mantıksal İnç : " + EkranObje["PixelsPerYLogicalInch"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Yükseklik : " + EkranObje["ScreenHeight"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Genişlik : " + EkranObje["ScreenWidth"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Durum : " + EkranObje["Status"]);
                }

                ManagementObjectSearcher FanBilgileri = new ManagementObjectSearcher("select * from Win32_Fan"); //fan bilgileri.
                foreach (ManagementObject FanObje in FanBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("İsim : " + FanObje["Name"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Aktif Soğutma : " + FanObje["ActiveCooling"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Altyazı : " + FanObje["Caption"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Açıklama : " + FanObje["Description"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("İstenilen Hız : " + FanObje["DesiredSpeed"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Aygıt Kimlik : " + FanObje["DeviceID"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Değişken Hız : " + FanObje["VariableSpeed"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Durum : " + FanObje["Status"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher GPUBilgileri = new ManagementObjectSearcher("select * from Win32_VideoController"); //gpu bilgileri.
                foreach (ManagementObject GPUObje in GPUBilgileri.Get())
                {

                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Model : " + GPUObje["Name"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Açıklama : " + GPUObje["Description"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Marka : " + GPUObje["VideoProcessor"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Video Açıklama : " + GPUObje["VideoModeDescription"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Sürüm : " + GPUObje["DriverVersion"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Yatay Çözünürlük : " + GPUObje["CurrentHorizontalResolution"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Dikey Çözünürlük : " + GPUObje["CurrentVerticalResolution"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Yenileme Hızı : " + GPUObje["CurrentRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Maksimum Yenileme Hızı : " + GPUObje["MaxRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Minumum Yenileme Hızı : " + GPUObje["MinRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Bellek : " + GPUObje["AdapterRAM"] + " MB");
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Piksel Başına Geçerli Bit Sayısı : " + GPUObje["CurrentBitsPerPixel"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Adaptör Uyumluluğu : " + GPUObje["AdapterCompatibility"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher KlavyeBilgileri = new ManagementObjectSearcher("select * from Win32_Keyboard"); //klavye bilgileri.
                foreach (ManagementObject KlavyeObje in KlavyeBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("İsim : " + KlavyeObje["Name"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Altyazı : " + KlavyeObje["Caption"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Açıklama : " + KlavyeObje["Description"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Kilit : " + KlavyeObje["IsLocked"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Düzen : " + KlavyeObje["Layout"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Fonksiyon Tuşları Sayısı : " + KlavyeObje["NumberOfFunctionKeys"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Şifre : " + KlavyeObje["Password"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher DVDBilgileri = new ManagementObjectSearcher("select * from Win32_CDROMDrive"); //dvd rom bilgileri.
                foreach (ManagementObject DVDObje in DVDBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("İsim : " + DVDObje["Name"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Altyazı : " + DVDObje["Caption"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Açıklama : " + DVDObje["Description"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Ortam Türü : " + DVDObje["MediaType"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Kimlik : " + DVDObje["Id"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Üretici Firma : " + DVDObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Sürücü : " + DVDObje["Drive"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Transfer Oranı : " + DVDObje["TransferRate"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Sıkıştırma Yöntemi : " + DVDObje["CompressionMethod"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher RAMBilgileri = new ManagementObjectSearcher("select * from Win32_MemoryDevice"); //ram bilgileri.
                foreach (ManagementObject RAMObje in RAMBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Model : " + RAMObje["DeviceID"]);
                }

                ManagementObjectSearcher RAMBoyutu = new ManagementObjectSearcher("select * from Win32_OperatingSystem"); //ram boyutu.
                foreach (ManagementObject RAMObje2 in RAMBoyutu.Get())
                {
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Toplam Görünen Bellek : " + RAMObje2["TotalVisibleMemorySize"] + " KB");
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Boştaki Fiziksel Bellek : " + RAMObje2["FreePhysicalMemory"] + " KB");
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Toplam Sanal Bellek : " + RAMObje2["TotalVirtualMemorySize"] + " KB");
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Boştaki Sanal Bellek : " + RAMObje2["FreeVirtualMemory"] + " KB");
                }

                ManagementObjectSearcher SesBilgileri = new ManagementObjectSearcher("select * from Win32_SoundDevice"); //ses bilgileri.
                foreach (ManagementObject SesObje in SesBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("İsim : " + SesObje["Name"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("Açıklama : " + SesObje["Description"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("Altyaız : " + SesObje["Caption"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("Üretici Firma : " + SesObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("MPU401 Adresi : " + SesObje["MPU401Address"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("Ürüm Adı : " + SesObje["ProductName"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("Durum : " + SesObje["Status"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher BiosBilgileri = new ManagementObjectSearcher("select * from Win32_BIOS"); //bios bilgileri.
                foreach (ManagementObject BiosObje in BiosBilgileri.Get())
                {
                    treeView1.Nodes[1].Nodes.Add("İsim : " + BiosObje["Name"]);
                    treeView1.Nodes[1].Nodes.Add("Sürüm : " + BiosObje["Version"]);
                    treeView1.Nodes[1].Nodes.Add("Altyazı : " + BiosObje["Caption"]);
                    treeView1.Nodes[1].Nodes.Add("Açıklama : " + BiosObje["Description"]);
                    treeView1.Nodes[1].Nodes.Add("Geçerli Dil : " + BiosObje["CurrentLanguage"]);
                    treeView1.Nodes[1].Nodes.Add("Üretici Firma : " + BiosObje["Manufacturer"]);
                    treeView1.Nodes[1].Nodes.Add("Birincil BİOS : " + BiosObje["PrimaryBIOS"]);
                    treeView1.Nodes[1].Nodes.Add("Yayın Tarihi : " + BiosObje["ReleaseDate"]);
                    treeView1.Nodes[1].Nodes.Add("Seri No : " + BiosObje["SerialNumber"]);
                    treeView1.Nodes[1].Nodes.Add("SMBIOS Sürümü : " + BiosObje["SMBIOSBIOSVersion"]);
                }

                ManagementObjectSearcher KullaniciBilgileri = new ManagementObjectSearcher("select * from Win32_Account"); //kullanıcı bilgileri.
                foreach (ManagementObject KulObje in KullaniciBilgileri.Get())
                {
                    treeView1.Nodes[2].Nodes.Add("İsim : " + KulObje["Name"]);
                    treeView1.Nodes[2].Nodes.Add("Altyazı : " + KulObje["Caption"]);
                    treeView1.Nodes[2].Nodes.Add("Açıklama : " + KulObje["Description"]);
                    treeView1.Nodes[2].Nodes.Add("Domain : " + KulObje["Domain"]);
                    treeView1.Nodes[2].Nodes.Add("Yerel Hesap : " + KulObje["LocalAccount"]);
                    treeView1.Nodes[2].Nodes.Add("____________________________________________________________");
                }

                ManagementObjectSearcher OSBilgileri = new ManagementObjectSearcher("select * from Win32_OperatingSystem"); //işletim bilgileri.
                foreach (ManagementObject OSObje in OSBilgileri.Get())
                {
                    treeView1.Nodes[3].Nodes.Add("Üretici Firma : " + OSObje["Manufacturer"]);
                    treeView1.Nodes[3].Nodes.Add("Yapı Numarası : " + OSObje["BuildNumber"]);
                    treeView1.Nodes[3].Nodes.Add("Altyazı : " + OSObje["Caption"]);
                    treeView1.Nodes[3].Nodes.Add("Seri No : " + OSObje["SerialNumber"]);
                    treeView1.Nodes[3].Nodes.Add("Sürüm : " + OSObje["Version"]);
                    treeView1.Nodes[3].Nodes.Add("Kullanıcı Sayısı : " + OSObje["NumberOfUsers"]);
                    treeView1.Nodes[3].Nodes.Add("Sistem Aygıtı: " + OSObje["SystemDevice"]);
                    treeView1.Nodes[3].Nodes.Add("Sistem Dizini : " + OSObje["SystemDirectory"]);
                    treeView1.Nodes[3].Nodes.Add("Windows Dizini : " + OSObje["WindowsDirectory"]);
                }
                treeView1.Nodes[0].Expand(); //treeview1 sadece sıfırıncı dalı genişlet.

                timer1.Start(); //performans değerleri için gerekli olan timer.
                timer2.Stop();

                islemler();
                hizmetler();

                string hostName = Dns.GetHostName(); //hostname çekme.
                label_hostname.Text = hostName;

                string IP = Dns.GetHostEntry(hostName).AddressList[1].ToString(); ; //IP çekme.
                label_ipadresi.Text = IP;

                String macadress = string.Empty; //mac adresi.
                string mac = null;
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    OperationalStatus ot = nic.OperationalStatus;
                    if (nic.OperationalStatus == OperationalStatus.Up)
                    {
                        macadress = nic.GetPhysicalAddress().ToString();
                        break;
                    }
                }
                for (int i = 0; i <= macadress.Length - 1; i++)
                {
                    mac = mac + ":" + macadress.Substring(i, 2);

                    i++;
                }
                mac = mac.Remove(0, 1);
                label_mac.Text = mac;

                label_bit.Text = System.Environment.Is64BitOperatingSystem.ToString(); //sistem türü.

                if (label_bit.Text == "True")
                {
                    label_bit.Text = "x64";
                }
                else
                {
                    label_bit.Text = "x86";
                }

                label_isletimsistemi.Text = System.Environment.OSVersion.ToString(); //sistem versiyonu.

                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) //internet kontrolü.
                {
                    label_internet.Text = "Bağlantı Mevcut";
                }
                else
                {
                    label_internet.Text = "Bağlantı Başarısız";
                }
            }
            catch (Exception)
            {
                pictureBox_hata.Visible = true;
                label_hata.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Sağ alt linklabel.
        {
            Process sayfa_ac = new Process();
            sayfa_ac.StartInfo.UseShellExecute = true;
            sayfa_ac.StartInfo.FileName = "https://www.yazilimturkiye.com/";
            sayfa_ac.Start();
        }
        private void button_DisariAktar_Click(object sender, EventArgs e) //Treeview içeriğini dışarı aktarma.
        {
            timer2.Start();
            try
            {
                void TXTOlustur() //Treview içindeki veriyi aşağıdaki konumu dışarı aktaran kod bloğu.
                {
                    string kullanici_yolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    System.Text.StringBuilder buffer = new System.Text.StringBuilder();
                    foreach (TreeNode rootNode in treeView1.Nodes)
                        TreeViewOlustur(rootNode, buffer);
                    System.IO.File.WriteAllText(kullanici_yolu + "\\PCMagTool.txt", buffer.ToString());
                }

                void TreeViewOlustur(TreeNode rootNode, System.Text.StringBuilder buffer)
                {
                    buffer.Append(rootNode.Text);
                    buffer.Append(Environment.NewLine);
                    foreach (TreeNode childNode in rootNode.Nodes)
                        TreeViewOlustur(childNode, buffer);
                }
                TXTOlustur();
                pictureBox_hata.Visible = true;
                label_hata.Visible = true;
                pictureBox_hata.Image = Properties.Resources.gecerli;
                label_hata.Text = "İşlem başarılı. Dosya Masaüstüne kaydedildi.";

            }
            catch (Exception)
            {
                pictureBox_hata.Visible = true;
                label_hata.Visible = true;
                pictureBox_hata.Image = Properties.Resources.hata;
                label_hata.Text = "İşlem başarısız. Uygulamanın yönetici olarak çalıştırıldığına emin olun.";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = performansCPU.NextValue(); //Donanım sekmesindeki performans barlar.
            float fram = performansRAM.NextValue();
            float fdisk = performansDisk.NextValue();
            progressBar_cpu.Value = (int)fcpu;
            progressBar_ram.Value = (int)fram;
            progressBar_disk.Value = (int)fdisk;
            label_diskyuzde.Text = string.Format("{0:0.00}%", fdisk);
            label_cpuyuzde.Text = string.Format("{0:0.00}%", fcpu);
            label_ramyuzde.Text = string.Format("{0:0.00}%", fram);

            performansSistem.NextValue(); //PC Açık Kalma Süresi Hesaplama.
            TimeSpan ts = TimeSpan.FromSeconds(performansSistem.NextValue());
            label_acikliksure.Text = ts.Days.ToString() + ":" + ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString();

        }

        private void button_genislet_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll(); //treeview1 dallarını genişlet.
        }

        private void timer2_Tick(object sender, EventArgs e) //timer2
        {
            if (progressBar_islem.Value == 100)
            {
                timer2.Stop();
                progressBar_islem.Value = 0;
            }
            else
            {
                progressBar_islem.Value++;
            }
        }

        private void button_daralt_Click(object sender, EventArgs e) //treeview1 dallarını daralt.
        {
            treeView1.CollapseAll();
        }

        private void button_kopyaekle_Click(object sender, EventArgs e) //listview'e kopyalanan öğeyi ekle.
        {
            string zaman = DateTime.Now.ToLongTimeString();
            string kopyaekle = Clipboard.GetText();
            if (kopyaekle == string.Empty & zaman == String.Empty)
            {

            }
            else
            {
                string[] bilgiekle = { kopyaekle, zaman };
                listView_kopya.Items.Add(new ListViewItem(bilgiekle));
            }
        }

        private void button_kopyacikar_Click(object sender, EventArgs e) //listview'deki öğeti çıkart.
        {
            foreach (ListViewItem secilioge in listView_kopya.CheckedItems)
            {
                listView_kopya.Items.Remove(secilioge);
            }
        }

        private void button_kopyatemizle_Click(object sender, EventArgs e) //listview'e ekli olan itemleri silme.
        {
            listView_kopya.Items.Clear();
        }

        private void button_islemsonlandir_Click(object sender, EventArgs e) //islem sonlandırma.
        {
            try
            {
                Process[] islemsonlandir = null;
                string islemadi = listView_islemler.SelectedItems[0].Text;
                islemsonlandir = Process.GetProcessesByName(islemadi);
                foreach (Process proces in islemsonlandir)
                {
                    proces.Kill();
                }
                islemler();
            }
            catch (Exception)
            {
                pictureBox_hata.Visible = true;
                label_hata.Visible = true;
                label_hata.Text = "Seçili görev sonlandırılamadı.";
                pictureBox_hata.Image = Properties.Resources.hata;
            }
        }

        private void button_islemleryenile_Click(object sender, EventArgs e) //islemler listesini yenileme.
        {
            islemler();
        }

        private void button_hizmetsonlandir_Click(object sender, EventArgs e) //hizmet sonlandırma.
        {
            try
            {
                string hizmetadi = listView_hizmetler.SelectedItems[0].Text;
                ServiceController hizmet = new ServiceController(hizmetadi);
                if ((hizmet.Status.Equals(ServiceControllerStatus.StartPending)) || (hizmet.Status.Equals(ServiceControllerStatus.Running)))
                {
                    hizmet.Stop();
                    listView_hizmetler.Items.Clear();
                    hizmetler();
                }
                else
                {
                    pictureBox_hata.Visible = true;
                    label_hata.Visible = true;
                    label_hata.Text = "Seçili hizmet zaten çalışmıyor.";
                    pictureBox_hata.Image = Properties.Resources.hata;
                }
            }
            catch (Exception)
            {
                pictureBox_hata.Visible = true;
                label_hata.Visible = true;
                label_hata.Text = "Hizmet durdurulamadı. PCMagTool'u yönetici olarak çalıştırın.";
                pictureBox_hata.Image = Properties.Resources.hata;
            }

        }

        private void button_hizmetbaslat_Click(object sender, EventArgs e) //hizmet başlatma.
        {
            try
            {
                string hizmetadi = listView_hizmetler.SelectedItems[0].Text;
                ServiceController hizmet = new ServiceController(hizmetadi);
                if ((hizmet.Status.Equals(ServiceControllerStatus.StopPending)) || (hizmet.Status.Equals(ServiceControllerStatus.Stopped)))
                {
                    hizmet.Start();
                    listView_hizmetler.Items.Clear();
                    hizmetler();
                }
                else
                {
                    pictureBox_hata.Visible = true;
                    label_hata.Visible = true;
                    label_hata.Text = "Seçili hizmet zaten çalışıyor.";
                    pictureBox_hata.Image = Properties.Resources.hata;
                }
            }
            catch (Exception)
            {
                pictureBox_hata.Visible = true;
                label_hata.Visible = true;
                label_hata.Text = "Hizmet başlatılamadı. PCMagTool'u yönetici olarak çalıştırın.";
                pictureBox_hata.Image = Properties.Resources.hata;
            }
        }

        private void button_hizmetyenile_Click(object sender, EventArgs e) //hizmetler listesini yenileme.
        {
            hizmetler();
        }

        private void button_ayarlar_Click(object sender, EventArgs e) //ayarlar butonu.
        {
            try
            {
                Process ayarlar = new Process();
                ayarlar.StartInfo.UseShellExecute = true;
                ayarlar.StartInfo.FileName = "ms-settings:system";
                ayarlar.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Ayarlar açılamadı.\nPCMagTool'un yönetici olarak çalıştırıldığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_denetimmasasi_Click(object sender, EventArgs e) //denetim masası butonu.
        {
            try
            {
                Process denetim = new Process();
                denetim.StartInfo.UseShellExecute = true;
                denetim.StartInfo.FileName = "control";
                denetim.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Denetim Masası açılamadı.\nPCMagTool'un yönetici olarak çalıştırıldığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_gezgin_Click(object sender, EventArgs e) //windows gezgini butonu.
        {
            try
            {
                Process gezgin = new Process();
                gezgin.StartInfo.UseShellExecute = true;
                gezgin.StartInfo.FileName = "explorer";
                gezgin.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Windows Gezgini açılamadı.\nPCMagTool'un yönetici olarak çalıştırıldığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_hesapmakinasi_Click(object sender, EventArgs e) //hesap makinesi butonu.
        {
            try
            {
                Process hesap = new Process();
                hesap.StartInfo.UseShellExecute = true;
                hesap.StartInfo.FileName = "calc";
                hesap.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Hesap Makinesi açılamadı.\nPCMagTool'un yönetici olarak çalıştırıldığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_cmd_Click(object sender, EventArgs e) //cmd butonu.
        {
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.UseShellExecute = true;
                cmd.StartInfo.FileName = "cmd";
                cmd.StartInfo.WorkingDirectory = @"C:\";
                cmd.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Komut Satırı açılamadı.\nPCMagTool'un yönetici olarak çalıştırıldığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_ekranyakala_Click(object sender, EventArgs e) //ekran yakalama butonu.
        {
            try
            {
                Process ekran = new Process();
                ekran.StartInfo.UseShellExecute = true;
                ekran.StartInfo.FileName = "snippingtool";
                ekran.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Ekran Yakalama Aracı açılamadı.\nPCMagTool'un yönetici olarak çalıştırıldığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_disktemizleme_Click(object sender, EventArgs e) //Disk temizleme butonu.
        {
            try
            {
                Process ekran = new Process();
                ekran.StartInfo.UseShellExecute = true;
                ekran.StartInfo.FileName = "cleanmgr";
                ekran.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Disk Temizleme Aracı açılamadı.\nPCMagTool'un yönetici olarak çalıştırıldığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label_hostname_Click(object sender, EventArgs e) //hostname kopylama.
        {
            Clipboard.SetText(label_hostname.Text);
        }

        private void label_ipadresi_Click(object sender, EventArgs e) //IP adresi kopylama.
        {
            Clipboard.SetText(label_ipadresi.Text);
        }

        private void label_mac_Click(object sender, EventArgs e) //MAC adresi kopyalama.
        {
            Clipboard.SetText(label_mac.Text);
        }

        private void button_paint_Click(object sender, EventArgs e)
        {
            try
            {
                Process ekran = new Process();
                ekran.StartInfo.UseShellExecute = true;
                ekran.StartInfo.FileName = "mspaint";
                ekran.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Paint açılamadı.\nPCMagTool'un yönetici olarak çalıştırıldığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_gorevyoneticisi_Click(object sender, EventArgs e)
        {
            try
            {
                Process ekran = new Process();
                ekran.StartInfo.UseShellExecute = true;
                ekran.StartInfo.FileName = "taskmgr";
                ekran.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Görev Yöneticisi açılamadı.\nPCMagTool'un yönetici olarak çalıştırıldığından emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
