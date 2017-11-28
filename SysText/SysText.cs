using System;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SysText
{
    /// <summary> Helpers for iTextSharp library </summary>
    public static class iTextHlp
    {

        #region Properties
        /// <summary> Font cache </summary>
        private static Hashtable __cache_fonts;
        #endregion // Properties

        #region Methods
        /// <summary> Get font from system fonts </summary>
        /// <param name="font_nm">Font name</param>
        /// <returns>BaseFont</returns>
        public static BaseFont FontSysGet(string font_nm)
        {

            // Create font cache if not exist
            if (null == __cache_fonts)
                __cache_fonts = new Hashtable();

            // Try get font from cache
            if (__cache_fonts.Contains(font_nm))
                return (BaseFont)__cache_fonts[font_nm];

            BaseFont result_font;

            // Try get font from system
            try
            {
                var sf = new System.Drawing.Font(font_nm, 8f);
                var enc = Metric.FontIsTrueType(sf) ? BaseFont.IDENTITY_H : "Cp1251";
                FontFactory.RegisterDirectories();
                var font = FontFactory.GetFont(font_nm, enc, true);
                result_font = font.GetCalculatedBaseFont(true);
            }
            catch (Exception)
            {
                return null;
            }

            // Save font in cache
            if (null != result_font)
                __cache_fonts[font_nm] = result_font;

            return result_font;
        } // font_sys_get
        #endregion // Methods

    } // ITEXT_HLP
}
