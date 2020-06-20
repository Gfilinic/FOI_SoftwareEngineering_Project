namespace frmAddIngredient
{
    partial class frmModIngredient
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
            // pbIngredient
            // 
            this.pbIngredient.Location = new System.Drawing.Point(485, 72);
            this.pbIngredient.Name = "pbIngredient";
            this.pbIngredient.Size = new System.Drawing.Size(290, 290);
            this.pbIngredient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIngredient.TabIndex = 27;
            this.pbIngredient.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(218, 333);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(169, 30);
            this.btnUpload.TabIndex = 26;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click_1);
            // 
            // lbMeasurement
            // 
            this.lbMeasurement.FormattingEnabled = true;
            this.lbMeasurement.ItemHeight = 16;
            this.lbMeasurement.Location = new System.Drawing.Point(218, 267);
            this.lbMeasurement.Name = "lbMeasurement";
            this.lbMeasurement.Size = new System.Drawing.Size(169, 20);
            this.lbMeasurement.TabIndex = 25;
            // 
            // tbUnit_number
            // 
            this.tbUnit_number.Location = new System.Drawing.Point(218, 205);
            this.tbUnit_number.Name = "tbUnit_number";
            this.tbUnit_number.Size = new System.Drawing.Size(169, 22);
            this.tbUnit_number.TabIndex = 24;
            // 
            // tbSelling_price_per_unit
            // 
            this.tbSelling_price_per_unit.Location = new System.Drawing.Point(218, 138);
            this.tbSelling_price_per_unit.Name = "tbSelling_price_per_unit";
            this.tbSelling_price_per_unit.Size = new System.Drawing.Size(167, 22);
            this.tbSelling_price_per_unit.TabIndex = 23;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(218, 72);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(168, 22);
            this.tbName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Measurement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Unit number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Selling price per unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Modify an ingredient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(670, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(530, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 31);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // frmModIngredient
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
            this.Name = "frmModIngredient";
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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