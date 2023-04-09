using CredentialsManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CredentialsManager.Controls
{
    public partial class Cards : UserControl
    {
        Label label;
        TextBox textBox;
        PictureBox copyEye_PictureBox;

        int locationX_Label = 5;
        int locationY = 60;
        int locationX_Textbox = 5;
        int offsetY = 0;
        int offsetX = 0;

        List<string> attributeNames;
        List<string> attributeValues;
        List<bool> hidedAttributes;

        public Cards(Image cardLogoImage, List<string> attributeNames,
            List<string> attributeValues, List<bool> hidedAttributes)
        {
            InitializeComponent();
            LogoImage_Picturebox.Image = cardLogoImage;
            this.attributeNames = attributeNames;
            this.attributeValues = attributeValues;
            this.hidedAttributes = hidedAttributes;
            Activate_Card();
        }

        private void Activate_Card()
        {
            for(int i=0; i < 3; i++)
            {
                if (attributeNames[i].Replace(" ", "").ToLower() == "displaytitle")
                {
                    CardTitle_Label.Text = attributeValues[i];
                }
                else
                {
                    Card.Controls.Add(Get_Label(attributeNames[i]));
                    Card.Controls.Add(Get_Textbox(attributeNames[i], attributeValues[i], hidedAttributes[i]));
                    offsetY += 48;
                } 
            }
            Adjust_HorizontalLengths();
        }

        private void Adjust_HorizontalLengths()
        {
            // OffsetX is set in initilizing Labels. As labels are the first one in the row
            foreach (Control control in Card.Controls)
            {
                if(control.Tag != null)
                {
                    if (control.Tag?.ToString() == "Textbox" ||
                    control.Tag.ToString() == "True")
                    {
                        control.Location = new Point(control.Location.X + offsetX, control.Location.Y);
                    }
                }
                
            }
            HorizontalLine_Label.Anchor = AnchorStyles.Left;
            HorizontalLine_Label.Width = HorizontalLine_Label.Width + (offsetX * 2);
            Adjust_CardSize();
        }

        private void Adjust_CardSize()
        {
            if (copyEye_PictureBox != null)
            {
                int card_Offset = (Size.Width + offsetX) -
                (copyEye_PictureBox.Location.X + copyEye_PictureBox.Width) - 10;
                Size = new Size((Size.Width + offsetX) - card_Offset, Height);
            }
        } 

        private Label Get_Label(string labelText)
        {
            label = new Label();
            label.Name = labelText + "_Label";
            label.Tag = "Label";
            label.Text = labelText + ":";
            label.RightToLeft = RightToLeft.No;
            label.ForeColor = Color.Black;
            label.AutoSize = true;
            label.RightToLeft = RightToLeft.No;
            label.Font = new Font("Segoe UI", (float)11.2, FontStyle.Regular);
            int width = TextRenderer.MeasureText(label.Text, new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style)).Width;
            int height = TextRenderer.MeasureText(label.Text, new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style)).Height;
            label.Size = new Size(width, height);
            if (offsetX < width)
            {
                offsetX = width;
            }
            label.Location = new Point(locationX_Label, locationY + offsetY);
            label.BringToFront();
            return label;
        }

        private TextBox Get_Textbox(string attributeName, string attributeValue, bool hiddenAttribute)
        {
            textBox = new TextBox();
            textBox.Name = attributeName + "_Textbox";
            textBox.Tag = "Textbox";
            textBox.Text = attributeValue;
            textBox.ReadOnly = true;
            textBox.Location = new Point(locationX_Textbox, locationY + offsetY);
            textBox.RightToLeft = RightToLeft.No;
            textBox.ForeColor = Color.Black;
            textBox.Size = new Size(190, 32);
            textBox.Font = new Font("Segoe UI", (float)9.5, FontStyle.Regular);

            if(hiddenAttribute)
            {
                textBox.UseSystemPasswordChar = true;
                Point location = new Point(textBox.Location.X + textBox.Size.Width + 3,
                    textBox.Location.Y + 3);
                Card.Controls.Add(Get_CopyEye_Picturebox(location, hiddenAttribute, attributeName));
            }

            textBox.BringToFront();
            return textBox;
        }

        private PictureBox Get_CopyEye_Picturebox(Point location, bool hiddenAttribute, string attributeName)
        {
            copyEye_PictureBox = new PictureBox();
            copyEye_PictureBox.Anchor = AnchorStyles.Left;
            copyEye_PictureBox.Cursor = Cursors.Hand;
            copyEye_PictureBox.Tag = hiddenAttribute;
            copyEye_PictureBox.Image = Resources.eye_35px;
            copyEye_PictureBox.Location = new Point(location.X, location.Y);
            copyEye_PictureBox.Name = attributeName + "_CopyEye_PictureBox";
            copyEye_PictureBox.Size = new Size(25, 20);
            copyEye_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            copyEye_PictureBox.TabIndex = 14;
            copyEye_PictureBox.Visible = true;
            copyEye_PictureBox.Click += new EventHandler(CopyEye_Picturebox_Click_Event);
            copyEye_PictureBox.DoubleClick += new EventHandler(CopyEye_Picturebox_DoubleClick_Event);
            copyEye_PictureBox.MouseLeave += new EventHandler(InfoLabel_MouseLeave);
            copyEye_PictureBox.MouseHover += new EventHandler(InfoLabel_MouseHover);
            copyEye_PictureBox.BringToFront();
            return copyEye_PictureBox;
        }

        private void Set_InfoLabelName(PictureBox pictureBox)
        {
            if (pictureBox == Details_Picturebox)
            {
                Info_Label.Text = "Details";
            }
            else if (pictureBox == Edit_Picturebox)
            {
                Info_Label.Text = "Edit";
            }
            else if (pictureBox == Delete_Picturebox)
            {
                Info_Label.Text = "Delete";
            }
            else if(pictureBox == copyEye_PictureBox)
            {
                Info_Label.Text = "Show Password";
            }
        }

        private void InfoLabel_MouseHover(object sender, EventArgs e)
        {
            Info_Label.Visible = true;
            PictureBox pictureBox = (PictureBox)sender;
            int offsetX = 0;
            int offsetY = -15;
            if(pictureBox == copyEye_PictureBox)
            {
                offsetX = -offsetX - 70;
                offsetY = -offsetY - 35;
            }
            else
            {
                offsetY = -15;
            }
            Set_InfoLabelName(pictureBox);
            Info_Label.Location = new Point(pictureBox.Location.X + offsetX, pictureBox.Location.Y + offsetY);
        }

        private void InfoLabel_MouseLeave(object sender, EventArgs e)
        {
            Info_Label.Visible = false;
        }

        private void CopyEye_Picturebox_Click_Event(object sender, EventArgs e)
        {
            PictureBox senderItem = (PictureBox)sender;
            Control[] foundControls = this.Controls
                .Find(senderItem.Name.Replace("_CopyEye_PictureBox", "_Textbox"), true);

            TextBox passwordTextbox = (TextBox)foundControls[0];
            passwordTextbox.UseSystemPasswordChar = !passwordTextbox.UseSystemPasswordChar;
            
            if (passwordTextbox.UseSystemPasswordChar)
            {
                senderItem.Image = Resources.eye_35px;
            }
            else
            {
                senderItem.Image = Resources.hide_35px;
            }
        }

        private void CopyEye_Picturebox_DoubleClick_Event(object sender, EventArgs e)
        {
            PictureBox senderItem = (PictureBox)sender;
            Control[] foundControls = this.Controls
                .Find(senderItem.Name.Replace("_CopyEye_PictureBox", "_Textbox"), true);
            
            foreach(Control control in foundControls)
            {
                if(control is TextBox)
                {
                    TextBox passwordTextbox = (TextBox)control;
                    Clipboard.SetText(passwordTextbox.Text);
                    CopyEye_Picturebox.Focus();
                    MessageBox.Show(senderItem.Name.Replace("_CopyEye_PictureBox", "")
                        + " Copied!!!", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign);
                }
            }
        }
    }
}
