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
    public partial class Ekipe : Form
    {

        MySqlConnection con = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");


        public Ekipe()
        {
            InitializeComponent();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            dodajEkipo dodajEkipo = new dodajEkipo();
            this.Hide();
            dodajEkipo.Show();
        }

        private void izbrisiButton_Click(object sender, EventArgs e)
        {

            MySqlConnection con1 = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");

            /*****************/
            string text = Convert.ToString(comboBox1.SelectedItem);
         
            con1.Open();
            MySqlCommand com1 = con1.CreateCommand();
            com1.CommandType = CommandType.Text;
            com1.CommandText = "DELETE FROM ekipe WHERE ime = '"+text+"' ";
            com1.ExecuteNonQuery();
            MessageBox.Show("Ekipa izbrisana!");
            comboBox1.Text = "";
        }

        private void Ekipe_Load(object sender, EventArgs e)
        {

            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT ime FROM ekipe ";
            com.ExecuteNonQuery();
            MySqlDataReader reader = com.ExecuteReader();
            while(reader.Read())
            {
                comboBox1.Items.Add(reader.GetString("ime"));
            }
            com.Dispose();
            con.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
             int i = comboBox1.SelectedIndex ;
            urediEkipo urediEkipo = new urediEkipo();
            urediEkipo.Show();
            this.Hide();
        }

        private void izpisiButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con2 = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");
            int index = comboBox1.SelectedIndex;
            con2.Open();
            MySqlCommand com2 = con2.CreateCommand();
            com2.CommandType = CommandType.Text;
            com2.CommandText = "SELECT ime, naslov, leto_ustanovitve, trener FROM ekipe WHERE id = '" + index + "'";
            com2.ExecuteNonQuery();

            MySqlDataReader reader = com2.ExecuteReader();
            while (reader.Read())
            {
                string ime = reader.GetString("ime");
                string naslov = reader.GetString("naslov");
                int leto_ustanovitve = reader.GetInt32("leto_ustanovitve");
                string trener = reader.GetString("trener");


                MessageBox.Show("Ime ekipe:" + ime + ", Mesto ekipe:" + naslov + ", Leto ustanovitve:" + leto_ustanovitve + ", Trener:" + trener + " ");
            }
        }

        private void urediButton_Click(object sender, EventArgs e)
        {
            urediEkipo uredi = new urediEkipo();
            uredi.Show();
            this.Hide();
        }

        private void nazajButton_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void osveziButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
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
    }
}
