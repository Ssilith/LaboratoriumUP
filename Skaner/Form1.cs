﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using WIA;

namespace Latwiutko
{
    public partial class Form1 : Form
    {
        int resolution = 300;
        int color_mode = 1;
        string rozszerzenie = ".JPEG";
        int b = 3500;
        int a = 2500;
        int y = 3500;
        int x = 2500;
        int c = 0, d = 0;
   

        private static void AdjustScannerPictureSize(IItem scannerItem, int x, int y)
        {
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";

            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, x);
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, y);
        }

        private static void AdjustScannerPictureStart(IItem scannerItem, int x, int y)
        {
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";

            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, x);
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, y);
        }
        private static void AdjustScannerResolution(IItem scannerItem, int resolution)
        {
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";

            SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, resolution);
            SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, resolution);
        }

        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        private static void AdjustScannerColorMode(IItem scannerItem, int color_mode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            SetWIAProperty(scannerItem.Properties, WIA_SCAN_COLOR_MODE, color_mode);
        }
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                var manager = new DeviceManager();

                for (int i = 1; i <= manager.DeviceInfos.Count; i++)
                {

                    if (manager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        continue;
                    }
                    listaSkanerow.Items.Add(manager.DeviceInfos[i].Properties["Name"].get_Value());
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var manager = new DeviceManager();
                DeviceInfo firstScannerAvailable = null;
                for (int i = 1; i <= manager.DeviceInfos.Count; i++)
                {
                    if (manager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        continue;
                    }
                    firstScannerAvailable = manager.DeviceInfos[i];
                    break;
                 
                }
               
                var ZawartoscSkanera = firstScannerAvailable.Connect().Items[1];

                AdjustScannerPictureSize(ZawartoscSkanera, a, b);
                AdjustScannerColorMode(ZawartoscSkanera, color_mode);
                AdjustScannerResolution(ZawartoscSkanera, resolution);
                AdjustScannerPictureStart(ZawartoscSkanera, c, d);

                var obraz = (ImageFile)ZawartoscSkanera.Transfer();
                var Path = @"C:\obrazek.jpeg";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Path = saveFileDialog1.FileName;
                    if (!(Path.Contains(".jpeg")|| Path.Contains(".JPEG")|| Path.Contains(".PNB")|| Path.Contains(".pnb")))
                    {
                        Path += rozszerzenie;
                    }
                }
                    
                if (File.Exists(Path))
                {
                    File.Delete(Path);
                }

                obraz.SaveFile(Path);

                PojemnikNaObraz.ImageLocation = Path;

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
   
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false; checkBox3.Checked = false;
                color_mode = 2;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false; checkBox3.Checked = false;
                color_mode = 1;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false; checkBox1.Checked = false;
                color_mode = 4;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            resolution = trackBar1.Value;
            resLabel.Text = trackBar1.Value.ToString();
        }

        private void PNG_CheckedChanged(object sender, EventArgs e)
        {
            if (PNG.Checked == true)
            {
                JPG.Checked = false;
                rozszerzenie = ".PNG";
            }
        }

        private void JPG_CheckedChanged(object sender, EventArgs e)
        {
            if (JPG.Checked == true)
            {
                PNG.Checked = false;
                rozszerzenie = ".JPEG";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                a = x;
                b = y;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                b = y / 2;
                checkBox4.Checked = false;
                checkBox6.Checked = false;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            c = trackBar2.Value;
            label6.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            d = trackBar3.Value;
            label7.Text = trackBar3.Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                a = x / 2;
                b = y / 2;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }
    }
}
