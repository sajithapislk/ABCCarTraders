namespace ABCCarTraders.Forms.AdminForms.ManageVehicleForm
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
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
            this.dgvList.Location = new System.Drawing.Point(22, 38);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(700, 261);
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
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 396);
            this.Controls.Add(this.dgvList);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
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
    }
}