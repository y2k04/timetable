namespace Timetable
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.startupEnabledBox = new System.Windows.Forms.CheckBox();
            this.classListLastChanged = new System.Windows.Forms.Label();
            this.timetableLastChanged = new System.Windows.Forms.Label();
            this.replaceClassList = new System.Windows.Forms.Button();
            this.replaceTimetable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // startupEnabledBox
            // 
            this.startupEnabledBox.AutoSize = true;
            this.startupEnabledBox.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.startupEnabledBox.Location = new System.Drawing.Point(12, 106);
            this.startupEnabledBox.Name = "startupEnabledBox";
            this.startupEnabledBox.Size = new System.Drawing.Size(130, 21);
            this.startupEnabledBox.TabIndex = 9;
            this.startupEnabledBox.Text = "Launch at startup";
            this.startupEnabledBox.UseVisualStyleBackColor = true;
            this.startupEnabledBox.CheckedChanged += new System.EventHandler(this.startupEnabledBox_CheckedChanged);
            // 
            // classListLastChanged
            // 
            this.classListLastChanged.AutoSize = true;
            this.classListLastChanged.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.classListLastChanged.Location = new System.Drawing.Point(151, 50);
            this.classListLastChanged.Name = "classListLastChanged";
            this.classListLastChanged.Size = new System.Drawing.Size(127, 17);
            this.classListLastChanged.TabIndex = 8;
            this.classListLastChanged.Text = "Last changed: Never";
            // 
            // timetableLastChanged
            // 
            this.timetableLastChanged.AutoSize = true;
            this.timetableLastChanged.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.timetableLastChanged.Location = new System.Drawing.Point(151, 17);
            this.timetableLastChanged.Name = "timetableLastChanged";
            this.timetableLastChanged.Size = new System.Drawing.Size(127, 17);
            this.timetableLastChanged.TabIndex = 7;
            this.timetableLastChanged.Text = "Last changed: Never";
            // 
            // replaceClassList
            // 
            this.replaceClassList.AutoSize = true;
            this.replaceClassList.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.replaceClassList.Location = new System.Drawing.Point(12, 45);
            this.replaceClassList.Name = "replaceClassList";
            this.replaceClassList.Size = new System.Drawing.Size(133, 27);
            this.replaceClassList.TabIndex = 6;
            this.replaceClassList.Text = "Replace Class List";
            this.replaceClassList.UseVisualStyleBackColor = true;
            this.replaceClassList.Click += new System.EventHandler(this.replaceClassList_Click);
            // 
            // replaceTimetable
            // 
            this.replaceTimetable.AutoSize = true;
            this.replaceTimetable.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.replaceTimetable.Location = new System.Drawing.Point(12, 12);
            this.replaceTimetable.Name = "replaceTimetable";
            this.replaceTimetable.Size = new System.Drawing.Size(133, 27);
            this.replaceTimetable.TabIndex = 5;
            this.replaceTimetable.Text = "Replace Timetable";
            this.replaceTimetable.UseVisualStyleBackColor = true;
            this.replaceTimetable.Click += new System.EventHandler(this.replaceTimetable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label3.Location = new System.Drawing.Point(0, 231);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.label3.Size = new System.Drawing.Size(225, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Timetable by Amber Healing - v3.0.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PDF Document (*.pdf)|*.pdf|PNG image (*.png)|*.png";
            this.openFileDialog1.Title = "Select Timetable";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startupEnabledBox);
            this.Controls.Add(this.classListLastChanged);
            this.Controls.Add(this.timetableLastChanged);
            this.Controls.Add(this.replaceClassList);
            this.Controls.Add(this.replaceTimetable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startupEnabledBox;
        private System.Windows.Forms.Label classListLastChanged;
        private System.Windows.Forms.Label timetableLastChanged;
        private System.Windows.Forms.Button replaceClassList;
        private System.Windows.Forms.Button replaceTimetable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}