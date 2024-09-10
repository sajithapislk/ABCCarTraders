namespace ABCCarTraders.Forms.CustomerForms
{
    partial class ShopForm
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
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVehiclePart = new System.Windows.Forms.CheckBox();
            this.cbVehicle = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpList.Location = new System.Drawing.Point(0, 0);
            this.flpList.Name = "flowLayoutPanel1";
            this.flpList.Size = new System.Drawing.Size(792, 590);
            this.flpList.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnViewCart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbVehiclePart);
            this.panel1.Controls.Add(this.cbVehicle);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnViewCart
            // 
            this.btnViewCart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnViewCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewCart.ForeColor = System.Drawing.Color.White;
            this.btnViewCart.Location = new System.Drawing.Point(610, 38);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(161, 48);
            this.btnViewCart.TabIndex = 3;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = false;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // cbVehiclePart
            // 
            this.cbVehiclePart.AutoSize = true;
            this.cbVehiclePart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbVehiclePart.ForeColor = System.Drawing.Color.White;
            this.cbVehiclePart.Location = new System.Drawing.Point(385, 26);
            this.cbVehiclePart.Name = "cbVehiclePart";
            this.cbVehiclePart.Size = new System.Drawing.Size(116, 23);
            this.cbVehiclePart.TabIndex = 1;
            this.cbVehiclePart.Text = "Vehicle Parts";
            this.cbVehiclePart.UseVisualStyleBackColor = true;
            this.cbVehiclePart.Click += new System.EventHandler(this.cbVehiclePart_Click);
            // 
            // cbVehicle
            // 
            this.cbVehicle.AutoSize = true;
            this.cbVehicle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbVehicle.ForeColor = System.Drawing.Color.White;
            this.cbVehicle.Location = new System.Drawing.Point(385, 52);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(84, 23);
            this.cbVehicle.TabIndex = 1;
            this.cbVehicle.Text = "Vehicles";
            this.cbVehicle.UseVisualStyleBackColor = true;
            this.cbVehicle.Click += new System.EventHandler(this.cbVehicle_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(26, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(306, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flpList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 590);
            this.panel2.TabIndex = 3;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cbVehicle;
        private System.Windows.Forms.CheckBox cbVehiclePart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Label label1;
    }
}