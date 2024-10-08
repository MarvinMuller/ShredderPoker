using static ShredderPoker.BitmapHandler;
using static ShredderPoker.Globals;
using Tesseract;

namespace ShredderPoker
{
    public partial class TableReader
    {
        public static string ReadRectText(int id)
        {
            var sliceRect = cardsRect[id];
            var slice = globalScreenshot.Clone(sliceRect, globalScreenshot.PixelFormat);

            slice.Save(@".\\Screenshot\\Rect.png");
            slice.Dispose();

            using (var engine = new TesseractEngine(@"C:\\Program Files\\Tesseract-OCR\\tessdata", "eng", EngineMode.Default))
            {
                engine.DefaultPageSegMode = PageSegMode.SingleLine;
                engine.SetVariable("tessedit_char_whitelist", "0123456789JQKA");

                using (var img = Pix.LoadFromFile(@".\\Screenshot\\Rect.png"))
                {
                    using (var page = engine.Process(img))
                    {
                        var text = page.GetText().Replace("\n", "").Replace(" ", "").Replace("\f", "");
                        img.Dispose();
                        return text;
                    }
                }
            }
        }

        public static string GetCardSuit(Rectangle rect)
        {
            for (int y = rect.Top; y < rect.Bottom; y++)
            {
                for (int x = rect.Left; x < rect.Right; x++)
                {
                    Color pixelColor = globalScreenshot.GetPixel(x, y);
                    Color red = Color.FromArgb(255, 208, 57, 43);
                    Color green = Color.FromArgb(255, 27, 167, 49);
                    Color blue = Color.FromArgb(255, 43, 89, 208);
                    Color black = Color.FromArgb(255, 18, 24, 31);

                    if (pixelColor == red)
                    { return "h"; }
                    if (pixelColor == green)
                    { return "c"; }
                    if (pixelColor == blue)
                    { return "d"; }
                    if (pixelColor == black)
                    { return "s"; }
                }
            }
            return "";
        }

        public static string GetCard(int id)
        {
            string cardValue = ReadRectText(id);
            if (cardValue == "10")
            {
                cardValue = "T";
            }
            else if (cardValue == "0")
            {
                cardValue = "Q";
            }

            string cardSuit = GetCardSuit(cardsRect[id]);

            if (cardValue == "" || cardSuit == "")
                return "";

            return cardValue + cardSuit;
        }

        public static int GetDealer()
        {
            for (int i = 0; i < 9; i++)
            {
                Bitmap croppedBitmap = globalScreenshot.Clone(dealerRect[i], globalScreenshot.PixelFormat);
                bool found = PixelScan(croppedBitmap, dealerColorRange);
                if (found)
                    return i;
            }
            return -1;
        }

        public static List<string> AvailablePositions()
        {
            string[] availablePositions = { "BB", "SB", "BTN", "CO", "HJ", "LJ", "MP", "UTG+1", "UTG" };
            OccupiedSeats();
            int seatsCount = globalSeats.Sum();
            List<string> positions = new List<string>();
            for (int i = 0; i < seatsCount; i++)
            {
                positions.Add((string)availablePositions[i]);
            }
            for (int i = 0; i <= 2; i++)
            {
                string firsPos = positions[0];
                positions.RemoveAt(0);
                positions.Add(firsPos);
            }
            positions.Reverse();
            return positions;
        }

        public static void OccupiedSeats()
        {
            for (int i = 0; i < 9; i++)
            {
                Bitmap croppedBitmap = globalScreenshot.Clone(seatPixel[i], globalScreenshot.PixelFormat);

                bool found = GrayPixel(croppedBitmap, 8);

                if (!disabledSeats[i])
                    globalSeats[i] = found ? 1 : 0;
                else
                {
                    globalSeats[i] = 0;
                }

                croppedBitmap.Dispose();
            }
        }

        public static void DistributePositions()
        {
            List<string> positions = new List<string>();
            positions = AvailablePositions();
            int dealer = GetDealer();
            int emptySeats = 0;

            for (int i = 0; i < dealer; i++)
            {
                if (globalSeats[i] == 0)
                    emptySeats++;
            }

            int dealerMinusEmptySeats = dealer - emptySeats;

            for (int i = 0; i < dealerMinusEmptySeats; i++)
            {
                string lastPos = positions[positions.Count - 1];
                positions.RemoveAt(positions.Count - 1);
                positions.Insert(0, lastPos);
            }

            for (int i = 0; i < 9; i++)
            {

                if (globalSeats[i] == 1)
                {
                    globalPositions[i] = positions[0];
                    positions.RemoveAt(0);
                }
                else
                {
                    globalPositions[i] = "";
                }
            }
        }
    }
}
