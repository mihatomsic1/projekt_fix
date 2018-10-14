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
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("datasource = mysql6001.site4now.net; username = a41c3d_mihatom; password = fuzbal100; database = db_a41c3d_mihatom; sslmode=none");
        public Login()
        {
            InitializeComponent();
            gesloTextbox.UseSystemPasswordChar = true;
        }
        private void prijavaButton_Click(object sender, EventArgs e)
        {
        }
         

        private void prijavaButton_Click_1(object sender, EventArgs e)
        {
                int i = 0;
                con.Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT * FROM uporabniki WHERE ((up_ime= '" + userTextbox.Text + "') AND (geslo ='" + gesloTextbox.Text + "'));";
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(com);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("Napačno uporabniško ime ali geslo.", "Neuspešna prijava!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userTextbox.Text = "";
                gesloTextbox.Text = "";
                }
                else
                {
                    Form1 Form1 = new Form1();
                    this.Hide();
                    Form1.Show();
                }
            }
        }
    }


    
