namespace Custom_pizza
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this._picLogo = new System.Windows.Forms.PictureBox();
            this.pnlLoginMenu = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this._lblWelcome = new System.Windows.Forms.Label();
            this.txtUserNameEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._picLogo)).BeginInit();
            this.pnlLoginMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _picLogo
            // 
            this._picLogo.BackColor = System.Drawing.Color.Firebrick;
            this._picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this._picLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("_picLogo.ErrorImage")));
            this._picLogo.Image = ((System.Drawing.Image)(resources.GetObject("_picLogo.Image")));
            this._picLogo.Location = new System.Drawing.Point(0, 0);
            this._picLogo.Name = "_picLogo";
            this._picLogo.Size = new System.Drawing.Size(437, 125);
            this._picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picLogo.TabIndex = 4;
            this._picLogo.TabStop = false;
            // 
            // pnlLoginMenu
            // 
            this.pnlLoginMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLoginMenu.BackColor = System.Drawing.Color.IndianRed;
            this.pnlLoginMenu.Controls.Add(this.btnShutDown);
            this.pnlLoginMenu.Controls.Add(this.btnRegister);
            this.pnlLoginMenu.Controls.Add(this.label1);
            this.pnlLoginMenu.Controls.Add(this.txtPassword);
            this.pnlLoginMenu.Controls.Add(this.lblPassword);
            this.pnlLoginMenu.Controls.Add(this.lblUsername);
            this.pnlLoginMenu.Controls.Add(this.btnLogin);
            this.pnlLoginMenu.Controls.Add(this._lblWelcome);
            this.pnlLoginMenu.Controls.Add(this.txtUserNameEmail);
            this.pnlLoginMenu.Location = new System.Drawing.Point(12, 131);
            this.pnlLoginMenu.Name = "pnlLoginMenu";
            this.pnlLoginMenu.Size = new System.Drawing.Size(413, 307);
            this.pnlLoginMenu.TabIndex = 0;
            // 
            // btnShutDown
            // 
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.ForeColor = System.Drawing.Color.White;
            this.btnShutDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutDown.Image")));
            this.btnShutDown.Location = new System.Drawing.Point(183, 261);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(29, 29);
            this.btnShutDown.TabIndex = 4;
            this.btnShutDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(323, 206);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Don\'t have an account? Then register on the next button:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPassword.Location = new System.Drawing.Point(8, 119);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUsername.Location = new System.Drawing.Point(8, 78);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username/email:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(323, 116);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // _lblWelcome
            // 
            this._lblWelcome.AutoSize = true;
            this._lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._lblWelcome.Location = new System.Drawing.Point(7, 19);
            this._lblWelcome.Name = "_lblWelcome";
            this._lblWelcome.Size = new System.Drawing.Size(331, 20);
            this._lblWelcome.TabIndex = 1;
            this._lblWelcome.Text = "Welcome to our site. Please login below:";
            // 
            // txtUserNameEmail
            // 
            this.txtUserNameEmail.Location = new System.Drawing.Point(113, 75);
            this.txtUserNameEmail.Name = "txtUserNameEmail";
            this.txtUserNameEmail.Size = new System.Drawing.Size(161, 20);
            this.txtUserNameEmail.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLoginMenu);
            this.Controls.Add(this._picLogo);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this._picLogo)).EndInit();
            this.pnlLoginMenu.ResumeLayout(false);
            this.pnlLoginMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _picLogo;
        private System.Windows.Forms.Panel pnlLoginMenu;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label _lblWelcome;
        private System.Windows.Forms.TextBox txtUserNameEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnShutDown;
    }
}

