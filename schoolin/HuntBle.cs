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
        bool up;
        bool down;
        bool right;
        bool left;

        public HuntBle()
        {

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right == true)
            {
                player.Left += 4;
            }

            if (up == true)
            {
                player.Top -= 4;
            }

            if (down == true)
            {
                player.Top += 4;
            }

            if (left == true)
            {
                player.Left -= 4;
            }

        }

        private void HuntBle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }

            if(e.KeyCode == Keys.Left)
            {
                left = true;
            }

            if(e.KeyCode == Keys.Up)
            {
                up = true;
            }

            if(e.KeyCode == Keys.Down)
            {
                down = true;
            }


        }

        private void HuntBle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if(e.KeyCode == Keys.Left)
            {
                left = false;
            }

            if(e.KeyCode == Keys.Up)
            {
                up = false;
            }

            if(e.KeyCode == Keys.Down)
            {
                down = false;
            }

        }

        private void HuntBle_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
