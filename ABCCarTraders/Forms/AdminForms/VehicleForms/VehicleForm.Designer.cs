namespace ABCCarTraders.Forms.AdminForms.VehicleForms
{
    partial class VehicleForm
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engine_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.torque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.type,
            this.brand,
            this.color,
            this.price,
            this.engine,
            this.engine_code,
            this.torque,
            this.afc,
            this.power});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(734, 347);
            this.dgvList.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "type";
            this.type.Name = "type";
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "brand";
            this.brand.Name = "brand";
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "color";
            this.color.Name = "color";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // engine
            // 
            this.engine.DataPropertyName = "engine";
            this.engine.HeaderText = "engine";
            this.engine.Name = "engine";
            // 
            // engine_code
            // 
            this.engine_code.DataPropertyName = "engine_code";
            this.engine_code.HeaderText = "engine_code";
            this.engine_code.Name = "engine_code";
            // 
            // torque
            // 
            this.torque.DataPropertyName = "torque";
            this.torque.HeaderText = "torque";
            this.torque.Name = "torque";
            // 
            // afc
            // 
            this.afc.DataPropertyName = "afc";
            this.afc.HeaderText = "afc";
            this.afc.Name = "afc";
            // 
            // power
            // 
            this.power.DataPropertyName = "power";
            this.power.HeaderText = "power";
            this.power.Name = "power";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 49);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 347);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vehicle - ABC Car Traders ";
            // 
            // button1
            // 
            this.button1.Image = global::ABCCarTraders.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(613, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 35);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::ABCCarTraders.Properties.Resources.insert;
            this.button2.Location = new System.Drawing.Point(666, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 35);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(734, 396);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn engine;
        private System.Windows.Forms.DataGridViewTextBoxColumn engine_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn torque;
        private System.Windows.Forms.DataGridViewTextBoxColumn afc;
        private System.Windows.Forms.DataGridViewTextBoxColumn power;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}