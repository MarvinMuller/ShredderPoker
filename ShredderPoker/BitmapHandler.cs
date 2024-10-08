using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ShredderPoker
{
    public class BitmapHandler
    {
        public static bool PixelScan(Bitmap bitmap, int[] colorRange)
        {
            int bytesPerPixel = 4;
            int byteCount = bitmap.Width * bitmap.Height * bytesPerPixel;

            Rectangle bitmapRect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

            BitmapData bitmapData = bitmap.LockBits(bitmapRect, ImageLockMode.ReadOnly, bitmap.PixelFormat);

            try
            {
                IntPtr ptr = bitmapData.Scan0;

                byte[] pixelData = new byte[byteCount];
                Marshal.Copy(ptr, pixelData, 0, byteCount);

                for (int y = 0; y < bitmap.Height; y++)
                {
                    int offset = y * bitmap.Width * bytesPerPixel;

                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        int blue = pixelData[offset];
                        int green = pixelData[offset + 1];
                        int red = pixelData[offset + 2];

                        int minRed = colorRange[0];
                        int minGreen = colorRange[1];
                        int minBlue = colorRange[2];
                        int maxRed = colorRange[3];
                        int maxGreen = colorRange[4];
                        int maxBlue = colorRange[5];

                        if (red >= minRed && red <= maxRed && green >= minGreen && green <= maxGreen && blue >= minBlue && blue <= maxBlue)
                        {
                            return true;
                        }

                        offset += bytesPerPixel;
                    }
                }
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }

            return false;
        }

        public static bool GrayPixel(Bitmap bitmap, int tolerance)
        {
            int bytesPerPixel = 4;
            int byteCount = bitmap.Width * bitmap.Height * bytesPerPixel;

            Rectangle bitmapRect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

            BitmapData bitmapData = bitmap.LockBits(bitmapRect, ImageLockMode.ReadOnly, bitmap.PixelFormat);

            try
            {
                IntPtr ptr = bitmapData.Scan0;

                byte[] pixelData = new byte[byteCount];
                Marshal.Copy(ptr, pixelData, 0, byteCount);

                for (int y = 0; y < bitmap.Height; y++)
                {
                    int offset = y * bitmap.Width * bytesPerPixel;

                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        int blue = pixelData[offset];
                        int green = pixelData[offset + 1];
                        int red = pixelData[offset + 2];

                        int deltaRedGreen = Math.Abs(red - green);
                        int deltaGreenBlue = Math.Abs(green - blue);
                        int deltaBlueRed = Math.Abs(blue - red);

                        if (deltaRedGreen <= tolerance && deltaGreenBlue <= tolerance && deltaBlueRed <= tolerance)
                        {
                            return true;
                        }

                        offset += bytesPerPixel;
                    }
                }
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }

            return false;
        }
    }
}
