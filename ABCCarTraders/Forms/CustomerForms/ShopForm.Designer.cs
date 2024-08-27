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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbVehicle = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbVehiclePart = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 365);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.cbVehiclePart);
            this.panel1.Controls.Add(this.cbVehicle);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 2;
            // 
            // cbVehicle
            // 
            this.cbVehicle.AutoSize = true;
            this.cbVehicle.Location = new System.Drawing.Point(556, 40);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(66, 17);
            this.cbVehicle.TabIndex = 1;
            this.cbVehicle.Text = "Vehicles";
            this.cbVehicle.UseVisualStyleBackColor = true;
            this.cbVehicle.Click += new System.EventHandler(this.cbVehicle_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(211, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(306, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // cbVehiclePart
            // 
            this.cbVehiclePart.AutoSize = true;
            this.cbVehiclePart.Location = new System.Drawing.Point(628, 40);
            this.cbVehiclePart.Name = "cbVehiclePart";
            this.cbVehiclePart.Size = new System.Drawing.Size(88, 17);
            this.cbVehiclePart.TabIndex = 1;
            this.cbVehiclePart.Text = "Vehicle Parts";
            this.cbVehiclePart.UseVisualStyleBackColor = true;
            this.cbVehiclePart.Click += new System.EventHandler(this.cbVehiclePart_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cbVehicle;
        private System.Windows.Forms.CheckBox cbVehiclePart;
    }
}