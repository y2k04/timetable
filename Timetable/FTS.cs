using Docnet.Core;
using Docnet.Core.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Timetable
{
    public partial class FTS : Form
    {
        private string timetablePath = "";
        private string classListPath = "";

        // Initialise the FTS class, check if any of the Timetable assets exist,
        // if they do, set them to the values for the app. (So the user doesn't have to reimport them)
        public FTS()
        {
            InitializeComponent();
            if (File.Exists($@"{Program.appdata}\timetable.png"))
                timetablePath = $@"{Program.appdata}\timetable.png";

            if (File.Exists($@"{Program.appdata}\classList.png"))
                classListPath = $@"{Program.appdata}\classList.png";

            selectedTimetablePath.Text = timetablePath == "" ? "(none)" : timetablePath.Substring(timetablePath.LastIndexOf(@"\") + 1,timetablePath.Length - timetablePath.LastIndexOf(@"\") - 1);
            selectedClassListPath.Text = classListPath == "" ? "(none)" : classListPath.Substring(classListPath.LastIndexOf(@"\") + 1, classListPath.Length - classListPath.LastIndexOf(@"\") - 1);
        }

        // Show the open file dialog and ask for the timetable pdf or png
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG image (*.png)|*.png|PDF Document (*.pdf)|*.pdf";
            openFileDialog1.Title = "Select your timetable";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedTimetablePath.Text = openFileDialog1.SafeFileName;
                timetablePath = openFileDialog1.FileName;
            }
            if (timetablePath != "" && classListPath != "")
                finish.Enabled = true;
        }

        // Show the open file dialog and ask for the class list png
        private void selectClassList_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG image (*.png)|*.png";
            openFileDialog1.Title = "Select your class list";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedClassListPath.Text = openFileDialog1.SafeFileName;
                classListPath = openFileDialog1.FileName;
            }
            if (timetablePath != "" && classListPath != "")
                finish.Enabled = true;
        }

        // Convert the Timetable pdf to a png (if it is a pdf), save the timetable and class list
        // to the AppData folder and restart the app
        private void finish_Click(object sender, EventArgs e)
        {
            Program.ClassListModified = "";
            Program.TimetableModified = "";
            if (timetablePath.EndsWith(".pdf"))
            {
                using (var docReader = DocLib.Instance.GetDocReader(timetablePath, new PageDimensions(2160, 3840)))
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
                File.Copy(timetablePath, $@"{Program.appdata}\timetable.png");
            if (!File.Exists($@"{Program.appdata}\classList.png"))
                File.Copy(classListPath, $@"{Program.appdata}\classList.png");
            new CropImage(() => {
                Process.Start(Application.ExecutablePath);
                Application.Exit();
                return null;
            }).ShowDialog();
            Hide();
        }

        // Function to move bitmap bytes to a byte array
        private static void AddBytes(Bitmap bmp, byte[] rawBytes)
        {
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            var bmpData = bmp.LockBits(rect, ImageLockMode.WriteOnly, bmp.PixelFormat);
            var pNative = bmpData.Scan0;

            Marshal.Copy(rawBytes, 0, pNative, rawBytes.Length);
            bmp.UnlockBits(bmpData);
        }
    }
}
