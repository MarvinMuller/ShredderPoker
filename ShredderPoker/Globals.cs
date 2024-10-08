using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShredderPoker
{
    public static class Globals
    {
        public static IntPtr globalHandle = IntPtr.Zero;
        public static Bitmap globalScreenshot = new Bitmap(1, 1);
        public static List<string> globalPositions = new List<string>(9) { "", "", "", "", "", "", "", "", "" };
        public static List<int> globalSeats = new List<int>(9) { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        public static List<bool> disabledSeats = new List<bool>(9) { false, false, false, false, false, false, false, false, false };

        public static readonly List<Rectangle> cardsRect = new List<Rectangle>()
        {
            Rectangle.FromLTRB(422, 432, 442, 457),
            Rectangle.FromLTRB(482, 432, 502, 457),
            Rectangle.FromLTRB(327, 244, 348, 269),
            Rectangle.FromLTRB(389, 244, 410, 269),
            Rectangle.FromLTRB(451, 244, 471, 269),
            Rectangle.FromLTRB(513, 244, 533, 269),
            Rectangle.FromLTRB(575, 244, 595, 269)
        };

        public static readonly int[] dealerColorRange = new int[] { 200, 0, 0, 255, 255, 255 };
        public static readonly List<Rectangle> dealerRect = new List<Rectangle>()
        {
            Rectangle.FromLTRB(392, 427, 412, 444),
            Rectangle.FromLTRB(304, 406, 324, 422),
            Rectangle.FromLTRB(193, 260, 213, 277),
            Rectangle.FromLTRB(206, 228, 226, 244),
            Rectangle.FromLTRB(327, 176, 347, 192),
            Rectangle.FromLTRB(584, 188, 604, 204),
            Rectangle.FromLTRB(722, 223, 742, 240),
            Rectangle.FromLTRB(742, 347, 762, 363),
            Rectangle.FromLTRB(644, 395, 663, 412)
        };

        public static readonly int[] seatColorRange = new int[] { 0, 0, 0, 25, 25, 25 };
        public static readonly List<Rectangle> seatPixel = new List<Rectangle>()
        {
            Rectangle.FromLTRB(397, 506, 398, 507),
            Rectangle.FromLTRB(123, 445, 124, 446),
            Rectangle.FromLTRB(31, 314, 32, 315),
            Rectangle.FromLTRB(70, 186, 71, 187),
            Rectangle.FromLTRB(244, 122, 245, 123),
            Rectangle.FromLTRB(717, 122, 718, 123),
            Rectangle.FromLTRB(888, 186, 889, 187),
            Rectangle.FromLTRB(928, 314, 929, 315),
            Rectangle.FromLTRB(830, 445, 831, 446),
        };

        public static readonly List<Rectangle> cardPixel = new List<Rectangle>()
        {
            Rectangle.FromLTRB(1, 1, 2, 2),
            Rectangle.FromLTRB(154, 395, 155, 396),
            Rectangle.FromLTRB(59, 262, 60, 263),
            Rectangle.FromLTRB(98, 134, 99, 135),
            Rectangle.FromLTRB(272, 72, 273, 73),
            Rectangle.FromLTRB(581, 72, 582, 73),
            Rectangle.FromLTRB(755, 134, 756, 135),
            Rectangle.FromLTRB(793, 262, 794, 263),
            Rectangle.FromLTRB(700, 395, 701, 396)
        };

        public static readonly List<Rectangle> betRect = new List<Rectangle>()
        { 
            Rectangle.FromLTRB(439,398,529,418),
            Rectangle.FromLTRB(297,370,387,390),
            Rectangle.FromLTRB(237,323,327,342),
            Rectangle.FromLTRB(260,222,350,241),
            Rectangle.FromLTRB(381,181,471,200),
            Rectangle.FromLTRB(502,165,592,183),
            Rectangle.FromLTRB(601,202,691,221),
            Rectangle.FromLTRB(634,324,724,343),
            Rectangle.FromLTRB(556,370,646,388)
        };

        public static readonly List<Rectangle> stackRect = new List<Rectangle>()
        {
            Rectangle.FromLTRB(412,506,513,527),
            Rectangle.FromLTRB(138,446,239,466),
            Rectangle.FromLTRB(46,314,147,334),
            Rectangle.FromLTRB(85,185,186,205),
            Rectangle.FromLTRB(258,124,359,144),
            Rectangle.FromLTRB(602,124,703,144),
            Rectangle.FromLTRB(755,186,856,206),
            Rectangle.FromLTRB(814,315,915,335),
            Rectangle.FromLTRB(722,449,823,669)
        };
    }
}
