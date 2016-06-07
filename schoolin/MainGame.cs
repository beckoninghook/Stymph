using System;
using System.IO;
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
        int money ;
        

        public MainGame(String Name)
        {
            _Name = Name;
            InitializeComponent();
            

            lblName.Text = _Name;

        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            tMoney.Start();

            tHatch.Start();

            pbHygiene.Value = 750;
            pbMood.Value = 750;
            pbHunger.Value = 750; 
            pbSleep.Value = 500;
            tConstanEnergyDrain.Enabled = true;
            notTest.ShowBalloonTip(7000, _Name + " notifications", "This is were you will get notifications about " + _Name + " so you dont have to check the app the whole time ;).", ToolTipIcon.None);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            //string text = File.ReadAllText("C:\\Stymph\\Stymphian.stymp");

            //text = text.Replace("pbHunger.Value == ", "pbHunger.Value == " + pbHunger.Value.ToString());
            //File.WriteAllText("C:\\Stymph\\Stymphian", text);

            using (StreamWriter sw = File.CreateText("C:\\Stymph\\Stymphian.stymp"))
            {
                //userinfo
                sw.WriteLine("lblName = " + _Name);
                sw.WriteLine("Race = Ble");
                //Progressbars
                sw.WriteLine("pbHunger.Value = " + pbHunger.Value.ToString() + ";");
                sw.WriteLine("pbHygiene.Value = " + pbHygiene.Value.ToString()+";");
                sw.WriteLine("pbMood.Value = " + pbMood.Value.ToString() + ";");
                sw.WriteLine("pbSleep.Value = " + pbSleep.Value.ToString() + ";");
                //Money
                sw.WriteLine("Money = " + lblMoney.Text + ";");
            }

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
           

            try
            {
                pbHygiene.Value -= 20;
                pbHunger.Value -= 20;
                pbSleep.Value -= 10;
                pbMood.Value -= 1;
            }
            catch
            {
                stoptimersED();
            }





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
                notTest.ShowBalloonTip(7000, _Name + " is quite bored", " You should play with " +_Name + " sometime", ToolTipIcon.None);
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

     

    

        private void btnSleep_Click(object sender, EventArgs e)
        {
            if (pbSleep.Value >= 500 )
            {
                pbMood.Value += 10;
            }

          

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
                tConstanEnergyDrain.Start();
            }

            //testdah

            //if (_leverEat == false || _leverClean == false || _leverSpeak == false )
            //{
            //    btnSleep.Image = Properties.Resources.btnSleep;
            //    tSleep.Stop();
            //    _leverSleep = true;
            //}
        }


    

      

        

        private void btnEat_Click(object sender, EventArgs e)
        {
            if (pbHunger.Value <= 500)
            {
                pbMood.Value += 10;
            }

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
                tConstanEnergyDrain.Start();
            }


            //if (_leverSleep == false || _leverClean == false || _leverSpeak == false)
            //{
            //    btnEat.Image = Properties.Resources.btnEat1;
            //    tEat.Stop();
            //    _leverEat = true;
            //}



        }

        private void tSleep_Tick(object sender, EventArgs e)
        {
            

            try
            {
                pbSleep.Value += 10;
            }
            catch
            {
                tSleep.Stop();
            }


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

            try
            {
                pbHunger.Value += 5;

            }
            catch
            {
                tEat.Stop();
            }

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
           
            if (pbHygiene.Value >= 500)
            {
                pbMood.Value += 10;
            }


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
                tConstanEnergyDrain.Start();
            }

            //if (_leverSleep == false || _leverSpeak == false || _leverEat == false)
            //{
            //    btnClean.Image = Properties.Resources.btnClean;
            //    tClean.Stop();
            //    _leverClean = true;
            //}

        }

        private void tClean_Tick(object sender, EventArgs e)
        {
           

            try
            {
                pbHygiene.Value += 20;
            }
            catch
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

        public void btnShop_Click(object sender, EventArgs e)
        {
            Form shop = new Shop(money);
            this.Hide();
            shop.Show(this);

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

        private void notTest_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tMoney_Tick(object sender, EventArgs e)
        {
            money++;
            lblMoney.Text = Convert.ToString(money);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //using (StreamReader read_file = new StreamReader("C:\\Stymph\\Stymphian"))
            //{
            //    string search_for_line = read_file.ReadLine();
            //    if (search_for_line.Contains("pbHunger.Value"))
            //    {
            //        using (StreamWriter write_file = new StreamWriter("C:\\Stymph\\Stymphian"))
            //        {
            //            string HungerValue = "pbHunger.value ==" + pbHunger.Value.ToString();
            //            write_file.WriteLine(HungerValue);

            //        }
            //    }
            //}




        }
    }
}
