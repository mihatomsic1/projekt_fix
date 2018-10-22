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
    public partial class dodajTekmo : Form
    {

        MySqlConnection con = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");


        public dodajTekmo()
        {
            InitializeComponent();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
          



 MySqlConnection con = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");

            string id1 = ekipa1combo.SelectedItem.ToString();
            string id2 = ekipa2combo.SelectedItem.ToString();
            string rezultat = maskedTextBox1.Text;
            string datum = dateTimePicker1.Text;

            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "INSERT INTO tekme (ekipa1_id, ekipa2_id, rezultat, datum_tekme) VALUES ((SELECT id FROM ekipe WHERE ime = '"+id1+ "'), (SELECT id FROM ekipe WHERE ime = '" + id2 + "'), '" + rezultat+ "', '" + datum + "') ";
            com.ExecuteNonQuery();
            MessageBox.Show("Tekma dodana!");
            tekmovanja tekmovanja = new tekmovanja();
            this.Hide();
            tekmovanja.Show();
        }

        private void dodajTekmo_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT ime FROM ekipe ";
            com.ExecuteNonQuery();
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                ekipa1combo.Items.Add(reader.GetString("ime"));
            }
            com.Dispose();
            con.Close();

            con.Open();
            MySqlCommand com1 = con.CreateCommand();
            com1.CommandType = CommandType.Text;
            com1.CommandText = "SELECT ime FROM ekipe ";
            com1.ExecuteNonQuery();
            MySqlDataReader reader1 = com.ExecuteReader();
            while (reader1.Read())
            {
                ekipa2combo.Items.Add(reader1.GetString("ime"));
            }
            com.Dispose();
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
