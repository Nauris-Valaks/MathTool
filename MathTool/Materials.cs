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
    public partial class Materials : Form
    {
        public Materials()
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

        private void btnRevision_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Revision()).Show();
        }

        private void pdfBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            // set file filter of dialog   
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                // use the LoadFile(ByVal fileName As String) function for open the pdf in control  
                pdfReader1.LoadFile(dlg.FileName);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.video.DocumentText = string.Format(html, txtLink.Text.Split('=')[1]);

        }
    }
}
