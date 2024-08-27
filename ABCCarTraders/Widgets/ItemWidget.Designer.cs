namespace ABCCarTraders.Widgets
{
    partial class ItemWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlQty = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveCart = new System.Windows.Forms.Button();
            this.pnlQty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(22, 135);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(58, 205);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddCart.TabIndex = 1;
            this.btnAddCart.Text = "Add Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(75, 176);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "1000$";
            // 
            // pnlQty
            // 
            this.pnlQty.BackColor = System.Drawing.Color.White;
            this.pnlQty.Controls.Add(this.btnSaveCart);
            this.pnlQty.Controls.Add(this.label1);
            this.pnlQty.Controls.Add(this.txtQty);
            this.pnlQty.Location = new System.Drawing.Point(25, 113);
            this.pnlQty.Name = "pnlQty";
            this.pnlQty.Size = new System.Drawing.Size(151, 115);
            this.pnlQty.TabIndex = 3;
            this.pnlQty.Visible = false;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(30, 38);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quntity";
            // 
            // btnSaveCart
            // 
            this.btnSaveCart.Location = new System.Drawing.Point(43, 79);
            this.btnSaveCart.Name = "btnSaveCart";
            this.btnSaveCart.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCart.TabIndex = 2;
            this.btnSaveCart.Text = "Save Cart";
            this.btnSaveCart.UseVisualStyleBackColor = true;
            this.btnSaveCart.Click += new System.EventHandler(this.btnSaveCart_Click);
            // 
            // ItemWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pnlQty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.lblTitle);
            this.Name = "ItemWidget";
            this.Size = new System.Drawing.Size(200, 250);
            this.pnlQty.ResumeLayout(false);
            this.pnlQty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel pnlQty;
        private System.Windows.Forms.Button btnSaveCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
    }
}
