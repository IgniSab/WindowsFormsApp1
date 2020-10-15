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

namespace WindowsFormsApp1
{
    public partial class PerfEv : Form
    {
        public PerfEv()
        {
            InitializeComponent();
            InfoSysCPU();
            InfoSysRAM();
            InfoSysSytem();
           
        }

        private void InfoSysCPU()
        {
            ManagementObjectSearcher managementObject = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM WIN32_Processor");


            foreach(ManagementObject obj in managementObject.Get())
            {   
                CpuThread.Text = obj["ThreadCount"].ToString();
                CpuThread.Visible = false;
            }
          
            if(CpuThread.Text == "1")
            {

                raitingCPU.ForeColor = Color.Red;
                raitingCPU.Text += " 1"+" ужасно";
            }
            if (CpuThread.Text == "2")
            {

                raitingCPU.ForeColor = Color.Red;
                raitingCPU.Text += " 2" + " ужасно";
            }
            if (CpuThread.Text == "4")
            {

                raitingCPU.ForeColor = Color.Yellow;
                raitingCPU.Text += " 3" + " неплохо";
            }
            if (CpuThread.Text == "6")
            {

                raitingCPU.ForeColor = Color.Yellow;
                raitingCPU.Text = " 4" + " неплохо";
            }
            if (CpuThread.Text == "8")
            {


                raitingCPU.ForeColor = Color.Green;
                raitingCPU.Text += " 5" + " отлично";
            }
            if (CpuThread.Text == "12")
            {
                raitingCPU.ForeColor = Color.Green;
                raitingCPU.Text += " 6" + " отлично";
            }
            if (CpuThread.Text == "16")
            {
                raitingCPU.ForeColor = Color.Green;
                raitingCPU.Text += " 7" + " отлично";
            }
            if (CpuThread.Text == "20")
            {
                raitingCPU.ForeColor = Color.Green;
                raitingCPU.Text += " 8" + " отлично";
            }
            if (CpuThread.Text == "24")
            {
                raitingCPU.ForeColor = Color.Green;
                raitingCPU.Text += " 9" + " отлично";
            }
            if (CpuThread.Text == "32")
            {
                raitingCPU.ForeColor = Color.Green;
                raitingCPU.Text += " 10" + " отлично";
            }



        }

        private void InfoSysRAM()
        {
            ManagementObjectSearcher managementObject = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject obj in managementObject.Get())
            {

                RAMcapacity.Text = obj["Capacity"].ToString();

                double memoryRam = Convert.ToDouble(RAMcapacity.Text);
                memoryRam = (memoryRam / 1024 / 1024 / 1024);
                RAMcapacity.Text = memoryRam.ToString();
                RAMcapacity.Visible = false;

                if (RAMcapacity.Text == "1")
                {
                    RatingRAM.ForeColor = Color.Red;
                    RatingRAM.Text = "Raiting RAM:" + " 1" + " ужасно";
                }
                if (RAMcapacity.Text == "2")
                {
                    RatingRAM.ForeColor = Color.Red;
                    RatingRAM.Text = "Raiting RAM:" + " 2" + " ужасно";
                }
                if (RAMcapacity.Text == "4")
                {
                    RatingRAM.ForeColor = Color.Yellow;
                    RatingRAM.Text = "Raiting RAM:" + " 3" + " неплохо";
                }
                if (RAMcapacity.Text == "8")
                {
                    RatingRAM.ForeColor = Color.Green;
                    RatingRAM.Text = "Raiting RAM:" + " 4"+" отлично";
                }
                if (RAMcapacity.Text == "16")
                {
                    RatingRAM.ForeColor = Color.Green;
                    RatingRAM.Text = "Raiting RAM:" + " 5" + " отлично";
                }
                if (RAMcapacity.Text == "32")
                {
                    RatingRAM.ForeColor = Color.Green;
                    RatingRAM.Text = "Raiting RAM:" + " 6" + " отлично";
                }
                if (RAMcapacity.Text == "64")
                {
                    RatingRAM.ForeColor = Color.Green;
                    RatingRAM.Text = "Raiting RAM:" + " 7" + " отлично";
                }
            }

        }

        private void InfoSysSytem()
        {
            //ManagementObjectSearcher managementObject = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
            //foreach (ManagementObject obj in managementObject.Get())
            //{
            //    Windows_RAT.Text =  obj["Caption"].ToString();
            //    Windows_RAT.Text = 
            //}
             Windows_RAT.Text = Environment.OSVersion.Version.Major.ToString() + "." + Environment.OSVersion.Version.Minor.ToString();
             Windows_RAT.Visible = false;
             
            if(Windows_RAT.Text == "5.1")
            {
                raitingWindows.ForeColor = Color.Red;
                //5.1 Winodws XP 32 32-bit
                raitingWindows.Text += " 1" + " ужасно";

            }
            if (Windows_RAT.Text == "5.2")
            {
                raitingWindows.ForeColor = Color.Red;
                //5.1 Winodws XP 32 64-bit
                raitingWindows.Text += " 2" + " ужасно";
            }
            if (Windows_RAT.Text == "6.0")
            {
                raitingWindows.ForeColor = Color.Red;
                //6.0 Winodws Vista
                raitingWindows.Text += " 3" + " ужасно";
            }
            if (Windows_RAT.Text == "6.1")
            {
                raitingWindows.ForeColor = Color.Yellow;
                //6.1 Winodws 7
                raitingWindows.Text += " 4" + " неплохо";
            }
            if (Windows_RAT.Text == "6.2")
            {
                raitingWindows.ForeColor = Color.Green;
                //6.1 Winodws 8 and Windows 10
                raitingWindows.Text += " 5" + " отлично";
            }

        }
    }
}
