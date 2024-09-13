namespace ABCCarTraders.Forms.AdminForms.CustomerForms
{
    partial class CustomerEditForm
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(12, 26);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(265, 26);
            this.txtUsername.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 26);
            this.txtName.TabIndex = 17;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegister.Location = new System.Drawing.Point(12, 224);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(267, 33);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(14, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tp";
            // 
            // txtTp
            // 
            this.txtTp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTp.Location = new System.Drawing.Point(14, 178);
            this.txtTp.Name = "txtTp";
            this.txtTp.Size = new System.Drawing.Size(265, 26);
            this.txtTp.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 272);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "CustomerEditForm";
            this.Text = "CustomerUpdateForm";
            this.Load += new System.EventHandler(this.CustomerEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}