namespace Custom_pizza
{
    partial class frmModDiscount
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNameDisc = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.dtp_begins = new System.Windows.Forms.DateTimePicker();
            this.dtp_ends = new System.Windows.Forms.DateTimePicker();
            this.lblDE = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbDiscount = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(121, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 23);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Modify Selected Discount";
            // 
            // lblNameDisc
            // 
            this.lblNameDisc.AutoSize = true;
            this.lblNameDisc.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDisc.Location = new System.Drawing.Point(12, 59);
            this.lblNameDisc.Name = "lblNameDisc";
            this.lblNameDisc.Size = new System.Drawing.Size(110, 13);
            this.lblNameDisc.TabIndex = 38;
            this.lblNameDisc.Text = "Discount Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 37;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.Location = new System.Drawing.Point(12, 109);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(121, 13);
            this.lblDB.TabIndex = 40;
            this.lblDB.Text = "Discount Begins ";
            // 
            // dtp_begins
            // 
            this.dtp_begins.Location = new System.Drawing.Point(141, 103);
            this.dtp_begins.Name = "dtp_begins";
            this.dtp_begins.Size = new System.Drawing.Size(200, 20);
            this.dtp_begins.TabIndex = 39;
            // 
            // dtp_ends
            // 
            this.dtp_ends.Location = new System.Drawing.Point(141, 147);
            this.dtp_ends.Name = "dtp_ends";
            this.dtp_ends.Size = new System.Drawing.Size(200, 20);
            this.dtp_ends.TabIndex = 42;
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.Location = new System.Drawing.Point(12, 153);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(105, 13);
            this.lblDE.TabIndex = 41;
            this.lblDE.Text = "Discount Ends";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDescription.Location = new System.Drawing.Point(12, 242);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 13);
            this.lblDescription.TabIndex = 44;
            this.lblDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(141, 196);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(319, 162);
            this.rtbDescription.TabIndex = 43;
            this.rtbDescription.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(370, 363);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 363);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(559, 259);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(127, 24);
            this.btnUpload.TabIndex = 49;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(422, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Image";
            // 
            // pbDiscount
            // 
            this.pbDiscount.Location = new System.Drawing.Point(526, 48);
            this.pbDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.pbDiscount.Name = "pbDiscount";
            this.pbDiscount.Size = new System.Drawing.Size(188, 207);
            this.pbDiscount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDiscount.TabIndex = 47;
            this.pbDiscount.TabStop = false;
            // 
            // frmModDiscount
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbDiscount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.dtp_ends);
            this.Controls.Add(this.lblDE);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.dtp_begins);
            this.Controls.Add(this.lblNameDisc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModDiscount";
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNameDisc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.DateTimePicker dtp_begins;
        private System.Windows.Forms.DateTimePicker dtp_ends;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbDiscount;
    }
}