namespace Custom_pizza
{
    partial class frmAddRemoveWorkers
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
            this.btnChangeToWorker = new System.Windows.Forms.Button();
            this.btnChangeToCustomer = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this._lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeToWorker
            // 
            this.btnChangeToWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeToWorker.Location = new System.Drawing.Point(1116, 26);
            this.btnChangeToWorker.Name = "btnChangeToWorker";
            this.btnChangeToWorker.Size = new System.Drawing.Size(75, 40);
            this.btnChangeToWorker.TabIndex = 1;
            this.btnChangeToWorker.Text = "Change to worker";
            this.btnChangeToWorker.UseVisualStyleBackColor = true;
            this.btnChangeToWorker.Click += new System.EventHandler(this.btnChangeToWorker_Click);
            // 
            // btnChangeToCustomer
            // 
            this.btnChangeToCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeToCustomer.Location = new System.Drawing.Point(1214, 26);
            this.btnChangeToCustomer.Name = "btnChangeToCustomer";
            this.btnChangeToCustomer.Size = new System.Drawing.Size(75, 40);
            this.btnChangeToCustomer.TabIndex = 2;
            this.btnChangeToCustomer.Text = "Change to customer";
            this.btnChangeToCustomer.UseVisualStyleBackColor = true;
            this.btnChangeToCustomer.Click += new System.EventHandler(this.btnChangeToCustomer_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsers.Location = new System.Drawing.Point(0, 77);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1301, 563);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            this.dgvUsers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUsers_DataBindingComplete);
            // 
            // _lblSearch
            // 
            this._lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblSearch.AutoSize = true;
            this._lblSearch.Location = new System.Drawing.Point(609, 53);
            this._lblSearch.Name = "_lblSearch";
            this._lblSearch.Size = new System.Drawing.Size(167, 13);
            this._lblSearch.TabIndex = 3;
            this._lblSearch.Text = "Search by name/username/email:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(797, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.Location = new System.Drawing.Point(993, 43);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmAddRemoveWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 640);
            this.ControlBox = false;
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this._lblSearch);
            this.Controls.Add(this.btnChangeToCustomer);
            this.Controls.Add(this.btnChangeToWorker);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmAddRemoveWorkers";
            this.Load += new System.EventHandler(this.frmAddRemoveWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChangeToWorker;
        private System.Windows.Forms.Button btnChangeToCustomer;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label _lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRestart;
    }
}