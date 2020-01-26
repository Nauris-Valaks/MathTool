namespace MathTool
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.carousel1 = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.cardLayout1 = new Syncfusion.Windows.Forms.Tools.CardLayout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudent
            // 
            this.txtStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudent.Location = new System.Drawing.Point(247, 74);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(100, 20);
            this.txtStudent.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(272, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(247, 113);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // carousel1
            // 
            this.carousel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carousel1.HighlightColor = System.Drawing.Color.White;
            this.carousel1.ImageshadeColor = System.Drawing.Color.Black;
            this.carousel1.ImageSlides = false;
            this.carousel1.Location = new System.Drawing.Point(12, 40);
            this.carousel1.Name = "carousel1";
            this.carousel1.PadX = 0;
            this.carousel1.PadY = 0;
            this.carousel1.Perspective = 4F;
            this.carousel1.RotateAlways = false;
            this.carousel1.ShowImagePreview = false;
            this.carousel1.ShowImageShadow = true;
            this.carousel1.Size = new System.Drawing.Size(178, 122);
            this.carousel1.TabIndex = 6;
            this.carousel1.Text = "carousel1";
            this.carousel1.TouchTransitionSpeed = 1F;
            this.carousel1.UseOriginalImageinPreview = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.carousel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardLayout1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.Carousel carousel1;
        private Syncfusion.Windows.Forms.Tools.CardLayout cardLayout1;
    }
}

