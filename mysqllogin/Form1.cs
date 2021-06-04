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

namespace mysqllogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = mysqlcsharp");
            MySqlDataAdapter sda = new MySqlDataAdapter("Select count(*) from mysqlc where username ='" + textBox1.Text + "' and password ='" + textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("incorect", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
