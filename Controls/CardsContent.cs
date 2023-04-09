using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Text;

namespace CredentialsManager.Controls
{
    public partial class CardsContent : UserControl
    {
        Database.FetchData fetchData = new Database.FetchData();

        int categoryID;
        int userID;
        DataTable referenceKeys = new DataTable();
        DataTable attributeValues = new DataTable();
        // List<List<string>> attributeTypes = new List<List<string>>();

        public CardsContent(Image cardLogoImage, int categoryID, int userID)
        {
            InitializeComponent();
            this.categoryID = categoryID;
            this.userID = userID;
            Cards_FlowLayoutPanel.Controls.Clear();
            GetCards(cardLogoImage);
        }

        private void GetCards(Image cardLogoImage)
        {
            referenceKeys = fetchData.GetRefernceKeys(userID, categoryID);
            attributeValues = fetchData.GetAttributes(userID, categoryID);
            fetchData.ArrangeCards(cardLogoImage, referenceKeys,
                attributeValues, Cards_FlowLayoutPanel);
        }

        private void AddItem_Btn_Click(object sender, EventArgs e)
        {
            AddItem formAddFields = new AddItem(categoryID, userID);
            formAddFields.ShowDialog();
        }
    }
}
