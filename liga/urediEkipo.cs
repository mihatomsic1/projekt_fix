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
    public partial class urediEkipo : Form
    {
        MySqlConnection con = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");
        
        public urediEkipo()
        {
            InitializeComponent();
        }

        private void urediEkipo_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT ime FROM ekipe ";
            com.ExecuteNonQuery();
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString("ime"));
            }
            com.Dispose();
            con.Close();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            string ime = imeTextbox.Text;
            string mesto = mestoTextbox.Text;
            int leto_ustanovitve = Convert.ToInt32(letoTextbox.Text);
            string trener = trenerTextbox.Text;
            int i = comboBox1.SelectedIndex + 1;

            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "UPDATE ekipe SET ime = '"+ime+ "', naslov = '" + mesto + "', leto_ustanovitve = '" + leto_ustanovitve + "', trener = '" + trener + "' WHERE id = '"+i+"'";
            com.ExecuteNonQuery();
            MessageBox.Show("Posodobitev uspesna.");
            Ekipe Ekipe = new Ekipe();
            Ekipe.Show();
            this.Hide();
            con.Close();
            com.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekipe ekipe = new Ekipe();
            this.Hide();
            ekipe.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ime1 = comboBox1.SelectedItem.ToString();
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT ime, naslov, leto_ustanovitve, trener FROM ekipe WHERE ime = '"+ime1+"'";
            com.ExecuteNonQuery();
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                imeTextbox.Text = reader.GetString("ime");
                mestoTextbox.Text = reader.GetString("naslov");
                letoTextbox.Text = reader.GetString("leto_ustanovitve");
                trenerTextbox.Text = reader.GetString("trener");
            }
            
            con.Close();
            com.Dispose();
        }
    }
}
