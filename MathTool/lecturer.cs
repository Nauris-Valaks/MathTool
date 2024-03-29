﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MathTool
{
    public partial class lecturer : Form
    {
        public lecturer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nauri\\source\\repos\\MathTool\\MathTool\\user.mdf;Integrated Security=True;Connect Timeout=30");

        private void lecturer_Load(object sender, EventArgs e)
        {
            var select = "SELECT * FROM [quiz]";
            var c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nauri\\source\\repos\\MathTool\\MathTool\\user.mdf;Integrated Security=True;Connect Timeout=30"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvAmend.DataSource = ds.Tables[0];

        }
        private void callonload()
        {
            var select = "SELECT * FROM [quiz]";
            var c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nauri\\source\\repos\\MathTool\\MathTool\\user.mdf;Integrated Security=True;Connect Timeout=30"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvAmend.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAnswer1.Text == "")
            {
                MessageBox.Show("Enter Answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnswer1.Focus();
                return;
            }
            if (richQuestion.Text == "")
            {
                MessageBox.Show("Enter Question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richQuestion.Focus();
                return;
            }
            if (txtAnswer2.Text == "")
            {
                MessageBox.Show("Enter Answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnswer2.Focus();
                return;
            }
            if (txtAnswer3.Text == "")
            {
                MessageBox.Show("Enter Answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnswer3.Focus();
                return;
            }
            if (txtAnswer4.Text == "")
            {
                MessageBox.Show("Enter Answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnswer4.Focus();
                return;
            }
            string connectionString = null;
            string sql = null;

            // All the info required to reach your db. See connectionstrings.com
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nauri\\source\\repos\\MathTool\\MathTool\\user.mdf;Integrated Security=True;Connect Timeout=30";

            // Prepare a proper parameterized query 
            sql = "insert into [quiz] ([Question], [Answer1], [Answer2], [Answer3], [Answer4]) values(@Question,@Answer1,@Answer2,@Answer3,@Answer4)";



            // Create the connection (and be sure to dispose it at the end)
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection to the database. 
                    // This is the first critical step in the process.
                    // If we cannot reach the db then we have connectivity problems
                    cnn.Open();

                    // Prepare the command to be executed on the db
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        // Create and set the parameters values 

                        cmd.Parameters.Add("@Question", SqlDbType.NVarChar).Value = richQuestion.Text;
                        cmd.Parameters.Add("@Answer1", SqlDbType.NVarChar).Value = txtAnswer1.Text;
                        cmd.Parameters.Add("@Answer2", SqlDbType.NVarChar).Value = txtAnswer2.Text;
                        cmd.Parameters.Add("@Answer3", SqlDbType.NVarChar).Value = txtAnswer3.Text;
                        cmd.Parameters.Add("@Answer4", SqlDbType.NVarChar).Value = txtAnswer4.Text;
                        // cmd.Parameters.Add("@role", SqlDbType.NVarChar).Value = boxRole.Text;

                        // Let's ask the db to execute the query
                        int rowsAdded = cmd.ExecuteNonQuery();

                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Row inserted!!");

                            this.Refresh();
                            dgvAmend.Update();
                            dgvAmend.Refresh();
                            callonload();
                            cmd.Cancel();
                            cnn.Close();

                        }


                        else
                        {
                            // Well this should never really happen
                            MessageBox.Show("No row inserted");

                            cnn.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    // We should log the error somewhere, 
                    // for this example let's just show a message
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbKeyNo_Click(object sender, EventArgs e)
        {

        }

        private void lbType_Click(object sender, EventArgs e)
        {

        }

        private void lbAllocated_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
                this.Visible = false;
                (new Login()).Show();         
        }

        private void richQuestion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
