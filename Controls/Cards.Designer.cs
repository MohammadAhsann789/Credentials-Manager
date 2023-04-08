namespace CredentialsManager.Controls
{
    partial class Cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            this.Card = new Bunifu.Framework.UI.BunifuCards();
            this.CopyEye_Picturebox = new System.Windows.Forms.PictureBox();
            this.Info_Label = new System.Windows.Forms.Label();
            this.Details_Picturebox = new System.Windows.Forms.PictureBox();
            this.Delete_Picturebox = new System.Windows.Forms.PictureBox();
            this.Edit_Picturebox = new System.Windows.Forms.PictureBox();
            this.OperationsMenu_Picturebox = new System.Windows.Forms.PictureBox();
            this.HorizontalLine_Label = new System.Windows.Forms.Label();
            this.LogoImage_Picturebox = new System.Windows.Forms.PictureBox();
            this.CardTitle_Label = new System.Windows.Forms.Label();
            this.Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopyEye_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Details_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsMenu_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.White;
            this.Card.BorderRadius = 5;
            this.Card.BottomSahddow = true;
            this.Card.color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Card.Controls.Add(this.CopyEye_Picturebox);
            this.Card.Controls.Add(this.Info_Label);
            this.Card.Controls.Add(this.Details_Picturebox);
            this.Card.Controls.Add(this.Delete_Picturebox);
            this.Card.Controls.Add(this.Edit_Picturebox);
            this.Card.Controls.Add(this.OperationsMenu_Picturebox);
            this.Card.Controls.Add(this.HorizontalLine_Label);
            this.Card.Controls.Add(this.LogoImage_Picturebox);
            this.Card.Controls.Add(this.CardTitle_Label);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.LeftSahddow = true;
            this.Card.Location = new System.Drawing.Point(0, 0);
            this.Card.Name = "Card";
            this.Card.RightSahddow = true;
            this.Card.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Card.ShadowDepth = 40;
            this.Card.Size = new System.Drawing.Size(405, 238);
            this.Card.TabIndex = 0;
            // 
            // CopyEye_Picturebox
            // 
            this.CopyEye_Picturebox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CopyEye_Picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyEye_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("CopyEye_Picturebox.Image")));
            this.CopyEye_Picturebox.Location = new System.Drawing.Point(353, 114);
            this.CopyEye_Picturebox.Name = "CopyEye_Picturebox";
            this.CopyEye_Picturebox.Size = new System.Drawing.Size(32, 24);
            this.CopyEye_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CopyEye_Picturebox.TabIndex = 14;
            this.CopyEye_Picturebox.TabStop = false;
            this.CopyEye_Picturebox.Tag = "Copyeye";
            this.CopyEye_Picturebox.Visible = false;
            this.CopyEye_Picturebox.MouseLeave += new System.EventHandler(this.InfoLabel_MouseLeave);
            this.CopyEye_Picturebox.MouseHover += new System.EventHandler(this.InfoLabel_MouseHover);
            // 
            // Info_Label
            // 
            this.Info_Label.AutoSize = true;
            this.Info_Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Info_Label.Location = new System.Drawing.Point(34, 177);
            this.Info_Label.Name = "Info_Label";
            this.Info_Label.Size = new System.Drawing.Size(50, 19);
            this.Info_Label.TabIndex = 13;
            this.Info_Label.Text = "Details";
            this.Info_Label.Visible = false;
            // 
            // Details_Picturebox
            // 
            this.Details_Picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Details_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("Details_Picturebox.Image")));
            this.Details_Picturebox.Location = new System.Drawing.Point(15, 199);
            this.Details_Picturebox.Name = "Details_Picturebox";
            this.Details_Picturebox.Size = new System.Drawing.Size(36, 28);
            this.Details_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Details_Picturebox.TabIndex = 12;
            this.Details_Picturebox.TabStop = false;
            this.Details_Picturebox.MouseLeave += new System.EventHandler(this.InfoLabel_MouseLeave);
            this.Details_Picturebox.MouseHover += new System.EventHandler(this.InfoLabel_MouseHover);
            // 
            // Delete_Picturebox
            // 
            this.Delete_Picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_Picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Picturebox.Image")));
            this.Delete_Picturebox.Location = new System.Drawing.Point(353, 199);
            this.Delete_Picturebox.Name = "Delete_Picturebox";
            this.Delete_Picturebox.Size = new System.Drawing.Size(36, 28);
            this.Delete_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Delete_Picturebox.TabIndex = 11;
            this.Delete_Picturebox.TabStop = false;
            this.Delete_Picturebox.MouseLeave += new System.EventHandler(this.InfoLabel_MouseLeave);
            this.Delete_Picturebox.MouseHover += new System.EventHandler(this.InfoLabel_MouseHover);
            // 
            // Edit_Picturebox
            // 
            this.Edit_Picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_Picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Picturebox.Image")));
            this.Edit_Picturebox.Location = new System.Drawing.Point(311, 203);
            this.Edit_Picturebox.Name = "Edit_Picturebox";
            this.Edit_Picturebox.Size = new System.Drawing.Size(35, 25);
            this.Edit_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Edit_Picturebox.TabIndex = 10;
            this.Edit_Picturebox.TabStop = false;
            this.Edit_Picturebox.MouseLeave += new System.EventHandler(this.InfoLabel_MouseLeave);
            this.Edit_Picturebox.MouseHover += new System.EventHandler(this.InfoLabel_MouseHover);
            // 
            // OperationsMenu_Picturebox
            // 
            this.OperationsMenu_Picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OperationsMenu_Picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OperationsMenu_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("OperationsMenu_Picturebox.Image")));
            this.OperationsMenu_Picturebox.Location = new System.Drawing.Point(369, 15);
            this.OperationsMenu_Picturebox.Name = "OperationsMenu_Picturebox";
            this.OperationsMenu_Picturebox.Size = new System.Drawing.Size(25, 25);
            this.OperationsMenu_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OperationsMenu_Picturebox.TabIndex = 9;
            this.OperationsMenu_Picturebox.TabStop = false;
            // 
            // HorizontalLine_Label
            // 
            this.HorizontalLine_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HorizontalLine_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.HorizontalLine_Label.ForeColor = System.Drawing.Color.White;
            this.HorizontalLine_Label.Location = new System.Drawing.Point(-16, 54);
            this.HorizontalLine_Label.Margin = new System.Windows.Forms.Padding(0, 30, 3, 0);
            this.HorizontalLine_Label.Name = "HorizontalLine_Label";
            this.HorizontalLine_Label.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.HorizontalLine_Label.Size = new System.Drawing.Size(435, 1);
            this.HorizontalLine_Label.TabIndex = 8;
            // 
            // LogoImage_Picturebox
            // 
            this.LogoImage_Picturebox.Image = global::CredentialsManager.Properties.Resources.mail_account_35px;
            this.LogoImage_Picturebox.Location = new System.Drawing.Point(15, 7);
            this.LogoImage_Picturebox.Name = "LogoImage_Picturebox";
            this.LogoImage_Picturebox.Size = new System.Drawing.Size(45, 44);
            this.LogoImage_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImage_Picturebox.TabIndex = 4;
            this.LogoImage_Picturebox.TabStop = false;
            // 
            // CardTitle_Label
            // 
            this.CardTitle_Label.AutoSize = true;
            this.CardTitle_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardTitle_Label.Location = new System.Drawing.Point(59, 15);
            this.CardTitle_Label.Name = "CardTitle_Label";
            this.CardTitle_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardTitle_Label.Size = new System.Drawing.Size(149, 28);
            this.CardTitle_Label.TabIndex = 1;
            this.CardTitle_Label.Text = "Gmail Account:";
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Card);
            this.Margin = new System.Windows.Forms.Padding(3, 20, 8, 3);
            this.Name = "Cards";
            this.Size = new System.Drawing.Size(405, 238);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopyEye_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Details_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsMenu_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage_Picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards Card;
        private System.Windows.Forms.Label CardTitle_Label;
        private System.Windows.Forms.PictureBox LogoImage_Picturebox;
        private System.Windows.Forms.Label HorizontalLine_Label;
        private System.Windows.Forms.PictureBox OperationsMenu_Picturebox;
        private System.Windows.Forms.PictureBox Edit_Picturebox;
        private System.Windows.Forms.PictureBox Delete_Picturebox;
        private System.Windows.Forms.PictureBox Details_Picturebox;
        private System.Windows.Forms.Label Info_Label;
        private System.Windows.Forms.PictureBox CopyEye_Picturebox;
    }
}
