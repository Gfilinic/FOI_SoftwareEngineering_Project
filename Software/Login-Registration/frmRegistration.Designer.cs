﻿namespace Login_Registration
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this._picLogo = new System.Windows.Forms.PictureBox();
            this.pnlLoginMenu = new System.Windows.Forms.Panel();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lblUserImage = new System.Windows.Forms.Label();
            this.picUserImage = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this._lblWelcome = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnResetImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._picLogo)).BeginInit();
            this.pnlLoginMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserImage)).BeginInit();
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
            this._picLogo.Size = new System.Drawing.Size(648, 105);
            this._picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picLogo.TabIndex = 5;
            this._picLogo.TabStop = false;
            // 
            // pnlLoginMenu
            // 
            this.pnlLoginMenu.BackColor = System.Drawing.Color.IndianRed;
            this.pnlLoginMenu.Controls.Add(this.btnResetImage);
            this.pnlLoginMenu.Controls.Add(this.txtRepeatPassword);
            this.pnlLoginMenu.Controls.Add(this.lblRepeatPassword);
            this.pnlLoginMenu.Controls.Add(this.btnGoBack);
            this.pnlLoginMenu.Controls.Add(this.label3);
            this.pnlLoginMenu.Controls.Add(this.txtAddress);
            this.pnlLoginMenu.Controls.Add(this.txtCity);
            this.pnlLoginMenu.Controls.Add(this.lblAddress);
            this.pnlLoginMenu.Controls.Add(this.txtSurname);
            this.pnlLoginMenu.Controls.Add(this.lblSurname);
            this.pnlLoginMenu.Controls.Add(this.txtZipcode);
            this.pnlLoginMenu.Controls.Add(this.lblZipcode);
            this.pnlLoginMenu.Controls.Add(this.lblName);
            this.pnlLoginMenu.Controls.Add(this.txtName);
            this.pnlLoginMenu.Controls.Add(this.btnAddImage);
            this.pnlLoginMenu.Controls.Add(this.lblUserImage);
            this.pnlLoginMenu.Controls.Add(this.picUserImage);
            this.pnlLoginMenu.Controls.Add(this.txtEmail);
            this.pnlLoginMenu.Controls.Add(this.lblEmail);
            this.pnlLoginMenu.Controls.Add(this.btnRegister);
            this.pnlLoginMenu.Controls.Add(this.txtPassword);
            this.pnlLoginMenu.Controls.Add(this.lblPassword);
            this.pnlLoginMenu.Controls.Add(this.lblUsername);
            this.pnlLoginMenu.Controls.Add(this._lblWelcome);
            this.pnlLoginMenu.Controls.Add(this.txtUsername);
            this.pnlLoginMenu.Location = new System.Drawing.Point(12, 121);
            this.pnlLoginMenu.Name = "pnlLoginMenu";
            this.pnlLoginMenu.Size = new System.Drawing.Size(624, 458);
            this.pnlLoginMenu.TabIndex = 0;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(128, 201);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(177, 20);
            this.txtRepeatPassword.TabIndex = 3;
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRepeatPassword.Location = new System.Drawing.Point(8, 204);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(114, 13);
            this.lblRepeatPassword.TabIndex = 27;
            this.lblRepeatPassword.Text = "Repeat password*:";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(384, 382);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(100, 40);
            this.btnGoBack.TabIndex = 11;
            this.btnGoBack.Text = "Go back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(152, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "City:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(128, 367);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(177, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(190, 322);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(115, 20);
            this.txtCity.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAddress.Location = new System.Drawing.Point(8, 367);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 13);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Address:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(128, 284);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(177, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSurname.Location = new System.Drawing.Point(8, 287);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 13);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Surname*:";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(71, 322);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(60, 20);
            this.txtZipcode.TabIndex = 6;
            this.txtZipcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipcode_KeyPress);
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblZipcode.Location = new System.Drawing.Point(8, 325);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(57, 13);
            this.lblZipcode.TabIndex = 17;
            this.lblZipcode.Text = "Zipcode:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblName.Location = new System.Drawing.Point(8, 247);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name*:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 244);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(509, 308);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(100, 30);
            this.btnAddImage.TabIndex = 10;
            this.btnAddImage.Text = "Add image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lblUserImage
            // 
            this.lblUserImage.AutoSize = true;
            this.lblUserImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUserImage.Location = new System.Drawing.Point(463, 51);
            this.lblUserImage.Name = "lblUserImage";
            this.lblUserImage.Size = new System.Drawing.Size(74, 13);
            this.lblUserImage.TabIndex = 13;
            this.lblUserImage.Text = "User image:";
            // 
            // picUserImage
            // 
            this.picUserImage.BackColor = System.Drawing.Color.Gray;
            this.picUserImage.Location = new System.Drawing.Point(384, 78);
            this.picUserImage.Name = "picUserImage";
            this.picUserImage.Size = new System.Drawing.Size(225, 225);
            this.picUserImage.TabIndex = 12;
            this.picUserImage.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEmail.Location = new System.Drawing.Point(8, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email*:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(509, 382);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 40);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPassword.Location = new System.Drawing.Point(8, 162);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password*:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUsername.Location = new System.Drawing.Point(8, 78);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(72, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username*:";
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
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(128, 75);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(177, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // btnResetImage
            // 
            this.btnResetImage.Location = new System.Drawing.Point(384, 308);
            this.btnResetImage.Name = "btnResetImage";
            this.btnResetImage.Size = new System.Drawing.Size(100, 30);
            this.btnResetImage.TabIndex = 9;
            this.btnResetImage.Text = "Reset to default";
            this.btnResetImage.UseVisualStyleBackColor = true;
            this.btnResetImage.Click += new System.EventHandler(this.btnResetImage_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(648, 591);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLoginMenu);
            this.Controls.Add(this._picLogo);
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this._picLogo)).EndInit();
            this.pnlLoginMenu.ResumeLayout(false);
            this.pnlLoginMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _picLogo;
        private System.Windows.Forms.Panel pnlLoginMenu;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label _lblWelcome;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picUserImage;
        private System.Windows.Forms.Label lblUserImage;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Button btnResetImage;
    }
}