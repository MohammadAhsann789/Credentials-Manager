using CredentialsManager.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace CredentialsManager
{
    public partial class Runner : Form
    {
        public Runner()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            Add_Control(
                    new CredentialManager(true, 1),
                    new Size(0, 0), new Size(0, 0),
                    new Size(1052, 784), FormWindowState.Maximized
                    );
            

            // Don't remove the follwoing code. Use it for Login purposes.
            /*FormBorderStyle = FormBorderStyle.FixedSingle;
            Add_Control(
                    new Login(this),
                    new Size(404, 692), new Size(0, 0),
                    new Size(404, 692), FormWindowState.Maximized
                    ); */
        }

        public void Add_Control(Control control, Size runnerFormMinSize,
            Size runnerFormMaxSize, Size formActualSize,
            FormWindowState formWindowState)
        {
            MinimumSize = runnerFormMinSize;
            MaximumSize = runnerFormMaxSize;
            Size = formActualSize;
            WindowState = formWindowState;
            Background_Panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            Background_Panel.Controls.Add(control);
        }
    }
}
