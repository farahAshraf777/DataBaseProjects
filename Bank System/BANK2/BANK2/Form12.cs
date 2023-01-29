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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("select Branch.Branch_num from Branch,deal_with where Branch.Branch_num not in (select deal_with.Branch_num from deal_with )", sqlConnection);
            SqlDataAdapter show = new SqlDataAdapter();
            show.SelectCommand = myCommand;
            DataTable Data = new DataTable();
            show.Fill(Data);
            dataGridView1.DataSource = Data;
            dataGridView1.Columns[0].HeaderText = "Branch number";
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("select Branch.Branch_num from Branch where Branch.Branch_num not in (select Employee.Branch_num from Employee )", sqlConnection);
            SqlDataAdapter show = new SqlDataAdapter();
            show.SelectCommand = myCommand;
            DataTable Data = new DataTable();
            show.Fill(Data);
            dataGridView2.DataSource = Data;
            dataGridView2.Columns[0].HeaderText = "Branch number";
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 query1 = new Form13();
            query1.Show();
            this.Hide();
        }
    }
}
