using IronBarCode;
using PdfSharpCore.Drawing;
using PdfSharpCore.Drawing.BarCodes;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;


namespace Helpers
{
    public class QR_Code_Generator_Helper
    {
        private static byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }
        public static XImage GenerateQR_Barcode(string DataToBeQR)
        {
            GeneratedBarcode barcode = QRCodeWriter.CreateQrCode(DataToBeQR, 200);
            Bitmap MyBarCodeBitmap = barcode.ToBitmap();
            var ByteArray = BitmapToBytes(MyBarCodeBitmap);
            return XImage.FromStream(() => new MemoryStream(ByteArray));

        }
        public static XImage Barcode(string DataToBeQR)
        {
            GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(DataToBeQR, BarcodeWriterEncoding.Code128);
            //barcode.ResizeTo(400, 120);
            barcode.AddBarcodeValueTextBelowBarcode();
            barcode.SetMargins(10);
            Bitmap MyBarCodeBitmap = barcode.ToBitmap();
            var ByteArray = BitmapToBytes(MyBarCodeBitmap);

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            return XImage.FromStream(() => new MemoryStream(ByteArray));

        }
    }
}
