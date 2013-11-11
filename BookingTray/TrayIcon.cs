using System;
using System.Drawing;

namespace BookingTray
{
    /// <summary>
    /// Used to dynamically generate bitmap images for the system tray
    /// </summary>
    static class TrayIcon
    {
        /// <summary>
        /// The width of the bitmap image
        /// </summary>
        private const int imageWidth = 40;

        /// <summary>
        /// The height of the bitmap image
        /// </summary>
        private const int imageHeight = 40;

        /// <summary>
        /// Get an icon
        /// </summary>
        /// <param name="iconText">The text to show in the icon - will be a one or two digit number</param>
        /// <returns>A dynamically created Icon instance</returns>
        public static Icon GetIcon(string iconText)
        {
            Bitmap bitmap = new Bitmap(imageWidth, imageHeight, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Rectangle rectangle = new Rectangle(0, 0, imageWidth, imageHeight);

            int textOffset = 0;
            if (iconText.Length < 2)
                textOffset = 5;

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(System.Drawing.Brushes.Yellow, 0, 0, imageWidth, imageHeight);
            graphics.DrawString(iconText, new Font("Arial", 26, FontStyle.Bold), System.Drawing.Brushes.Black, new PointF(textOffset, 0));

            IntPtr hBitmap = bitmap.GetHicon();
            return Icon.FromHandle(hBitmap);
        }
    }
}
