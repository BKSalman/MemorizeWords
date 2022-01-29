using System.IO;

namespace newApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Record = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Files = new System.Windows.Forms.Button();
            this.Words = new System.Windows.Forms.ListBox();
            this.Play = new System.Windows.Forms.Button();
            this.StopP = new System.Windows.Forms.Button();
            this.volumeSlider1 = new NAudio.Gui.VolumeSlider();
            this.wordText = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(502, 398);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(118, 40);
            this.Record.TabIndex = 0;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(626, 398);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(118, 40);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Files
            // 
            this.Files.Location = new System.Drawing.Point(359, 398);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(118, 40);
            this.Files.TabIndex = 2;
            this.Files.Text = "File Directory";
            this.Files.UseVisualStyleBackColor = true;
            this.Files.Click += new System.EventHandler(this.File_Click);
            // 
            // Words
            // 
            this.Words.FormattingEnabled = true;
            this.Words.Location = new System.Drawing.Point(87, 27);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(657, 303);
            this.Words.TabIndex = 3;
            this.Words.SelectedIndexChanged += new System.EventHandler(this.wordsBox1_SelectedIndexChanged);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(211, 398);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(118, 40);
            this.Play.TabIndex = 5;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // StopP
            // 
            this.StopP.Location = new System.Drawing.Point(87, 398);
            this.StopP.Name = "StopP";
            this.StopP.Size = new System.Drawing.Size(118, 40);
            this.StopP.TabIndex = 4;
            this.StopP.Text = "StopP";
            this.StopP.UseVisualStyleBackColor = true;
            this.StopP.Click += new System.EventHandler(this.StopP_Click);
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.volumeSlider1.Location = new System.Drawing.Point(87, 376);
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.Size = new System.Drawing.Size(104, 16);
            this.volumeSlider1.TabIndex = 6;
            this.volumeSlider1.Volume = 0.2F;
            this.volumeSlider1.VolumeChanged += new System.EventHandler(this.volumeSlider1_VolumeChanged);
            // 
            // wordText
            // 
            this.wordText.Location = new System.Drawing.Point(546, 372);
            this.wordText.Name = "wordText";
            this.wordText.Size = new System.Drawing.Size(170, 20);
            this.wordText.TabIndex = 8;
            this.wordText.TextChanged += new System.EventHandler(this.textChange);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(87, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(242, 12);
            this.progressBar1.TabIndex = 9;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(359, 352);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(118, 40);
            this.Remove.TabIndex = 10;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.wordText);
            this.Controls.Add(this.volumeSlider1);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.StopP);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.Files);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Record);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Salman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Files;
        private System.Windows.Forms.ListBox Words;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button StopP;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private System.Windows.Forms.TextBox wordText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Remove;
    }
}

