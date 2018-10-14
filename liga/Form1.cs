using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        }

        private void ekipeButton_Click(object sender, EventArgs e)
        {
            Ekipe Ekipe = new Ekipe();
            this.Hide();
            Ekipe.Show();
        }

        private void igralciButton_Click(object sender, EventArgs e)
        {
            igralci igralci = new igralci();
            igralci.Show();
            this.Hide();
        }
    }
}
