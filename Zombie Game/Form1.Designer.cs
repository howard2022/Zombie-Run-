namespace Zombie_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Roadback = new System.Windows.Forms.Panel();
            this.zombie1 = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.win = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.zombie2 = new System.Windows.Forms.PictureBox();
            this.Road1 = new System.Windows.Forms.PictureBox();
            this.RoadAtTop = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ScorePanel = new System.Windows.Forms.Label();
            this.Intro = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.zombie3 = new System.Windows.Forms.PictureBox();
            this.Roadback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zombie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadAtTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie3)).BeginInit();
            this.SuspendLayout();
            // 
            // Roadback
            // 
            this.Roadback.BackColor = System.Drawing.Color.Black;
            this.Roadback.Controls.Add(this.zombie3);
            this.Roadback.Controls.Add(this.zombie1);
            this.Roadback.Controls.Add(this.explosion);
            this.Roadback.Controls.Add(this.win);
            this.Roadback.Controls.Add(this.player);
            this.Roadback.Controls.Add(this.zombie2);
            this.Roadback.Controls.Add(this.Road1);
            this.Roadback.Controls.Add(this.RoadAtTop);
            resources.ApplyResources(this.Roadback, "Roadback");
            this.Roadback.Name = "Roadback";
            this.Roadback.Paint += new System.Windows.Forms.PaintEventHandler(this.Roadback_Paint);
            // 
            // zombie1
            // 
            resources.ApplyResources(this.zombie1, "zombie1");
            this.zombie1.Name = "zombie1";
            this.zombie1.TabStop = false;
            this.zombie1.Tag = "leftZombie";
            // 
            // explosion
            // 
            this.explosion.Image = global::Zombie_Game.Properties.Resources.explosion;
            resources.ApplyResources(this.explosion, "explosion");
            this.explosion.Name = "explosion";
            this.explosion.TabStop = false;
            // 
            // win
            // 
            this.win.Image = global::Zombie_Game.Properties.Resources.bronze;
            resources.ApplyResources(this.win, "win");
            this.win.Name = "win";
            this.win.TabStop = false;
            this.win.Click += new System.EventHandler(this.win_Click);
            // 
            // player
            // 
            resources.ApplyResources(this.player, "player");
            this.player.Name = "player";
            this.player.TabStop = false;
            this.player.Tag = "human";
            // 
            // zombie2
            // 
            this.zombie2.Image = global::Zombie_Game.Properties.Resources.zombie2;
            resources.ApplyResources(this.zombie2, "zombie2");
            this.zombie2.Name = "zombie2";
            this.zombie2.TabStop = false;
            this.zombie2.Tag = "rightZombie";
            this.zombie2.Click += new System.EventHandler(this.zombie2_Click);
            // 
            // Road1
            // 
            this.Road1.Image = global::Zombie_Game.Properties.Resources.roadTrack;
            resources.ApplyResources(this.Road1, "Road1");
            this.Road1.Name = "Road1";
            this.Road1.TabStop = false;
            this.Road1.Click += new System.EventHandler(this.Road_Click);
            // 
            // RoadAtTop
            // 
            this.RoadAtTop.Image = global::Zombie_Game.Properties.Resources.roadTrack;
            resources.ApplyResources(this.RoadAtTop, "RoadAtTop");
            this.RoadAtTop.Name = "RoadAtTop";
            this.RoadAtTop.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LawnGreen;
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.Name = "StartButton";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.start);
            // 
            // ScorePanel
            // 
            resources.ApplyResources(this.ScorePanel, "ScorePanel");
            this.ScorePanel.Name = "ScorePanel";
            // 
            // Intro
            // 
            resources.ApplyResources(this.Intro, "Intro");
            this.Intro.Name = "Intro";
            this.Intro.Click += new System.EventHandler(this.label2_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // zombie3
            // 
            this.zombie3.Image = global::Zombie_Game.Properties.Resources.zombie3;
            resources.ApplyResources(this.zombie3, "zombie3");
            this.zombie3.Name = "zombie3";
            this.zombie3.TabStop = false;
            this.zombie3.Tag = "midZombie";
            this.zombie3.Click += new System.EventHandler(this.zombie3_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Intro);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Roadback);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.TimerEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.Roadback.ResumeLayout(false);
            this.Roadback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zombie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadAtTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zombie3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Roadback;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ScorePanel;
        private System.Windows.Forms.Label Intro;
        private System.Windows.Forms.PictureBox Road1;
        private System.Windows.Forms.PictureBox RoadAtTop;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox win;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox zombie2;
        private System.Windows.Forms.PictureBox zombie1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox zombie3;
    }
}

