using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand mycommand = new SqlCommand("INSERT INTO ADMIN VALUES('" + textBox1.Text + "','" + textBox2.Text.ToString() + "','" + textBox3.Text + "')", sqlConnection);
            mycommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Successfuly Insert");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 bank = new Form5();
            bank.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 branch = new Form6();
            branch.Show();
            this.Hide();
        }
    }
}
