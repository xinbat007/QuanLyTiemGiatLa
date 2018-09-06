using System;
using System.Drawing;
using System.Drawing.Printing;

namespace QuanLyTiemGiatLa.UserCtrl
{
	public class PCPrint : System.Drawing.Printing.PrintDocument
	{
		public String TextToPrint { get; set; }
		public Font PrinterFont { get; set; }

		static int curChar;

		public PCPrint() : base()
		{
			TextToPrint = String.Empty;
		}

		public PCPrint(String textToPrint) : base()
		{
			TextToPrint = textToPrint;
		}

		protected override void OnBeginPrint(PrintEventArgs e)
		{
			base.OnBeginPrint(e);
			if (PrinterFont == null)
			{
				PrinterFont = new Font("Arial", 10);
			}
		}

		protected override void OnPrintPage(PrintPageEventArgs e)
		{
			base.OnPrintPage(e);
			int printHeight, printWidth, leftMargin, rightMargin;
			Int32 lines, chars;
			printHeight = base.DefaultPageSettings.PaperSize.Height - base.DefaultPageSettings.Margins.Top - base.DefaultPageSettings.Margins.Bottom;
			printWidth = base.DefaultPageSettings.PaperSize.Width - base.DefaultPageSettings.Margins.Left - base.DefaultPageSettings.Margins.Right;
			leftMargin = base.DefaultPageSettings.Margins.Left;  //X
			rightMargin = base.DefaultPageSettings.Margins.Top;  //Y
			if (base.DefaultPageSettings.Landscape)
			{
				int tmp;
				tmp = printHeight;
				printHeight = printWidth;
				printWidth = tmp;
			}
			Int32 numLines = (int)printHeight / PrinterFont.Height;
			RectangleF printArea = new RectangleF(leftMargin, rightMargin, printWidth, printHeight);
			StringFormat format = new StringFormat(StringFormatFlags.LineLimit);
			e.Graphics.MeasureString(TextToPrint.Substring(RemoveZeros(curChar)), PrinterFont, 
						new SizeF(printWidth, printHeight), format, out chars, out lines);
			e.Graphics.DrawString(TextToPrint.Substring(RemoveZeros(curChar)), PrinterFont, Brushes.Black, printArea, format);
			curChar += chars;
			if (curChar < TextToPrint.Length)
			{
				e.HasMorePages = true;
			}
			else
			{
				e.HasMorePages = false;
				curChar = 0;
			}
		}

		private int RemoveZeros(int value)
		{
			return value == 0 ? 1 : value;
		}
	}
}
