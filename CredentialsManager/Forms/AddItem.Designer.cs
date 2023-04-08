namespace CredentialsManager
{
    partial class AddItem
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
            this.Back_Panel = new System.Windows.Forms.Panel();
            this.Attributes_Panel = new System.Windows.Forms.Panel();
            this.BottomActionBtn_Panel = new System.Windows.Forms.Panel();
            this.AddItem_Btn = new System.Windows.Forms.Button();
            this.Titel_Panel = new System.Windows.Forms.Panel();
            this.HorizontalLine_Label = new System.Windows.Forms.Label();
            this.LogoImage_Picturebox = new System.Windows.Forms.PictureBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Back_Panel.SuspendLayout();
            this.BottomActionBtn_Panel.SuspendLayout();
            this.Titel_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Panel
            // 
            this.Back_Panel.Controls.Add(this.Attributes_Panel);
            this.Back_Panel.Controls.Add(this.BottomActionBtn_Panel);
            this.Back_Panel.Controls.Add(this.Titel_Panel);
            this.Back_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Back_Panel.Location = new System.Drawing.Point(0, 0);
            this.Back_Panel.Name = "Back_Panel";
            this.Back_Panel.Size = new System.Drawing.Size(439, 666);
            this.Back_Panel.TabIndex = 1;
            // 
            // Attributes_Panel
            // 
            this.Attributes_Panel.AutoScroll = true;
            this.Attributes_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Attributes_Panel.Location = new System.Drawing.Point(0, 77);
            this.Attributes_Panel.Name = "Attributes_Panel";
            this.Attributes_Panel.Size = new System.Drawing.Size(439, 512);
            this.Attributes_Panel.TabIndex = 2;
            // 
            // BottomActionBtn_Panel
            // 
            this.BottomActionBtn_Panel.Controls.Add(this.AddItem_Btn);
            this.BottomActionBtn_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomActionBtn_Panel.Location = new System.Drawing.Point(0, 589);
            this.BottomActionBtn_Panel.Name = "BottomActionBtn_Panel";
            this.BottomActionBtn_Panel.Size = new System.Drawing.Size(439, 77);
            this.BottomActionBtn_Panel.TabIndex = 1;
            // 
            // AddItem_Btn
            // 
            this.AddItem_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItem_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AddItem_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem_Btn.FlatAppearance.BorderSize = 0;
            this.AddItem_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem_Btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.AddItem_Btn.ForeColor = System.Drawing.Color.White;
            this.AddItem_Btn.Image = global::CredentialsManager.Properties.Resources.add_20px;
            this.AddItem_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItem_Btn.Location = new System.Drawing.Point(265, 25);
            this.AddItem_Btn.Name = "AddItem_Btn";
            this.AddItem_Btn.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.AddItem_Btn.Size = new System.Drawing.Size(153, 40);
            this.AddItem_Btn.TabIndex = 1;
            this.AddItem_Btn.Text = "Add Item";
            this.AddItem_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItem_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddItem_Btn.UseVisualStyleBackColor = false;
            this.AddItem_Btn.Click += new System.EventHandler(this.AddItem_Btn_Click);
            // 
            // Titel_Panel
            // 
            this.Titel_Panel.Controls.Add(this.HorizontalLine_Label);
            this.Titel_Panel.Controls.Add(this.LogoImage_Picturebox);
            this.Titel_Panel.Controls.Add(this.Title_Label);
            this.Titel_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titel_Panel.Location = new System.Drawing.Point(0, 0);
            this.Titel_Panel.Name = "Titel_Panel";
            this.Titel_Panel.Size = new System.Drawing.Size(439, 77);
            this.Titel_Panel.TabIndex = 0;
            // 
            // HorizontalLine_Label
            // 
            this.HorizontalLine_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.HorizontalLine_Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HorizontalLine_Label.ForeColor = System.Drawing.Color.White;
            this.HorizontalLine_Label.Location = new System.Drawing.Point(0, 76);
            this.HorizontalLine_Label.Name = "HorizontalLine_Label";
            this.HorizontalLine_Label.Size = new System.Drawing.Size(439, 1);
            this.HorizontalLine_Label.TabIndex = 6;
            // 
            // LogoImage_Picturebox
            // 
            this.LogoImage_Picturebox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoImage_Picturebox.Image = global::CredentialsManager.Properties.Resources.Add_properties_35px;
            this.LogoImage_Picturebox.Location = new System.Drawing.Point(133, 16);
            this.LogoImage_Picturebox.Name = "LogoImage_Picturebox";
            this.LogoImage_Picturebox.Size = new System.Drawing.Size(40, 40);
            this.LogoImage_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImage_Picturebox.TabIndex = 5;
            this.LogoImage_Picturebox.TabStop = false;
            // 
            // Title_Label
            // 
            this.Title_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.Title_Label.ForeColor = System.Drawing.Color.Black;
            this.Title_Label.Location = new System.Drawing.Point(178, 19);
            this.Title_Label.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(105, 30);
            this.Title_Label.TabIndex = 4;
            this.Title_Label.Text = "Add Item";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 666);
            this.Controls.Add(this.Back_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Items";
            this.Back_Panel.ResumeLayout(false);
            this.BottomActionBtn_Panel.ResumeLayout(false);
            this.Titel_Panel.ResumeLayout(false);
            this.Titel_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage_Picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Back_Panel;
        private System.Windows.Forms.Panel Titel_Panel;
        private System.Windows.Forms.PictureBox LogoImage_Picturebox;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Label HorizontalLine_Label;
        private System.Windows.Forms.Panel BottomActionBtn_Panel;
        private System.Windows.Forms.Button AddItem_Btn;
        private System.Windows.Forms.Panel Attributes_Panel;
    }
}