﻿using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UON8VAS\SQLEXPRESS;Initial Catalog=BANK_SYSTEM2;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("insert into Customer values('" + textBox1.Text + "','" + textBox2.Text.ToString() +
            "' ,'" + textBox3.Text.ToString() + "' ,'" + textBox4.Text + "')", sqlConnection);
            myCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("successfully insert customer's information");
        }
    }
}
