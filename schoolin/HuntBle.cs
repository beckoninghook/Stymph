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
    public partial class HuntBle : Form
    {
       

        bool jump;
        int G = 20;
        int force;

        int i;

        int randomNumber;
        int rdm2;
        int rdm3;
        int rdm4;
        int rdm5;
        int rdm6;

        int rdm1y;
        int rdm2y;
        int rdm3y;
        int rdm4y;
        int rdm5y;
        int rdm6y;

        public HuntBle()
        {
            //lblRandom2.Left = rdm2;
            //lblRandom2.Top = 180;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

        public void generaternd()
        {
            Random rnd = new Random();

            //x-axis
            randomNumber = rnd.Next(0, 1250);
            rdm2 = rnd.Next(300, 5000);
            rdm3 = rnd.Next(300, 5250);
            rdm4 = rnd.Next(300, 5250);
            rdm5 = rnd.Next(300, 5250);
            rdm6 = rnd.Next(300, 5250);


            //y-axis
            rdm1y = rnd.Next(20, 500);
            rdm2y = rnd.Next(20, 500);
            rdm3y = rnd.Next(20, 500);
            rdm4y = rnd.Next(20, 500);
            rdm5y = rnd.Next(20, 500);
            rdm6y = rnd.Next(20, 500);


        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            lblrandom.Left -= 5;
            lblRandom2.Left -= 5;
            lblRandom3.Left -= 5;
            lblRandom4.Left -= 5;
            lblRandom5.Left -= 5;
            lblRandom6.Left -= 5;


            int y = 0;


            y = player.Top;


            lblY.Text = Convert.ToString(y);

            i++;

            testTimer.Text = Convert.ToString(i);

            if (y <= -10)
            {

                force -= 1;

                jump = false;
            }



            if (i == 1250)
            {
                timer1.Stop();
            }

            bgHunt.Left -= 5;


            if (jump == true)
            {
                player.Top -= force;

                force -= 1;

            }


        

            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height; //stop falling at bottom
                jump = false;

            }
            else
            {
                player.Top += 5; //falling
            }




        }

        private void HuntBle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.Back)
            {
                Form mg = new MainGame(Name);
                this.Hide();
                mg.Show(this);
            }

            if (e.KeyCode == Keys.Up)
            {
                jump = true;
                force = G;

                rdm2 -= 6;
            }

        }

        private void HuntBle_KeyUp(object sender, KeyEventArgs e)
        {

        }

        public void HuntBle_Load(object sender, EventArgs e)
        {
            tGametime.Start();
            generaternd();

            lblrandom.Text = Convert.ToString(randomNumber);
            lblRandom2.Text = Convert.ToString(rdm2);
            lblRandom3.Text = Convert.ToString(rdm3);
            lblRandom4.Text = Convert.ToString(rdm4);
            lblRandom5.Text = Convert.ToString(rdm5);
            lblRandom6.Text = Convert.ToString(rdm6);
            testlabel.Text = Convert.ToString(rdm2);



            lblrandom.Left = randomNumber;
            lblrandom.Top = rdm1y;

            lblRandom2.Left = rdm2;
            lblRandom2.Top = rdm2y;

            lblRandom3.Left = rdm3;
            lblRandom3.Top = rdm3y;

            lblRandom4.Left = rdm4;
            lblRandom4.Top = rdm4y;

            lblRandom5.Left = rdm5;
            lblRandom5.Top = rdm5y;

            lblRandom6.Left = rdm6;
            lblRandom6.Top = rdm6y;

          
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

        private void tGametime_Tick(object sender, EventArgs e)
        {
            int i = 0;

            i++;
            lblTijd.Text = Convert.ToString(i);


            if (i == 50)
            {
                MessageBox.Show("timesup");
            }

        }  
        private void bgHunt_Click(object sender, EventArgs e)
        {

        }
    }
}
