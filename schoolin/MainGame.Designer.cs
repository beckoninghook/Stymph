namespace schoolin
{
    partial class MainGame
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
            this.btnExit = new System.Windows.Forms.Button();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbHunger = new System.Windows.Forms.ProgressBar();
            this.pbSleep = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tConstanEnergyDrain = new System.Windows.Forms.Timer(this.components);
            this.btnEat = new System.Windows.Forms.PictureBox();
            this.pbMood = new System.Windows.Forms.ProgressBar();
            this.pbHygiene = new System.Windows.Forms.ProgressBar();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btnSleep = new System.Windows.Forms.PictureBox();
            this.btnClean = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.tHatch = new System.Windows.Forms.Timer(this.components);
            this.tSleep = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tEat = new System.Windows.Forms.Timer(this.components);
            this.pbEgg = new System.Windows.Forms.PictureBox();
            this.tClean = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(394, -6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbBird
            // 
            this.pbBird.BackColor = System.Drawing.Color.Transparent;
            this.pbBird.Location = new System.Drawing.Point(133, 18);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(134, 134);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBird.TabIndex = 8;
            this.pbBird.TabStop = false;
            // 
            // pbHunger
            // 
            this.pbHunger.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pbHunger.Location = new System.Drawing.Point(12, 98);
            this.pbHunger.MarqueeAnimationSpeed = 1000;
            this.pbHunger.Maximum = 1000;
            this.pbHunger.Name = "pbHunger";
            this.pbHunger.Size = new System.Drawing.Size(64, 12);
            this.pbHunger.TabIndex = 9;
            // 
            // pbSleep
            // 
            this.pbSleep.Location = new System.Drawing.Point(325, 98);
            this.pbSleep.MarqueeAnimationSpeed = 1000;
            this.pbSleep.Maximum = 1000;
            this.pbSleep.Name = "pbSleep";
            this.pbSleep.Size = new System.Drawing.Size(64, 12);
            this.pbSleep.TabIndex = 10;
            this.pbSleep.Click += new System.EventHandler(this.pbSleep_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::schoolin.Properties.Resources.bedje2;
            this.pictureBox2.Location = new System.Drawing.Point(317, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::schoolin.Properties.Resources.foodicon;
            this.pictureBox3.Location = new System.Drawing.Point(9, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // tConstanEnergyDrain
            // 
            this.tConstanEnergyDrain.Interval = 1000;
            this.tConstanEnergyDrain.Tick += new System.EventHandler(this.tConstanEnergyDrain_Tick);
            // 
            // btnEat
            // 
            this.btnEat.BackColor = System.Drawing.Color.Transparent;
            this.btnEat.Image = global::schoolin.Properties.Resources.btnEat1;
            this.btnEat.Location = new System.Drawing.Point(74, 283);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(71, 67);
            this.btnEat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEat.TabIndex = 13;
            this.btnEat.TabStop = false;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            this.btnEat.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pbMood
            // 
            this.pbMood.Location = new System.Drawing.Point(12, 154);
            this.pbMood.MarqueeAnimationSpeed = 1000;
            this.pbMood.Maximum = 1000;
            this.pbMood.Name = "pbMood";
            this.pbMood.Size = new System.Drawing.Size(64, 12);
            this.pbMood.TabIndex = 19;
            // 
            // pbHygiene
            // 
            this.pbHygiene.Location = new System.Drawing.Point(325, 154);
            this.pbHygiene.MarqueeAnimationSpeed = 1000;
            this.pbHygiene.Maximum = 1000;
            this.pbHygiene.Name = "pbHygiene";
            this.pbHygiene.Size = new System.Drawing.Size(64, 12);
            this.pbHygiene.TabIndex = 20;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::schoolin.Properties.Resources.moodicon2;
            this.pictureBox10.Location = new System.Drawing.Point(26, 117);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(36, 33);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 23;
            this.pictureBox10.TabStop = false;
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.Color.Transparent;
            this.btnSleep.Image = global::schoolin.Properties.Resources.btnSleep;
            this.btnSleep.Location = new System.Drawing.Point(167, 283);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(71, 67);
            this.btnSleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSleep.TabIndex = 27;
            this.btnSleep.TabStop = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            this.btnSleep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSleep_MouseClick);
            this.btnSleep.MouseLeave += new System.EventHandler(this.btnSleep_MouseLeave);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.Image = global::schoolin.Properties.Resources.btnClean;
            this.btnClean.Location = new System.Drawing.Point(257, 283);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(71, 67);
            this.btnClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClean.TabIndex = 28;
            this.btnClean.TabStop = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            this.btnClean.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClean_MouseClick);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = global::schoolin.Properties.Resources.btnPlay;
            this.btnPlay.Location = new System.Drawing.Point(74, 369);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(71, 67);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 29;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::schoolin.Properties.Resources.buttonclean;
            this.pictureBox8.Location = new System.Drawing.Point(167, 369);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(71, 67);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::schoolin.Properties.Resources.buttonclean;
            this.pictureBox9.Location = new System.Drawing.Point(257, 369);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(71, 67);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            // 
            // tHatch
            // 
            this.tHatch.Interval = 1000;
            this.tHatch.Tick += new System.EventHandler(this.tHatch_Tick);
            // 
            // tSleep
            // 
            this.tSleep.Tick += new System.EventHandler(this.tSleep_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::schoolin.Properties.Resources.bubbles;
            this.pictureBox1.Location = new System.Drawing.Point(325, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // tEat
            // 
            this.tEat.Tick += new System.EventHandler(this.tEat_Tick);
            // 
            // pbEgg
            // 
            this.pbEgg.BackColor = System.Drawing.Color.Transparent;
            this.pbEgg.Image = global::schoolin.Properties.Resources.eitjebleminiv21;
            this.pbEgg.Location = new System.Drawing.Point(148, 43);
            this.pbEgg.Name = "pbEgg";
            this.pbEgg.Size = new System.Drawing.Size(119, 117);
            this.pbEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEgg.TabIndex = 33;
            this.pbEgg.TabStop = false;
            // 
            // tClean
            // 
            this.tClean.Tick += new System.EventHandler(this.tClean_Tick);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.BackgroundImage = global::schoolin.Properties.Resources.nestje2;
            this.ClientSize = new System.Drawing.Size(410, 520);
            this.Controls.Add(this.pbEgg);
            this.Controls.Add(this.pbHygiene);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.pbMood);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbSleep);
            this.Controls.Add(this.pbHunger);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.ProgressBar pbHunger;
        private System.Windows.Forms.ProgressBar pbSleep;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer tConstanEnergyDrain;
        private System.Windows.Forms.PictureBox btnEat;
        private System.Windows.Forms.ProgressBar pbMood;
        private System.Windows.Forms.ProgressBar pbHygiene;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox btnSleep;
        private System.Windows.Forms.PictureBox btnClean;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Timer tHatch;
        private System.Windows.Forms.Timer tSleep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tEat;
        private System.Windows.Forms.PictureBox pbEgg;
        private System.Windows.Forms.Timer tClean;
    }
}