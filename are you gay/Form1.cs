using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace are_you_gay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            btnNo.Location = new Point(generator.Next(300, 600), generator.Next(100, 400));
            btnNo.Size = new Size(generator.Next(50, 100), generator.Next(25, 50));
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Form gae = new Form2();
            gae.Show();
        }
    }
}
