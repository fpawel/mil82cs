using System;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SysText
{
    public class CellSpacingEvent : IPdfPCellEvent
    {
        public CellSpacingEvent()
        {
            CellSpacing = 2;
            BorderColor = BaseColor.LIGHT_GRAY;
        }

        public int CellSpacing { get; set; }
        public BaseColor BorderColor { get; set; }

        void IPdfPCellEvent.CellLayout(PdfPCell cell, Rectangle position, PdfContentByte[] canvases)
        {
            //Grab the line canvas for drawing lines on
            PdfContentByte cb = canvases[PdfPTable.LINECANVAS];
            //Create a new rectangle using our previously supplied spacing
            cb.Rectangle(
                position.Left + CellSpacing,
                position.Bottom + CellSpacing,
                (position.Right - CellSpacing) - (position.Left + CellSpacing),
                (position.Top - CellSpacing) - (position.Bottom + CellSpacing)
                );
            //Set a color
            cb.SetColorStroke(BorderColor);
            //Draw the rectangle
            cb.Stroke();
        }
    }
}
