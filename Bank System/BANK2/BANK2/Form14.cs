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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT E_name ,E_ID FROM Employee WHERE E_ID IN (SELECT E_ID FROM Loan GROUP BY E_ID HAVING count(*) = (SELECT MAX(mycount) FROM (SELECT COUNT(*) mycount FROM Loan GROUP BY E_ID) a))", sqlConnection);
            SqlDataAdapter show = new SqlDataAdapter();
            show.SelectCommand = myCommand;
            DataTable Data = new DataTable();
            show.Fill(Data);
            dataGridView1.DataSource = Data;
            dataGridView1.Columns[0].HeaderText = "Employee Name ";
            dataGridView1.Columns[1].HeaderText = "Employee ID ";
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT C_name ,C_SSN FROM Customer WHERE C_SSN IN (SELECT C_SSN FROM Loan GROUP BY C_SSN HAVING count(*) = (SELECT MAX (mycount) FROM (SELECT COUNT(*) mycount FROM Loan GROUP BY C_SSN) a))", sqlConnection);
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
    }
}
