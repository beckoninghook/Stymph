namespace schoolin
{
    partial class ChooseCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCharacter));
            this.btnExit = new System.Windows.Forms.Button();
            this.pbBle = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.PictureBox();
            this.btnLeft = new System.Windows.Forms.PictureBox();
            this.pbStremma = new System.Windows.Forms.PictureBox();
            this.pbRez = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStremma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(392, -5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbBle
            // 
            this.pbBle.BackColor = System.Drawing.Color.Transparent;
            this.pbBle.Image = ((System.Drawing.Image)(resources.GetObject("pbBle.Image")));
            this.pbBle.Location = new System.Drawing.Point(87, 69);
            this.pbBle.Name = "pbBle";
            this.pbBle.Size = new System.Drawing.Size(262, 280);
            this.pbBle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBle.TabIndex = 7;
            this.pbBle.TabStop = false;
            this.pbBle.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.Location = new System.Drawing.Point(267, 389);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(112, 107);
            this.btnRight.TabIndex = 8;
            this.btnRight.TabStop = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.Location = new System.Drawing.Point(48, 389);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(117, 107);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.TabStop = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // pbStremma
            // 
            this.pbStremma.BackColor = System.Drawing.Color.Transparent;
            this.pbStremma.Image = global::schoolin.Properties.Resources.vogel3;
            this.pbStremma.Location = new System.Drawing.Point(87, 69);
            this.pbStremma.Name = "pbStremma";
            this.pbStremma.Size = new System.Drawing.Size(262, 280);
            this.pbStremma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStremma.TabIndex = 10;
            this.pbStremma.TabStop = false;
            // 
            // pbRez
            // 
            this.pbRez.BackColor = System.Drawing.Color.Transparent;
            this.pbRez.Image = global::schoolin.Properties.Resources.vogel2;
            this.pbRez.Location = new System.Drawing.Point(87, 69);
            this.pbRez.Name = "pbRez";
            this.pbRez.Size = new System.Drawing.Size(262, 280);
            this.pbRez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRez.TabIndex = 11;
            this.pbRez.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.Image = global::schoolin.Properties.Resources.knopje;
            this.btnSelect.Location = new System.Drawing.Point(179, 426);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 61);
            this.btnSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSelect.TabIndex = 12;
            this.btnSelect.TabStop = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ChooseCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.BackgroundImage = global::schoolin.Properties.Resources.choosescreen;
            this.ClientSize = new System.Drawing.Size(410, 520);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.pbRez);
            this.Controls.Add(this.pbStremma);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.pbBle);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseCharacter";
            this.Load += new System.EventHandler(this.ChooseCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStremma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbBle;
        private System.Windows.Forms.PictureBox btnRight;
        private System.Windows.Forms.PictureBox btnLeft;
        private System.Windows.Forms.PictureBox pbStremma;
        private System.Windows.Forms.PictureBox pbRez;
        private System.Windows.Forms.PictureBox btnSelect;
    }
}