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
    public partial class igralci : Form

    {

        MySqlConnection con = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");


        public igralci()
        {
            InitializeComponent();
        }

        private void igralci_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = comboBox1.SelectedIndex + 1;
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT ime, priimek, st_dresa FROM igralci WHERE ekipa_id = '"+i+"' ";
            com.ExecuteNonQuery();
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string ime = reader.GetString("ime");
                string priimek = reader.GetString("priimek");
                string st = reader.GetString("st_dresa");
                string igralec = ime + " " + priimek + " " + st;

                //push to list
                listBox1.Items.Add(igralec);
            }
            com.Dispose();
            con.Close();
        }
    }
}

