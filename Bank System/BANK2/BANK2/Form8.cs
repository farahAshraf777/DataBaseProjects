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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("update Customer set C_name ='" + textBox2.Text.ToString() +"', C_addr ='" + textBox3.Text.ToString() + "', C_phone ='" + textBox4.Text + "'WHERE C_SSN ='" + textBox1.Text+ "'",sqlConnection) ;
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("successfully Update customer's information");

        }
    }
}
