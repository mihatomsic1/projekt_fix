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
    public partial class tekmovanja : Form
    {
        MySqlConnection con = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");

        public tekmovanja()
        {
            InitializeComponent();
        }

        private void tekmovanja_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            //com.CommandText = "SELECT e.ime, t.rezultat, t.datum_tekme FROM tekme t  INNER JOIN ekipe e  ON e.id = t.ekipa1_id";
            com.CommandText = "SELECT e.ime AS 'klub1', e1.ime AS 'klub2', t.rezultat, t.datum_tekme FROM tekme t  INNER JOIN ekipe e  ON e.id = t.ekipa1_id INNER JOIN ekipe e1 ON t.ekipa2_id = e1.id";
            com.ExecuteNonQuery();
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string ekipa1 = reader.GetString("klub1");
                string ekipa2 = reader.GetString("klub2");
                string rezultat = reader.GetString("rezultat");
                string datum = reader.GetString("datum_tekme");

                string tekma = ekipa1 + " " + rezultat + " " + ekipa2 + " " + datum;

                //push to list
                listBox1.Items.Add(tekma);

            }
            com.Dispose();
            con.Close();
        }

        private void nazajButton_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            dodajTekmo dodajTekmo = new dodajTekmo();
            this.Hide();
            dodajTekmo.Show();
        }
    }
}
