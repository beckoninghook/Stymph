namespace schoolin
{
    partial class ROZGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROZGame));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEat = new System.Windows.Forms.PictureBox();
            this.btnClean = new System.Windows.Forms.PictureBox();
            this.btnSleep = new System.Windows.Forms.PictureBox();
            this.btnSpeak = new System.Windows.Forms.PictureBox();
            this.btnHunt = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.pbSleep = new System.Windows.Forms.ProgressBar();
            this.pbHygiene = new System.Windows.Forms.ProgressBar();
            this.pbMood = new System.Windows.Forms.ProgressBar();
            this.pbHunger = new System.Windows.Forms.ProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbEgg = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tConstantEnergyDrain = new System.Windows.Forms.Timer(this.components);
            this.tHatch = new System.Windows.Forms.Timer(this.components);
            this.tSleep = new System.Windows.Forms.Timer(this.components);
            this.tEat = new System.Windows.Forms.Timer(this.components);
            this.tClean = new System.Windows.Forms.Timer(this.components);
            this.notTest = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHunt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(392, -6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEat
            // 
            this.btnEat.BackColor = System.Drawing.Color.Transparent;
            this.btnEat.Image = global::schoolin.Properties.Resources.btnEat1;
            this.btnEat.Location = new System.Drawing.Point(79, 275);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(71, 71);
            this.btnEat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEat.TabIndex = 8;
            this.btnEat.TabStop = false;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.Image = global::schoolin.Properties.Resources.btnClean;
            this.btnClean.Location = new System.Drawing.Point(257, 275);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(71, 71);
            this.btnClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClean.TabIndex = 9;
            this.btnClean.TabStop = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.Color.Transparent;
            this.btnSleep.Image = global::schoolin.Properties.Resources.btnSleep;
            this.btnSleep.Location = new System.Drawing.Point(170, 275);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(71, 71);
            this.btnSleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSleep.TabIndex = 10;
            this.btnSleep.TabStop = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.Color.Transparent;
            this.btnSpeak.Image = global::schoolin.Properties.Resources.btnSpeak;
            this.btnSpeak.Location = new System.Drawing.Point(257, 365);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(71, 71);
            this.btnSpeak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSpeak.TabIndex = 11;
            this.btnSpeak.TabStop = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnHunt
            // 
            this.btnHunt.BackColor = System.Drawing.Color.Transparent;
            this.btnHunt.Image = global::schoolin.Properties.Resources.btnHunt;
            this.btnHunt.Location = new System.Drawing.Point(170, 365);
            this.btnHunt.Name = "btnHunt";
            this.btnHunt.Size = new System.Drawing.Size(71, 71);
            this.btnHunt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHunt.TabIndex = 12;
            this.btnHunt.TabStop = false;
            this.btnHunt.Click += new System.EventHandler(this.btnHunt_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = global::schoolin.Properties.Resources.btnPlay;
            this.btnPlay.Location = new System.Drawing.Point(79, 365);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(71, 71);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 13;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbSleep
            // 
            this.pbSleep.Location = new System.Drawing.Point(326, 94);
            this.pbSleep.MarqueeAnimationSpeed = 1000;
            this.pbSleep.Maximum = 1000;
            this.pbSleep.Name = "pbSleep";
            this.pbSleep.Size = new System.Drawing.Size(61, 5);
            this.pbSleep.TabIndex = 16;
            // 
            // pbHygiene
            // 
            this.pbHygiene.Location = new System.Drawing.Point(323, 152);
            this.pbHygiene.MarqueeAnimationSpeed = 1000;
            this.pbHygiene.Maximum = 1000;
            this.pbHygiene.Name = "pbHygiene";
            this.pbHygiene.Size = new System.Drawing.Size(61, 5);
            this.pbHygiene.TabIndex = 17;
            // 
            // pbMood
            // 
            this.pbMood.Location = new System.Drawing.Point(14, 157);
            this.pbMood.MarqueeAnimationSpeed = 1000;
            this.pbMood.Maximum = 1000;
            this.pbMood.Name = "pbMood";
            this.pbMood.Size = new System.Drawing.Size(61, 5);
            this.pbMood.TabIndex = 18;
            // 
            // pbHunger
            // 
            this.pbHunger.Location = new System.Drawing.Point(12, 94);
            this.pbHunger.MarqueeAnimationSpeed = 1000;
            this.pbHunger.Maximum = 1000;
            this.pbHunger.Name = "pbHunger";
            this.pbHunger.Size = new System.Drawing.Size(61, 5);
            this.pbHunger.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::schoolin.Properties.Resources.foodicon;
            this.pictureBox3.Location = new System.Drawing.Point(5, 59);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::schoolin.Properties.Resources.moodicon2;
            this.pictureBox10.Location = new System.Drawing.Point(24, 124);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(36, 33);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 24;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::schoolin.Properties.Resources.bedje2;
            this.pictureBox2.Location = new System.Drawing.Point(316, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::schoolin.Properties.Resources.bubbles;
            this.pictureBox1.Location = new System.Drawing.Point(327, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pbEgg
            // 
            this.pbEgg.BackColor = System.Drawing.Color.Transparent;
            this.pbEgg.Location = new System.Drawing.Point(160, 43);
            this.pbEgg.Name = "pbEgg";
            this.pbEgg.Size = new System.Drawing.Size(119, 117);
            this.pbEgg.TabIndex = 35;
            this.pbEgg.TabStop = false;
            // 
            // pbBird
            // 
            this.pbBird.BackColor = System.Drawing.Color.Transparent;
            this.pbBird.Location = new System.Drawing.Point(147, 19);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(134, 134);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBird.TabIndex = 36;
            this.pbBird.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Consolas", 21F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(166, 451);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 33);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tConstantEnergyDrain
            // 
            this.tConstantEnergyDrain.Interval = 1000;
            this.tConstantEnergyDrain.Tick += new System.EventHandler(this.tConstantEnergyDrain_Tick);
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
            // tEat
            // 
            this.tEat.Tick += new System.EventHandler(this.tEat_Tick);
            // 
            // tClean
            // 
            this.tClean.Tick += new System.EventHandler(this.tClean_Tick);
            // 
            // notTest
            // 
            this.notTest.Icon = ((System.Drawing.Icon)(resources.GetObject("notTest.Icon")));
            this.notTest.Text = "Stymph";
            this.notTest.Visible = true;
            // 
            // ROZGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::schoolin.Properties.Resources.bgRoz1;
            this.ClientSize = new System.Drawing.Size(410, 520);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbEgg);
            this.Controls.Add(this.pbHunger);
            this.Controls.Add(this.pbMood);
            this.Controls.Add(this.pbHygiene);
            this.Controls.Add(this.pbSleep);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHunt);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ROZGame";
            this.Text = "ROZGame";
            this.Load += new System.EventHandler(this.ROZGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnEat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHunt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox btnEat;
        private System.Windows.Forms.PictureBox btnClean;
        private System.Windows.Forms.PictureBox btnSleep;
        private System.Windows.Forms.PictureBox btnSpeak;
        private System.Windows.Forms.PictureBox btnHunt;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.ProgressBar pbSleep;
        private System.Windows.Forms.ProgressBar pbHygiene;
        private System.Windows.Forms.ProgressBar pbMood;
        private System.Windows.Forms.ProgressBar pbHunger;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbEgg;
        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer tConstantEnergyDrain;
        private System.Windows.Forms.Timer tHatch;
        private System.Windows.Forms.Timer tSleep;
        private System.Windows.Forms.Timer tEat;
        private System.Windows.Forms.Timer tClean;
        private System.Windows.Forms.NotifyIcon notTest;
    }
}