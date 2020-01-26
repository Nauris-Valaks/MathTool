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
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings5 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings5 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materials));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings5 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRevision = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pdfMaterials = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            this.materialList = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
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
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(622, 79);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 3;
            // 
            // pdfMaterials
            // 
            this.pdfMaterials.AutoScroll = true;
            this.pdfMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pdfMaterials.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.pdfMaterials.EnableContextMenu = true;
            this.pdfMaterials.HorizontalScrollOffset = 0;
            this.pdfMaterials.IsTextSearchEnabled = true;
            this.pdfMaterials.IsTextSelectionEnabled = true;
            this.pdfMaterials.Location = new System.Drawing.Point(230, 79);
            messageBoxSettings5.EnableNotification = true;
            this.pdfMaterials.MessageBoxSettings = messageBoxSettings5;
            this.pdfMaterials.MinimumZoomPercentage = 50;
            this.pdfMaterials.Name = "pdfMaterials";
            this.pdfMaterials.PageBorderThickness = 1;
            pdfViewerPrinterSettings5.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings5.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings5.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings5.PrintLocation")));
            pdfViewerPrinterSettings5.ShowPrintStatusDialog = true;
            this.pdfMaterials.PrinterSettings = pdfViewerPrinterSettings5;
            this.pdfMaterials.ReferencePath = null;
            this.pdfMaterials.ScrollDisplacementValue = 0;
            this.pdfMaterials.ShowHorizontalScrollBar = true;
            this.pdfMaterials.ShowVerticalScrollBar = true;
            this.pdfMaterials.Size = new System.Drawing.Size(386, 250);
            this.pdfMaterials.SpaceBetweenPages = 8;
            this.pdfMaterials.TabIndex = 4;
            textSearchSettings5.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings5.HighlightAllInstance = true;
            textSearchSettings5.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pdfMaterials.TextSearchSettings = textSearchSettings5;
            this.pdfMaterials.ThemeName = "Default";
            this.pdfMaterials.VerticalScrollOffset = 0;
            this.pdfMaterials.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.pdfMaterials.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
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
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.materialList);
            this.Controls.Add(this.pdfMaterials);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRevision);
            this.Controls.Add(this.btnHome);
            this.Name = "Materials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRevision;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView pdfMaterials;
        private System.Windows.Forms.ComboBox materialList;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}