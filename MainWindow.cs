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
    public partial class MainWindow : Form
    {
        bool mouseDown;
        private Point offset;

        public MainWindow()
        {
            InitializeComponent();
            this.pnlTabLoader.Controls.Clear();
            CalcTab CalcTab_Vrb = new CalcTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CalcTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlTabLoader.Controls.Add(CalcTab_Vrb);
            CalcTab_Vrb.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        //Don't know if there is a better way and I don't care.
        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X =e.X;
            offset.Y =e.Y;
            mouseDown = true;
        }
        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblcalctab_Click(object sender, EventArgs e)
        {
            lblcalctab.BackColor = Color.FromArgb(30, 30, 35);
            lblinfotab.BackColor = Color.FromArgb(20, 20, 25);

            this.pnlTabLoader.Controls.Clear();
            CalcTab CalcTab_Vrb = new CalcTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CalcTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlTabLoader.Controls.Add(CalcTab_Vrb);
            CalcTab_Vrb.Show();
        }

        private void lblinfotab_Click(object sender, EventArgs e)
        {
            lblinfotab.BackColor = Color.FromArgb(30, 30, 35);
            lblcalctab.BackColor = Color.FromArgb(20, 20, 25);

            this.pnlTabLoader.Controls.Clear();
            InfoTab InfoTab_Vrb = new InfoTab() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            InfoTab_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlTabLoader.Controls.Add(InfoTab_Vrb);
            InfoTab_Vrb.Show();
        }
    }
}
