using System;
using System.Drawing;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Timetable
{
    public partial class View : Form
    {
        private Image ttImg;

        // Initialise View class and add event handlers
        public View()
        {
            InitializeComponent();
            Load += View_Load;
            GotFocus += View_GotFocus;
            LostFocus += View_LostFocus;
            exitButton.Click += ExitButton_Click;
            minimiseButton.Click += MinimiseButton_Click;
            SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;
            
            ttImg = Functions.ScaleImage(Functions.LoadImageToMemory($@"{Program.appdata}\timetable.png"), Screen.PrimaryScreen.Bounds.Width, (int)(Screen.PrimaryScreen.Bounds.Height / 1.2f));
        }

        // Since it is a custom window control box, I have to add my own event handlers for the buttons
        private void ExitButton_Click(object sender, EventArgs e) =>
            Application.Exit();

        // When another program is focused or if the desktop is clicked (which causes all windows to be
        // unfocused) hide the menu bar
        private void View_LostFocus(object sender, EventArgs e) =>
            menuBar.Hide();

        // Does the opposite of the above event handler.
        private void View_GotFocus(object sender, EventArgs e) =>
            menuBar.Show();

        // Animates the window to the side and minimises it.
        private void MinimiseButton_Click(object sender, EventArgs e)
        {
            Functions.HideWindow(Handle, WindowState);
            WindowState = FormWindowState.Minimized;
        }

        // When the screen orientation changes, reposition the window, otherwise it would just be moved to
        // the middle of the screen.
        private void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e) =>
            Functions.FitToImageBounds(this, ttImg, timetable);

        // When the app loads, resize the window to fit the timetable image.
        private void View_Load(object sender, EventArgs e) =>
            Functions.FitToImageBounds(this, ttImg, timetable);

        // Opens the class list window
        private void showClassList_Click(object sender, EventArgs e) =>
            new ClassList().ShowDialog();

        // Shows the settings window, and reloads the timetable image on the main window after it closes.
        private void showSettings_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();

            timetable.Image = Functions.ScaleImage(Functions.LoadImageToMemory($@"{Program.appdata}\timetable.png"), Screen.PrimaryScreen.Bounds.Width, (int)(Screen.PrimaryScreen.Bounds.Height / 1.2f));
            ttImg = timetable.Image;

            Functions.FitToImageBounds(this, ttImg, timetable);
        }
    }
}

