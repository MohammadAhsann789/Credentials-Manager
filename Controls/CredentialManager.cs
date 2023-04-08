using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CredentialsManager.Controls
{
    public partial class CredentialManager : UserControl
    {
        Panel sideBtnPanel;
        Button currentBtn;
        Image UnActivatedImage;
        Color activeBackColor = Color.FromArgb(46, 55, 70);
        Color activeForeColor = Color.FromArgb(249, 250, 250);
        Color deActiveBackColor = Color.FromArgb(40, 40, 40);
        Color deActiveForeColor = Color.FromArgb(123, 135, 156);
        private readonly int userID;
        private DataTable userCategoriesDatatable = new DataTable();

        private Dictionary<int, List<Control>> btnControlsDictionary = new Dictionary<int, List<Control>>();

        public CredentialManager(bool isAdmin, int userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadCategories();
            SideBtn_Panel();
            Mails_Btn_Click(Mails_Btn, new EventArgs());
            
            if(!isAdmin)
            {
                Users_Btn.Visible = false;
            }
        }

        private void LoadCategories()
        {
            userCategoriesDatatable = new DataTable();
            Data.Categories userCategories = new Data.Categories();
            userCategoriesDatatable = userCategories.GetCategories(userID);
            Create_UserBtns();
        }

        private Panel GetSideBtn_Panel()
        {
            Panel panel = new Panel();
            panel.Size = new Size(5, 46);
            panel.BackColor = Color.FromArgb(0, 176, 255);
            return panel;
        }

        private void Add_Control(Control control)
        {
            Content_Panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            Content_Panel.Controls.Add(control);
        }

        private void SideBtn_Panel()
        {
            sideBtnPanel = GetSideBtn_Panel();
            sideBtnPanel.Name = "SideBtn_Panel";
            ButtonsPanel.Controls.Add(sideBtnPanel);
            sideBtnPanel.BringToFront();
        }

        private void Activate_Btn(Button senderBtn, Image ActivatedImage, Image UnActivatedImage)
        {
            if (currentBtn != null)
            {
                Deactivate_Btn();
            }
            currentBtn = senderBtn;
            this.UnActivatedImage = UnActivatedImage;
            sideBtnPanel.Location = new Point(0, currentBtn.Location.Y);
            currentBtn.BackColor = activeBackColor;
            currentBtn.ForeColor = activeForeColor;
            currentBtn.Image = ActivatedImage;
        }

        private void Deactivate_Btn()
        {
            currentBtn.Image = UnActivatedImage;
            currentBtn.BackColor = deActiveBackColor;
            currentBtn.ForeColor = deActiveForeColor;
        }

        private void Activate_BtnLogoPanel(Image logoImage, string titleText)
        {
            Category_Title_Label.Text = titleText;
            LogoImage_Picturebox.Image = logoImage;
        }

        private int GetCategoryID(string category)
        {
            foreach (DataRow row in userCategoriesDatatable.Rows)
            {
                if (row["Name"].ToString() == category.Trim())
                {
                    return (int)row["CategoryID"];
                }
            }
            return 0;
        }

        private void Create_UserBtns()
        {
            foreach (DataRow row in userCategoriesDatatable.Rows)
            {
                if ((int)row["CategoryID"] >= 0 || (int)row["CategoryID"] <= 0)
                {
                    Button btn = new Button();
                    btn.Size = new Size(331, 47);
                    btn.Text = " " + (string)row["Name"];
                    btn.Tag = GetCategoryID((string)row["Name"]);
                    btn.Dock = DockStyle.Top;
                    btn.ForeColor = deActiveForeColor;
                    btn.BackColor = deActiveBackColor;
                    btn.Font = new Font("Segoe UI", 13, FontStyle.Regular); ;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Image = Properties.Resources.mail_account_UnHighlighted_35px;
                    btn.Padding = new Padding(25, 0, 0, 0);
                    btn.Click += new EventHandler(Btn_Click_Events);
                    ButtonsPanel.Controls.Add(btn);
                    ButtonsPanel.Controls.SetChildIndex(btn, 2);
                }
            }
        }

        private void Btn_Click_Events(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Activate_Btn(btn, Properties.Resources.mail_account_Highlighted_35px,
                Properties.Resources.mail_account_UnHighlighted_35px);

            Activate_BtnLogoPanel(Properties.Resources.mail_account_35px,
                    Get_CategoryTitleLabel((int)btn.Tag));

            // Add_Control(new Control());
            Add_Control(new CardsContent(Properties.Resources.mail_account_35px,
                (int)btn.Tag, userID));
        }

        private string Get_CategoryTitleLabel(int btnID)
        {
            foreach(DataRow row in userCategoriesDatatable.Rows)
            {
                if ((int)row["CategoryID"] == btnID)
                {
                    return (string)row["CategoryTitle"];
                }
            }
            return "";
        }

        private void Mails_Btn_Click(object sender, EventArgs e)
        {
            Activate_Btn((Button)sender, Properties.Resources.mail_account_Highlighted_35px,
                Properties.Resources.mail_account_UnHighlighted_35px);

            Activate_BtnLogoPanel(Properties.Resources.mail_account_35px,
                "Manage your Mail Accounts");

            Mails_Btn.Tag = GetCategoryID(Mails_Btn.Text);
            Add_Control(new CardsContent(Properties.Resources.mail_account_35px, (int)Mails_Btn.Tag, userID));
        }

        private void Credentials_Btn_Click(object sender, EventArgs e)
        {
            Activate_Btn((Button)sender, Properties.Resources.Card_Security_Highlighted_35px,
                Properties.Resources.Card_Security_UnHighlighted_35px);

            Activate_BtnLogoPanel(Properties.Resources.Card_Security_35px,
              "Manage your Crdentials");

            int categoryID = GetCategoryID(Credentials_Btn.Text);
            Add_Control(new CardsContent(Properties.Resources.Card_Security_35px, categoryID, userID));
        }

        private void Categories_Btn_Click(object sender, EventArgs e)
        {
            Activate_Btn((Button)sender, Properties.Resources.categorize_Highlighted_35px,
                Properties.Resources.categorize_UnHighlighted_35px);
            
            Activate_BtnLogoPanel(Properties.Resources.categorize_35px,
              "Catgeories");
            
            Add_Control(new Control());
        }

        private void Users_Btn_Click(object sender, EventArgs e)
        {
            Activate_Btn((Button)sender, Properties.Resources.Users_Highlighted_35px,
                Properties.Resources.Users_UnHighlighted_35px);
            
            Activate_BtnLogoPanel(Properties.Resources.users_35px,
              "Users");

            Add_Control(new Control());
        }

        private void CredentialManager_Resize(object sender, EventArgs e)
        {
            /*if (this.Width <= 300 && this.Width >= 90)
            {
                if (width != this.Width && this.Width < width)
                {
                    SidePanel.Width = SidePanel.Width - 1;
                }
                if (this.Width > width)
                {
                    SidePanel.Width = SidePanel.Width + 1;
                }
                width = this.Width;
            }
            else if (this.Width > 300)
            {
                SidePanel.Width = sidePanelWidth;
            }*/
        }
    }
}
