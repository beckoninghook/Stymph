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

            
       

        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }
    }
}
