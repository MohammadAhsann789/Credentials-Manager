using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CredentialsManager.Controls;
using System.Windows.Forms;

namespace CredentialsManager.Database
{
    public class FetchData
    {
        DataTable datatable;
        SqlConnection con = new SqlConnection();

        public FetchData()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        }

        public DataTable GetRefernceKeys(int userID, int categoryID)
        {
            try
            {
                if (con.State != ConnectionState.Open) { con.Open(); }
                string query = "SELECT ReferenceKey FROM AttributeValues WHERE " +
                    "UserID = '" + userID + "' AND CategoryID = '" + categoryID + "' GROUP BY ReferenceKey";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                datatable = new DataTable();
                SDA.Fill(datatable);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
            return datatable;
        }

        public DataTable GetAttributes(int userID, int categoryID)
        {
            try
            {
                if (con.State != ConnectionState.Open) { con.Open(); }
                string query = "SELECT IsHide, AttributeTypes.TypeID AS TypeID, ReferenceKey, AttributeName, AttributeValue " +
                               "FROM AttributeValues " +
                               "JOIN AttributeTypes ON AttributeTypes.TypeID = AttributeValues.TypeID " +
                               "JOIN Categories ON Categories.CategoryID = AttributeValues.CategoryID " +
                               "JOIN Users ON Users.UserID = AttributeValues.UserID " +
                               "WHERE AttributeValues.UserID = '" + userID + "' AND Categories.CategoryID = '" + categoryID + "' " +
                               "UNION " +
                               "SELECT IsHide, AttributeTypes.TypeID AS TypeID, ReferenceKey, AttributeName, AttributeValue " +
                               "FROM AttributeValues " +
                               "JOIN AttributeTypes ON AttributeTypes.TypeID = AttributeValues.TypeID " +
                               "JOIN DefaultCategories ON DefaultCategories.CategoryID = AttributeValues.CategoryID " +
                               "JOIN Users ON Users.UserID = AttributeValues.UserID " +
                               "WHERE AttributeValues.UserID = '" + userID + "' AND DefaultCategories.CategoryID = '" + categoryID + "' ;";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                datatable = new DataTable();
                SDA.Fill(datatable);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
            return datatable;
        }

        public void ArrangeCards(Image cardLogoImage, DataTable referenceKeys, DataTable attributeValues,
            FlowLayoutPanel Cards_FlowLayoutPanel)
        {
            List<string> cardAttributesNames;
            List<string> cardAttributesValues;
            List<bool> cardHidedAttributes;

            foreach (DataRow keyRow in referenceKeys.Rows)
            {
                cardAttributesNames = new List<string>();
                cardAttributesValues = new List<string>();
                cardHidedAttributes = new List<bool>();

                try
                {
                    int referenceKey = (int)keyRow["ReferenceKey"];
                    foreach (DataRow valueRow in attributeValues.Rows)
                    {
                        if ((int)valueRow["ReferenceKey"] == referenceKey)
                        {
                            cardAttributesNames.Add((string)valueRow["AttributeName"]);
                            cardAttributesValues.Add((string)valueRow["AttributeValue"]);
                            cardHidedAttributes.Add((bool)valueRow["IsHide"]);
                        }
                    }
                    Cards_FlowLayoutPanel.Controls.Add(new Cards(cardLogoImage,
                        cardAttributesNames, cardAttributesValues, cardHidedAttributes));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Class: FetchData.cs, Function: ArrangeCards\n" + ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                }
            }
        }

        public DataTable GetAttributeTypes(int userID, int categoryID)
        {
            try
            {
                if (con.State != ConnectionState.Open) { con.Open(); }
                string query = "SELECT TypeID, AttributeName, IsRequired " +
                    "FROM AttributeTypes " +
                    "WHERE UserID = '"+userID+"' AND CategoryID = '"+categoryID+"';";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                datatable = new DataTable();
                SDA.Fill(datatable);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
            return datatable;
        }

        public int GetNextReferenceKey()
        {
            try
            {
                if (con.State == ConnectionState.Closed) { con.Open(); }
                string query = "SELECT MAX(ReferenceKey) FROM AttributeValues;";
                SqlCommand cmd = new SqlCommand(query, con);
                int referenceKey = (int)cmd.ExecuteScalar();
                con.Close();
                return referenceKey;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
            return -1;
        }
    }
}
