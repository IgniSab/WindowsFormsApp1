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
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void infoCPU_Click_1(object sender, EventArgs e)
        {
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM WIN32_Processor");

            foreach (ManagementObject obj in managementObjectSearcher.Get())
            {
                richTextBox1.Text = ("Name: " + obj["Name"]) + "\r\n" + 
                ("NumberOfCores: " + obj["NumberOfCores"]) + "\r\n"
                + ("Caption: " + obj["Caption"]) + "\r\n" + 
                ("Characteristics: " + obj["Characteristics"]) + "\r\n"
                + ("CpuStatus: " + obj["CpuStatus"]) + "\r\n" + 
                ("Description: " + obj["Description"]) + "\r\n" +
                ("DeviceID: " + obj["DeviceID"]) + "\r\n" + ("Family: " + obj["Family"]) + "\r\n" + 
                ("L2CacheSize: " + obj["L2CacheSize"])
                + "\r\n" + ("L3CacheSize: " + obj["L3CacheSize"]) + "\r\n" + 
                ("Manufacturer: " + obj["Manufacturer"]) + "\r\n"
                + ("MaxClockSpeed: " + obj["MaxClockSpeed"]) + "\r\n" + 
                ("Role: " + obj["Role"]) + "\r\n" +
                ("PowerManagementSupported: " + obj["PowerManagementSupported"]) + "\r\n" + 
                ("SerialNumber: " + obj["SerialNumber"]) +
                "\r\n" + ("SocketDesignation: " + obj["SocketDesignation"]) + "\r\n" +
                ("Status: " + obj["Status"]) + "\r\n" +
                ("ProcessorId: " + obj["ProcessorId"]) + "\r\n" + 
                ("ThreadCount: " + obj["ThreadCount"]) + "\r\n"  +
                ("Cpu load: " + obj["LoadPercentage"] + "%"); 
            }
    
            
        }

        private void infoGPU_Click_1(object sender, EventArgs e)
        {
            ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject obj in managementObjectSearcher2.Get())
            {

                string gpuMemotyString = obj["AdapterRAM"].ToString();
                double gpuMemory = Convert.ToDouble(gpuMemotyString);
                gpuMemory = Math.Round((gpuMemory / 1024 / 1024 / 1024));

              //  ("AdapterRAM: " + obj["AdapterRAM"])


                richTextBox1.Text = ("AdapterCompatibility: " + obj["AdapterCompatibility"]) + 
                "\r\n" + ("AdapterDACType: " + obj["AdapterDACType"])
                + "\r\n" + ("AdapterRAM: " + gpuMemory.ToString()) + 
                "\r\n" + ("Caption: " + obj["Caption"]) + "\r\n" +
                ("Description: " + obj["Description"]) + "\r\n" + 
                ("DeviceID: " + obj["DeviceID"]) + "\r\n" +
                ("Name: " + obj["Name"]) + "\r\n" + 
                ("PNPDeviceID: " + obj["PNPDeviceID"]) + "\r\n" + 
                ("Status: " + obj["Status"]) + "\r\n" +
                ("SystemName: " + obj["SystemName"]) + "\r\n" + 
                ("InfSection: " + obj["InfSection"]) + "\r\n" + 
                ("VideoMemoryType: " + obj["VideoMemoryType"])
                + "\r\n" + ("VideoModeDescription: " + obj["VideoModeDescription"]) + "\r\n" + 
                ("VideoProcessor: " + obj["VideoProcessor"]);
            }
        }

        private void infoMotherBoard_Click_1(object sender, EventArgs e)
        {
            ManagementObjectSearcher managementObjectSearcher5 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject obj in managementObjectSearcher5.Get())
            {
                richTextBox1.Text =
                 "Name: " + obj["Name"] + "\r\n" +
                 "Caption: " + obj["Caption"] + "\r\n" +
                 "CreationClassName: " + obj["CreationClassName"] + "\r\n" +
                 "Manufacturer: " + obj["Manufacturer"] + "\r\n" +
                 "Model: " + obj["Model"] + "\r\n" +
                 "PartNumber: " + obj["PartNumber"] + "\r\n" +
                 "Product: " + obj["Product"] + "\r\n" +
                 "SerialNumber: " + obj["SerialNumber"] + "\r\n" +
                 "SpecialRequirements: " + obj["SpecialRequirements"] + "\r\n" +
                 "Version: " + obj["Version"] + "\r\n";

            }
        }

        private void infoStorage_Click_1(object sender, EventArgs e)
        {


            foreach(var drive1 in DriveInfo.GetDrives())
            {
                try
                {

                    //richTextBox1.Text =
                    //   "Name: " + drive1.Name + "\r\n" +
                    //   "FileSystem: " + drive1.DriveFormat + "\r\n" +
                    //   "Type: " + drive1.DriveType + "\r\n" +
                    //   "FreeSpace: " + drive1.AvailableFreeSpace + "\r\n" +
                    //   "Disk size: " + drive1.TotalSize + "\r\n" +
                    //   "RootDirectory: " + drive1.RootDirectory + "\r\n" +
                    //   "Total free space: " + drive1.TotalFreeSpace + "\r\n" +
                    //   "Disk is ready: " + drive1.IsReady;
                    richTextBox1.Text += "\r\n";
                    richTextBox1.Text += "Name: " + drive1.Name;
                    richTextBox1.Text += "\r\n";
                    richTextBox1.Text += "FileSystem: " + drive1.DriveFormat;
                    richTextBox1.Text += "\r\n";
                    richTextBox1.Text += "Type: " + drive1.DriveType;
                    richTextBox1.Text += "\r\n";
                    richTextBox1.Text += "FreeSpace: " + drive1.AvailableFreeSpace/1024/1024/1024;
                    richTextBox1.Text += "\r\n";
                    richTextBox1.Text += "Disk size: " + drive1.TotalSize/1024/1024/1024;
                    richTextBox1.Text += "\r\n";
                    richTextBox1.Text += "RootDirectory: " + drive1.RootDirectory;
                    richTextBox1.Text += "\r\n";
                    richTextBox1.Text += "Total free space: " + drive1.TotalFreeSpace/1024/1024/1024;
                    richTextBox1.Text += "\r\n";
                    richTextBox1.Text += "Disk is ready: " + drive1.IsReady;
             
                    richTextBox1.Text += "\r\n";







                }
                catch
                {

                }

            }
           
        }

        private void infoRAM_Click_1(object sender, EventArgs e)
        {
            ManagementObjectSearcher managementObjectSearcher3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject obj in managementObjectSearcher3.Get())
            {
                string memoryRamString = obj["Capacity"].ToString();
                double memoryRam = Convert.ToDouble(memoryRamString);
                memoryRam = Math.Round((memoryRam / 1024 / 1024 / 1024));
                //("Capacity: " + obj["Capacity"])
                richTextBox1.Text = ("Attributes: " + obj["Attributes"]) + "\r\n" +
                ("Capacity: " + memoryRam.ToString()) + "\r\n" +
                ("BankLabel: " + obj["BankLabel"])
                + "\r\n" + ("Caption: " + obj["Caption"]) + "\r\n" +
                ("ConfiguredClockSpeed: " + obj["ConfiguredClockSpeed"])
                + "\r\n" + ("ConfiguredVoltage: " + obj["ConfiguredVoltage"]) + "\r\n" +
                ("Description: " + obj["Description"])
                + "\r\n" + ("DeviceLocator: " + obj["DeviceLocator"]) + "\r\n" + 
                ("FormFactor: " + obj["FormFactor"]) + "\r\n" +
                ("MaxVoltage: " + obj["MaxVoltage"]) + "\r\n" + 
                ("MemoryType: " + obj["MemoryType"]) + "\r\n" +
                ("Model: " + obj["Model"]) + "\r\n" + 
                ("Name: " + obj["Name"]) + "\r\n" +
                ("OtherIdentifyingInfo:" + obj["OtherIdentifyingInfo"]) + "\r\n" +
                ("SerialNumber: " + obj["SerialNumber"]) + "\r\n" + 
                ("Speed: " + obj["Speed"])
                ;


            }
        }

        private void infoSystem_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher managementObjectSearcher0 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in managementObjectSearcher0.Get())
            {
                
                richTextBox1.Text = "BootDevice: " + obj["BootDevice"] + "\r\n"
                 + ("Caption: " + obj["Caption"]) + "\r\n" 
               + ("CountryCode: " + obj["CountryCode"]) + "\r\n"
               + ("CSName: " + obj["CSName"]) + "\r\n" + 
               ("Description: " + obj["Description"]) + "\r\n" +
               ("Distributed: " + obj["Distributed"]) + "\r\n" + 
               ("SystemDirectory: " + obj["SystemDirectory"]) + "\r\n" + 
               ("Version: " + obj["Version"])
               + "\r\n" + ("ProductType: " + obj["ProductType"]) + "\r\n" + 
               ("OSType: " + obj["OSType"]) + "\r\n" +
               ("OSProductSuite: " + obj["OSProductSuite"]) +
               "\r\n" + ("OperatingSystemSKU: " + obj["OperatingSystemSKU"]) +
               "\r\n" + ("NumberOfUsers: " + obj["NumberOfUsers"]) + "\r\n" +
               ("Locale: " + obj["Locale"]) + "\r\n" + (
               "InstallDate: " + (obj["InstallDate"]));
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (richTextBox1.Text.Length != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                    streamWriter.WriteLine(richTextBox1.Text);
                    streamWriter.Close();
                }

            }
            else
            {
                richTextBox1.Text = "Нет выходных данных!";
            }

        }

        private void infoBios_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher managementObjectSearcher6 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
            foreach (ManagementObject obj in managementObjectSearcher6.Get())
            {
                richTextBox1.Text =
                 "BuildNumber: " + obj["BuildNumber"] + "\r\n" +
                 "Caption: " + obj["Caption"] + "\r\n" +
                 "CodeSet: " + obj["CodeSet"] + "\r\n" +
                 "CurrentLanguage: " + obj["CurrentLanguage"] + "\r\n" +
                 "Name: " + obj["Name"] + "\r\n" +
                 "OtherTargetOS: " + obj["OtherTargetOS"] + "\r\n" +
                 "SerialNumber: " + obj["SerialNumber"] + "\r\n" +
                 "SoftwareElementID: " + obj["SoftwareElementID"] + "\r\n" +
                 "Status: " + obj["Status"] + "\r\n" +
                 "Version: " + obj["Version"];


            }
        }

        private void infoAudio_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher managementObjectSearcher7 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_SoundDevice");
            foreach (ManagementObject obj in managementObjectSearcher7.Get())
            {
                richTextBox1.Text =
            
                 "DeviceID: " + obj["DeviceID"] + "\r\n" +
                 "Name: " + obj["Name"] + "\r\n" +
                 "Manufacturer: " + obj["Manufacturer"] + "\r\n" +
                 "PNPDeviceID: " + obj["PNPDeviceID"] + "\r\n" +
                 "ProductName: " + obj["ProductName"] + "\r\n" +
                 "Status: " + obj["Status"] + "\r\n" +
                 "SystemName: " + obj["SystemName"];


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerfEv perfEv = new PerfEv();
            perfEv.Show();

            
        }

        
    }
}
