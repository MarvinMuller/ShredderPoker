using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShredderPoker
{
    public partial class Shredder : Form
    {
        // function to move the main form window by dragging it
        #region DragAndDrop
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragAndDrop(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
    }

    public partial class WindowSelect : Form
    {
        // function to return the window name by its handle
        #region GetWindowTitle
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        public static string GetWindowTitle(IntPtr handle)
        {
            int maxTitleLength = 255;
            StringBuilder sbTitle = new StringBuilder(maxTitleLength + 1);
            int titleLength = GetWindowText(handle, sbTitle, maxTitleLength);
            if (titleLength > 0)
            {
                return sbTitle.ToString(0, titleLength);
            }
            return "";
        }
        #endregion

        // function to bring the window to front by its handle
        #region SetForegroundWindow
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        #endregion

        // function to enumerate all top-level windows
        #region EnumWindows
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        #endregion

        // function that retrieves the identifier of the thread that created the specified window
        #region
        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        #endregion

        // function to find all windows that contains a partial name
        #region FindWindowsWithPartialName
        public static IntPtr[] FindWindowsWithPartialName(string partialName)
        {
            List<IntPtr> handles = new List<IntPtr>();
            EnumWindows(delegate (IntPtr hWnd, IntPtr lParam)
            {
                uint processId;
                GetWindowThreadProcessId(hWnd, out processId);
                //TO DO: use the name of processes found by its partial name instead of "PokerStars"
                if (Process.GetProcessById((int)processId).ProcessName == "PokerStars")
                {
                    StringBuilder sbTitle = new StringBuilder(1024);
                    GetWindowText(hWnd, sbTitle, sbTitle.Capacity);
                    if (sbTitle.ToString().Contains(partialName))
                    {
                        handles.Add(hWnd);
                    }
                }
                return true;
            }, IntPtr.Zero);
            return handles.ToArray();
        }
        #endregion
    }
}
