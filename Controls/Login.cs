using CredentialsManager.Data;
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
    public partial class Login : UserControl
    {
        Runner runner;
        public Login(Runner runner)
        {
            InitializeComponent();
            this.runner = runner;
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            Data.Login login = new Data.Login();
            DataTable dataTable = login.GetUser_Data(LoginID_Textbox.Text, MasterKey_Textbox.Text);
            if(dataTable.Rows.Count == 1)
            {
                runner.FormBorderStyle = FormBorderStyle.Sizable;
                runner.Add_Control(
                    new CredentialManager(
                        (string)dataTable.Rows[0]["Role"] == "Admin"? true : false,
                        (int)dataTable.Rows[0]["UserID"]),
                    new Size(0, 0), new Size(0, 0),
                    new Size(1052, 784), FormWindowState.Maximized
                    );
            }
            else
            {
                MessageBox.Show("Wrong Credentials!!!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
        }
    }
}
