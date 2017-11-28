namespace SysText
{

    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    /// <summary> Access to system fon metric class. </summary>
    static public class Metric
    {

        public static byte TMPF_TRUETYPE = 0x4;

        #region Native structs
        [StructLayout(LayoutKind.Sequential)]
        public struct TextMetric
        {
            public int tmHeight;
            public int tmAscent;
            public int tmDescent;
            public int tmInternalLeading;
            public int tmExternalLeading;
            public int tmAveCharWidth;
            public int tmMaxCharWidth;
            public int tmWeight;
            public int tmOverhang;
            public int tmDigitizedAspectX;
            public int tmDigitizedAspectY;
            public char tmFirstChar;
            public char tmLastChar;
            public char tmDefaultChar;
            public char tmBreakChar;
            public byte tmItalic;
            public byte tmUnderlined;
            public byte tmStruckOut;
            public byte tmPitchAndFamily;
            public byte tmCharSet;
        }
        #endregion // Native structs

        /// <summary> Verify is font TrueType </summary>
        /// <param name="font">Font</param>
        /// <returns>Font is TrueType</returns>
        public static bool FontIsTrueType(Font font)
        {
            TextMetric tm;
            GetFontMetrics(font, out tm);
            return (tm.tmPitchAndFamily & TMPF_TRUETYPE) != 0;
        }

        /// <summary> Get font metrics </summary>
        /// <param name="font">Font</param>
        /// <param name="tm">Text metrics</param>
        public static void GetFontMetrics(Font font, out TextMetric tm)
        {
            TextMetric tmRet = new TextMetric();
            IntPtr hdc = GetDC(IntPtr.Zero);

            IntPtr hfnt = font.ToHfont();
            // Select in DC new font
            IntPtr hFontPrevious = SelectObject(hdc, hfnt);

            GetTextMetrics(hdc, ref tmRet);
            SelectObject(hdc, hFontPrevious);
            ReleaseDC(IntPtr.Zero, hdc);
            tm = tmRet;
        }

        [DllImport("Gdi32.dll")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [DllImport("Gdi32.dll")]
        private static extern bool GetTextMetrics(IntPtr hdc, ref TextMetric lptm);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static private extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static private extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

    } // METRIC

} // SYS_TEXT