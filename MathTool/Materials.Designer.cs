namespace MathTool
{
    partial class Materials
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materials));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRevision = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.materialList = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.btnPdf = new System.Windows.Forms.Button();
            this.pdfReader1 = new AxAcroPDFLib.AxAcroPDF();
            this.video = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pdfReader1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRevision
            // 
            this.btnRevision.Location = new System.Drawing.Point(93, 12);
            this.btnRevision.Name = "btnRevision";
            this.btnRevision.Size = new System.Drawing.Size(75, 23);
            this.btnRevision.TabIndex = 1;
            this.btnRevision.Text = "Revision";
            this.btnRevision.UseVisualStyleBackColor = true;
            this.btnRevision.Click += new System.EventHandler(this.btnRevision_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(797, 12);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Sign Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // materialList
            // 
            this.materialList.DisplayMember = "Materials";
            this.materialList.FormattingEnabled = true;
            this.materialList.Items.AddRange(new object[] {
            "sad",
            "asd",
            "ads"});
            this.materialList.Location = new System.Drawing.Point(12, 79);
            this.materialList.Name = "materialList";
            this.materialList.Size = new System.Drawing.Size(121, 21);
            this.materialList.TabIndex = 98;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel1.Location = new System.Drawing.Point(12, 285);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 100;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel2.Location = new System.Drawing.Point(12, 302);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(55, 13);
            this.linkLabel2.TabIndex = 101;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel3.Location = new System.Drawing.Point(12, 319);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(55, 13);
            this.linkLabel3.TabIndex = 102;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel3";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel4.Location = new System.Drawing.Point(12, 336);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(55, 13);
            this.linkLabel4.TabIndex = 103;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "linkLabel4";
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(174, 426);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 105;
            this.btnPdf.Text = "button1";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // pdfReader1
            // 
            this.pdfReader1.Enabled = true;
            this.pdfReader1.Location = new System.Drawing.Point(174, 41);
            this.pdfReader1.Name = "pdfReader1";
            this.pdfReader1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfReader1.OcxState")));
            this.pdfReader1.Size = new System.Drawing.Size(409, 379);
            this.pdfReader1.TabIndex = 106;
            // 
            // video
            // 
            this.video.Location = new System.Drawing.Point(589, 101);
            this.video.MinimumSize = new System.Drawing.Size(20, 20);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(283, 274);
            this.video.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Enter Youtube link";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(589, 57);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(100, 20);
            this.txtLink.TabIndex = 109;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(742, 57);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 110;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.video);
            this.Controls.Add(this.pdfReader1);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.materialList);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRevision);
            this.Controls.Add(this.btnHome);
            this.Name = "Materials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materials";
            ((System.ComponentModel.ISupportInitialize)(this.pdfReader1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRevision;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.ComboBox materialList;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Button btnPdf;
        private AxAcroPDFLib.AxAcroPDF pdfReader1;
        private System.Windows.Forms.WebBrowser video;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnPlay;
    }
}