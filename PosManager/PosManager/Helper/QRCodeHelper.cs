﻿
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using QRCoder;
using Serilog;

namespace PosManager.Helper
{
    public class QRCodeHelper
    {
        public static Bitmap GenerateQRCodeWithLogo(string content, Bitmap logo, int bitxel = 5)
        {
            // Tạo QR Code
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            // Tạo hình ảnh QR Code
            Bitmap qrCodeImage = qrCode.GetGraphic(bitxel);

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
        }
        public static string ReadQRCode(Bitmap bitmap)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            try
            {
                // Đọc nội dung từ tập tin ảnh chứa mã QR
                string decodedText = decoder.Decode(new QRCodeBitmapImage(bitmap));
                if (!string.IsNullOrEmpty(decodedText))
                {
                    return decodedText;
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