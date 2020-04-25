using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTool
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nauri\\source\\repos\\MathTool\\MathTool\\user.mdf;Integrated Security=True;Connect Timeout=30");

        private void admin_Load(object sender, EventArgs e)
        {
            var select = "SELECT * FROM [user]";
            var c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nauri\\source\\repos\\MathTool\\MathTool\\user.mdf;Integrated Security=True;Connect Timeout=30"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvAmend.DataSource = ds.Tables[0];
        }
        private void callonload()
        {
            var select = "SELECT * FROM [user]";
            var c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nauri\\source\\repos\\MathTool\\MathTool\\user.mdf;Integrated Security=True;Connect Timeout=30"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvAmend.DataSource = ds.Tables[0];
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("Enter Student Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            if (boxRole.Text == "")
            {
                MessageBox.Show("Select Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boxRole.Focus();
                return;
            }
            string connectionString = null;
            string sql = null;

            // All the info required to reach your db. See connectionstrings.com
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nauri\\source\\repos\\MathTool\\MathTool\\user.mdf;Integrated Security=True;Connect Timeout=30";

            // Prepare a proper parameterized query 
            sql = "insert into [user] ([StudentNumber], [Password], [Role]) values(@number,@pass, @role)";



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

                        cmd.Parameters.Add("@number", SqlDbType.NVarChar).Value = txtNumber.Text;
                        cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = txtPass.Text;
                        cmd.Parameters.Add("@role", SqlDbType.NVarChar).Value = boxRole.Text;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Login()).Show();
        }
    }

}