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

namespace MathTool
{
    public partial class Login : Form
    {
        String cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nauri\\source\\repos\\MathTool\\MathTool\\users.mdf;Integrated Security=True;Connect Timeout=30";
        public Login()
        {
            InitializeComponent();
        }
       // Login1 login = new Login1("user", "1234");

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtStudent.Text == "")
            {
                MessageBox.Show("Enter Student Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudent.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Enter Student Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT StudentNumber, Password FROM Users WHERE StudentNumber = @StudentNumber AND Password = @Password", myConnection);

                SqlParameter sNumber = new SqlParameter("@StudentNumber", SqlDbType.NVarChar);
                SqlParameter sPass = new SqlParameter("@Password", SqlDbType.NVarChar);

                sNumber.Value =txtStudent.Text;
                sPass.Value = txtPass.Text;

                myCommand.Parameters.Add(sNumber);
                myCommand.Parameters.Add(sPass);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if(myReader.Read() == true)
                {
                    MessageBox.Show("You have logged in successfully " + txtStudent.Text);
                    this.Visible = false;
                    (new Home()).Show();
                }
                else
                {
                    MessageBox.Show("Login Failed, Try again !"," Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtPass.Focus();
                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();

                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
        //string user = txtStudent.Text;
        //string pass = txtPass.Text;

        //if (login.IsLoggedIn(user, pass))
        //{
        //   MessageBox.Show("You are logged in successfully");
        //   this.Visible = false;
        //   (new Home()).Show();

        // }
    }
    }
