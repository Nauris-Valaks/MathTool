using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTool
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Login1 login = new Login1("user", "1234");

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtStudent.Text;
            string pass = txtPass.Text;

            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("You are logged in successfully");
                this.Visible = false;
                (new Home()).Show();

            }
        }
    }

}
