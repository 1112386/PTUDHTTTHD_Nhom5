using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.Script.Services;
using System.Web.Services;
using System.Drawing;
//using BarcodeLib.Barcode;
//using BarcodeLib.BarcodeReader;
using Bytescout.BarCodeReader;
namespace QLThuVien.Controllers
{
    public class BarcodeController : Controller
    {
        //
        // GET: /Barcode/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Read(string imageData)
        {
            
         //  string fileNameWitPath = Server.MapPath("~/Content/images/" + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "- ").Replace(":", "") + ".png");

            //using (FileStream fs = new FileStream(fileNameWitPath, FileMode.Create))
            //{

            //    using (BinaryWriter bw = new BinaryWriter(fs))
            //    {

            //        byte[] data = Convert.FromBase64String(imageData);
            //       bw.Write(data);
            //        bw.Close();
            //    }
            //}



            byte[] data = Convert.FromBase64String(imageData);
           // string[] barcodes = null;
            Bitmap bmp = null;
            using (MemoryStream stream = new MemoryStream(data))
            {
                bmp = new Bitmap(stream);
                // use bmp here....
              //  bmp.Save(fileNameWitPath);
               // barcodes = BarcodeReader.read(bmp, BarcodeReader.CODE39);
                stream.Close();
            }
            //string result="";
            //if (barcodes != null)
            //{
            //    for (int i = 0; i < barcodes.Length; i++)
            //    {
            //        result += barcodes[i];
            //    }
            //}
            //return Content(result);

            Bytescout.BarCodeReader.Reader reader = new Reader();

            //reader.BarcodeTypesToFind = Bytescout.BarCodeReader.SymbologyType.;
            // read barcodes from image
            BarcodeTypeSelector selector = new BarcodeTypeSelector();
            selector.Code39 = true;
            reader.BarcodeTypesToFind = selector;
            reader.ReadFrom(bmp);
            // if there are any result then convert them into a single stream
            string result=string.Empty;
            if (reader.FoundBarcodes != null)
            {
                foreach (FoundBarcode barcode in reader.FoundBarcodes)
                {
                    // form the output string
                    //send = send + (String.Format("{0} : {1}", barcode.Type, barcode.Value));
                    result = String.Format("{0}",barcode.Value);
                    break;
                }
            }
            return Content(result);

        }
        public ActionResult Generator()
        {
            return View();
        }
        public ActionResult MakeBarcode(string code)
        {
            //string fileNameWitPath = Server.MapPath("~/Content/images/" + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "- ").Replace(":", "") + ".png");
            BarcodeLib.Barcode.Linear barcode = new BarcodeLib.Barcode.Linear();
            barcode.Type = BarcodeLib.Barcode.BarcodeType.CODE39;
            // Set your encoded barcode value
            barcode.Data = code;
            barcode.AddCheckSum = false;
            barcode.ShowStartStopChar = false;
            //barcode.Format = System.Drawing.Imaging.ImageFormat.Gif;
            //barcode.Rotate = Rotate.Rotate0;
            // Draw barcode image into a PNG file
            barcode.ImageWidth = 200;
            barcode.ImageHeight = 100;
            byte[] barcodeimage = barcode.drawBarcodeAsBytes();
            string imagedata = Convert.ToBase64String(barcodeimage);

            //byte[] data = Convert.FromBase64String(imagedata);
            //using (MemoryStream stream = new MemoryStream(data))
            //{
            //    Bitmap bmp = new Bitmap(stream);
            //    // use bmp here....
            //    bmp.Save(fileNameWitPath, System.Drawing.Imaging.ImageFormat.Png);
            //    stream.Close();
            //}

            return Content(imagedata);
        }
    }
}
