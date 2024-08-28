namespace ABCCarTraders.Forms.AdminForms
{
    partial class AdminDashboardForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "© 2024 APIS.LK, Inc. All rights reserved.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(198, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "ABC Car Traders ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 22);
            this.lblName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hello";
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::ABCCarTraders.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(532, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(31, 26);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ABCCarTraders.Properties.Resources.order_history;
            this.button1.Location = new System.Drawing.Point(435, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 142);
            this.button1.TabIndex = 4;
            this.button1.Text = "Order List";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Image = global::ABCCarTraders.Properties.Resources.maintain;
            this.btnOrderHistory.Location = new System.Drawing.Point(301, 128);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(128, 142);
            this.btnOrderHistory.TabIndex = 3;
            this.btnOrderHistory.Text = "Vehicle Part Management";
            this.btnOrderHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrderHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnCart
            // 
            this.btnCart.Image = global::ABCCarTraders.Properties.Resources.vehicle;
            this.btnCart.Location = new System.Drawing.Point(165, 128);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(130, 142);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Vehicle Management";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShop.Image = global::ABCCarTraders.Properties.Resources.people;
            this.btnShop.Location = new System.Drawing.Point(21, 128);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(138, 142);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "Customer List";
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
    }
}