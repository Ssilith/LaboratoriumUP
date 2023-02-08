using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace UPLab3
{
    public partial class Form1 : Form
    {

        Soundcard sc;
        SoundcardWF scw;
        SoundcardDX scd;
        public bool isWav;
        public bool isRecording;
        private Stopwatch recordTimer;
        SoundPlayer backgroundMusic;

        public Form1()
        {
            InitializeComponent();

            sc = new Soundcard();
            scw = new SoundcardWF();
            scd = new SoundcardDX(this.Handle);
            recordTimer = new Stopwatch();
         
            loadButton.Enabled = false;
            playButton.Enabled = false;
            stopButton.Enabled = false;
            tableLayoutPanel1.Visible = false;
            filenameLabel.Text = null;
            isRecording = false;
            backgroundMusic = new SoundPlayer(@"a.wav");
            backgroundMusic.PlayLooping();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("ActiveX");
            comboBox.Items.Add("Waveform & Auxillary Audio");
            comboBox.Items.Add("DirectSound");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();

            ofd1.InitialDirectory = "c:\\";
            if (comboBox.SelectedIndex == 0)
            {
                ofd1.Filter = "Music files (*.wav, *.mp3)|*.wav;*.mp3";
            } else ofd1.Filter = "Music files(*.wav)| *.wav";

            ofd1.FilterIndex = 0;
            ofd1.RestoreDirectory = true;

                
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                
                filenameLabel.Text = System.IO.Path.GetFileName(ofd1.FileName);
                String spath = ofd1.FileName;
                
                if (Path.GetExtension(spath) == ".wav")
                {
                    isWav = true;
                    scd.readHeader(ofd1.FileName); 
                    fillHeaderInfo(spath);
                } else
                {
                    isWav = false;
                    fillHeaderInfo(null);
                }

                if (comboBox.SelectedIndex == 0) WMPlay.URL = ofd1.FileName; 
                sc.loadMusic(spath); 
                scw.loadMusic(spath);
                scd.loadMusic(spath);

            }
            else Console.WriteLine("Blad zaladowania pliku");
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (isWav)
            {
                if (comboBox.SelectedIndex == 0)
                {
                    sc.playMusic();
                }
                else if (comboBox.SelectedIndex == 1)
                {
                    scw.playMusic();
                }
                else if (comboBox.SelectedIndex == 2)
                {
                    scd.playMusic();

                }
            } 
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                sc.stopMusic();
                backgroundMusic.PlayLooping();
            }
            else if (comboBox.SelectedIndex == 1)
            {
                scw.stopMusic();
                backgroundMusic.PlayLooping();
            }
            else if (comboBox.SelectedIndex == 2)
            {
                scd.stopMusic();
                backgroundMusic.PlayLooping();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadButton.Enabled = true;
            playButton.Enabled = true;
            stopButton.Enabled = true;
        }

        private void fillHeaderInfo(String spath)
        {

            if (isWav)
            {
                scd.readHeader(spath);

                label4.Text = scd.getChunkId();
                label6.Text = scd.getChunkSize().ToString();
                label8.Text = scd.getFormat();
                label10.Text = scd.getSubChunkId();
                label12.Text = scd.getSubChunkSize().ToString();
                label14.Text = scd.getAudioFormat();
                label16.Text = scd.getNumChannels().ToString();
                label18.Text = scd.getSampleRate().ToString();
                label20.Text = scd.getBytesPerSecond().ToString();
                label22.Text = scd.getBlockAlign().ToString();
                label24.Text = scd.getBitsPerSample().ToString();
                label26.Text = scd.getDataChunkId();
                label28.Text = scd.getDataSize().ToString();

                tableLayoutPanel1.Visible = true;
            } else
            {
                tableLayoutPanel1.Visible = false;
            }

        }

        private void recordButton_Click(object sender, EventArgs e)
        { 
            if (isRecording)
            {
                recordButton.Text = "Nagraj";
                scw.record(isRecording);
                isRecording = false;
            } else
            {
                recordButton.Text = "Nagraj";
                scw.record(isRecording);
                isRecording = true;

            }
        }

    }
}
