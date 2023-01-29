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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("update Employee set E_name='" + textBox2.Text.ToString() +"', E_phone ='" + textBox3.Text + "', E_addr ='" + textBox4.Text.ToString() + "'WHERE E_ID ='" + textBox1.Text+ "'",sqlConnection) ;
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("successfully Update employee's information");
        }
    }
}
