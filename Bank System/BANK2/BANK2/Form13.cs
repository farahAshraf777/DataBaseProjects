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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("select Customer.C_SSN,C_name,C_addr,C_phone,count(DealWith.E_ID) as number from Customer ,DealWith where Customer.C_SSN=DealWith.C_SSN group by Customer.C_SSN ,C_name,C_addr,C_phone", sqlConnection);
            SqlDataAdapter show = new SqlDataAdapter();
            show.SelectCommand = myCommand;
            DataTable Data = new DataTable();
            show.Fill(Data);
            dataGridView1.DataSource = Data;
            dataGridView1.Columns[0].HeaderText = "Customer SSN ";
            dataGridView1.Columns[1].HeaderText = "Customer Name ";
            dataGridView1.Columns[2].HeaderText = "Customer Address ";
            dataGridView1.Columns[3].HeaderText = "Customer Phone ";
            dataGridView1.Columns[4].HeaderText = "Employee Number  ";
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("select C_name,Customer.C_SSN from Customer where Customer.C_SSN not in (select Loan.C_SSN from Loan)", sqlConnection);
            SqlDataAdapter show = new SqlDataAdapter();
            show.SelectCommand = myCommand;
            DataTable Data = new DataTable();
            show.Fill(Data);
            dataGridView2.DataSource = Data;
            dataGridView2.Columns[0].HeaderText = "Customer Name ";
            dataGridView2.Columns[1].HeaderText = "Customer SSN ";
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 query1 = new Form14();
            query1.Show();
            this.Hide();
        }
    }
}
