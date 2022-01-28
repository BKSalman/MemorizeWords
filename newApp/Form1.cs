using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;


namespace newApp
{
    public partial class Form1 : Form
    {
        private WaveIn waveSource;
        private WaveFileWriter waveFile;
        private String outputFilePath;
        public Form1()
        {
            InitializeComponent();
            this.Record.Enabled = false;
            this.Stop.Enabled = false;
			processFiles();
        }

        private void Record_Click(object sender, EventArgs e)
        {
            this.Record.Enabled = false;
            this.Stop.Enabled = true;

			Console.WriteLine("Recording...");
			Console.WriteLine(sender);

			this.waveSource = new WaveIn();
			this.waveSource.WaveFormat = new WaveFormat(44100, 16, 1);
			this.waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
			this.waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);
			this.waveFile = new WaveFileWriter(outputFilePath, waveSource.WaveFormat);

			this.waveSource.StartRecording();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            this.Record.Enabled = true;
            this.Stop.Enabled = false;

			this.waveSource.StopRecording();
        }
		void waveSource_DataAvailable(object sender, WaveInEventArgs e)
		{
			if (this.waveFile != null)
			{
				this.waveFile.WriteAsync(e.Buffer, 0, e.BytesRecorded);
				this.waveFile.FlushAsync();
			}
		}
		
		void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
		{
			if (this.waveSource != null)
			{
				this.waveSource.Dispose();
				this.waveSource = null;
			}

			if (this.waveFile != null)
			{
				this.waveFile.Dispose();
				this.waveFile = null;
			}

			this.Record.Enabled = false;
			this.Stop.Enabled = false;
		}
		private void File_Click(object sender, EventArgs e)
        {
			Console.WriteLine(sender);
			var dialog = new SaveFileDialog();
            dialog.Filter = "Wave files | *.wav";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

			this.outputFilePath = dialog.FileName;
			
            this.Record.Enabled = true;
            this.Stop.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
		private void processFiles()
        {
			string dir = Directory.GetCurrentDirectory() + "\\Recordings";
			if (!(Directory.Exists(dir)))
			{
				Directory.CreateDirectory(dir);
			}
            Console.WriteLine(dir);
			string[] files = Directory.GetFiles(dir, "*.wav");
			foreach (string file in files)
			{
				Console.WriteLine(file);
				string[] words = file.Split('\\');
				string word = words[words.Length - 1];
				word = word.Split('.')[0];
				Console.WriteLine(word);
				this.Words.Items.Add(word);
			}
        }
    }
}
