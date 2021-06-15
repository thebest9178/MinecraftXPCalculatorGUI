using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftXPCalculatorGUI
{
    public partial class InfoTab : Form
    {
        public InfoTab()
        {
            InitializeComponent();
        }

        private void btnGitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uh Oh, Something went fucky");
            }
        }

        private void VisitLink()
        {
            //This will open the link with the default browser
            System.Diagnostics.Process.Start("https://github.com/thebest9178/MinecraftXPCalculatorGUI");
        }
    }
}
