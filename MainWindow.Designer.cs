
namespace MinecraftXPCalculatorGUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.closebutton = new System.Windows.Forms.PictureBox();
            this.lblcalctab = new System.Windows.Forms.Label();
            this.lblinfotab = new System.Windows.Forms.Label();
            this.pnlTabLoader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
            this.SuspendLayout();
            // 
            // closebutton
            // 
            this.closebutton.Image = global::MinecraftXPCalculatorGUI.Properties.Resources.close;
            this.closebutton.Location = new System.Drawing.Point(960, 0);
            this.closebutton.Margin = new System.Windows.Forms.Padding(0);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(25, 25);
            this.closebutton.TabIndex = 13;
            this.closebutton.TabStop = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // lblcalctab
            // 
            this.lblcalctab.AutoSize = true;
            this.lblcalctab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.lblcalctab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalctab.ForeColor = System.Drawing.Color.White;
            this.lblcalctab.Location = new System.Drawing.Point(0, 0);
            this.lblcalctab.Margin = new System.Windows.Forms.Padding(0);
            this.lblcalctab.Name = "lblcalctab";
            this.lblcalctab.Size = new System.Drawing.Size(109, 25);
            this.lblcalctab.TabIndex = 15;
            this.lblcalctab.Text = "Calculator";
            this.lblcalctab.Click += new System.EventHandler(this.lblcalctab_Click);
            // 
            // lblinfotab
            // 
            this.lblinfotab.AutoSize = true;
            this.lblinfotab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.lblinfotab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfotab.ForeColor = System.Drawing.Color.White;
            this.lblinfotab.Location = new System.Drawing.Point(109, 0);
            this.lblinfotab.Margin = new System.Windows.Forms.Padding(0);
            this.lblinfotab.Name = "lblinfotab";
            this.lblinfotab.Size = new System.Drawing.Size(47, 25);
            this.lblinfotab.TabIndex = 15;
            this.lblinfotab.Text = "Info";
            this.lblinfotab.Click += new System.EventHandler(this.lblinfotab_Click);
            // 
            // pnlTabLoader
            // 
            this.pnlTabLoader.Location = new System.Drawing.Point(0, 25);
            this.pnlTabLoader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTabLoader.Name = "pnlTabLoader";
            this.pnlTabLoader.Size = new System.Drawing.Size(985, 725);
            this.pnlTabLoader.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.panel1.Location = new System.Drawing.Point(156, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 25);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(985, 750);
            this.Controls.Add(this.lblcalctab);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTabLoader);
            this.Controls.Add(this.lblinfotab);
            this.Controls.Add(this.closebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox closebutton;
        private System.Windows.Forms.Label lblcalctab;
        private System.Windows.Forms.Label lblinfotab;
        private System.Windows.Forms.Panel pnlTabLoader;
        private System.Windows.Forms.Panel panel1;
    }
}

