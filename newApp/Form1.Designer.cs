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
            this.File = new System.Windows.Forms.Button();
            this.Words = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(281, 398);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(118, 40);
            this.Record.TabIndex = 0;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(405, 398);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(118, 40);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop / Save";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // File
            // 
            this.File.Location = new System.Drawing.Point(343, 352);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(118, 40);
            this.File.TabIndex = 2;
            this.File.Text = "File Directory";
            this.File.UseVisualStyleBackColor = true;
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // Words
            // 
            this.Words.FormattingEnabled = true;
            this.Words.Location = new System.Drawing.Point(87, 27);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(657, 303);
            this.Words.TabIndex = 3;
            this.Words.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.File);
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
        }

        #endregion

        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button File;
        private System.Windows.Forms.ListBox Words;
    }
}

