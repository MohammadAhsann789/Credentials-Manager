namespace CredentialsManager.Controls
{
    partial class CardsContent
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
            this.components = new System.ComponentModel.Container();
            this.AddItem_Btn_Ellipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AddItem_Btn = new System.Windows.Forms.Button();
            this.ContentOperations_Panel = new System.Windows.Forms.Panel();
            this.Cards_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ContentOperations_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddItem_Btn_Ellipse
            // 
            this.AddItem_Btn_Ellipse.ElipseRadius = 15;
            this.AddItem_Btn_Ellipse.TargetControl = this.AddItem_Btn;
            // 
            // AddItem_Btn
            // 
            this.AddItem_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItem_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AddItem_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem_Btn.FlatAppearance.BorderSize = 0;
            this.AddItem_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem_Btn.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.AddItem_Btn.ForeColor = System.Drawing.Color.White;
            this.AddItem_Btn.Image = global::CredentialsManager.Properties.Resources.add_25px;
            this.AddItem_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItem_Btn.Location = new System.Drawing.Point(763, 18);
            this.AddItem_Btn.Name = "AddItem_Btn";
            this.AddItem_Btn.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.AddItem_Btn.Size = new System.Drawing.Size(175, 46);
            this.AddItem_Btn.TabIndex = 0;
            this.AddItem_Btn.Text = "Add Item";
            this.AddItem_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItem_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddItem_Btn.UseVisualStyleBackColor = false;
            this.AddItem_Btn.Click += new System.EventHandler(this.AddItem_Btn_Click);
            // 
            // ContentOperations_Panel
            // 
            this.ContentOperations_Panel.Controls.Add(this.AddItem_Btn);
            this.ContentOperations_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentOperations_Panel.Location = new System.Drawing.Point(0, 0);
            this.ContentOperations_Panel.Name = "ContentOperations_Panel";
            this.ContentOperations_Panel.Size = new System.Drawing.Size(971, 72);
            this.ContentOperations_Panel.TabIndex = 5;
            // 
            // Cards_FlowLayoutPanel
            // 
            this.Cards_FlowLayoutPanel.AutoScroll = true;
            this.Cards_FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cards_FlowLayoutPanel.Location = new System.Drawing.Point(0, 72);
            this.Cards_FlowLayoutPanel.Name = "Cards_FlowLayoutPanel";
            this.Cards_FlowLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.Cards_FlowLayoutPanel.Size = new System.Drawing.Size(971, 694);
            this.Cards_FlowLayoutPanel.TabIndex = 6;
            // 
            // CardsContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Cards_FlowLayoutPanel);
            this.Controls.Add(this.ContentOperations_Panel);
            this.Name = "CardsContent";
            this.Size = new System.Drawing.Size(971, 766);
            this.ContentOperations_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse AddItem_Btn_Ellipse;
        private System.Windows.Forms.Button AddItem_Btn;
        private System.Windows.Forms.Panel ContentOperations_Panel;
        private System.Windows.Forms.FlowLayoutPanel Cards_FlowLayoutPanel;
    }
}
