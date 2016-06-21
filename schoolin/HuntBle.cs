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
                player.Left += 5;
            }

            if (left == true)
            {
                player.Left -= 5;
            }
        }

        private void HuntBle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }

            if(e.KeyCode == Keys.A)
            {
                left = true;
            }
        }

        private void HuntBle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }

            if(e.KeyCode == Keys.A)
            {
                left = false;
            }
        }

        private void HuntBle_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
