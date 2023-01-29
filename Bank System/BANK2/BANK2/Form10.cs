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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANK_SYSTEM2DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bANK_SYSTEM2DataSet.Employee);
            // TODO: This line of code loads data into the 'bANK_SYSTEM2DataSet.Loan' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bANK_SYSTEM2DataSet.Customer' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.bANK_SYSTEM2DataSet.Customer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.loanTableAdapter.Fill(this.bANK_SYSTEM2DataSet.Loan);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("Select L_num ,C_name,E_name from Loan ,Customer,Employee where Loan.C_SSN=Customer.C_SSN and Loan.E_ID=Employee.E_ID", sqlConnection);
            SqlDataAdapter show = new SqlDataAdapter();
            show.SelectCommand = myCommand;
            DataTable Data = new DataTable();
            show.Fill(Data);
            dataGridView3.DataSource = Data;
            dataGridView3.Columns[0].HeaderText = "L_num";
            dataGridView3.Columns[1].HeaderText = "C_name";
            dataGridView3.Columns[2].HeaderText = "E_name";
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
