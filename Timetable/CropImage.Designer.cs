namespace Timetable
{
    partial class CropImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropImage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageView = new System.Windows.Forms.PictureBox();
            this.clearSel = new System.Windows.Forms.Button();
            this.saveExit = new System.Windows.Forms.Button();
            this.cropED = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imageView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clearSel);
            this.splitContainer1.Panel2.Controls.Add(this.saveExit);
            this.splitContainer1.Panel2.Controls.Add(this.cropED);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // imageView
            // 
            this.imageView.BackColor = System.Drawing.Color.White;
            this.imageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageView.Location = new System.Drawing.Point(0, 0);
            this.imageView.Name = "imageView";
            this.imageView.Size = new System.Drawing.Size(492, 450);
            this.imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageView.TabIndex = 0;
            this.imageView.TabStop = false;
            this.imageView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageView_MouseDown);
            this.imageView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageView_MouseMove);
            this.imageView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageView_MouseUp);
            // 
            // clearSel
            // 
            this.clearSel.AutoSize = true;
            this.clearSel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearSel.Enabled = false;
            this.clearSel.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.clearSel.Location = new System.Drawing.Point(0, 27);
            this.clearSel.Name = "clearSel";
            this.clearSel.Size = new System.Drawing.Size(307, 27);
            this.clearSel.TabIndex = 2;
            this.clearSel.Text = "Clear Selection";
            this.clearSel.UseVisualStyleBackColor = true;
            this.clearSel.Click += new System.EventHandler(this.clearSel_Click);
            // 
            // saveExit
            // 
            this.saveExit.AutoSize = true;
            this.saveExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveExit.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.saveExit.Location = new System.Drawing.Point(0, 409);
            this.saveExit.Name = "saveExit";
            this.saveExit.Size = new System.Drawing.Size(307, 41);
            this.saveExit.TabIndex = 1;
            this.saveExit.Text = "Save and Exit";
            this.saveExit.UseVisualStyleBackColor = true;
            this.saveExit.Click += new System.EventHandler(this.saveExit_Click);
            // 
            // cropED
            // 
            this.cropED.AutoSize = true;
            this.cropED.Dock = System.Windows.Forms.DockStyle.Top;
            this.cropED.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.cropED.Location = new System.Drawing.Point(0, 0);
            this.cropED.Name = "cropED";
            this.cropED.Size = new System.Drawing.Size(307, 27);
            this.cropED.TabIndex = 0;
            this.cropED.Text = "Start Crop Selection";
            this.cropED.UseVisualStyleBackColor = true;
            this.cropED.Click += new System.EventHandler(this.CropED_Click);
            // 
            // CropImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CropImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crop Timetable";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.CropImage_Shown);
            this.ResizeBegin += new System.EventHandler(this.CropImage_ResizeBegin);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button cropED;
        private System.Windows.Forms.PictureBox imageView;
        private System.Windows.Forms.Button saveExit;
        private System.Windows.Forms.Button clearSel;
    }
}