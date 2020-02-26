namespace MathTool
{
    partial class admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvAmend = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet = new MathTool.userDataSet();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbKeyNo = new System.Windows.Forms.Label();
            this.lbAllocated = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.boxRole = new System.Windows.Forms.ComboBox();
            this.userTableAdapter = new MathTool.userDataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search in the database";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(830, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete Row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(830, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(830, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(114, 20);
            this.txtSearch.TabIndex = 31;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1189, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 23);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(87, 23);
            this.btnHelp.TabIndex = 29;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(830, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvAmend
            // 
            this.dgvAmend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmend.Location = new System.Drawing.Point(377, 29);
            this.dgvAmend.Name = "dgvAmend";
            this.dgvAmend.Size = new System.Drawing.Size(343, 450);
            this.dgvAmend.TabIndex = 27;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.userDataSet;
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "userDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(253, 29);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 40;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(253, 55);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 43;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add user";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbKeyNo
            // 
            this.lbKeyNo.AutoSize = true;
            this.lbKeyNo.Location = new System.Drawing.Point(163, 29);
            this.lbKeyNo.Name = "lbKeyNo";
            this.lbKeyNo.Size = new System.Drawing.Size(84, 13);
            this.lbKeyNo.TabIndex = 45;
            this.lbKeyNo.Text = "Student Number";
            // 
            // lbAllocated
            // 
            this.lbAllocated.AutoSize = true;
            this.lbAllocated.Location = new System.Drawing.Point(188, 81);
            this.lbAllocated.Name = "lbAllocated";
            this.lbAllocated.Size = new System.Drawing.Size(29, 13);
            this.lbAllocated.TabIndex = 46;
            this.lbAllocated.Text = "Role";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(194, 55);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(53, 13);
            this.lbType.TabIndex = 48;
            this.lbType.Text = "Password";
            // 
            // boxRole
            // 
            this.boxRole.FormattingEnabled = true;
            this.boxRole.Items.AddRange(new object[] {
            "Lecturer",
            "Admin",
            "Student"});
            this.boxRole.Location = new System.Drawing.Point(253, 82);
            this.boxRole.Name = "boxRole";
            this.boxRole.Size = new System.Drawing.Size(100, 21);
            this.boxRole.TabIndex = 49;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 681);
            this.Controls.Add(this.boxRole);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbAllocated);
            this.Controls.Add(this.lbKeyNo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvAmend);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvAmend;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbKeyNo;
        private System.Windows.Forms.Label lbAllocated;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox boxRole;
        private userDataSet userDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private userDataSetTableAdapters.UserTableAdapter userTableAdapter;
    }
}