using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ShredderPoker
{
    public static class WindowManager
    {

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public static void MoveAndResizeWindow(IntPtr hwnd, int x, int y, int width, int height)
        {
            RECT rect;
            if (GetWindowRect(hwnd, out rect))
            {
                MoveWindow(hwnd, x, y, width, height, true);
            }
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, uint nFlags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT { public int Left; public int Top; public int Right; public int Bottom; }

        public static Bitmap StoreScreenshotToBitmap(IntPtr windowHandle)
        {
            RECT rect;
            GetWindowRect(windowHandle, out rect);

            Bitmap screenshot = new Bitmap(rect.Right - rect.Left, rect.Bottom - rect.Top, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                IntPtr hdc = graphics.GetHdc();
                PrintWindow(windowHandle, hdc, 0);
                graphics.ReleaseHdc(hdc);

            }

            return screenshot;
        }
    }
}
