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


            int i = comboBox1.SelectedIndex + 3;
            comboBox1.Items.Remove(comboBox1.SelectedIndex);
            con1.Open();
            MySqlCommand com1 = con1.CreateCommand();
            com1.CommandType = CommandType.Text;
            com1.CommandText = "DELETE FROM ekipe WHERE id = '"+i+"' ";
            com1.ExecuteNonQuery();

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

        }
    }
}
