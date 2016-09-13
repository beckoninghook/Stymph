using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            int line_to_edit = 7; // Warning: 1-based indexing!
            string sourceFile = "Stymphian.sty";
            string destinationFile = "C:\\Stymph\\Stymphian.sty";

            // Read the appropriate line from the file.
            string lineToWrite = null;
            using (StreamReader reader = new StreamReader(sourceFile))
            {
                for (int i = 1; i <= line_to_edit; ++i)
                    lineToWrite = reader.ReadLine();
            }

            if (lineToWrite == null)
                throw new InvalidDataException("Line does not exist in " + sourceFile);

            // Read the old file.
            string[] lines = File.ReadAllLines(destinationFile);

            // Write the new file over the old file.

            using (StreamWriter writer = new StreamWriter(destinationFile))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == line_to_edit)
                    {
                        writer.WriteLine(30);
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }


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

        private void item1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
