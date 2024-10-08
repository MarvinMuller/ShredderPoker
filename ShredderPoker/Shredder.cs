using System.Diagnostics;
using System.Windows.Forms;
using static ShredderPoker.Globals;
using static ShredderPoker.TableReader;
using static ShredderPoker.WindowManager;

namespace ShredderPoker
{
    public partial class Shredder : Form
    {
        string[] cards = new string[7];
        string[] cPath = new string[7];
        List<PictureBox> cardImage = new List<PictureBox>(7);
        public static List<Button> playerButtons = new List<Button>(9);

        public Shredder()
        {
            InitializeComponent();
        }

        private void tcLoad(object sender, EventArgs e)
        {
            Font tcFont = new Font("Cascadia Code", 11, FontStyle.Bold);
            this.FormBorderStyle = FormBorderStyle.None;

            foreach (Control control in this.Controls)
            {
                control.Font = tcFont;

                if (control is Button)
                {
                    control.BackColor = Color.Transparent;
                    Button button = (Button)control;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    button.FlatAppearance.MouseDownBackColor = Color.Transparent;

                    if (control.Name.StartsWith("player"))
                    {
                        Button playerSeat = (Button)control;
                        playerButtons.Add(playerSeat);
                    }
                }

                if (control is PictureBox && control.Name.StartsWith("card"))
                {
                    PictureBox cardPicture = (PictureBox)control;
                    cardPicture.BackColor = Color.Transparent;

                    cardImage.Add(cardPicture);
                }
            }
            playerButtons = playerButtons.OrderBy(button => button.Name).ToList();
            cardImage = cardImage.OrderBy(cardImage => cardImage.Name).ToList();

            for (int i = 1; i < 9; i++)
            {
                int buttonIndex = i;
                playerButtons[i].Click += (sender, e) =>
                {
                    disabledSeats[buttonIndex] = !disabledSeats[buttonIndex];
                    playerButtons[buttonIndex].Text = disabledSeats[buttonIndex] ? "disabled" : "enabled";
                };
            }
        }

        private void tcExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tcAttach_Click(object sender, EventArgs e)
        {
            WindowSelect tcSelect = new WindowSelect();
            tcSelect.Owner = this;
            tcSelect.StartPosition = FormStartPosition.Manual;
            tcSelect.Location = new Point(this.Location.X + 335, this.Location.Y + 45);
            tcSelect.Show();
        }

        private void tcTicker_Tick(object sender, EventArgs e)
        {
            if (globalHandle == IntPtr.Zero) { return; }
            globalScreenshot = StoreScreenshotToBitmap(globalHandle);

            for (int i = 0; i <= 6; i++)
            {
                cards[i] = GetCard(i);
                if (cards[i] != "")
                {
                    cPath[i] = @".\Cards\" + cards[i] + ".png";
                    try
                    {
                        cardImage[i].Image = Image.FromFile(cPath[i]);
                    }
                    catch
                    {
                        cards[i] = "";
                        cardImage[i].Image = null;
                    }
                }
                else
                {
                    cardImage[i].Image = null;
                }
            }

            DistributePositions();
            for (int i = 0; i < 9; i++)
            {
                playerButtons[i].Text = globalPositions[i];
            }

            globalScreenshot.Dispose();
        }

        private void player0_OnClick(object sender, EventArgs e)
        {
            if (globalHandle == IntPtr.Zero) { return; }

            globalScreenshot = WindowManager.StoreScreenshotToBitmap(globalHandle);

            globalScreenshot.Save(@".\\Screenshot\\FullTable.png");
            globalScreenshot.Dispose();
        }
    }
}