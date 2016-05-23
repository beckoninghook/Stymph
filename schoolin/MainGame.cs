using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolin
{
    public partial class MainGame : Form
    {
        
        bool _leverEat = false;
        String _Name;
        int i = 0;

        public MainGame(String Name)
        {
            InitializeComponent();
            

            if ( pbSleep.Value == 20 || pbHunger.Value == 20)
            {
                stoptimersED();
            }
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
           
            tHatch.Start();


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
                pbHunger.Value -= 20;
                pbSleep.Value -= 10;

            if (pbHunger.Value <= 20 || pbSleep.Value <= 20)
            {
                stoptimersED();
                MessageBox.Show ("Your HUNGER or SLEEP IS TOO LOW");
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

        private void btnEat_MouseClick(object sender, MouseEventArgs e)
        {
            btnEat.Image = Properties.Resources.btnEatPressed;
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            pbBird.Image = Properties.Resources.Ble_sleep;
            tConstanEnergyDrain.Stop();
            //elke interval van de timer gaat de value van een pb met 10 omhoog als de animatie is gestopt van het slapen stopt Ble met slapen
            tSleep.Start();
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
            

            if (_leverEat == false)
            {
                btnEat.Image = Properties.Resources.btnEatPressed;
                pbBird.Image = Properties.Resources.Ble_eten1;
                tConstanEnergyDrain.Stop();
                tEat.Start();
                _leverEat = true;
            }
            else if (_leverEat == true)
            {
                btnEat.Image = Properties.Resources.btnEat1;
                pbBird.Image = Properties.Resources.Ble_idle1;
               _leverEat = false;
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
    }
}
