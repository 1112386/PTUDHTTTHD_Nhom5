using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnBarcode.Barcode;
using OnBarcode.Barcode.BarcodeScanner;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

using Limilabs.Barcode;
namespace Barcode_Nhom5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VideoCaptureDevice cam;
        FilterInfoCollection webcam;
        private void button1_Click(object sender, EventArgs e)
        {
            Linear barcode = new Linear();
            // barcode.Data = "123456789";
            // Set barcode type to Code 39
            string key = cbxBarcodeTypes.SelectedValue.ToString();
            barcode.Type = dic[key];
            
            // Set your encoded barcode value
            barcode.Data = code.Text.ToString();

            // Other barcode settings
            // Save barcode image into your system
            barcode.UOM = UnitOfMeasure.PIXEL;
            barcode.X = 1;
            barcode.Y = 80;
            barcode.LeftMargin = 20;
            barcode.RightMargin = 20;
            barcode.TopMargin = 0;
            barcode.BottomMargin = 0;
            barcode.Resolution = 96;
            barcode.AddCheckSum = true;
            barcode.ShowCheckSumChar = false;
            barcode.Format = System.Drawing.Imaging.ImageFormat.Gif;
            barcode.Rotate = Rotate.Rotate0;
            // Draw barcode image into a PNG file
            byte[] barcodeimage = barcode.drawBarcodeAsBytes();
            MemoryStream ms = new MemoryStream(barcodeimage);
            ms.Write(barcodeimage, 0, barcodeimage.Length);
            ms.Position = 0; // THIS !!!!!
            barcodeimg.Image = Image.FromStream(ms);
            barcode.drawBarcode("barcode.gif");



            //BaseBarcode barcode = BarcodeFactory.GetBarcode(Symbology.Code93);
            //barcode.Number = code.Text.ToString(); ;
            //barcode.ChecksumAdd = false;

            //// Render barcode:
            //Bitmap bitmap = barcode.Render();

            //// You can also save it to file:
            //barcodeimg.Image = bitmap;
            //barcode.Save("abc.gif", ImageType.Gif);
            
        }
        Dictionary<string, OnBarcode.Barcode.BarcodeType> dic;
        void LoadData()
        {

            dic = new Dictionary<string, OnBarcode.Barcode.BarcodeType>()
                {
                {"CODE93", OnBarcode.Barcode.BarcodeType.CODE93},
                {"ISBN", OnBarcode.Barcode.BarcodeType.ISBN},
                {"CODABAR", OnBarcode.Barcode.BarcodeType.CODABAR},
                {"CODE128", OnBarcode.Barcode.BarcodeType.CODE128},
                {"CODE39", OnBarcode.Barcode.BarcodeType.CODE39},
                {"EAN13", OnBarcode.Barcode.BarcodeType.EAN13},
                {"EAN8", OnBarcode.Barcode.BarcodeType.EAN8}
               
            };
            cbxBarcodeTypes.DataSource = new BindingSource(dic, null);
            cbxBarcodeTypes.DisplayMember = "Key";
            cbxBarcodeTypes.ValueMember = "Value";
        }

        Dictionary<string, OnBarcode.Barcode.BarcodeScanner.BarcodeType> dic1;
        void LoadDataBarcodeScanner()
        {

            dic1 = new Dictionary<string, OnBarcode.Barcode.BarcodeScanner.BarcodeType>()
                {
                {"Code93", OnBarcode.Barcode.BarcodeScanner.BarcodeType.Code93},
                {"ISBN", OnBarcode.Barcode.BarcodeScanner.BarcodeType.ISBN},
                {"Codabar", OnBarcode.Barcode.BarcodeScanner.BarcodeType.Codabar},
                {"Code128", OnBarcode.Barcode.BarcodeScanner.BarcodeType.Code128},
                {"Code39", OnBarcode.Barcode.BarcodeScanner.BarcodeType.Code39},
                {"EAN13", OnBarcode.Barcode.BarcodeScanner.BarcodeType.EAN13},
                {"EAN8", OnBarcode.Barcode.BarcodeScanner.BarcodeType.EAN8}
               
            };
            barcodetypescanner.DataSource = new BindingSource(dic1, null);
            barcodetypescanner.DisplayMember = "Key";
            barcodetypescanner.ValueMember = "Value";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            LoadData();
            LoadDataBarcodeScanner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[0].MonikerString);
            
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();
            //OnOff(false);
        }
        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pic.Image = bit;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stop();
        }
        void Stop()
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string key = barcodetypescanner.SelectedValue.ToString();
            Bitmap image = new Bitmap(pic.Image);
            string[] barcodes = BarcodeScanner.ScanSingleBarcode(image, dic1[key]);
            
            if (barcodes != null)
                decode.Text = string.Join(",", barcodes);
        }
    }
}
