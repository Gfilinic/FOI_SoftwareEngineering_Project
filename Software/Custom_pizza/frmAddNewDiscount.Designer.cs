namespace Custom_pizza
{
    partial class frmAddNewDiscount
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblNameDisc = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtp_begins = new System.Windows.Forms.DateTimePicker();
            this.lblDE = new System.Windows.Forms.Label();
            this.lblDB = new System.Windows.Forms.Label();
            this.dtp_ends = new System.Windows.Forms.DateTimePicker();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbDiscount = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 0;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(156, 192);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(319, 162);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // lblNameDisc
            // 
            this.lblNameDisc.AutoSize = true;
            this.lblNameDisc.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDisc.Location = new System.Drawing.Point(27, 53);
            this.lblNameDisc.Name = "lblNameDisc";
            this.lblNameDisc.Size = new System.Drawing.Size(110, 13);
            this.lblNameDisc.TabIndex = 3;
            this.lblNameDisc.Text = "Discount Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDescription.Location = new System.Drawing.Point(27, 238);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // dtp_begins
            // 
            this.dtp_begins.Location = new System.Drawing.Point(156, 99);
            this.dtp_begins.Name = "dtp_begins";
            this.dtp_begins.Size = new System.Drawing.Size(200, 20);
            this.dtp_begins.TabIndex = 5;
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.Location = new System.Drawing.Point(27, 157);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(105, 13);
            this.lblDE.TabIndex = 6;
            this.lblDE.Text = "Discount Ends";
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.Location = new System.Drawing.Point(27, 105);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(121, 13);
            this.lblDB.TabIndex = 7;
            this.lblDB.Text = "Discount Begins ";
            // 
            // dtp_ends
            // 
            this.dtp_ends.Location = new System.Drawing.Point(156, 151);
            this.dtp_ends.Name = "dtp_ends";
            this.dtp_ends.Size = new System.Drawing.Size(200, 20);
            this.dtp_ends.TabIndex = 8;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(594, 232);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(127, 24);
            this.btnUpload.TabIndex = 34;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(457, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Image";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(385, 373);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(156, 373);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(77, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 23);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Add new Discount ";
            // 
            // pbDiscount
            // 
            this.pbDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDiscount.Location = new System.Drawing.Point(561, 21);
            this.pbDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.pbDiscount.Name = "pbDiscount";
            this.pbDiscount.Size = new System.Drawing.Size(188, 207);
            this.pbDiscount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDiscount.TabIndex = 30;
            this.pbDiscount.TabStop = false;
            // 
            // frmAddNewDiscount
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(775, 416);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbDiscount);
            this.Controls.Add(this.dtp_ends);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.lblDE);
            this.Controls.Add(this.dtp_begins);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNameDisc);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmAddNewDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddNewDiscount_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblNameDisc;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtp_begins;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.DateTimePicker dtp_ends;
        private System.Windows.Forms.PictureBox pbDiscount;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
    }
}