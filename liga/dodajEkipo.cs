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
    public partial class dodajEkipo : Form
    {
        MySqlConnection con = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");


        public dodajEkipo()
        {
            InitializeComponent();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {

            string ime = imeTextbox.Text;
            string mesto = mestoTextbox.Text;
            int leto  = Convert.ToInt32(letoTextbox.Text);
            string trener = trenerTextbox.Text;

            con.Open();

            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "INSERT INTO ekipe (ime, naslov, leto_ustanovitve, trener) VALUES ('" + ime + "', '" + mesto + "', '" + leto + "', '"+trener+"' )";
            com.ExecuteNonQuery();
            MessageBox.Show("Ekipa dodana!");
            Ekipe Ekipe = new Ekipe();
            Ekipe.Show();
            this.Hide();
        }
    }
}
