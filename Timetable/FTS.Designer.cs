namespace Timetable
{
    partial class FTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTS));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.selectedTimetablePath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.finish = new System.Windows.Forms.Button();
            this.selectedClassListPath = new System.Windows.Forms.Label();
            this.selectClassList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label1.Location = new System.Drawing.Point(3, 203);
            this.label1.MaximumSize = new System.Drawing.Size(355, 0);
            this.label1.MinimumSize = new System.Drawing.Size(355, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you for installing Timetable!\r\nTo begin using this program, there are a few" +
    " things we need to sort out.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Timetable.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(0, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select your timetable (can be a PDF or PNG file)";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.button1.Location = new System.Drawing.Point(6, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectedTimetablePath
            // 
            this.selectedTimetablePath.AutoSize = true;
            this.selectedTimetablePath.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.selectedTimetablePath.Location = new System.Drawing.Point(92, 317);
            this.selectedTimetablePath.Name = "selectedTimetablePath";
            this.selectedTimetablePath.Size = new System.Drawing.Size(45, 17);
            this.selectedTimetablePath.TabIndex = 4;
            this.selectedTimetablePath.Text = "(none)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PDF Document (*.pdf)|*.pdf|PNG image (*.png)|*.png";
            this.openFileDialog1.Title = "Select your timetable";
            // 
            // finish
            // 
            this.finish.AutoSize = true;
            this.finish.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.finish.Enabled = false;
            this.finish.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.finish.Location = new System.Drawing.Point(0, 423);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(358, 27);
            this.finish.TabIndex = 5;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // selectedClassListPath
            // 
            this.selectedClassListPath.AutoSize = true;
            this.selectedClassListPath.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.selectedClassListPath.Location = new System.Drawing.Point(92, 386);
            this.selectedClassListPath.Name = "selectedClassListPath";
            this.selectedClassListPath.Size = new System.Drawing.Size(45, 17);
            this.selectedClassListPath.TabIndex = 8;
            this.selectedClassListPath.Text = "(none)";
            // 
            // selectClassList
            // 
            this.selectClassList.AutoSize = true;
            this.selectClassList.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.selectClassList.Location = new System.Drawing.Point(6, 381);
            this.selectClassList.Name = "selectClassList";
            this.selectClassList.Size = new System.Drawing.Size(80, 27);
            this.selectClassList.TabIndex = 7;
            this.selectClassList.Text = "Select File";
            this.selectClassList.UseVisualStyleBackColor = true;
            this.selectClassList.Click += new System.EventHandler(this.selectClassList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label4.Location = new System.Drawing.Point(3, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Please select your class list (needs to be a PNG file,\r\nyou can screenshot it to " +
    "do this)";
            // 
            // FTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.ControlBox = false;
            this.Controls.Add(this.selectedClassListPath);
            this.Controls.Add(this.selectClassList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.selectedTimetablePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(376, 497);
            this.Name = "FTS";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timetable - First Time Setup";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label selectedTimetablePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Label selectedClassListPath;
        private System.Windows.Forms.Button selectClassList;
        private System.Windows.Forms.Label label4;
    }
}

