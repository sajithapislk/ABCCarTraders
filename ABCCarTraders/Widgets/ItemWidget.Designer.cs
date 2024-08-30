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
            this.btnSaveCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.pbDp = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlQty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDp)).BeginInit();
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
            this.btnAddCart.Location = new System.Drawing.Point(12, 206);
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
            this.pnlQty.Location = new System.Drawing.Point(0, 128);
            this.pnlQty.Name = "pnlQty";
            this.pnlQty.Size = new System.Drawing.Size(200, 122);
            this.pnlQty.TabIndex = 3;
            this.pnlQty.Visible = false;
            // 
            // btnSaveCart
            // 
            this.btnSaveCart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSaveCart.ForeColor = System.Drawing.Color.White;
            this.btnSaveCart.Location = new System.Drawing.Point(48, 69);
            this.btnSaveCart.Name = "btnSaveCart";
            this.btnSaveCart.Size = new System.Drawing.Size(99, 32);
            this.btnSaveCart.TabIndex = 2;
            this.btnSaveCart.Text = "Save Cart";
            this.btnSaveCart.UseVisualStyleBackColor = false;
            this.btnSaveCart.Click += new System.EventHandler(this.btnSaveCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quntity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(48, 37);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 0;
            // 
            // pbDp
            // 
            this.pbDp.BackColor = System.Drawing.Color.White;
            this.pbDp.Location = new System.Drawing.Point(0, 0);
            this.pbDp.Name = "pbDp";
            this.pbDp.Size = new System.Drawing.Size(200, 132);
            this.pbDp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDp.TabIndex = 4;
            this.pbDp.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(101, 206);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // ItemWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pnlQty);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.pbDp);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.lblTitle);
            this.Name = "ItemWidget";
            this.Size = new System.Drawing.Size(200, 250);
            this.pnlQty.ResumeLayout(false);
            this.pnlQty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDp)).EndInit();
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
        private System.Windows.Forms.PictureBox pbDp;
        private System.Windows.Forms.Button btnView;
    }
}
