namespace ABCCarTraders.Forms.CustomerForms
{
    partial class CustomerDashboardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(64, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 22);
            this.lblName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(133, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "ABC Car Traders ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "© 2024 APIS.LK, Inc. All rights reserved.";
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::ABCCarTraders.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(441, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(31, 26);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Image = global::ABCCarTraders.Properties.Resources.order_history;
            this.btnOrderHistory.Location = new System.Drawing.Point(317, 140);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(128, 142);
            this.btnOrderHistory.TabIndex = 3;
            this.btnOrderHistory.Text = "Order History";
            this.btnOrderHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrderHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnCart
            // 
            this.btnCart.Image = global::ABCCarTraders.Properties.Resources.cart;
            this.btnCart.Location = new System.Drawing.Point(181, 140);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(130, 142);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShop.Image = global::ABCCarTraders.Properties.Resources.PngItem_62303471;
            this.btnShop.Location = new System.Drawing.Point(37, 140);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(138, 142);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "Shop";
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // CustomerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogout;
    }
}