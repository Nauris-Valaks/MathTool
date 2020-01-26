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
    public partial class Revision : Form
    {
        public Revision()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Login()).Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Home()).Show();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Materials()).Show();
        }
    }
}
