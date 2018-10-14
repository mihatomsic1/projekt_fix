using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace liga
{
    public partial class Registracija : Form
    {
    
        MySqlConnection con = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");

        public Registracija()
        {
            InitializeComponent();
            gesloTextbox.UseSystemPasswordChar = true;

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string up_ime = userTextbox.Text;
            string email = emailTextbox.Text;
            string geslo = gesloTextbox.Text;
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "INSERT INTO uporabniki (up_ime, geslo, email) VALUES ('"+up_ime+ "', '" + geslo + "', '" + email + "' )";
            com.ExecuteNonQuery();
            MessageBox.Show("Registracija uspesna!");
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }
    }
}
