namespace Timetable
{
    partial class ClassList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassList));
            this.classView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.classView)).BeginInit();
            this.SuspendLayout();
            // 
            // classView
            // 
            this.classView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classView.Location = new System.Drawing.Point(0, 0);
            this.classView.Name = "classView";
            this.classView.Size = new System.Drawing.Size(800, 450);
            this.classView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.classView.TabIndex = 0;
            this.classView.TabStop = false;
            // 
            // ClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.classView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClassList";
            this.Text = "Class List";
            this.Load += new System.EventHandler(this.ClassList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox classView;
    }
}