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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
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
            this.btnSpeak = new System.Windows.Forms.PictureBox();
            this.btnHunt = new System.Windows.Forms.PictureBox();
            this.tHatch = new System.Windows.Forms.Timer(this.components);
            this.tSleep = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tEat = new System.Windows.Forms.Timer(this.components);
            this.pbEgg = new System.Windows.Forms.PictureBox();
            this.tClean = new System.Windows.Forms.Timer(this.components);
            this.notTest = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.btnShop = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.tMoney = new System.Windows.Forms.Timer(this.components);
            this.tPlay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHunt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.pbHunger.Location = new System.Drawing.Point(15, 135);
            this.pbHunger.MarqueeAnimationSpeed = 1000;
            this.pbHunger.Maximum = 1000;
            this.pbHunger.Name = "pbHunger";
            this.pbHunger.Size = new System.Drawing.Size(64, 5);
            this.pbHunger.TabIndex = 10;
            // 
            // pbSleep
            // 
            this.pbSleep.Location = new System.Drawing.Point(323, 135);
            this.pbSleep.MarqueeAnimationSpeed = 1000;
            this.pbSleep.Maximum = 1000;
            this.pbSleep.Name = "pbSleep";
            this.pbSleep.Size = new System.Drawing.Size(64, 5);
            this.pbSleep.TabIndex = 10;
            this.pbSleep.Click += new System.EventHandler(this.pbSleep_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::schoolin.Properties.Resources.bedje2;
            this.pictureBox2.Location = new System.Drawing.Point(315, 85);
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
            this.pictureBox3.Location = new System.Drawing.Point(12, 98);
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
            this.btnEat.Location = new System.Drawing.Point(91, 301);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(71, 71);
            this.btnEat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEat.TabIndex = 13;
            this.btnEat.TabStop = false;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            this.btnEat.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pbMood
            // 
            this.pbMood.Location = new System.Drawing.Point(42, 194);
            this.pbMood.MarqueeAnimationSpeed = 1000;
            this.pbMood.Maximum = 1000;
            this.pbMood.Name = "pbMood";
            this.pbMood.Size = new System.Drawing.Size(64, 5);
            this.pbMood.TabIndex = 19;
            // 
            // pbHygiene
            // 
            this.pbHygiene.Location = new System.Drawing.Point(303, 196);
            this.pbHygiene.MarqueeAnimationSpeed = 1000;
            this.pbHygiene.Maximum = 1000;
            this.pbHygiene.Name = "pbHygiene";
            this.pbHygiene.Size = new System.Drawing.Size(64, 5);
            this.pbHygiene.TabIndex = 20;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::schoolin.Properties.Resources.moodicon2;
            this.pictureBox10.Location = new System.Drawing.Point(52, 159);
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
            this.btnSleep.Location = new System.Drawing.Point(168, 301);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(71, 67);
            this.btnSleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSleep.TabIndex = 27;
            this.btnSleep.TabStop = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.Image = global::schoolin.Properties.Resources.btnClean;
            this.btnClean.Location = new System.Drawing.Point(245, 301);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(71, 67);
            this.btnClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClean.TabIndex = 28;
            this.btnClean.TabStop = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = global::schoolin.Properties.Resources.btnPlay;
            this.btnPlay.Location = new System.Drawing.Point(91, 374);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(71, 67);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 29;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.Color.Transparent;
            this.btnSpeak.Image = global::schoolin.Properties.Resources.btnSpeak;
            this.btnSpeak.Location = new System.Drawing.Point(245, 374);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(71, 67);
            this.btnSpeak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSpeak.TabIndex = 30;
            this.btnSpeak.TabStop = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnHunt
            // 
            this.btnHunt.BackColor = System.Drawing.Color.Transparent;
            this.btnHunt.Image = global::schoolin.Properties.Resources.btnHunt;
            this.btnHunt.Location = new System.Drawing.Point(168, 374);
            this.btnHunt.Name = "btnHunt";
            this.btnHunt.Size = new System.Drawing.Size(71, 67);
            this.btnHunt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHunt.TabIndex = 31;
            this.btnHunt.TabStop = false;
            this.btnHunt.Click += new System.EventHandler(this.btnHunt_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(303, 153);
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
            // notTest
            // 
            this.notTest.Icon = ((System.Drawing.Icon)(resources.GetObject("notTest.Icon")));
            this.notTest.Text = "Stymph";
            this.notTest.Visible = true;
            this.notTest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notTest_MouseDoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Consolas", 21F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(152, 459);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 33);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.Transparent;
            this.btnShop.Image = global::schoolin.Properties.Resources.shopbutton;
            this.btnShop.Location = new System.Drawing.Point(265, 248);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(71, 27);
            this.btnShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShop.TabIndex = 35;
            this.btnShop.TabStop = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::schoolin.Properties.Resources.munt;
            this.pictureBox4.Location = new System.Drawing.Point(329, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(338, 30);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(18, 20);
            this.lblMoney.TabIndex = 37;
            this.lblMoney.Text = "0";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tMoney
            // 
            this.tMoney.Interval = 10000;
            this.tMoney.Tick += new System.EventHandler(this.tMoney_Tick);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.BackgroundImage = global::schoolin.Properties.Resources.MainBG;
            this.ClientSize = new System.Drawing.Size(410, 520);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbEgg);
            this.Controls.Add(this.pbHygiene);
            this.Controls.Add(this.btnHunt);
            this.Controls.Add(this.btnSpeak);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(410, 520);
            this.MinimumSize = new System.Drawing.Size(410, 520);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHunt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox btnSpeak;
        private System.Windows.Forms.PictureBox btnHunt;
        private System.Windows.Forms.Timer tHatch;
        private System.Windows.Forms.Timer tSleep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tEat;
        private System.Windows.Forms.PictureBox pbEgg;
        private System.Windows.Forms.Timer tClean;
        private System.Windows.Forms.NotifyIcon notTest;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox btnShop;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Timer tMoney;
        private System.Windows.Forms.Timer tPlay;
    }
}