namespace Timetable
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.timetable = new System.Windows.Forms.PictureBox();
            this.menuBar = new System.Windows.Forms.ToolStrip();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.minimiseButton = new System.Windows.Forms.ToolStripButton();
            this.showSettings = new System.Windows.Forms.ToolStripButton();
            this.showClassList = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).BeginInit();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // timetable
            // 
            this.timetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timetable.Location = new System.Drawing.Point(0, 0);
            this.timetable.Name = "timetable";
            this.timetable.Size = new System.Drawing.Size(800, 450);
            this.timetable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.timetable.TabIndex = 0;
            this.timetable.TabStop = false;
            // 
            // menuBar
            // 
            this.menuBar.AllowMerge = false;
            this.menuBar.CanOverflow = false;
            this.menuBar.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitButton,
            this.minimiseButton,
            this.showSettings,
            this.showClassList});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(0);
            this.menuBar.ShowItemToolTips = false;
            this.menuBar.Size = new System.Drawing.Size(800, 27);
            this.menuBar.Stretch = true;
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "toolStrip1";
            this.menuBar.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 24);
            this.exitButton.Text = "❌";
            // 
            // minimiseButton
            // 
            this.minimiseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimiseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.minimiseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimiseButton.Image = ((System.Drawing.Image)(resources.GetObject("minimiseButton.Image")));
            this.minimiseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(34, 24);
            this.minimiseButton.Text = "➖";
            this.minimiseButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // showSettings
            // 
            this.showSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showSettings.Image = ((System.Drawing.Image)(resources.GetObject("showSettings.Image")));
            this.showSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showSettings.Name = "showSettings";
            this.showSettings.Size = new System.Drawing.Size(66, 24);
            this.showSettings.Text = "Settings";
            this.showSettings.Click += new System.EventHandler(this.showSettings_Click);
            // 
            // showClassList
            // 
            this.showClassList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showClassList.Image = ((System.Drawing.Image)(resources.GetObject("showClassList.Image")));
            this.showClassList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showClassList.Name = "showClassList";
            this.showClassList.Size = new System.Drawing.Size(112, 24);
            this.showClassList.Text = "Show Class List";
            this.showClassList.Click += new System.EventHandler(this.showClassList_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.timetable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View";
            this.Text = "Timetable";
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox timetable;
        private System.Windows.Forms.ToolStrip menuBar;
        private System.Windows.Forms.ToolStripButton exitButton;
        private System.Windows.Forms.ToolStripButton minimiseButton;
        private System.Windows.Forms.ToolStripButton showClassList;
        private System.Windows.Forms.ToolStripButton showSettings;
    }
}

