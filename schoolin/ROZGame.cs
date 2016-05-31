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
    public partial class ROZGame : Form
    {
        bool _leverEat = true;
        bool _leverClean = true;
        bool _leverSleep = true;
        bool _leverSpeak = true;
        int i = 0;
        String _Name;

        public ROZGame(String name)
        {
            _Name = Name;
            InitializeComponent();
        }

        private void ROZGame_Load(object sender, EventArgs e)
        {
            tHatch.Start();

            pbHygiene.Value = 750;
            pbMood.Value = 750;
            pbHunger.Value = 750;
            pbSleep.Value = 500;
            tConstantEnergyDrain.Enabled = true;
            notTest.ShowBalloonTip(7000, _Name + " notifications", "This is were you will get notifications about " + _Name + " so you dont have to check the app the whole time ;).", ToolTipIcon.None);
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



        /////////////////////////////////////////////////////////////////
        /////////////////////////////BUTTONS/////////////////////////////
        ////////////////////////////////////////////////////////////////
        private void btnEat_Click(object sender, EventArgs e)
        {

        }

        private void btnSleep_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnHunt_Click(object sender, EventArgs e)
        {

        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {

        }



        ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////




        /////////////////////////////////////////////////////////////////
        /////////////////////////////TIMERS//////////////////////////////
        ////////////////////////////////////////////////////////////////
        private void tConstantEnergyDrain_Tick(object sender, EventArgs e)
        {
            pbHygiene.Value -= 20;
            pbHunger.Value -= 20;
            pbSleep.Value -= 10;
            pbMood.Value -= 1;

            if (pbHunger.Value == 10 || pbHunger.Value == 20 || pbHunger.Value == 30 || pbHunger.Value == 40)
            {
                stoptimersED();
                notTest.ShowBalloonTip(7000, _Name + " is hungry!", "You should give " + _Name + " some food!", ToolTipIcon.None);
            }

            if (pbSleep.Value == 10 || pbSleep.Value == 20 || pbSleep.Value == 30 || pbSleep.Value == 40)
            {
                stoptimersED();
                notTest.ShowBalloonTip(7000, _Name + " is really tired!", " You should let " + _Name + " go to sleep!", ToolTipIcon.None);
            }

            if (pbHygiene.Value == 10 || pbHygiene.Value == 20 || pbHygiene.Value == 30 || pbHygiene.Value == 40)
            {
                stoptimersED();
                notTest.ShowBalloonTip(7000, _Name + " is dirty. ", _Name + " needs a bath!", ToolTipIcon.None);
            }

            if (pbMood.Value == 10 || pbMood.Value == 20 || pbMood.Value == 30 || pbMood.Value == 40)
            {
                stoptimersED();
                notTest.ShowBalloonTip(7000, _Name + " is quite bored", " You should play with " + _Name + " sometime", ToolTipIcon.None);
            }


        }

        private void stoptimersED()
        {
            tConstantEnergyDrain.Stop();
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

        private void tSleep_Tick(object sender, EventArgs e)
        {
            pbSleep.Value += 10;


            if (pbSleep.Value == 1000 || pbSleep.Value == 980 || pbSleep.Value == 990)
            {
                pbBird.Image = Properties.Resources.Ble_idle1;
                btnSleep.Image = Properties.Resources.btnSleep;
                tSleep.Stop();
                tConstantEnergyDrain.Start();
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
                tConstantEnergyDrain.Start();
            }
        }

        private void tClean_Tick(object sender, EventArgs e)
        {
            pbMood.Value += 10;


            if (_leverClean == true)
            {
                btnClean.Image = Properties.Resources.btnCleanPressed;
                pbBird.Image = Properties.Resources.Ble_Clean;
                tConstantEnergyDrain.Stop();
                tClean.Start();
                _leverClean = false;
            }
            else if (_leverEat == false)
            {
                btnClean.Image = Properties.Resources.btnClean;
                pbBird.Image = Properties.Resources.Ble_idle1;
                _leverClean = true;
                tClean.Stop();
                tConstantEnergyDrain.Start();
            }
        }



        ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////
    }
}
