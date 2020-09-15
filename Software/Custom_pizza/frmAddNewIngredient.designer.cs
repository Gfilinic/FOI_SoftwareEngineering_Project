namespace frmAddIngredient
{
    partial class frmAddNewIngredient
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbIngredient = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lbMeasurement = new System.Windows.Forms.ListBox();
            this.tbUnit_number = new System.Windows.Forms.TextBox();
            this.tbSelling_price_per_unit = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(164, 276);
            this.tbStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(126, 20);
            this.tbStock.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Stock";
            // 
            // pbIngredient
            // 
            this.pbIngredient.Location = new System.Drawing.Point(364, 58);
            this.pbIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbIngredient.Name = "pbIngredient";
            this.pbIngredient.Size = new System.Drawing.Size(218, 236);
            this.pbIngredient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIngredient.TabIndex = 29;
            this.pbIngredient.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(161, 328);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(127, 24);
            this.btnUpload.TabIndex = 28;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click_1);
            // 
            // lbMeasurement
            // 
            this.lbMeasurement.FormattingEnabled = true;
            this.lbMeasurement.Location = new System.Drawing.Point(164, 223);
            this.lbMeasurement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbMeasurement.Name = "lbMeasurement";
            this.lbMeasurement.Size = new System.Drawing.Size(126, 17);
            this.lbMeasurement.TabIndex = 27;
            // 
            // tbUnit_number
            // 
            this.tbUnit_number.Location = new System.Drawing.Point(164, 167);
            this.tbUnit_number.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUnit_number.Name = "tbUnit_number";
            this.tbUnit_number.Size = new System.Drawing.Size(128, 20);
            this.tbUnit_number.TabIndex = 26;
            // 
            // tbSelling_price_per_unit
            // 
            this.tbSelling_price_per_unit.Location = new System.Drawing.Point(164, 112);
            this.tbSelling_price_per_unit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSelling_price_per_unit.Name = "tbSelling_price_per_unit";
            this.tbSelling_price_per_unit.Size = new System.Drawing.Size(126, 20);
            this.tbSelling_price_per_unit.TabIndex = 25;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(164, 58);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(127, 20);
            this.tbName.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Measurement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Unit number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Selling price per unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add a new Ingredient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(502, 328);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(398, 328);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // frmAddNewIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbIngredient);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lbMeasurement);
            this.Controls.Add(this.tbUnit_number);
            this.Controls.Add(this.tbSelling_price_per_unit);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddNewIngredient";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddNewIngredient_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbIngredient;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ListBox lbMeasurement;
        private System.Windows.Forms.TextBox tbUnit_number;
        private System.Windows.Forms.TextBox tbSelling_price_per_unit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}

