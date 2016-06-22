﻿using System;
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
        bool jump;
        int G = 30;
        int force;


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

            if (jump != true)
            {
                if (e.KeyCode == Keys.Up)
                {

                }
            }

        }

        private void HuntBle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = false;

            }

        }

        private void HuntBle_Load(object sender, EventArgs e)
        {
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
    }
}