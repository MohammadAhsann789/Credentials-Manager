namespace CredentialsManager.Controls
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Background_Panel = new System.Windows.Forms.Panel();
            this.TitleLogo_Label = new System.Windows.Forms.Label();
            this.CrdentialsManagerLogo_Picturebox = new System.Windows.Forms.PictureBox();
            this.Password_Panel = new System.Windows.Forms.Panel();
            this.LoginID_Panel = new System.Windows.Forms.Panel();
            this.PasswordLogo_Picturebox = new System.Windows.Forms.PictureBox();
            this.LoginIdLogo_Picturebox = new System.Windows.Forms.PictureBox();
            this.MasterKey_Textbox = new System.Windows.Forms.TextBox();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.LoginID_Textbox = new System.Windows.Forms.TextBox();
            this.Background_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrdentialsManagerLogo_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLogo_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginIdLogo_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Background_Panel
            // 
            this.Background_Panel.BackColor = System.Drawing.Color.White;
            this.Background_Panel.Controls.Add(this.TitleLogo_Label);
            this.Background_Panel.Controls.Add(this.CrdentialsManagerLogo_Picturebox);
            this.Background_Panel.Controls.Add(this.Password_Panel);
            this.Background_Panel.Controls.Add(this.LoginID_Panel);
            this.Background_Panel.Controls.Add(this.PasswordLogo_Picturebox);
            this.Background_Panel.Controls.Add(this.LoginIdLogo_Picturebox);
            this.Background_Panel.Controls.Add(this.MasterKey_Textbox);
            this.Background_Panel.Controls.Add(this.Login_Btn);
            this.Background_Panel.Controls.Add(this.LoginID_Textbox);
            this.Background_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background_Panel.Location = new System.Drawing.Point(0, 0);
            this.Background_Panel.Name = "Background_Panel";
            this.Background_Panel.Size = new System.Drawing.Size(494, 778);
            this.Background_Panel.TabIndex = 0;
            // 
            // TitleLogo_Label
            // 
            this.TitleLogo_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLogo_Label.AutoSize = true;
            this.TitleLogo_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLogo_Label.Location = new System.Drawing.Point(202, 214);
            this.TitleLogo_Label.Name = "TitleLogo_Label";
            this.TitleLogo_Label.Size = new System.Drawing.Size(92, 35);
            this.TitleLogo_Label.TabIndex = 13;
            this.TitleLogo_Label.Text = "LOGIN";
            // 
            // CrdentialsManagerLogo_Picturebox
            // 
            this.CrdentialsManagerLogo_Picturebox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CrdentialsManagerLogo_Picturebox.Image = global::CredentialsManager.Properties.Resources.CredentialsManager_Logo;
            this.CrdentialsManagerLogo_Picturebox.Location = new System.Drawing.Point(139, 3);
            this.CrdentialsManagerLogo_Picturebox.Name = "CrdentialsManagerLogo_Picturebox";
            this.CrdentialsManagerLogo_Picturebox.Size = new System.Drawing.Size(211, 211);
            this.CrdentialsManagerLogo_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CrdentialsManagerLogo_Picturebox.TabIndex = 11;
            this.CrdentialsManagerLogo_Picturebox.TabStop = false;
            // 
            // Password_Panel
            // 
            this.Password_Panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Password_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Password_Panel.Location = new System.Drawing.Point(23, 471);
            this.Password_Panel.Name = "Password_Panel";
            this.Password_Panel.Size = new System.Drawing.Size(443, 2);
            this.Password_Panel.TabIndex = 10;
            // 
            // LoginID_Panel
            // 
            this.LoginID_Panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginID_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoginID_Panel.Location = new System.Drawing.Point(23, 363);
            this.LoginID_Panel.Name = "LoginID_Panel";
            this.LoginID_Panel.Size = new System.Drawing.Size(443, 2);
            this.LoginID_Panel.TabIndex = 7;
            // 
            // PasswordLogo_Picturebox
            // 
            this.PasswordLogo_Picturebox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordLogo_Picturebox.Image = global::CredentialsManager.Properties.Resources.password_Login_35px;
            this.PasswordLogo_Picturebox.Location = new System.Drawing.Point(23, 428);
            this.PasswordLogo_Picturebox.Name = "PasswordLogo_Picturebox";
            this.PasswordLogo_Picturebox.Size = new System.Drawing.Size(36, 36);
            this.PasswordLogo_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordLogo_Picturebox.TabIndex = 9;
            this.PasswordLogo_Picturebox.TabStop = false;
            // 
            // LoginIdLogo_Picturebox
            // 
            this.LoginIdLogo_Picturebox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginIdLogo_Picturebox.Image = global::CredentialsManager.Properties.Resources.mail_account_35px;
            this.LoginIdLogo_Picturebox.Location = new System.Drawing.Point(23, 320);
            this.LoginIdLogo_Picturebox.Name = "LoginIdLogo_Picturebox";
            this.LoginIdLogo_Picturebox.Size = new System.Drawing.Size(36, 36);
            this.LoginIdLogo_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginIdLogo_Picturebox.TabIndex = 6;
            this.LoginIdLogo_Picturebox.TabStop = false;
            // 
            // MasterKey_Textbox
            // 
            this.MasterKey_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MasterKey_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MasterKey_Textbox.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.MasterKey_Textbox.Location = new System.Drawing.Point(65, 431);
            this.MasterKey_Textbox.Name = "MasterKey_Textbox";
            this.MasterKey_Textbox.Size = new System.Drawing.Size(399, 30);
            this.MasterKey_Textbox.TabIndex = 2;
            this.MasterKey_Textbox.UseSystemPasswordChar = true;
            // 
            // Login_Btn
            // 
            this.Login_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Btn.FlatAppearance.BorderSize = 0;
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Login_Btn.ForeColor = System.Drawing.Color.White;
            this.Login_Btn.Image = global::CredentialsManager.Properties.Resources.lock_Highlighted_35px;
            this.Login_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_Btn.Location = new System.Drawing.Point(17, 577);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Padding = new System.Windows.Forms.Padding(160, 0, 0, 0);
            this.Login_Btn.Size = new System.Drawing.Size(447, 55);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // LoginID_Textbox
            // 
            this.LoginID_Textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginID_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginID_Textbox.Font = new System.Drawing.Font("Segoe UI", 13.2F);
            this.LoginID_Textbox.Location = new System.Drawing.Point(65, 323);
            this.LoginID_Textbox.Name = "LoginID_Textbox";
            this.LoginID_Textbox.Size = new System.Drawing.Size(399, 30);
            this.LoginID_Textbox.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Background_Panel);
            this.MinimumSize = new System.Drawing.Size(494, 692);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(494, 778);
            this.Background_Panel.ResumeLayout(false);
            this.Background_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrdentialsManagerLogo_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLogo_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginIdLogo_Picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background_Panel;
        private System.Windows.Forms.TextBox LoginID_Textbox;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.PictureBox LoginIdLogo_Picturebox;
        private System.Windows.Forms.Panel LoginID_Panel;
        private System.Windows.Forms.Panel Password_Panel;
        private System.Windows.Forms.PictureBox PasswordLogo_Picturebox;
        private System.Windows.Forms.TextBox MasterKey_Textbox;
        private System.Windows.Forms.PictureBox CrdentialsManagerLogo_Picturebox;
        private System.Windows.Forms.Label TitleLogo_Label;
    }
}
