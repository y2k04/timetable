using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Timetable
{
    public partial class CropImage : Form
    {
        private Func<dynamic> finishAction;
        private bool croppingEnabled = false;
        private int cropX,cropY,cropWidth,cropHeight;
        public Pen cropPen = new Pen(Color.Black, 1) { DashStyle = DashStyle.DashDotDot };

        public DashStyle cropDashStyle = DashStyle.DashDot;

        public CropImage(Func<dynamic> onFinish)
        {
            InitializeComponent();
            finishAction = onFinish;
        }

        // Save the cropped (or uncropped) version of the Timetable and run the 'finishAction' function
        // that was supplied from the FTS class.
        private void saveExit_Click(object sender, EventArgs e)
        {
            imageView.Image.Save($@"{Program.appdata}\timetable.png");
            finishAction();
            Close();
        }

        // Reload the Timetable from file and replace the drawn image.
        private void clearSel_Click(object sender, EventArgs e)
        {
            cropX = cropY = cropWidth = cropHeight = 0;
            Bitmap i = new Bitmap(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
            Graphics g = Graphics.FromImage(i);
            Bitmap t = Functions.LoadImageToMemory($@"{Program.appdata}\timetable.png");
            g.Clear(Color.White);
            g.DrawImage(Functions.ScaleImage(t,i.Width,i.Height), 0, 0);
            imageView.Image = i;
            clearSel.Enabled = false;
        }

        // When the left mouse button is pressed, start drawing the crop region and change the mouse cursor
        // to a '+'.
        private void imageView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && croppingEnabled)
            {
                saveExit.Enabled = false;
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
            }
            imageView.Refresh();
        }

        // When the left mouse button is unpressed, crop and resize the image.
        private void imageView_MouseUp(object sender, MouseEventArgs e)
        {
            if (croppingEnabled)
            {
                Cursor = Cursors.Default;
                if (cropWidth < 1) return;
                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
                Bitmap ori = new Bitmap(imageView.Image, imageView.Width, imageView.Height);
                Bitmap _img = new Bitmap(cropWidth, cropHeight);
                Graphics g = Graphics.FromImage(_img);
                g.CompositingQuality = CompositingQuality.HighSpeed;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PageUnit = GraphicsUnit.Pixel;
                g.SmoothingMode = SmoothingMode.None;
                g.DrawImage(ori, new Rectangle(0,0,cropWidth, cropHeight),rect,GraphicsUnit.Pixel);
                imageView.Image = _img;
                imageView.Size = _img.Size;
                clearSel.Enabled = saveExit.Enabled = cropED.Enabled = true;
                croppingEnabled = false;
                cropED.Text = "Start Crop Selection";
            }
        }

        // When the window is shown, set the size of the container and draw the Timetable [to be cropped].
        private void CropImage_Shown(object sender, EventArgs e)
        {
            Bitmap i = new Bitmap(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
            Graphics g = Graphics.FromImage(i);
            Bitmap t = Functions.LoadImageToMemory($@"{Program.appdata}\timetable.png");
            g.Clear(Color.White);
            g.DrawImage(Functions.ScaleImage(t, i.Width, i.Height), 0, 0);
            imageView.Image = i;
        }

        // When the left mouse button is held over the cropping area and dragged, it will draw the cropping region.
        private void imageView_MouseMove(object sender, MouseEventArgs e)
        {
            if (imageView.Image == null) return;
            if (e.Button == MouseButtons.Left && croppingEnabled)
            {
                imageView.Refresh();
                cropWidth = e.X - cropX;
                cropHeight = e.Y - cropY;
                imageView.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
            }
        }

        // Change the position of the splitter when the window is resized.
        private void CropImage_ResizeBegin(object sender, EventArgs e) =>
            splitContainer1.SplitterDistance = (int)(Width * 0.6f);

        // Disable crop button, change text and enable cropping on click.
        private void CropED_Click(object sender, EventArgs e)
        {
            croppingEnabled = true;
            cropED.Enabled = false;
            cropED.Text = "Cropping enabled";
        }
    }
}
