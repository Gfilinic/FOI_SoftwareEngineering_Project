namespace CustomPizza
{
    partial class fmrCustomPizza
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
            this.dgvIngredient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNamePizza = new System.Windows.Forms.Label();
            this.lbSellingPricePerUnitPizza = new System.Windows.Forms.Label();
            this.lbUnitNumberPizza = new System.Windows.Forms.Label();
            this.lbMeasurementPizza = new System.Windows.Forms.Label();
            this.lbMeasurement = new System.Windows.Forms.Label();
            this.lbUnitNumber = new System.Windows.Forms.Label();
            this.lbSellingPricePerUnit = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvIngredientInPizza = new System.Windows.Forms.DataGridView();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.lbNb = new System.Windows.Forms.Label();
            this.pbIngredient = new System.Windows.Forms.PictureBox();
            this.pbIngredientPizza = new System.Windows.Forms.PictureBox();
            this.btnAbort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientInPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredientPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIngredient
            // 
            this.dgvIngredient.AllowUserToAddRows = false;
            this.dgvIngredient.AllowUserToDeleteRows = false;
            this.dgvIngredient.AllowUserToResizeColumns = false;
            this.dgvIngredient.AllowUserToResizeRows = false;
            this.dgvIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredient.Location = new System.Drawing.Point(17, 50);
            this.dgvIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvIngredient.Name = "dgvIngredient";
            this.dgvIngredient.ReadOnly = true;
            this.dgvIngredient.RowHeadersWidth = 51;
            this.dgvIngredient.RowTemplate.Height = 24;
            this.dgvIngredient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIngredient.Size = new System.Drawing.Size(347, 188);
            this.dgvIngredient.TabIndex = 0;
            this.dgvIngredient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIngredient_CellClick);
            this.dgvIngredient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIngredient_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingredients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingredient in your pizza";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1190, 536);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Pizza";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1042, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1042, 413);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selling price per unit :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1042, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unit number :";
            // 
            // lbNamePizza
            // 
            this.lbNamePizza.AutoSize = true;
            this.lbNamePizza.Location = new System.Drawing.Point(1268, 388);
            this.lbNamePizza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNamePizza.Name = "lbNamePizza";
            this.lbNamePizza.Size = new System.Drawing.Size(0, 13);
            this.lbNamePizza.TabIndex = 11;
            // 
            // lbSellingPricePerUnitPizza
            // 
            this.lbSellingPricePerUnitPizza.AutoSize = true;
            this.lbSellingPricePerUnitPizza.Location = new System.Drawing.Point(1268, 413);
            this.lbSellingPricePerUnitPizza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSellingPricePerUnitPizza.Name = "lbSellingPricePerUnitPizza";
            this.lbSellingPricePerUnitPizza.Size = new System.Drawing.Size(0, 13);
            this.lbSellingPricePerUnitPizza.TabIndex = 12;
            // 
            // lbUnitNumberPizza
            // 
            this.lbUnitNumberPizza.AutoSize = true;
            this.lbUnitNumberPizza.Location = new System.Drawing.Point(1268, 435);
            this.lbUnitNumberPizza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUnitNumberPizza.Name = "lbUnitNumberPizza";
            this.lbUnitNumberPizza.Size = new System.Drawing.Size(0, 13);
            this.lbUnitNumberPizza.TabIndex = 13;
            // 
            // lbMeasurementPizza
            // 
            this.lbMeasurementPizza.AutoSize = true;
            this.lbMeasurementPizza.Location = new System.Drawing.Point(1301, 435);
            this.lbMeasurementPizza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMeasurementPizza.Name = "lbMeasurementPizza";
            this.lbMeasurementPizza.Size = new System.Drawing.Size(0, 13);
            this.lbMeasurementPizza.TabIndex = 14;
            // 
            // lbMeasurement
            // 
            this.lbMeasurement.AutoSize = true;
            this.lbMeasurement.Location = new System.Drawing.Point(1303, 179);
            this.lbMeasurement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMeasurement.Name = "lbMeasurement";
            this.lbMeasurement.Size = new System.Drawing.Size(0, 13);
            this.lbMeasurement.TabIndex = 22;
            // 
            // lbUnitNumber
            // 
            this.lbUnitNumber.AutoSize = true;
            this.lbUnitNumber.Location = new System.Drawing.Point(1270, 179);
            this.lbUnitNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUnitNumber.Name = "lbUnitNumber";
            this.lbUnitNumber.Size = new System.Drawing.Size(0, 13);
            this.lbUnitNumber.TabIndex = 21;
            // 
            // lbSellingPricePerUnit
            // 
            this.lbSellingPricePerUnit.AutoSize = true;
            this.lbSellingPricePerUnit.Location = new System.Drawing.Point(1270, 157);
            this.lbSellingPricePerUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSellingPricePerUnit.Name = "lbSellingPricePerUnit";
            this.lbSellingPricePerUnit.Size = new System.Drawing.Size(0, 13);
            this.lbSellingPricePerUnit.TabIndex = 20;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(1270, 132);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 13);
            this.lbName.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1042, 179);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Unit number :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1042, 157);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Selling price per unit :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1042, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Name :";
            // 
            // dgvIngredientInPizza
            // 
            this.dgvIngredientInPizza.AllowUserToAddRows = false;
            this.dgvIngredientInPizza.AllowUserToDeleteRows = false;
            this.dgvIngredientInPizza.AllowUserToResizeColumns = false;
            this.dgvIngredientInPizza.AllowUserToResizeRows = false;
            this.dgvIngredientInPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientInPizza.Location = new System.Drawing.Point(17, 318);
            this.dgvIngredientInPizza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvIngredientInPizza.Name = "dgvIngredientInPizza";
            this.dgvIngredientInPizza.ReadOnly = true;
            this.dgvIngredientInPizza.RowHeadersWidth = 51;
            this.dgvIngredientInPizza.RowTemplate.Height = 24;
            this.dgvIngredientInPizza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIngredientInPizza.Size = new System.Drawing.Size(347, 188);
            this.dgvIngredientInPizza.TabIndex = 23;
            this.dgvIngredientInPizza.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIngredientInPizza_CellClick);
            this.dgvIngredientInPizza.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIngredientInPizza_CellDoubleClick_1);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lbTotalPrice.Location = new System.Drawing.Point(408, 541);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(127, 25);
            this.lbTotalPrice.TabIndex = 24;
            this.lbTotalPrice.Text = "Total price :";
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.Transparent;
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(135, 536);
            this.btnplus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(38, 41);
            this.btnplus.TabIndex = 25;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.Btnplus_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.BackColor = System.Drawing.Color.Transparent;
            this.btnMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoins.Location = new System.Drawing.Point(327, 536);
            this.btnMoins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(38, 41);
            this.btnMoins.TabIndex = 26;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = false;
            this.btnMoins.Click += new System.EventHandler(this.BtnMoins_Click);
            // 
            // lbNb
            // 
            this.lbNb.AutoSize = true;
            this.lbNb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNb.Location = new System.Drawing.Point(184, 548);
            this.lbNb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNb.Name = "lbNb";
            this.lbNb.Size = new System.Drawing.Size(139, 17);
            this.lbNb.TabIndex = 27;
            this.lbNb.Text = "Number of copies : 1";
            // 
            // pbIngredient
            // 
            this.pbIngredient.Location = new System.Drawing.Point(836, 54);
            this.pbIngredient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbIngredient.Name = "pbIngredient";
            this.pbIngredient.Size = new System.Drawing.Size(171, 188);
            this.pbIngredient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIngredient.TabIndex = 15;
            this.pbIngredient.TabStop = false;
            // 
            // pbIngredientPizza
            // 
            this.pbIngredientPizza.Location = new System.Drawing.Point(836, 318);
            this.pbIngredientPizza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbIngredientPizza.Name = "pbIngredientPizza";
            this.pbIngredientPizza.Size = new System.Drawing.Size(171, 188);
            this.pbIngredientPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIngredientPizza.TabIndex = 6;
            this.pbIngredientPizza.TabStop = false;
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.Color.Red;
            this.btnAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbort.Location = new System.Drawing.Point(1006, 536);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(131, 37);
            this.btnAbort.TabIndex = 29;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Click += new System.EventHandler(this.BtnAbort_Click_1);
            // 
            // fmrCustomPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1364, 602);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.lbNb);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.dgvIngredientInPizza);
            this.Controls.Add(this.lbMeasurement);
            this.Controls.Add(this.lbUnitNumber);
            this.Controls.Add(this.lbSellingPricePerUnit);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pbIngredient);
            this.Controls.Add(this.lbMeasurementPizza);
            this.Controls.Add(this.lbUnitNumberPizza);
            this.Controls.Add(this.lbSellingPricePerUnitPizza);
            this.Controls.Add(this.lbNamePizza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbIngredientPizza);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIngredient);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fmrCustomPizza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FmrCustomPizza_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmrCustomPizza_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientInPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredientPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIngredient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbIngredientPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNamePizza;
        private System.Windows.Forms.Label lbSellingPricePerUnitPizza;
        private System.Windows.Forms.Label lbUnitNumberPizza;
        private System.Windows.Forms.Label lbMeasurementPizza;
        private System.Windows.Forms.Label lbMeasurement;
        private System.Windows.Forms.Label lbUnitNumber;
        private System.Windows.Forms.Label lbSellingPricePerUnit;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbIngredient;
        private System.Windows.Forms.DataGridView dgvIngredientInPizza;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Label lbNb;
        private System.Windows.Forms.Button btnAbort;
    }
}

