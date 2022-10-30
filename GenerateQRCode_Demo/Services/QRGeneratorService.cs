using GenerateQRCode_Demo.Interfaces;
using GenerateQRCode_Demo.Models;
using Helpers;
using PdfSharpCore;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace GenerateQRCode_Demo.Services
{
    public class QRGeneratorServices : IQRGeneratorService
    {
        public void GeneratePDF(Product product)
        {
            var PathToSaveFile = "D:\\Work\\CrocoBite\\GenerateQRCodeMVCCore6-main\\GenerateQRCode_Demo\\wwwroot";

            using (PdfDocument pdf = new PdfDocument())
            {

                int start = 0;
                pdf.Info.Title = "My First PDF";
                PdfPage pdfPage = pdf.AddPage();  //For Designed
                pdfPage.Height = XUnit.FromCentimeter(33);
                pdfPage.Width = XUnit.FromCentimeter(22);
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                // pdfPage.Height = xImage.PixelHeight;
                pdfPage.Orientation = PageOrientation.Portrait;
                var options = new XPdfFontOptions(PdfFontEncoding.Unicode);
                XFont font = new XFont("Arial", 10, XFontStyle.Bold, options);
                double XCompanyCover = 30;
                double YCompanyCover = 33 + 9;


                 double XQR = 120;
                 double YQR = 172;

                double XBarCode = 300;
                double YBarCode = 350;

                graph.DrawImage(QR_Code_Generator_Helper.GenerateSingleQR(product.Name+product.Unit+product.Color), XQR+50, YQR+50 + 0, 40, 40);//The QR
                graph.DrawImage(QR_Code_Generator_Helper.GenerateQR_Barcode(product.Name + product.Unit + product.Color), XQR, YQR + 0, 40, 40);//The QR
                 graph.DrawImage(QR_Code_Generator_Helper.Barcode(product.Name + product.Unit + product.Color), XBarCode, YBarCode + 0, 40, 40);//The Barcode


                pdf.Save(Path.Combine(PathToSaveFile,"test3.pdf"));
            }



        }

            public string GenerateQRCode()
        {
            var x = "data:image/png;base64," + Convert.ToBase64String(QR_Code_Generator_Helper.QR_Code_Generator("2568", "00652", "2589"));
            return x;
        }
    }
}
