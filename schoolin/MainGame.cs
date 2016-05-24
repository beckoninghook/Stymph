using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Media;

namespace schoolin
{
    public partial class MainGame : Form
    {
        public SoundPlayer _damnDaniel;
        bool _leverEat = true;
        bool _leverClean = true;
        bool _leverSleep = true;
        bool _leverSpeak = true;
        String _Name;
        int i = 0;

        public MainGame(String Name)
        {
            _Name = Name;
            InitializeComponent();
            _damnDaniel = new SoundPlayer("damn_daniel.wav");

            if (pbHunger.Value == 20)
            {
               
            }

            if (pbSleep.Value == 20 || pbHunger.Value == 20 || pbHygiene.Value == 20)
            {
                
                stoptimersED();
            }
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            
            tHatch.Start();

            pbHygiene.Value = 750;
            pbMood.Value = 750;
            pbHunger.Value = 750;
            pbSleep.Value = 500;
            tConstanEnergyDrain.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }


        //TIMERS
        private void tConstanEnergyDrain_Tick(object sender, EventArgs e)
        {
            pbHygiene.Value -= 20;
            pbHunger.Value -= 20;
            pbSleep.Value -= 10;

            if (pbHunger.Value <= 20 || pbSleep.Value <= 20 || pbHygiene.Value <= 20)
            {
                stoptimersED();
                notTest.ShowBalloonTip(7000, _Name + "is hungry!", "You should give " + _Name + " some food.", ToolTipIcon.None);
            }
       



        }
        private void stoptimersED()
        {
            tConstanEnergyDrain.Stop();
        }

        private void pbSleep_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            btnPlay.Image = Properties.Resources.btnPlayPressed;
        }

      
       

        private void tHatch_Tick(object sender, EventArgs e)
        {
            i++;
            Size size = new Size(100, 100);
           

            if (i <= 4)
            {
                
                pbEgg.Visible = true;
            }
            else
            {
                pbEgg.Visible = false;
                tHatch.Stop();
                pbBird.Image = Properties.Resources.Ble_idle1;
            }
        }


        //BUTTONS

        private void btnClean_MouseClick(object sender, MouseEventArgs e)
        {
            btnClean.Image = Properties.Resources.btnCleanPressed;
        }

    

        private void btnSleep_Click(object sender, EventArgs e)
        {
            if (_leverSleep == true)
            {
                btnSleep.Image = Properties.Resources.btnSleepPressed;
                pbBird.Image = Properties.Resources.Ble_sleep;
                tConstanEnergyDrain.Stop();
                tSleep.Start();
                _leverSleep = false;
            }
            else if (_leverSleep == false)
            {
                btnSleep.Image = Properties.Resources.btnSleep;
                pbBird.Image = Properties.Resources.Ble_idle1;
                _leverSleep = true;
                tSleep.Stop();
            }
        }

        private void btnSleep_MouseClick(object sender, MouseEventArgs e)
        {
            btnSleep.Image = Properties.Resources.btnSleepPressed;
        }

    

        private void btnSleep_MouseLeave(object sender, EventArgs e)
        {
            btnSleep.Image = Properties.Resources.btnSleep;
        }

        

        private void btnEat_Click(object sender, EventArgs e)
        {
            

            if (_leverEat == true)
            {
                btnEat.Image = Properties.Resources.btnEatPressed;
                pbBird.Image = Properties.Resources.Ble_etenpsd;
                tConstanEnergyDrain.Stop();
                tEat.Start();
                _leverEat = false;
            }
            else if (_leverEat == false)
            {
                btnEat.Image = Properties.Resources.btnEat1;
                pbBird.Image = Properties.Resources.Ble_idle1;
               _leverEat = true;
                tEat.Stop();
            }
            
           

           
           

        }

        private void tSleep_Tick(object sender, EventArgs e)
        {
            pbSleep.Value += 10;
           

            if (pbSleep.Value == 1000 || pbSleep.Value == 980 || pbSleep.Value == 990)
            {
                pbBird.Image = Properties.Resources.Ble_idle1;
                btnSleep.Image = Properties.Resources.btnSleep;
                tSleep.Stop();
                tConstanEnergyDrain.Start();
            }
           
        }

        private void tEat_Tick(object sender, EventArgs e)
        {
            pbHunger.Value += 5;

            if (pbHunger.Value == 1000 || pbHunger.Value == 980 || pbHunger.Value == 990)
            {
                pbBird.Image = Properties.Resources.Ble_idle1;
                btnEat.Image = Properties.Resources.btnEat1;
                tEat.Stop();
                tConstanEnergyDrain.Start();
            }

        }


        //CLEAN
        private void btnClean_Click(object sender, EventArgs e)
        {

            if (_leverClean == true)
            {
                btnClean.Image = Properties.Resources.btnCleanPressed;
                pbBird.Image = Properties.Resources.Ble_Clean;
                tConstanEnergyDrain.Stop();
                tClean.Start();
                _leverClean = false;
            }
            else if (_leverEat == false)
            {
                btnClean.Image = Properties.Resources.btnClean;
                pbBird.Image = Properties.Resources.Ble_idle1;
                _leverClean = true;
                tClean.Stop();
            }

        }

        private void tClean_Tick(object sender, EventArgs e)
        {
            pbHygiene.Value += 20;

            if (pbHygiene.Value == 1000 || pbHygiene.Value == 980 || pbHygiene.Value == 990)
            {
                pbBird.Image = Properties.Resources.Ble_idle1;
                btnClean.Image = Properties.Resources.btnClean;
                tClean.Stop();
                tConstanEnergyDrain.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (_leverSpeak == true)
            {
                btnSpeak.Image = Properties.Resources.btnSpeakPressed;
                pbBird.Image = Properties.Resources.ble_speak;
                tConstanEnergyDrain.Stop();
                _leverSpeak = false;
            }
            else if (_leverSpeak == false)
            {
                btnSpeak.Image = Properties.Resources.btnSpeak;
                pbBird.Image = Properties.Resources.Ble_idle1;
                _leverSpeak = true;
                
            }
        }
    }
}
