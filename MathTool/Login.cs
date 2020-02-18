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

                myCommand = new SqlCommand("SELECT StudentNumber, Password, role FROM Users WHERE StudentNumber = @StudentNumber AND Password = @Password AND role = @role", myConnection);

                SqlParameter sNumber = new SqlParameter("@StudentNumber", SqlDbType.NVarChar);
                SqlParameter sPass = new SqlParameter("@Password", SqlDbType.NVarChar);
                SqlParameter role = new SqlParameter("@role", SqlDbType.NVarChar);

                SqlDataAdapter da = new SqlDataAdapter("select role from Users where StudentNumber='" + txtStudent.Text + "' and Password='" + txtPass.Text + "'", myConnection);


                //sNumber.Value = txtStudent.Text;
                //sPass.Value = txtPass.Text;
                //role.Value = "@role";

                //myCommand.Parameters.Add(sNumber);
                //myCommand.Parameters.Add(sPass);
                //myCommand.Parameters.Add(role);


                //myCommand.Connection.Open();

                //SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    switch (dt.Rows[0]["role"] as string)
                    {
                        case "admin":
                            {
                                this.Hide();
                                new Materials().Show();
                                break;
                            }
                        case "student":
                            {
                                this.Hide();
                                new Revision().Show();
                                MessageBox.Show("You are User and only view the things");
                                break;
                            }
                        case "lecturer":
                            {
                                this.Hide();
                                new Revision().Show();
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Enter Correct Username and Password");
                                break;
                            }
                    }
                    //if(myReader.Read() == true)
                    //{
                    //    MessageBox.Show("You have logged in successfully " + txtStudent.Text);
                    //    this.Visible = false;
                    //    (new Home()).Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Login Failed, Try again !"," Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    txtPass.Clear();
                    //    txtPass.Focus();
                    //}
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Dispose();

                    }
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
