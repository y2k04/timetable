using System;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Timetable
{
    public static class Functions
    {
        public const int AW_HOR_POSITIVE = 0x00000001;
        public const int AW_SLIDE = 0x00040000;
        public const int AW_HIDE = 0x00010000;

        // Import system dll function to animate the window
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        // Read the image file and put it in memory (avoid locking the file)
        public static Bitmap LoadImageToMemory(string path)
        {
            try
            {
                using (var stream = WebRequest.Create(path).GetResponse().GetResponseStream())
                    if (stream != null)
                        return (Bitmap)Image.FromStream(stream);
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Change image size without any stretching within the bounds of the minimum and maximum size values.
        public static Bitmap ScaleImage(Bitmap bmp, int maxWidth, int maxHeight)
        {
            var ratio = Math.Min((double)maxWidth / bmp.Width, (double)maxHeight / bmp.Height);
            var newImage = new Bitmap((int)(bmp.Width * ratio), (int)(bmp.Height * ratio));
            Graphics.FromImage(newImage).DrawImage(bmp,0,0,newImage.Width,newImage.Height);
            return newImage;
        }

        // Animate the window on minimise
        public static void HideWindow(IntPtr handle,FormWindowState window) =>
            AnimateWindow(handle, 100, AW_SLIDE | AW_HOR_POSITIVE | AW_HIDE);

        // Change the window size to the size of the input image
        public static void FitToImageBounds(Form form, Image image, PictureBox imgbox)
        {
            form.Width = image.Width;
            form.Height = image.Height;
            form.Location = new Point(Screen.PrimaryScreen.Bounds.Width - form.Width, 0);
            imgbox.Image = image;
        }
    }
}
