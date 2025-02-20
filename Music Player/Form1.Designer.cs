namespace Music_Player
{
    partial class MusicPlayer
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_resume = new System.Windows.Forms.Button();
            this.TrackBarVolume = new System.Windows.Forms.TrackBar();
            this.ListBoxSongs = new System.Windows.Forms.ListBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbl_CurrentSong = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 264);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(85, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Select Folder";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(125, 264);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(87, 23);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(251, 264);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(84, 23);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(380, 264);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(78, 23);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(494, 264);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(94, 23);
            this.btn_resume.TabIndex = 4;
            this.btn_resume.Text = "Resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            // 
            // TrackBarVolume
            // 
            this.TrackBarVolume.Location = new System.Drawing.Point(366, 108);
            this.TrackBarVolume.Maximum = 100;
            this.TrackBarVolume.Name = "TrackBarVolume";
            this.TrackBarVolume.Size = new System.Drawing.Size(196, 45);
            this.TrackBarVolume.TabIndex = 5;
            this.TrackBarVolume.Value = 50;
            // 
            // ListBoxSongs
            // 
            this.ListBoxSongs.FormattingEnabled = true;
            this.ListBoxSongs.Location = new System.Drawing.Point(73, 25);
            this.ListBoxSongs.Name = "ListBoxSongs";
            this.ListBoxSongs.Size = new System.Drawing.Size(441, 56);
            this.ListBoxSongs.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(112, 182);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // lbl_CurrentSong
            // 
            this.lbl_CurrentSong.AutoSize = true;
            this.lbl_CurrentSong.Location = new System.Drawing.Point(248, 182);
            this.lbl_CurrentSong.Name = "lbl_CurrentSong";
            this.lbl_CurrentSong.Size = new System.Drawing.Size(69, 13);
            this.lbl_CurrentSong.TabIndex = 8;
            this.lbl_CurrentSong.Text = "Current Song";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(73, 108);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(232, 23);
            this.progressBar.TabIndex = 9;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 367);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lbl_CurrentSong);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.ListBoxSongs);
            this.Controls.Add(this.TrackBarVolume);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_load);
            this.Name = "MusicPlayer";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.TrackBar TrackBarVolume;
        private System.Windows.Forms.ListBox ListBoxSongs;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbl_CurrentSong;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

