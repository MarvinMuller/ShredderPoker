using static ShredderPoker.Globals;
using static ShredderPoker.WindowManager;

namespace ShredderPoker
{
    public partial class WindowSelect : Form
    {
        private IntPtr[]? handles;

        public WindowSelect()
        {
            InitializeComponent();
            PopulateWindowList(tcWindowList, "Logged");
        }

        private void PopulateWindowList(ListBox listBox, string partialName)
        {
            handles = FindWindowsWithPartialName(partialName);
            for (int i = 0; i < handles.Length; i++)
            {
                string windowTitle = GetWindowTitle(handles[i]);
                listBox.Items.Add($"{windowTitle}");
            }
        }

        private void tcWindowSelect_Load(object sender, EventArgs e)
        {
            Color midGray = Color.FromArgb(0x4e, 0x4b, 0x49);
            Color lightGray = Color.FromArgb(0x88, 0x8c, 0x7d);
            Color darkGray = Color.FromArgb(0x2d, 0x2b, 0x29);
            Font tcFont = new Font("Cascadia Code", 11, FontStyle.Bold);

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = darkGray;
            tcWindowList.BackColor = midGray;
            tcWindowList.ForeColor = midGray;
            tcWindowList.BorderStyle = BorderStyle.None;
            foreach (Control control in this.Controls)
            {
                control.Font = tcFont;
                control.ForeColor = lightGray;

                if (control is Button)
                {
                    control.BackColor = Color.Transparent;
                    Button button = (Button)control;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                }
            }
        }

        private void tcSelect_Click(object sender, EventArgs e)
        {
            if (tcWindowList.SelectedItem != null && handles != null)
            {
                int selectedIndex = tcWindowList.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < handles.Length)
                {
                    IntPtr handle = handles[selectedIndex];
                    MoveAndResizeWindow(handle, 0, 0, 960, 700);
                    SetForegroundWindow(handle);

                    Form? MainForm = this.Owner;
                    if (MainForm != null)
                    {
                        MainForm.Location = new Point(955, 2);
                    }

                    globalHandle = handle;
                }
            }
            this.Close();
        }

        private void tcCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
