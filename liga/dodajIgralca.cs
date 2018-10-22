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
    public partial class dodajIgralca : Form
    {
        MySqlConnection con = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");

        public dodajIgralca()
        {
            InitializeComponent();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string priimek = textBox2.Text;
            string datum = dateTimePicker1.Text;
            string st_dresa = textBox4.Text;
            string e_ime = comboBox1.SelectedItem.ToString();

            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "INSERT INTO igralci (ekipa_id, ime, priimek, datum_roj, st_dresa) VALUES((SELECT id FROM ekipe WHERE ime='"+e_ime+"'), '"+ime+"', '"+priimek+"', '"+datum+"','"+st_dresa+"')";
            com.ExecuteNonQuery();
            MessageBox.Show("Igralec dodan");
            com.Dispose();
            con.Close();
        }

        private void dodajIgralca_Load(object sender, EventArgs e)
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
    }
}
