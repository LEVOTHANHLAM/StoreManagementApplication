using QRCoder;
using Serilog;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using ZXing.Windows.Compatibility;

namespace PosManager.Helper
{
    public class QRCodeHelper
    {
        public static Bitmap GenerateQRCodeWithLogo(string content, Bitmap logo, int width = 500, int height = 500)
        {
            // Tạo QR Code
            QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);

            // Tạo hình ảnh QR Code
            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            // Kết hợp hình ảnh QR Code với hình ảnh nền
            // Tính toán vị trí và kích thước của logo
            int logoSize = qrCodeImage.Width / 4; // Có thể điều chỉnh kích thước của logo ở đây
            int xPosition = (qrCodeImage.Width - logoSize) / 2;
            int yPosition = (qrCodeImage.Height - logoSize) / 2;

            // Chèn logo vào QR Code
            using (Graphics g = Graphics.FromImage(qrCodeImage))
            {
                g.DrawImage(logo, new Rectangle(xPosition, yPosition, logoSize, logoSize));
            }

            return qrCodeImage;

         //   return qrCodeBitmap;
        }
        public static string ReadQRCode(Bitmap bitmap)
        {
           
            try
            {
                BarcodeReader reader = new()
                {
                    Options = new DecodingOptions()
                    {
                        PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE },
                        TryHarder = true
                    }
                };
                Result qrCodeResult = reader.Decode(bitmap);
                if(qrCodeResult != null && !string.IsNullOrEmpty(qrCodeResult.Text) )
                {
                    return qrCodeResult.Text;
                }
                return null;
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                return null;
            }
        }
    }
}
