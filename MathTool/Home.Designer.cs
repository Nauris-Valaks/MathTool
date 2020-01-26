namespace MathTool
{
    partial class Home
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
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnRevision = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaterials
            // 
            this.btnMaterials.Location = new System.Drawing.Point(12, 12);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(75, 23);
            this.btnMaterials.TabIndex = 0;
            this.btnMaterials.Text = "Materials";
            this.btnMaterials.UseVisualStyleBackColor = true;
            // 
            // btnRevision
            // 
            this.btnRevision.Location = new System.Drawing.Point(93, 12);
            this.btnRevision.Name = "btnRevision";
            this.btnRevision.Size = new System.Drawing.Size(75, 23);
            this.btnRevision.TabIndex = 1;
            this.btnRevision.Text = "Revision";
            this.btnRevision.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(466, 12);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Sign Out";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRevision);
            this.Controls.Add(this.btnMaterials);
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button btnRevision;
        private System.Windows.Forms.Button btnOut;
    }
}