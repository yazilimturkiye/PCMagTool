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
using Microsoft.Win32;
using System.Reflection.Emit;

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
        PerformanceCounter performansCPUutilization = new PerformanceCounter("Processor", "% Processor Time", "_Total");

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
        private void islemsayac() //Count all windows services
        {
            int processCount = Process.GetProcesses().Length;
            label_process_count.Text = processCount.ToString();
        }
        private void hizmetsayac()
        {
            ServiceController[] services = ServiceController.GetServices();
            int serviceCount = services.Length;
            label_services_count.Text = serviceCount.ToString();
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
                islemsayac();
                hizmetsayac();
                //Network Adapters Informations
                ManagementObjectSearcher AgBilgileri = new ManagementObjectSearcher("select * from Win32_NetworkAdapter");
                foreach (ManagementObject AgObje in AgBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Name : " + AgObje["Name"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Product Name : " + AgObje["ProductName"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Manufacturer : " + AgObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Caption : " + AgObje["Caption"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Description : " + AgObje["Description"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Status : " + AgObje["Status"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Speed : " + AgObje["Speed"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Max Speed : " + AgObje["MaxSpeed"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Service Name : " + AgObje["ServiceName"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Adapter Type : " + AgObje["AdapterType"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Adapter Type ID : " + AgObje["AdapterTypeID"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Device ID : " + AgObje["DeviceID"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("GUID : " + AgObje["GUID"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("MAC : " + AgObje["MACAddress"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Net Connection ID : " + AgObje["NetConnectionID"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Net Connection Status : " + AgObje["NetConnectionStatus"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Net Enabled : " + AgObje["NetEnabled"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Physical Adapter : " + AgObje["PhysicalAdapter"]);
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("____________________________________________________________");
                }
                //MotherBoard Info
                ManagementObjectSearcher AnaKartBilgileri = new ManagementObjectSearcher("select * from Win32_BaseBoard");
                foreach (ManagementObject AnaKartObje in AnaKartBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Manufacturer : " + AnaKartObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Description : " + AnaKartObje["Description"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Model : " + AnaKartObje["Model"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Name : " + AnaKartObje["Name"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Product : " + AnaKartObje["Product"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Serial Number : " + AnaKartObje["SerialNumber"]);
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("Version : " + AnaKartObje["Version"]);
                }
                //Battery Info
                ManagementObjectSearcher BataryaBilgileri = new ManagementObjectSearcher("select * from Win32_Battery");
                foreach (ManagementObject BataryaObje in BataryaBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Name : " + BataryaObje["Name"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Caption : " + BataryaObje["Caption"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Description : " + BataryaObje["Description"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Status: " + BataryaObje["Status"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Chemistry : " + BataryaObje["Chemistry"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Device ID : " + BataryaObje["DeviceID"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Battery Recharge Time : " + BataryaObje["BatteryRechargeTime"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Battery Status : " + BataryaObje["BatteryStatus"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Design Capacity : " + BataryaObje["DesignCapacity"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Design Voltage : " + BataryaObje["DesignVoltage"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Estimated Charge Remaining : " + BataryaObje["EstimatedChargeRemaining"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Estimated Run Time : " + BataryaObje["EstimatedRunTime"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Expected Battery Life : " + BataryaObje["ExpectedBatteryLife"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Expected Life : " + BataryaObje["ExpectedLife"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Full Charge Capacity : " + BataryaObje["FullChargeCapacity"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Smart Battery Version : " + BataryaObje["SmartBatteryVersion"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Time On Battery : " + BataryaObje["TimeOnBattery"]);
                    treeView1.Nodes[0].Nodes[2].Nodes.Add("Time To Full Charge : " + BataryaObje["TimeToFullCharge"]);
                }
                //CPU Info
                ManagementObjectSearcher CPUBilgileri = new ManagementObjectSearcher("select * from Win32_Processor");
                foreach (ManagementObject CPUObje in CPUBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Model : " + CPUObje["Name"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Description : " + CPUObje["Description"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Processor Id : " + CPUObje["ProcessorId"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Max Clock Speed : " + CPUObje["MaxClockSpeed"] + " GHz");
                    label_cpu_maxspeed.Text = CPUObje["MaxClockSpeed"] + " GHz".ToString();
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Number Of Cores : " + CPUObje["NumberOfCores"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Number Of Enabled Core : " + CPUObje["NumberOfEnabledCore"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Number Of Logical Processors : " + CPUObje["NumberOfLogicalProcessors"]);
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Current Voltage : " + CPUObje["CurrentVoltage"] + " V");
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("Virtualization : " + CPUObje["VirtualizationFirmwareEnabled"]);
                    label_cpu_virtualization.Text = CPUObje["VirtualizationFirmwareEnabled"].ToString();
                    treeView1.Nodes[0].Nodes[3].Nodes.Add("VMMonitor Mode Extensions : " + CPUObje["VMMonitorModeExtensions"]);
                }
                //Disk Info
                ManagementObjectSearcher DiskBilgileri = new ManagementObjectSearcher("select * from Win32_DiskDrive");
                foreach (ManagementObject DiskObje in DiskBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Name : " + DiskObje["Name"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Model : " + DiskObje["Model"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Caption : " + DiskObje["Caption"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Description : " + DiskObje["Description"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Manufacturer : " + DiskObje["Manufacturer"]);
                    double boyutGB = Convert.ToDouble(DiskObje["Size"]) / (1024 * 1024 * 1024);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Size : " + boyutGB.ToString("0.00") + " GB");
                    label_disk_space.Text = boyutGB.ToString("0.00") + " GB";
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Serial Number : " + DiskObje["SerialNumber"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Device ID : " + DiskObje["DeviceID"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Interface Type : " + DiskObje["InterfaceType"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Partitions : " + DiskObje["Partitions"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("Status : " + DiskObje["Status"]);
                    treeView1.Nodes[0].Nodes[4].Nodes.Add("____________________________________________________________");
                }
                //Display Info
                ManagementObjectSearcher EkranBilgileri = new ManagementObjectSearcher("select * from Win32_DesktopMonitor");
                foreach (ManagementObject EkranObje in EkranBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Name : " + EkranObje["Name"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Caption : " + EkranObje["Caption"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Description : " + EkranObje["Description"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Manufacturer : " + EkranObje["MonitorManufacturer"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Display Type : " + EkranObje["DisplayType"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Monitor Type : " + EkranObje["MonitorType"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Pixels Per X Logical Inch : " + EkranObje["PixelsPerXLogicalInch"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Pixels Per Y Logical Inch : " + EkranObje["PixelsPerYLogicalInch"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Screen Height : " + EkranObje["ScreenHeight"]);
                    treeView1.Nodes[0].Nodes[5].Nodes.Add("Screen Width : " + EkranObje["ScreenWidth"]);
                }
                //FAN-Cooling Info
                ManagementObjectSearcher FanBilgileri = new ManagementObjectSearcher("select * from Win32_Fan");
                foreach (ManagementObject FanObje in FanBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Name : " + FanObje["Name"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Active Cooling : " + FanObje["ActiveCooling"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Caption : " + FanObje["Caption"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Description : " + FanObje["Description"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Desired Speed : " + FanObje["DesiredSpeed"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Device ID : " + FanObje["DeviceID"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Variable Speed : " + FanObje["VariableSpeed"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("Status : " + FanObje["Status"]);
                    treeView1.Nodes[0].Nodes[6].Nodes.Add("____________________________________________________________");
                }
                //GPU Informations
                ManagementObjectSearcher GPUBilgileri = new ManagementObjectSearcher("select * from Win32_VideoController");
                foreach (ManagementObject GPUObje in GPUBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Model : " + GPUObje["Name"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Description : " + GPUObje["Description"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Marka : " + GPUObje["VideoProcessor"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Video Mode Description :  " + GPUObje["VideoModeDescription"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Driver Version : " + GPUObje["DriverVersion"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Current Horizontal Resolution : " + GPUObje["CurrentHorizontalResolution"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Current Vertical Resolution : " + GPUObje["CurrentVerticalResolution"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Current Refresh Rate : " + GPUObje["CurrentRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Max Refresh Rate : " + GPUObje["MaxRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Min Refresh Rate : " + GPUObje["MinRefreshRate"] + " Hz");
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Adapter RAM : " + GPUObje["AdapterRAM"] + " MB");
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Current Bits Per Pixel : " + GPUObje["CurrentBitsPerPixel"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("Adapter Compatibility : " + GPUObje["AdapterCompatibility"]);
                    treeView1.Nodes[0].Nodes[7].Nodes.Add("____________________________________________________________");
                }
                //Keyboard Informations
                ManagementObjectSearcher KlavyeBilgileri = new ManagementObjectSearcher("select * from Win32_Keyboard");
                foreach (ManagementObject KlavyeObje in KlavyeBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Name : " + KlavyeObje["Name"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Caption : " + KlavyeObje["Caption"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Description : " + KlavyeObje["Description"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Is Locked : " + KlavyeObje["IsLocked"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Layout : " + KlavyeObje["Layout"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("Number Of Function Keys : " + KlavyeObje["NumberOfFunctionKeys"]);
                    treeView1.Nodes[0].Nodes[8].Nodes.Add("____________________________________________________________");
                }
                //DVD-ROM Info
                ManagementObjectSearcher DVDBilgileri = new ManagementObjectSearcher("select * from Win32_CDROMDrive");
                foreach (ManagementObject DVDObje in DVDBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Name : " + DVDObje["Name"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Caption : " + DVDObje["Caption"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Description : " + DVDObje["Description"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Media Type : " + DVDObje["MediaType"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Id : " + DVDObje["Id"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Manufacturer : " + DVDObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Drive : " + DVDObje["Drive"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Transfer Rate : " + DVDObje["TransferRate"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("Compression Method : " + DVDObje["CompressionMethod"]);
                    treeView1.Nodes[0].Nodes[9].Nodes.Add("____________________________________________________________");
                }
                //RAM Info
                ManagementObjectSearcher RAMBilgileri = new ManagementObjectSearcher("select * from Win32_MemoryDevice");
                foreach (ManagementObject RAMObje in RAMBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Model : " + RAMObje["DeviceID"]);
                }
                //RAM Size Informataions
                ManagementObjectSearcher RAMBoyutu = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                foreach (ManagementObject RAMObje2 in RAMBoyutu.Get())
                {
                    double totalVisibleMemory = Convert.ToUInt64(RAMObje2["TotalVisibleMemorySize"]) / (1024.0 * 1024.0);
                    double freePhysicalMemory = Convert.ToUInt64(RAMObje2["FreePhysicalMemory"]) / (1024.0 * 1024.0);
                    double totalVirtualMemory = Convert.ToUInt64(RAMObje2["TotalVirtualMemorySize"]) / (1024.0 * 1024.0);
                    double freeVirtualMemory = Convert.ToUInt64(RAMObje2["FreeVirtualMemory"]) / (1024.0 * 1024.0);
                    treeView1.Nodes[0].Nodes[10].Nodes.Add($"Total Visible MemorySize : {totalVisibleMemory:0.00} GB");
                    label_toplamram.Text = $"{totalVisibleMemory:0.00} GB";
                    treeView1.Nodes[0].Nodes[10].Nodes.Add($"Free Physical Memory : {freePhysicalMemory:0.00} GB");
                    treeView1.Nodes[0].Nodes[10].Nodes.Add($"Total Virtual Memory Size : {totalVirtualMemory:0.00} GB");
                    treeView1.Nodes[0].Nodes[10].Nodes.Add($"Free Virtual Memory: {freeVirtualMemory:0.00} GB");
                }
                //RAM Speed Informations
                ManagementObjectSearcher RAMHizi = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
                foreach (ManagementObject RAMObje in RAMHizi.Get())
                {
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Manufacturer: " + RAMObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Speed : " + RAMObje["Speed"] + " MHz");
                    label_ramspeed.Text = RAMObje["Speed"] + " MT/s".ToString();
                    ulong kapasite = Convert.ToUInt64(RAMObje["Capacity"]) / (1024 * 1024 * 1024);
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Capacity : " + kapasite + " GB");
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Serial Number : " + RAMObje["SerialNumber"]);
                }
                //RAM Slots Informations
                ManagementObjectSearcher RAMSlotlari = new ManagementObjectSearcher("select * from Win32_PhysicalMemoryArray");
                foreach (ManagementObject RAMObje in RAMSlotlari.Get())
                {
                    treeView1.Nodes[0].Nodes[10].Nodes.Add("Memory Devices : " + RAMObje["MemoryDevices"]);
                }
                //Sound Informations
                ManagementObjectSearcher SesBilgileri = new ManagementObjectSearcher("select * from Win32_SoundDevice");
                foreach (ManagementObject SesObje in SesBilgileri.Get())
                {
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("Name : " + SesObje["Name"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("Description : " + SesObje["Description"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("Caption : " + SesObje["Caption"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("Manufacturer : " + SesObje["Manufacturer"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("Product Name : " + SesObje["ProductName"]);
                    treeView1.Nodes[0].Nodes[11].Nodes.Add("____________________________________________________________");
                }
                //BIOS Informations
                ManagementObjectSearcher BiosBilgileri = new ManagementObjectSearcher("select * from Win32_BIOS");
                foreach (ManagementObject BiosObje in BiosBilgileri.Get())
                {
                    treeView1.Nodes[1].Nodes.Add("Name : " + BiosObje["Name"]);
                    treeView1.Nodes[1].Nodes.Add("Version : " + BiosObje["Version"]);
                    treeView1.Nodes[1].Nodes.Add("Caption : " + BiosObje["Caption"]);
                    treeView1.Nodes[1].Nodes.Add("Description : " + BiosObje["Description"]);
                    treeView1.Nodes[1].Nodes.Add("Current Language : " + BiosObje["CurrentLanguage"]);
                    treeView1.Nodes[1].Nodes.Add("Manufacturer : " + BiosObje["Manufacturer"]);
                    treeView1.Nodes[1].Nodes.Add("Primary BIOS : " + BiosObje["PrimaryBIOS"]);
                    treeView1.Nodes[1].Nodes.Add("Serial Number : " + BiosObje["SerialNumber"]);
                    treeView1.Nodes[1].Nodes.Add("SMBIOS Version : " + BiosObje["SMBIOSBIOSVersion"]);
                }
                //User Informations
                ManagementObjectSearcher KullaniciBilgileri = new ManagementObjectSearcher("select * from Win32_Account");
                foreach (ManagementObject KulObje in KullaniciBilgileri.Get())
                {
                    treeView1.Nodes[2].Nodes.Add("Name : " + KulObje["Name"]);
                    treeView1.Nodes[2].Nodes.Add("Caption : " + KulObje["Caption"]);
                    treeView1.Nodes[2].Nodes.Add("Description : " + KulObje["Description"]);
                    treeView1.Nodes[2].Nodes.Add("Domain : " + KulObje["Domain"]);
                    treeView1.Nodes[2].Nodes.Add("Local Account : " + KulObje["LocalAccount"]);
                    treeView1.Nodes[2].Nodes.Add("____________________________________________________________");
                }
                //Operation System Info
                ManagementObjectSearcher OSBilgileri = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                foreach (ManagementObject OSObje in OSBilgileri.Get())
                {
                    treeView1.Nodes[3].Nodes.Add("Manufacturer : " + OSObje["Manufacturer"]);
                    treeView1.Nodes[3].Nodes.Add("Build Number : " + OSObje["BuildNumber"]);
                    treeView1.Nodes[3].Nodes.Add("Caption : " + OSObje["Caption"]);
                    treeView1.Nodes[3].Nodes.Add("Serial Number : " + OSObje["SerialNumber"]);
                    treeView1.Nodes[3].Nodes.Add("Version : " + OSObje["Version"]);
                    treeView1.Nodes[3].Nodes.Add("Number Of Users : " + OSObje["NumberOfUsers"]);
                    treeView1.Nodes[3].Nodes.Add("System Device: " + OSObje["SystemDevice"]);
                    treeView1.Nodes[3].Nodes.Add("System Directory : " + OSObje["SystemDirectory"]);
                    treeView1.Nodes[3].Nodes.Add("Windows Directory : " + OSObje["WindowsDirectory"]);
                }
                //TreeView1 All Nodes Expand Button
                treeView1.Nodes[0].Expand();
                //Timer For Monitor Performance Tab
                timer1.Start();
                timer2.Stop();
                islemler();
                hizmetler();
                //Get Hostname
                string hostName = Dns.GetHostName();
                label_hostname.Text = hostName;
                //Get IP Address
                string IP = Dns.GetHostEntry(hostName).AddressList[1].ToString();
                label_ipadresi.Text = IP;
                //Get MAC Address
                String macadress = string.Empty;
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
                //System Type
                label_bit.Text = System.Environment.Is64BitOperatingSystem.ToString();
                if (label_bit.Text == "True")
                {
                    label_bit.Text = "x64";
                }
                else
                {
                    label_bit.Text = "x86";
                }
                //Operation System
                string osName = string.Empty;
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem"))
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        osName = queryObj["Caption"]?.ToString();
                    }
                }
                label_isletimsistemi.Text = osName;
                //Operation System Version
                string version = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "DisplayVersion", "Unknown").ToString();
                label_isletimsurumu.Text = version;
                //Activation Status
                ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT LicenseStatus FROM SoftwareLicensingProduct WHERE PartialProductKey IS NOT NULL");
                foreach (ManagementObject obj in searcher2.Get())
                {
                    int licenseStatus = Convert.ToInt32(obj["LicenseStatus"]);
                    string statusMessage = licenseStatus switch
                    {
                        1 => "Active",
                        2 => "Trial period continues",
                        3 => "Trial period has expired",
                        4 => "License is incorrect",
                        5 => "License is invalid",
                        _ => "Unknown License Status"
                    };
                    label_activation.Text = statusMessage;
                }
                //TPM Status
                using (ManagementObjectSearcher tpmsearcher = new ManagementObjectSearcher(@"Root\CIMv2\Security\MicrosoftTpm", "SELECT * FROM Win32_Tpm"))
                {
                    foreach (ManagementObject tpmobj in tpmsearcher.Get())
                    {
                        bool isTpmEnabled = (bool)tpmobj["IsEnabled_InitialValue"];
                        label_tpm.Text = isTpmEnabled ? "Enable" : "Disable";
                        return;
                    }
                }
                label_tpm.Text = "Not Supported";
                //BitLocker
                using (ManagementObjectSearcher btlsearcher = new ManagementObjectSearcher(@"Root\CIMv2\Security\MicrosoftVolumeEncryption", "SELECT * FROM Win32_EncryptableVolume"))
                {
                    foreach (ManagementObject btlobj in btlsearcher.Get())
                    {
                        uint protectionStatus = (uint)btlobj["ProtectionStatus"];
                        label_bitlocker.Text = protectionStatus == 1 ? "Enable" : "Disable";
                        return;
                    }
                }
                label_bitlocker.Text = "Not Supported";
                //Install Date
                using (ManagementObjectSearcher installsearcher = new ManagementObjectSearcher("SELECT InstallDate FROM Win32_OperatingSystem"))
                {
                    foreach (ManagementObject installobj in installsearcher.Get())
                    {
                        string installDate = installobj["InstallDate"].ToString();
                        DateTime formattedDate = DateTime.ParseExact(installDate.Substring(0, 8), "yyyyMMdd", null);
                        label_installdate.Text = formattedDate.ToString("dd.MM.yyyy");
                        return;
                    }
                }
                label_installdate.Text = "Unknown";
                //Hyper-V Status
                using (ManagementObjectSearcher hypersearcher = new ManagementObjectSearcher("SELECT HypervisorPresent FROM Win32_ComputerSystem"))
                {
                    foreach (ManagementObject hyperobj in hypersearcher.Get())
                    {
                        bool isHyperVEnabled = Convert.ToBoolean(hyperobj["HypervisorPresent"]);
                        label_hyperv.Text = isHyperVEnabled ? "Enable" : "Disable";
                        return;
                    }
                }
                label_hyperv.Text = "Unknown";
                //SandBox Status
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Microsoft\WindowsSandbox"))
                {
                    if (key != null)
                    {
                        object value = key.GetValue("AllowSandbox");
                        bool isSandboxEnabled = value != null && (int)value == 1;
                        label_sandbox.Text = isSandboxEnabled ? "Enable" : "Disable";
                    }
                    else
                    {
                        label_sandbox.Text = "Unknown";
                    }
                }
                //Telnet Status
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/c dism /online /get-featureinfo /featurename:TelnetClient";
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();

                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();

                label_telnet.Text = output.Contains("Enable") ? "Enable" : "Disable";
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
            try
            {
                // Performans verilerini al
                float fcpu = performansCPU.NextValue();
                float fdisk = performansDisk.NextValue();
                // RAM bilgilerini daha doğru hesaplamak için:
                var searcher = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize, FreePhysicalMemory FROM Win32_OperatingSystem");
                foreach (var obj in searcher.Get())
                {
                    ulong totalMemory = Convert.ToUInt64(obj["TotalVisibleMemorySize"]);
                    ulong freeMemory = Convert.ToUInt64(obj["FreePhysicalMemory"]);
                    float fram = (float)((totalMemory - freeMemory) / (double)totalMemory * 100);
                    // RAM yüzdesini etiket ve progress bar ile güncelle
                    progressBar_ram.Value = Math.Min(100, Math.Max(0, (int)fram));
                    label_ramyuzde.Text = $"{fram:0.00}%";
                }
                // Diğer değerlerin güncellenmesi
                progressBar_cpu.Value = Math.Min(100, Math.Max(0, (int)fcpu));
                progressBar_disk.Value = Math.Min(100, Math.Max(0, (int)fdisk));
                label_cpuyuzde.Text = $"{fcpu:0.00}%";
                label_diskyuzde.Text = $"{fdisk:0.00}%";
                // CPU Threads
                int totalThreads = Process.GetProcesses().Sum(p => p.Threads.Count);
                label_cpu_threads.Text = totalThreads.ToString();
                // CPU Handles
                int totalHandles = Process.GetProcesses().Sum(p => p.HandleCount);
                label_cpu_handles.Text = totalHandles.ToString();
                // CPU Processes
                int totalProcesses = Process.GetProcesses().Length;
                label_cpu_processes.Text = totalProcesses.ToString();
                // CPU Utilization
                float cpuUtilization = performansCPUutilization.NextValue();
                label_cpu_utilization.Text = $"{cpuUtilization:0.00}%";
                // PC açık kalma süresi
                float uptimeSeconds = performansSistem.NextValue();
                TimeSpan ts = TimeSpan.FromSeconds(uptimeSeconds);
                label_acikliksure.Text = $"{ts.Days}:{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Application is crashed." + ex.Message, "Critical Error!", MessageBoxButtons.OK);
            }
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
            islemsayac();
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
            hizmetsayac();
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
    }
}
