using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Music_Player
{
    public partial class MusicPlayer : Form
    {
        private string[] musicFiles;
        private string selectedFile;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        // testing testing


        public MusicPlayer()
        {
            InitializeComponent();


        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;

                    // get all mp3 files from folder
                    musicFiles = Directory.GetFiles(selectedFolder, "*.mp3");

                    // extract only the file names for display
                    ListBoxSongs.Items.Clear();
                    ListBoxSongs.Items.AddRange(musicFiles.Select(Path.GetFileName).ToArray());

                    if (musicFiles.Length > 0)
                    {
                        ListBoxSongs.SelectedIndex = 0; // get first song
                        selectedFile = musicFiles[0];
                        lbl_CurrentSong.Text = "now playing: " + Path.GetFileName(selectedFile);
                    }
                }
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (selectedFile == null)
            {
                MessageBox.Show("please select a song first. ", "No Song selected");
                return;
            }

            StopPlayback();

            try
            {
                audioFile = new AudioFileReader(selectedFile);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();

                lbl_CurrentSong.Text = "Now Playing: " + Path.GetFileName(selectedFile);

                // progress bar
                progressBar.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                progressBar.Value = 0;
                timerProgress.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing file: " + ex.Message, "playback error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void StopPlayback()
        {
            if (outputDevice != null)
            {
                if (outputDevice.PlaybackState == PlaybackState.Playing || outputDevice.PlaybackState == PlaybackState.Paused)
                {
                    outputDevice.Stop(); // stop playback but keep time
                }

                outputDevice.Dispose();
                outputDevice = null;
                
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }

            timerProgress.Stop();
            progressBar.Value = 0;
        }

        private void PlaySelectedSong()
        {
            StopPlayback();

            try
            {
                audioFile = new AudioFileReader(selectedFile);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();

                lbl_CurrentSong.Text = "Now Playing: " + Path.GetDirectoryName(selectedFile);

                // reset nad start progressbar
                progressBar.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                progressBar.Value = 0;
                timerProgress.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing file!");

            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
            }
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Paused)
            {
                outputDevice.Play();
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            StopPlayback();
            selectedFile = null; // only reset if full stop is needed
        }

        private void TrackBarVolume_Scroll(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                float volume = TrackBarVolume.Value / 100f; // convert to range 0.0 - 1.0
                outputDevice.Volume = volume;
            }
                
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
           

        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && outputDevice != null)
            {
                progressBar.Value = (int)audioFile.CurrentTime.TotalSeconds;
            }
        }

        private void progressBar_MouseClick(object sender, MouseEventArgs e)
        {
            if (audioFile != null)
            {
                // Calculate new position based on where the user clicked
                double percentage = (double)e.X / progressBar.Width;
                int newPosition = (int)(percentage * audioFile.TotalTime.TotalSeconds);

                // Seek to the new position
                audioFile.CurrentTime = TimeSpan.FromSeconds(newPosition);
                progressBar.Value = newPosition;
            }
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            if (musicFiles == null || musicFiles.Length == 0)
            {
                MessageBox.Show("No songs loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int currentIndex = Array.IndexOf(musicFiles, selectedFile);

            if (currentIndex >= 0 && currentIndex < musicFiles.Length - 1)
            {
                selectedFile = musicFiles[currentIndex + 1];
            }
            else
            {
                selectedFile = musicFiles[0];
            }

            int newIndex = Array.IndexOf(musicFiles, selectedFile);
            if (newIndex >= 0)
            {
                ListBoxSongs.SelectedIndex = newIndex;
            }

            PlaySelectedSong();
            
        }

       
    }
}
