using System;
using System.Drawing;
using System.Windows.Forms;

namespace Timetable
{
    public partial class ClassList : Form
    {
        public ClassList() =>
            InitializeComponent();

        // When window loads, set class list image and set the size.
        private void ClassList_Load(object sender, EventArgs e)
        {
            Bitmap cl = Functions.LoadImageToMemory($@"{Program.appdata}\classList.png");
            classView.Image = cl;
            Size = MaximumSize = MinimumSize = new Size(cl.Width + 25, cl.Height + 50);
        }
    }
}
