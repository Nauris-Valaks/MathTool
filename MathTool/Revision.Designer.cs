namespace MathTool
{
    partial class Revision
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnOpt1 = new System.Windows.Forms.Button();
            this.btnOpt4 = new System.Windows.Forms.Button();
            this.btnOpt3 = new System.Windows.Forms.Button();
            this.btnOpt2 = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMaterials
            // 
            this.btnMaterials.Location = new System.Drawing.Point(93, 12);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(75, 23);
            this.btnMaterials.TabIndex = 2;
            this.btnMaterials.Text = "Materials";
            this.btnMaterials.UseVisualStyleBackColor = true;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(797, 12);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Sign Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnOpt1
            // 
            this.btnOpt1.Location = new System.Drawing.Point(93, 75);
            this.btnOpt1.Name = "btnOpt1";
            this.btnOpt1.Size = new System.Drawing.Size(75, 23);
            this.btnOpt1.TabIndex = 4;
            this.btnOpt1.Text = "Option 1";
            this.btnOpt1.UseVisualStyleBackColor = true;
            // 
            // btnOpt4
            // 
            this.btnOpt4.Location = new System.Drawing.Point(93, 203);
            this.btnOpt4.Name = "btnOpt4";
            this.btnOpt4.Size = new System.Drawing.Size(75, 23);
            this.btnOpt4.TabIndex = 5;
            this.btnOpt4.Text = "Option 4";
            this.btnOpt4.UseVisualStyleBackColor = true;
            // 
            // btnOpt3
            // 
            this.btnOpt3.Location = new System.Drawing.Point(93, 159);
            this.btnOpt3.Name = "btnOpt3";
            this.btnOpt3.Size = new System.Drawing.Size(75, 23);
            this.btnOpt3.TabIndex = 6;
            this.btnOpt3.Text = "Option 3";
            this.btnOpt3.UseVisualStyleBackColor = true;
            // 
            // btnOpt2
            // 
            this.btnOpt2.Location = new System.Drawing.Point(93, 119);
            this.btnOpt2.Name = "btnOpt2";
            this.btnOpt2.Size = new System.Drawing.Size(75, 23);
            this.btnOpt2.TabIndex = 7;
            this.btnOpt2.Text = "Option 2";
            this.btnOpt2.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(320, 75);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(280, 242);
            this.txtInfo.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(372, 342);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 46);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // Revision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnOpt2);
            this.Controls.Add(this.btnOpt3);
            this.Controls.Add(this.btnOpt4);
            this.Controls.Add(this.btnOpt1);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnMaterials);
            this.Controls.Add(this.btnHome);
            this.Name = "Revision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnOpt1;
        private System.Windows.Forms.Button btnOpt4;
        private System.Windows.Forms.Button btnOpt3;
        private System.Windows.Forms.Button btnOpt2;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnStart;
    }
}