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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSelling_price_per_unit = new System.Windows.Forms.TextBox();
            this.tbUnit_number = new System.Windows.Forms.TextBox();
            this.lbMeasurement = new System.Windows.Forms.ListBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pbIngredient = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(528, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(668, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add a new Ingredient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selling price per unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unit number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Measurement";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(216, 66);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(168, 22);
            this.tbName.TabIndex = 8;
            // 
            // tbSelling_price_per_unit
            // 
            this.tbSelling_price_per_unit.Location = new System.Drawing.Point(216, 132);
            this.tbSelling_price_per_unit.Name = "tbSelling_price_per_unit";
            this.tbSelling_price_per_unit.Size = new System.Drawing.Size(167, 22);
            this.tbSelling_price_per_unit.TabIndex = 9;
            // 
            // tbUnit_number
            // 
            this.tbUnit_number.Location = new System.Drawing.Point(216, 199);
            this.tbUnit_number.Name = "tbUnit_number";
            this.tbUnit_number.Size = new System.Drawing.Size(169, 22);
            this.tbUnit_number.TabIndex = 10;
            // 
            // lbMeasurement
            // 
            this.lbMeasurement.FormattingEnabled = true;
            this.lbMeasurement.ItemHeight = 16;
            this.lbMeasurement.Location = new System.Drawing.Point(216, 269);
            this.lbMeasurement.Name = "lbMeasurement";
            this.lbMeasurement.Size = new System.Drawing.Size(167, 20);
            this.lbMeasurement.TabIndex = 11;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(216, 327);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(169, 30);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // pbIngredient
            // 
            this.pbIngredient.Location = new System.Drawing.Point(483, 66);
            this.pbIngredient.Name = "pbIngredient";
            this.pbIngredient.Size = new System.Drawing.Size(290, 290);
            this.pbIngredient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIngredient.TabIndex = 13;
            this.pbIngredient.TabStop = false;
            // 
            // frmAddNewIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "frmAddNewIngredient";
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSelling_price_per_unit;
        private System.Windows.Forms.TextBox tbUnit_number;
        private System.Windows.Forms.ListBox lbMeasurement;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pbIngredient;
    }
}

