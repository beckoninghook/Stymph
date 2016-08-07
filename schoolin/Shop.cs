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
    public partial class Shop : Form
    {
        int _money;

        public Shop(int money)
        {
            
            _money = money;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

        private void btnThemes_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.SHOPItems;
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.SHOPThemes;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form mg = new MainGame(Name);
            this.Hide();
            mg.Show(this);

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            lblMoneyShop.Text = Convert.ToString(_money);
        }

        private void lblMoneyShop_Click(object sender, EventArgs e)
        {

        }
    }
}
