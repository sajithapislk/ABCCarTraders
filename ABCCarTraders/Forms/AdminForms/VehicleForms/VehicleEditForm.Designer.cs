﻿namespace ABCCarTraders.Forms.AdminForms.VehicleForms
{
    partial class VehicleEditForm
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
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbVehicleColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbVehicleBrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVehicleType = new System.Windows.Forms.ComboBox();
            this.txtVehicleAFC = new System.Windows.Forms.TextBox();
            this.txtVehiclePower = new System.Windows.Forms.TextBox();
            this.txtVehicleTorque = new System.Windows.Forms.TextBox();
            this.txtVehicleEngineCode = new System.Windows.Forms.TextBox();
            this.txtVehicleEngine = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtVehicleYear = new System.Windows.Forms.TextBox();
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtQty.Location = new System.Drawing.Point(514, 12);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(62, 26);
            this.txtQty.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(415, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "Qty";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(301, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(444, 223);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 40);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbVehicleColor
            // 
            this.cbVehicleColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbVehicleColor.FormattingEnabled = true;
            this.cbVehicleColor.Items.AddRange(new object[] {
            "alizarin",
            "amaranth",
            "amber",
            "amethyst",
            "apricot",
            "aqua",
            "aquamarine",
            "asparagus",
            "auburn",
            "azure",
            "beige",
            "bistre",
            "black",
            "blue",
            "blue-green",
            "blue-violet",
            "bondi-blue",
            "brass",
            "bronze",
            "brown",
            "buff",
            "burgundy",
            "camouflage-green",
            "caput-mortuum",
            "cardinal",
            "carmine",
            "carrot-orange",
            "celadon",
            "cerise",
            "cerulean",
            "champagne",
            "charcoal",
            "chartreuse",
            "cherry-blossom-pink",
            "chestnut",
            "chocolate",
            "cinnabar",
            "cinnamon",
            "cobalt",
            "copper",
            "coral",
            "corn",
            "cornflower",
            "cream",
            "crimson",
            "cyan",
            "dandelion",
            "denim",
            "ecru",
            "emerald",
            "eggplant",
            "falu-red",
            "fern-green",
            "firebrick",
            "flax",
            "forest-green",
            "french-rose",
            "fuchsia",
            "gamboge",
            "gold",
            "goldenrod",
            "green",
            "grey",
            "han-purple",
            "harlequin",
            "heliotrope",
            "hollywood-cerise",
            "indigo",
            "ivory",
            "jade",
            "kelly-green",
            "khaki",
            "lavender",
            "lawn-green",
            "lemon",
            "lemon-chiffon",
            "lilac",
            "lime",
            "lime-green",
            "linen",
            "magenta",
            "magnolia",
            "malachite",
            "maroon",
            "mauve",
            "midnight-blue",
            "mint-green",
            "misty-rose",
            "moss-green",
            "mustard",
            "myrtle",
            "navajo-white",
            "navy-blue",
            "ochre",
            "office-green",
            "olive",
            "olivine",
            "orange",
            "orchid",
            "papaya-whip",
            "peach",
            "pear",
            "periwinkle",
            "persimmon",
            "pine-green",
            "pink",
            "platinum",
            "plum",
            "powder-blue",
            "puce",
            "prussian-blue",
            "psychedelic-purple",
            "pumpkin",
            "purple",
            "quartz-grey",
            "raw-umber",
            "razzmatazz",
            "red",
            "robin-egg-blue",
            "rose",
            "royal-blue",
            "royal-purple",
            "ruby",
            "russet",
            "rust",
            "safety-orange",
            "saffron",
            "salmon",
            "sandy-brown",
            "sangria",
            "sapphire",
            "scarlet",
            "school-bus-yellow",
            "sea-green",
            "seashell",
            "sepia",
            "shamrock-green",
            "shocking-pink",
            "silver",
            "sky-blue",
            "slate-grey",
            "smalt",
            "spring-bud",
            "spring-green",
            "steel-blue",
            "tan",
            "tangerine",
            "taupe",
            "teal",
            "tenné-(tawny)",
            "terra-cotta",
            "thistle",
            "titanium-white",
            "tomato",
            "turquoise",
            "tyrian-purple",
            "ultramarine",
            "van-dyke-brown",
            "vermilion",
            "violet",
            "viridian",
            "wheat",
            "white",
            "wisteria",
            "yellow",
            "zucchini"});
            this.cbVehicleColor.Location = new System.Drawing.Point(99, 158);
            this.cbVehicleColor.Name = "cbVehicleColor";
            this.cbVehicleColor.Size = new System.Drawing.Size(157, 27);
            this.cbVehicleColor.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Brand";
            // 
            // cbVehicleBrand
            // 
            this.cbVehicleBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbVehicleBrand.FormattingEnabled = true;
            this.cbVehicleBrand.Location = new System.Drawing.Point(99, 121);
            this.cbVehicleBrand.Name = "cbVehicleBrand";
            this.cbVehicleBrand.Size = new System.Drawing.Size(157, 27);
            this.cbVehicleBrand.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Type";
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Location = new System.Drawing.Point(99, 84);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(157, 27);
            this.cbVehicleType.TabIndex = 27;
            // 
            // txtVehicleAFC
            // 
            this.txtVehicleAFC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtVehicleAFC.Location = new System.Drawing.Point(419, 107);
            this.txtVehicleAFC.Name = "txtVehicleAFC";
            this.txtVehicleAFC.Size = new System.Drawing.Size(157, 26);
            this.txtVehicleAFC.TabIndex = 25;
            // 
            // txtVehiclePower
            // 
            this.txtVehiclePower.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtVehiclePower.Location = new System.Drawing.Point(99, 231);
            this.txtVehiclePower.Name = "txtVehiclePower";
            this.txtVehiclePower.Size = new System.Drawing.Size(157, 26);
            this.txtVehiclePower.TabIndex = 24;
            // 
            // txtVehicleTorque
            // 
            this.txtVehicleTorque.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtVehicleTorque.Location = new System.Drawing.Point(419, 154);
            this.txtVehicleTorque.Name = "txtVehicleTorque";
            this.txtVehicleTorque.Size = new System.Drawing.Size(157, 26);
            this.txtVehicleTorque.TabIndex = 23;
            // 
            // txtVehicleEngineCode
            // 
            this.txtVehicleEngineCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtVehicleEngineCode.Location = new System.Drawing.Point(419, 75);
            this.txtVehicleEngineCode.Name = "txtVehicleEngineCode";
            this.txtVehicleEngineCode.Size = new System.Drawing.Size(157, 26);
            this.txtVehicleEngineCode.TabIndex = 26;
            // 
            // txtVehicleEngine
            // 
            this.txtVehicleEngine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtVehicleEngine.Location = new System.Drawing.Point(419, 44);
            this.txtVehicleEngine.Name = "txtVehicleEngine";
            this.txtVehicleEngine.Size = new System.Drawing.Size(157, 26);
            this.txtVehicleEngine.TabIndex = 22;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(419, 189);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(157, 26);
            this.txtPrice.TabIndex = 21;
            // 
            // txtVehicleYear
            // 
            this.txtVehicleYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtVehicleYear.Location = new System.Drawing.Point(99, 195);
            this.txtVehicleYear.Name = "txtVehicleYear";
            this.txtVehicleYear.Size = new System.Drawing.Size(157, 26);
            this.txtVehicleYear.TabIndex = 20;
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtVehicleName.Location = new System.Drawing.Point(99, 12);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(292, 26);
            this.txtVehicleName.TabIndex = 19;
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtVehicleNo.Location = new System.Drawing.Point(99, 48);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(157, 26);
            this.txtVehicleNo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Color";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(297, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 38);
            this.label12.TabIndex = 15;
            this.label12.Text = "Average Fuel\r\nConsumption";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(9, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Power";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(297, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Torque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(297, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Engine Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(297, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Engine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(297, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(9, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Car Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Car No";
            // 
            // VehicleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 271);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbVehicleColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbVehicleBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVehicleType);
            this.Controls.Add(this.txtVehicleAFC);
            this.Controls.Add(this.txtVehiclePower);
            this.Controls.Add(this.txtVehicleTorque);
            this.Controls.Add(this.txtVehicleEngineCode);
            this.Controls.Add(this.txtVehicleEngine);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtVehicleYear);
            this.Controls.Add(this.txtVehicleName);
            this.Controls.Add(this.txtVehicleNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "VehicleEditForm";
            this.Text = "VehicleEditForm";
            this.Load += new System.EventHandler(this.VehicleEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbVehicleColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbVehicleBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVehicleType;
        private System.Windows.Forms.TextBox txtVehicleAFC;
        private System.Windows.Forms.TextBox txtVehiclePower;
        private System.Windows.Forms.TextBox txtVehicleTorque;
        private System.Windows.Forms.TextBox txtVehicleEngineCode;
        private System.Windows.Forms.TextBox txtVehicleEngine;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtVehicleYear;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}