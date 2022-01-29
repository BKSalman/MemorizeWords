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
		private WaveOut outputDevice;
        private WaveIn waveSource;
        private WaveFileWriter waveFile;
        private String outputFilePath;
        private String outputFileName;
		private	string recDir = Directory.GetCurrentDirectory() + "\\Recordings";
		private	string txtDir = Directory.GetCurrentDirectory() + "\\output.txt";
		 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Record.Enabled = false;
            this.Stop.Enabled = false;
			loadFiles();
			outputDir();
        }
        private void textChange(object sender, EventArgs e)
        {
			if (this.wordText.Text == "")
			{
				this.Record.Enabled = false;
			}
			else this.Record.Enabled = true;

			foreach(String word in this.Words.Items)
			{
				if(word == this.wordText.Text)
				{
					this.Record.Enabled = false;
					break;
				}
			}
        }
		private void loadFiles()
        {
			string dir = File.ReadAllText(txtDir);
			if (dir == "")
			{
				this.outputFilePath = this.recDir;
			}
			this.outputFilePath = dir;
            Console.WriteLine(outputFilePath);
			string[] files = Directory.GetFiles(this.outputFilePath, "*.wav");
			this.Words.Items.Clear();
			foreach (string file in files)
			{
				string[] words = file.Split('\\');
				string word = words[words.Length - 1];
				word = word.Split('.')[0];
				this.Words.Items.Add(word);
			}
        }

		private void outputDir()
		{
			string dir = Directory.GetCurrentDirectory();
			if(!(File.Exists(dir + "\\output.txt")))
			{
				File.CreateText(Directory.GetCurrentDirectory() + "\\output.txt");
				File.WriteAllText(dir + "\\output.txt", recDir);
				outputFilePath = recDir;
			}
			else {
				outputFilePath = File.ReadAllText(dir + "\\output.txt");
			}
		}
		private void Recording(){
			this.outputFileName = "\\" + this.wordText.Text + ".wav";

			this.waveSource = new WaveIn();
			this.waveSource.WaveFormat = new WaveFormat(44100, 16, 1);

			this.waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
			this.waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);

			System.Console.WriteLine(outputFilePath);

			this.waveFile = new WaveFileWriter(outputFilePath + outputFileName, waveSource.WaveFormat);

			this.waveSource.StartRecording();

			Console.WriteLine("Recording...");
		}
        private void Record_Click(object sender, EventArgs e)
        {
            this.Record.Enabled = false;
            this.Stop.Enabled = true;


			Recording();
        }
		void waveSource_DataAvailable(object sender, WaveInEventArgs e)
		{
			if (waveFile != null)
			{
				waveFile.Write(e.Buffer, 0, e.BytesRecorded);
				waveFile.Flush();
			}
		}
		
		void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
		{
			if (waveSource != null)
			{
				waveSource.Dispose();
				waveSource = null;
			}

			if (waveFile != null)
			{
				waveFile.Dispose();
				waveFile = null;
			}

			this.Record.Enabled = true;
		}
		
		void outputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
		{
			System.Console.WriteLine("Playback Disposed");
			if (outputDevice != null)
			{
				outputDevice.Dispose();
				outputDevice = null;
			}
		}


        private void Stop_Click(object sender, EventArgs e)
        {
            this.Record.Enabled = true;
            this.Stop.Enabled = false;

			this.waveSource.StopRecording();
			loadFiles();
			this.wordText.Text = "";
        }
		private void File_Click(object sender, EventArgs e)
        {
			FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				outputFilePath = folderBrowserDialog1.SelectedPath;
				File.WriteAllText(txtDir, outputFilePath);
				loadFiles();
			}
		}

        private void wordsBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
			if(this.Words.SelectedItem == null)
				return;
			string file = this.outputFilePath + "\\" + this.Words.SelectedItem.ToString() + ".wav";
			if (File.Exists(file))
			{
				try
                {
					Console.WriteLine("Playing...");
					this.outputDevice = new WaveOut();
					this.outputDevice.Init(new WaveFileReader(file));
					this.outputDevice.PlaybackStopped += new EventHandler<StoppedEventArgs>(outputDevice_PlaybackStopped);
					this.outputDevice.Play();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				
			}
			
        }
        private void StopP_Click(object sender, EventArgs e)
        {
			if(this.Words.SelectedItem == null)
				return;
			string file = this.outputFilePath + "\\" + this.Words.SelectedItem.ToString() + ".wav";
			if (File.Exists(file))
			{
				if (outputDevice != null)
				{
					Console.WriteLine("Stopping...");
					outputDevice.Stop();
				}
			}
        }

        private void volumeSlider1_VolumeChanged(object sender, EventArgs e)
        {
			if (this.outputDevice != null)
			{
				this.outputDevice.Volume = this.volumeSlider1.Volume;
			}
        }

        private void Remove_Click(object sender, EventArgs e)
        {
			if (this.Words.SelectedItem == null)
				return;
			String file = outputFilePath + "\\" + this.Words.SelectedItem.ToString() + ".wav";
			try {
			File.Delete(file);
			loadFiles();
			}
			catch (IOException) {
				Console.WriteLine("File is in use");
			}

        }
    }
}
