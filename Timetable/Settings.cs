using System;
using Microsoft.Win32;
using System.Windows.Forms;
using Docnet.Core;
using Docnet.Core.Models;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace Timetable
{
    public partial class Settings : Form
    {
        // Create the registry value for when the timetable and class list was last saved.
        public Settings()
        {
            InitializeComponent();
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Timetable");
            startupEnabledBox.Checked = LaunchOnStartup;
            timetableLastChanged.Text = Program.TimetableModified;
            classListLastChanged.Text = Program.ClassListModified;
        }

        // Set the startup checkbox state to true or false depending on if it is set to start
        private void startupEnabledBox_CheckedChanged(object sender, EventArgs e) =>
            LaunchOnStartup = startupEnabledBox.Checked;

        // Open the registry key and check whether the Timetable app is listed as an application,
        // or alternatively, set the value or delete it.
        private bool LaunchOnStartup
        {
            get {
                return (Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).GetValue(GetType().Namespace) == null ? false : true);
            }
            set {
                if (value == true)
                    Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).SetValue(GetType().Namespace, Application.ExecutablePath);
                else if (value == false)
                    Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue(GetType().Namespace);
            }
        }

        // Ask user for timetable pdf or png and convert it to png (if it is infact a pdf) and save it
        // to the appdata folder. Also set the last modified date in the registry.
        private void replaceTimetable_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF Document (*.pdf)|*.pdf|PNG image (*.png)|*.png";
            openFileDialog1.Title = "Select your timetable";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.EndsWith(".pdf"))
                {
                    using (var docReader = DocLib.Instance.GetDocReader(openFileDialog1.FileName, new PageDimensions(1080,1920)))
                    using (var pageReader = docReader.GetPageReader(0))
                    {
                        var rawBytes = pageReader.GetImage(RenderFlags.RenderAnnotations);
                        var width = pageReader.GetPageWidth();
                        var height = pageReader.GetPageHeight();

                        using (var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb))
                        {
                            AddBytes(bmp, rawBytes);
                            Bitmap nb = new Bitmap(width, height, PixelFormat.Format32bppArgb);
                            Graphics g = Graphics.FromImage(nb);
                            g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, width, height));
                            g.DrawImage(bmp, new Rectangle(0, 0, width, height));
                            g.CompositingQuality = CompositingQuality.HighQuality;
                            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            g.PageUnit = GraphicsUnit.Pixel;
                            g.SmoothingMode = SmoothingMode.HighQuality;
                            g.Save();

                            using (var stream = new MemoryStream())
                            {
                                nb.Save(stream, ImageFormat.Png);
                                File.WriteAllBytes($@"{Program.appdata}\timetable.png", stream.ToArray());
                            }
                        }
                    }
                }
                else
                    File.Copy(openFileDialog1.FileName, $@"{Program.appdata}\timetable.png");
                new CropImage(() => { return null; }).ShowDialog();
                Program.TimetableModified = "";
                timetableLastChanged.Text = Program.TimetableModified;
            }
        }

        // Function to move image bytes to a byte array
        private static void AddBytes(Bitmap bmp, byte[] rawBytes)
        {
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            var bmpData = bmp.LockBits(rect, ImageLockMode.WriteOnly, bmp.PixelFormat);
            var pNative = bmpData.Scan0;

            Marshal.Copy(rawBytes, 0, pNative, rawBytes.Length);
            bmp.UnlockBits(bmpData);
        }

        // Ask user for class list png and save it to the appdata folder.
        // Also set the class list last modified date.
        private void replaceClassList_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG image (*.png)|*.png";
            openFileDialog1.Title = "Select your class list";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(openFileDialog1.FileName != $@"{Program.appdata}\classList.png")
                    File.Copy(openFileDialog1.FileName, $@"{Program.appdata}\classList.png");
                Program.ClassListModified = "";
                classListLastChanged.Text = Program.ClassListModified;
            }
        }
    }
}
