namespace Custom_pizza
{
    partial class frmWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorker));
            this._pnlBackgroundUp = new System.Windows.Forms.Panel();
            this._pnlBackGroundLeft = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlShutDown = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this._picLogo = new System.Windows.Forms.PictureBox();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.btnInstagram = new System.Windows.Forms.Button();
            this.btnTwitter = new System.Windows.Forms.Button();
            this._pnlBackGroundLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.pnlShutDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnlBackgroundUp
            // 
            this._pnlBackgroundUp.BackColor = System.Drawing.Color.Firebrick;
            this._pnlBackgroundUp.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlBackgroundUp.Location = new System.Drawing.Point(0, 0);
            this._pnlBackgroundUp.Name = "_pnlBackgroundUp";
            this._pnlBackgroundUp.Size = new System.Drawing.Size(1523, 50);
            this._pnlBackgroundUp.TabIndex = 2;
            // 
            // _pnlBackGroundLeft
            // 
            this._pnlBackGroundLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._pnlBackGroundLeft.Controls.Add(this.picUser);
            this._pnlBackGroundLeft.Controls.Add(this.btnAbout);
            this._pnlBackGroundLeft.Controls.Add(this.btnBills);
            this._pnlBackGroundLeft.Controls.Add(this.btnHome);
            this._pnlBackGroundLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlBackGroundLeft.Location = new System.Drawing.Point(0, 50);
            this._pnlBackGroundLeft.Name = "_pnlBackGroundLeft";
            this._pnlBackGroundLeft.Size = new System.Drawing.Size(202, 771);
            this._pnlBackGroundLeft.TabIndex = 6;
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(12, 3);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(168, 154);
            this.picUser.TabIndex = 12;
            this.picUser.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(40, 304);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(140, 40);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "  About";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnBills
            // 
            this.btnBills.FlatAppearance.BorderSize = 0;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Image = ((System.Drawing.Image)(resources.GetObject("btnBills.Image")));
            this.btnBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.Location = new System.Drawing.Point(40, 258);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(140, 40);
            this.btnBills.TabIndex = 6;
            this.btnBills.Text = "  Bills";
            this.btnBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBills.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.AllowDrop = true;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(40, 202);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 33);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "  Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // pnlShutDown
            // 
            this.pnlShutDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShutDown.Controls.Add(this.btnExit);
            this.pnlShutDown.Controls.Add(this.btnHelp);
            this.pnlShutDown.Controls.Add(this.btnNotification);
            this.pnlShutDown.Controls.Add(this.btnLogOut);
            this.pnlShutDown.Controls.Add(this.btnShutDown);
            this.pnlShutDown.Controls.Add(this.btnSettings);
            this.pnlShutDown.Location = new System.Drawing.Point(1369, 53);
            this.pnlShutDown.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.pnlShutDown.Name = "pnlShutDown";
            this.pnlShutDown.Size = new System.Drawing.Size(154, 33);
            this.pnlShutDown.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(71, 61);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gray;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(3, 1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(29, 29);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnNotification
            // 
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.White;
            this.btnNotification.Image = ((System.Drawing.Image)(resources.GetObject("btnNotification.Image")));
            this.btnNotification.Location = new System.Drawing.Point(38, 1);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(29, 29);
            this.btnNotification.TabIndex = 8;
            this.btnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotification.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(71, 33);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 28);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnShutDown
            // 
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.ForeColor = System.Drawing.Color.White;
            this.btnShutDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutDown.Image")));
            this.btnShutDown.Location = new System.Drawing.Point(113, 1);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(29, 29);
            this.btnShutDown.TabIndex = 4;
            this.btnShutDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(73, 1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(29, 29);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // _picLogo
            // 
            this._picLogo.BackColor = System.Drawing.Color.Firebrick;
            this._picLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("_picLogo.ErrorImage")));
            this._picLogo.Image = ((System.Drawing.Image)(resources.GetObject("_picLogo.Image")));
            this._picLogo.Location = new System.Drawing.Point(337, 3);
            this._picLogo.Name = "_picLogo";
            this._picLogo.Size = new System.Drawing.Size(110, 175);
            this._picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picLogo.TabIndex = 16;
            this._picLogo.TabStop = false;
            // 
            // btnFacebook
            // 
            this.btnFacebook.FlatAppearance.BorderSize = 0;
            this.btnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacebook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacebook.ForeColor = System.Drawing.Color.White;
            this.btnFacebook.Image = ((System.Drawing.Image)(resources.GetObject("btnFacebook.Image")));
            this.btnFacebook.Location = new System.Drawing.Point(453, 56);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(28, 30);
            this.btnFacebook.TabIndex = 17;
            this.btnFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacebook.UseVisualStyleBackColor = true;
            // 
            // btnInstagram
            // 
            this.btnInstagram.FlatAppearance.BorderSize = 0;
            this.btnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstagram.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstagram.ForeColor = System.Drawing.Color.White;
            this.btnInstagram.Image = ((System.Drawing.Image)(resources.GetObject("btnInstagram.Image")));
            this.btnInstagram.Location = new System.Drawing.Point(521, 56);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(28, 30);
            this.btnInstagram.TabIndex = 19;
            this.btnInstagram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstagram.UseVisualStyleBackColor = true;
            // 
            // btnTwitter
            // 
            this.btnTwitter.FlatAppearance.BorderSize = 0;
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwitter.ForeColor = System.Drawing.Color.White;
            this.btnTwitter.Image = ((System.Drawing.Image)(resources.GetObject("btnTwitter.Image")));
            this.btnTwitter.Location = new System.Drawing.Point(487, 56);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(28, 30);
            this.btnTwitter.TabIndex = 18;
            this.btnTwitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTwitter.UseVisualStyleBackColor = true;
            // 
            // frmWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1523, 821);
            this.ControlBox = false;
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.btnInstagram);
            this.Controls.Add(this.btnTwitter);
            this.Controls.Add(this._picLogo);
            this.Controls.Add(this.pnlShutDown);
            this.Controls.Add(this._pnlBackGroundLeft);
            this.Controls.Add(this._pnlBackgroundUp);
            this.Name = "frmWorker";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._pnlBackGroundLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.pnlShutDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlBackgroundUp;
        private System.Windows.Forms.Panel _pnlBackGroundLeft;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlShutDown;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox _picLogo;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Button btnInstagram;
        private System.Windows.Forms.Button btnTwitter;
    }
}