using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fetcher
{
    public partial class frmFetcher : Form
    {
        public frmFetcher()
        {
            InitializeComponent();
        }

        private void cmdProcess_Click(object sender, EventArgs e)
        {
            runConsoleCommands();
        }

        private void runConsoleCommands()
        {
            /* Posts console commands for processing */
            lstConsole.Items.Add(StringHelper.GetDatNow() + txtInput.Text);
            if (txtInput.Text != string.Empty)
            {
                string response = ConsoleProcess.checkCommand(txtInput.Text);
                if(response != string.Empty)
                {
                    lstConsole.Items.Add(response);
                }
            }
            txtInput.Text = string.Empty;
        }
    }
}
