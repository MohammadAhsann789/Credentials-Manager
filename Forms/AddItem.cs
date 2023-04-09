using CredentialsManager.Controls;
using CredentialsManager.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CredentialsManager
{
    public partial class AddItem : Form
    {
        FetchData fetchData = new FetchData();

        DataTable attributeTypes = new DataTable();
        Label label;
        TextBox textBox;
        PictureBox minusSign_Picturebox;

        int locationX_Label = 15;
        int locationY = 45;
        int locationX_Textbox = 15;
        int locationX_MinusSign = 15;
        int minusSign_OffsetX_Wrt_Textbox = 0;
        int offsetY = 0;
        int repositionOffsetY = 48;
        int offsetX = 0;

        int categoryID;
        int userID;


        public AddItem(int categoryID, int userID)
        {
            InitializeComponent();
            this.categoryID = categoryID;
            this.userID = userID;
            attributeTypes = fetchData.GetAttributeTypes(userID, categoryID);
            GeneratetAttributes();
        }

        private void GeneratetAttributes()
        {
            for (int i = 0; i < attributeTypes.Rows.Count; i++)
            {
                Attributes_Panel.Controls.Add(Get_Label(attributeTypes.Rows[i]["AttributeName"].ToString(), Convert.ToBoolean(attributeTypes.Rows[i]["IsRequired"])));
                Attributes_Panel.Controls.Add(Get_Textbox(attributeTypes.Rows[i]["AttributeName"].ToString(), Convert.ToInt32(attributeTypes.Rows[i]["TypeID"])));
                Attributes_Panel.Controls.Add(GetMinusSign_Picturebox(attributeTypes.Rows[i]["AttributeName"].ToString(), textBox.Width));

                offsetY += 48;
            }

            Adjust_HorizontalLengths();
        }

        private void Adjust_HorizontalLengths()
        {
            foreach(Control control in Attributes_Panel.Controls)
            {
                if(!(control is Label))
                {
                    control.Location = new Point(control.Location.X + offsetX, control.Location.Y);
                }
            }

            Adjust_FormSize();
        }

        private void Adjust_FormSize()
        {
            int form_OffsetX = (Size.Width + offsetX) -
                (minusSign_Picturebox.Location.X + minusSign_Picturebox.Width) - 30;

            // From above formula formOffset found, which was observed fixed for all kinds of varying lengths
            // int form_OffsetX = 65;  

            Size = new Size((Size.Width + offsetX) - form_OffsetX, Height);
        }

        private Label Get_Label(string labelText, bool isRequired)
        {
            label = new Label();
            label.Font = new Font("Segoe UI", (float)11.2, FontStyle.Regular);
            label.Name = labelText + "_Label";
            label.Tag = labelText;
            if (!isRequired)
            {
                label.Text = labelText + " (Optional)";
            }
            else
            {
                label.Text = labelText + " (Required)";
            }
            label.RightToLeft = RightToLeft.No;
            int width = TextRenderer.MeasureText(label.Text, new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style)).Width;
            int height = TextRenderer.MeasureText(label.Text, new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style)).Height;
            label.Size = new Size(width, height);
            if(offsetX < width)
            {
                offsetX = width;
            }
            label.ForeColor = Color.Black;
            label.Location = new Point(locationX_Label, locationY + offsetY);
            label.BringToFront();
            return label;
        }

        private TextBox Get_Textbox(string labelText, int typeID)
        {
            textBox = new TextBox();
            textBox.Tag = typeID;
            textBox.Name = labelText + "_Textbox";
            textBox.Text = "";
            textBox.Location = new Point(locationX_Textbox, locationY + offsetY);
            textBox.RightToLeft = RightToLeft.No;
            textBox.ForeColor = Color.Black;
            textBox.Size = new Size(200, 32);
            textBox.Font = new Font("Segoe UI", (float)9.5, FontStyle.Regular);
            textBox.BringToFront();
            return textBox;
        }

        private PictureBox GetMinusSign_Picturebox(string labelText, int textboxSize)
        {
            minusSign_OffsetX_Wrt_Textbox = textboxSize + 10;
            minusSign_Picturebox = new PictureBox();
            minusSign_Picturebox.Tag = labelText;
            minusSign_Picturebox.Name = labelText + "_MinusSign_Picturebox";
            minusSign_Picturebox.Size = new Size(25, 25);
            minusSign_Picturebox.Image = Properties.Resources.minus_35px;
            minusSign_Picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            minusSign_Picturebox.Cursor = Cursors.Hand;
            minusSign_Picturebox.Location = new Point(locationX_MinusSign + minusSign_OffsetX_Wrt_Textbox, locationY + offsetY);
            minusSign_Picturebox.Click += new EventHandler(MinusSign_Picturebox_Click_Event);
            minusSign_Picturebox.BringToFront();
            return minusSign_Picturebox;
        }

        private void MinusSign_Picturebox_Click_Event(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to remove the Field!!!", "Confirmation!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign) == DialogResult.Cancel)
            {
                return;
            }

            PictureBox senderItem = (PictureBox)sender;

            // Working Code 1:
            foreach (Control control in Attributes_Panel.Controls)
            {
                if (control.Tag.ToString().Trim() == senderItem.Tag.ToString().Trim())
                {
                    //MessageBox.Show("Tag: " + control.Tag.ToString().Trim() +
                    //"\nName: " + control.Name.Trim());

                    Attributes_Panel.Controls.Remove(control);
                }
            }

            foreach (Control control in Attributes_Panel.Controls)
            {
                if (control.Name == senderItem.Tag.ToString().Trim() + "_Textbox"
                    || control.Name == senderItem.Tag.ToString().Trim() + "_Label")
                {
                    Attributes_Panel.Controls.Remove(control);
                }
            }


            // Working Code 2:
            /* Control[] controls = Attributes_Panel.Controls.Find(senderItem.Tag.ToString() + "_Label", true);
            Attributes_Panel.Controls.Remove(controls[0]);

            controls = Attributes_Panel.Controls.Find(senderItem.Tag.ToString() + "_Textbox", true);
            Attributes_Panel.Controls.Remove(controls[0]);

            controls = Attributes_Panel.Controls.Find(senderItem.Tag.ToString() + "_MinusSign_Picturebox", true);
            Attributes_Panel.Controls.Remove(controls[0]); */

            RepositionFields(senderItem.Location.Y);

        }

        private void RepositionFields(int baseLocationY)
        {
            foreach (Control control in Attributes_Panel.Controls)
            {
                if (control.Location.Y > baseLocationY)
                {
                    control.Location = new Point(control.Location.X,
                        control.Location.Y - repositionOffsetY);
                }
            }
        }

        private void AddItem_Btn_Click(object sender, EventArgs e)
        {
            fetchData = new FetchData();
            int referrenceKey = fetchData.GetNextReferenceKey();
            if (referrenceKey == -1)
            {
                MessageBox.Show("Internal Error while inserting the Data!!!\n" +
                    "Please Contact to your Service Provider.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                return;
            }

            if (Attributes_Panel.Controls.Count < 3)
            {
                MessageBox.Show("Minimum 3 Fields Are Required!!!\n" +
                    "No Data Found to Add!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                return;
            }


            string query = "";
            referrenceKey++;
            foreach (Control control in Attributes_Panel.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text.Trim() == "")
                    {
                        MessageBox.Show("Please insert all the Fields!!!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                        return;
                    }
                    else
                    {
                        query += "INSERT INTO AttributeValues (UserID, CategoryID, TypeID," +
                            "ReferenceKey, AttributeValue) " +
                            "VALUES ('"+userID+"', '"+categoryID+"', '"+(int)control.Tag+"'," +
                            "'"+ referrenceKey +"', '"+control.Text.Trim()+"');";
                        
                    }
                }
            }

            InsertData insertData = new InsertData();
            if (insertData.Insert(query))
            {
                foreach (Control control in Attributes_Panel.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Text = "";
                    }
                }
                MessageBox.Show("Data Saved Sucessfully!!!", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
        }
    }
}
