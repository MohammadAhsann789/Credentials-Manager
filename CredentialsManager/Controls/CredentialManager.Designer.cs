namespace CredentialsManager.Controls
{
    partial class CredentialManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CredentialManager));
            this.Background_Panel = new System.Windows.Forms.Panel();
            this.Content_Panel = new System.Windows.Forms.Panel();
            this.ActiveBtnLogo_Panel = new System.Windows.Forms.Panel();
            this.LogoImage_Picturebox = new System.Windows.Forms.PictureBox();
            this.HorizontalLine_Label = new System.Windows.Forms.Label();
            this.Category_Title_Label = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.Users_Btn = new System.Windows.Forms.Button();
            this.Categories_Btn = new System.Windows.Forms.Button();
            this.Credentials_Btn = new System.Windows.Forms.Button();
            this.Mails_Btn = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.CrdentialsManagerLogo_Picturebox = new System.Windows.Forms.PictureBox();
            this.Background_Panel.SuspendLayout();
            this.ActiveBtnLogo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage_Picturebox)).BeginInit();
            this.SidePanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrdentialsManagerLogo_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Background_Panel
            // 
            this.Background_Panel.Controls.Add(this.Content_Panel);
            this.Background_Panel.Controls.Add(this.ActiveBtnLogo_Panel);
            this.Background_Panel.Controls.Add(this.SidePanel);
            this.Background_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background_Panel.Location = new System.Drawing.Point(0, 0);
            this.Background_Panel.Name = "Background_Panel";
            this.Background_Panel.Size = new System.Drawing.Size(1045, 785);
            this.Background_Panel.TabIndex = 1;
            // 
            // Content_Panel
            // 
            this.Content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_Panel.Location = new System.Drawing.Point(331, 116);
            this.Content_Panel.Name = "Content_Panel";
            this.Content_Panel.Size = new System.Drawing.Size(714, 669);
            this.Content_Panel.TabIndex = 3;
            // 
            // ActiveBtnLogo_Panel
            // 
            this.ActiveBtnLogo_Panel.Controls.Add(this.LogoImage_Picturebox);
            this.ActiveBtnLogo_Panel.Controls.Add(this.HorizontalLine_Label);
            this.ActiveBtnLogo_Panel.Controls.Add(this.Category_Title_Label);
            this.ActiveBtnLogo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActiveBtnLogo_Panel.Location = new System.Drawing.Point(331, 0);
            this.ActiveBtnLogo_Panel.Name = "ActiveBtnLogo_Panel";
            this.ActiveBtnLogo_Panel.Size = new System.Drawing.Size(714, 116);
            this.ActiveBtnLogo_Panel.TabIndex = 1;
            // 
            // LogoImage_Picturebox
            // 
            this.LogoImage_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("LogoImage_Picturebox.Image")));
            this.LogoImage_Picturebox.Location = new System.Drawing.Point(26, 40);
            this.LogoImage_Picturebox.Name = "LogoImage_Picturebox";
            this.LogoImage_Picturebox.Size = new System.Drawing.Size(50, 50);
            this.LogoImage_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImage_Picturebox.TabIndex = 3;
            this.LogoImage_Picturebox.TabStop = false;
            // 
            // HorizontalLine_Label
            // 
            this.HorizontalLine_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.HorizontalLine_Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HorizontalLine_Label.ForeColor = System.Drawing.Color.White;
            this.HorizontalLine_Label.Location = new System.Drawing.Point(0, 115);
            this.HorizontalLine_Label.Name = "HorizontalLine_Label";
            this.HorizontalLine_Label.Size = new System.Drawing.Size(714, 1);
            this.HorizontalLine_Label.TabIndex = 0;
            // 
            // Category_Title_Label
            // 
            this.Category_Title_Label.AutoSize = true;
            this.Category_Title_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Title_Label.ForeColor = System.Drawing.Color.Black;
            this.Category_Title_Label.Location = new System.Drawing.Point(80, 47);
            this.Category_Title_Label.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.Category_Title_Label.Name = "Category_Title_Label";
            this.Category_Title_Label.Size = new System.Drawing.Size(235, 35);
            this.Category_Title_Label.TabIndex = 2;
            this.Category_Title_Label.Text = "Active Button Logo";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SidePanel.Controls.Add(this.ButtonsPanel);
            this.SidePanel.Controls.Add(this.TitlePanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(331, 785);
            this.SidePanel.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.AutoScroll = true;
            this.ButtonsPanel.AutoSize = true;
            this.ButtonsPanel.Controls.Add(this.Users_Btn);
            this.ButtonsPanel.Controls.Add(this.Categories_Btn);
            this.ButtonsPanel.Controls.Add(this.Credentials_Btn);
            this.ButtonsPanel.Controls.Add(this.Mails_Btn);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 228);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(331, 557);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // Users_Btn
            // 
            this.Users_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Users_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Users_Btn.FlatAppearance.BorderSize = 0;
            this.Users_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users_Btn.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Users_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.Users_Btn.Image = global::CredentialsManager.Properties.Resources.Users_UnHighlighted_35px;
            this.Users_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Users_Btn.Location = new System.Drawing.Point(0, 186);
            this.Users_Btn.Name = "Users_Btn";
            this.Users_Btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Users_Btn.Size = new System.Drawing.Size(331, 62);
            this.Users_Btn.TabIndex = 5;
            this.Users_Btn.Text = " Users";
            this.Users_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Users_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Users_Btn.UseVisualStyleBackColor = true;
            this.Users_Btn.Click += new System.EventHandler(this.Users_Btn_Click);
            // 
            // Categories_Btn
            // 
            this.Categories_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Categories_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Categories_Btn.FlatAppearance.BorderSize = 0;
            this.Categories_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categories_Btn.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Categories_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.Categories_Btn.Image = global::CredentialsManager.Properties.Resources.categorize_UnHighlighted_35px;
            this.Categories_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Categories_Btn.Location = new System.Drawing.Point(0, 124);
            this.Categories_Btn.Name = "Categories_Btn";
            this.Categories_Btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Categories_Btn.Size = new System.Drawing.Size(331, 62);
            this.Categories_Btn.TabIndex = 4;
            this.Categories_Btn.Text = " Categories";
            this.Categories_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Categories_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Categories_Btn.UseVisualStyleBackColor = true;
            this.Categories_Btn.Click += new System.EventHandler(this.Categories_Btn_Click);
            // 
            // Credentials_Btn
            // 
            this.Credentials_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Credentials_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Credentials_Btn.FlatAppearance.BorderSize = 0;
            this.Credentials_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Credentials_Btn.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Credentials_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.Credentials_Btn.Image = global::CredentialsManager.Properties.Resources.Card_Security_UnHighlighted_35px;
            this.Credentials_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Credentials_Btn.Location = new System.Drawing.Point(0, 62);
            this.Credentials_Btn.Name = "Credentials_Btn";
            this.Credentials_Btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Credentials_Btn.Size = new System.Drawing.Size(331, 62);
            this.Credentials_Btn.TabIndex = 3;
            this.Credentials_Btn.Text = " Credentials";
            this.Credentials_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Credentials_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Credentials_Btn.UseVisualStyleBackColor = true;
            this.Credentials_Btn.Click += new System.EventHandler(this.Credentials_Btn_Click);
            // 
            // Mails_Btn
            // 
            this.Mails_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mails_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Mails_Btn.FlatAppearance.BorderSize = 0;
            this.Mails_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mails_Btn.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Mails_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.Mails_Btn.Image = global::CredentialsManager.Properties.Resources.mail_account_UnHighlighted_35px;
            this.Mails_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mails_Btn.Location = new System.Drawing.Point(0, 0);
            this.Mails_Btn.Name = "Mails_Btn";
            this.Mails_Btn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Mails_Btn.Size = new System.Drawing.Size(331, 62);
            this.Mails_Btn.TabIndex = 2;
            this.Mails_Btn.Text = " Mails";
            this.Mails_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mails_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Mails_Btn.UseVisualStyleBackColor = true;
            this.Mails_Btn.Click += new System.EventHandler(this.Mails_Btn_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.CrdentialsManagerLogo_Picturebox);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(331, 228);
            this.TitlePanel.TabIndex = 0;
            // 
            // CrdentialsManagerLogo_Picturebox
            // 
            this.CrdentialsManagerLogo_Picturebox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CrdentialsManagerLogo_Picturebox.Image = global::CredentialsManager.Properties.Resources.CredentialsManager_Logo;
            this.CrdentialsManagerLogo_Picturebox.Location = new System.Drawing.Point(64, 12);
            this.CrdentialsManagerLogo_Picturebox.Name = "CrdentialsManagerLogo_Picturebox";
            this.CrdentialsManagerLogo_Picturebox.Size = new System.Drawing.Size(211, 211);
            this.CrdentialsManagerLogo_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CrdentialsManagerLogo_Picturebox.TabIndex = 12;
            this.CrdentialsManagerLogo_Picturebox.TabStop = false;
            // 
            // CredentialManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Background_Panel);
            this.Name = "CredentialManager";
            this.Size = new System.Drawing.Size(1045, 785);
            this.Resize += new System.EventHandler(this.CredentialManager_Resize);
            this.Background_Panel.ResumeLayout(false);
            this.ActiveBtnLogo_Panel.ResumeLayout(false);
            this.ActiveBtnLogo_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage_Picturebox)).EndInit();
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CrdentialsManagerLogo_Picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background_Panel;
        private System.Windows.Forms.Panel ActiveBtnLogo_Panel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.PictureBox LogoImage_Picturebox;
        private System.Windows.Forms.Label Category_Title_Label;
        private System.Windows.Forms.Label HorizontalLine_Label;
        private System.Windows.Forms.PictureBox CrdentialsManagerLogo_Picturebox;
        private System.Windows.Forms.Panel Content_Panel;
        private System.Windows.Forms.Button Mails_Btn;
        private System.Windows.Forms.Button Credentials_Btn;
        private System.Windows.Forms.Button Users_Btn;
        private System.Windows.Forms.Button Categories_Btn;
    }
}
