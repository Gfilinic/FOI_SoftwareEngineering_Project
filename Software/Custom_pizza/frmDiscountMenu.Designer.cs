namespace Custom_pizza
{
    partial class frmDiscountMenu
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
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddDiscount.Location = new System.Drawing.Point(28, 35);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(164, 89);
            this.btnAddDiscount.TabIndex = 0;
            this.btnAddDiscount.Text = "Add Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AllowUserToAddRows = false;
            this.dgvDiscount.AllowUserToDeleteRows = false;
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Location = new System.Drawing.Point(348, 51);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            this.dgvDiscount.Size = new System.Drawing.Size(413, 338);
            this.dgvDiscount.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = global::Custom_pizza.Properties.Resources.refresh1;
            this.btnRefresh.Location = new System.Drawing.Point(222, 35);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 89);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(28, 158);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(276, 71);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "Modify Selected Discount";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(28, 246);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(276, 81);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Selected Discount";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDiscountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvDiscount);
            this.Controls.Add(this.btnAddDiscount);
            this.Name = "frmDiscountMenu";
            this.Text = "Discount";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
    }
}