using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

using KB.OpticalReader.SyncfusionApp.Properties;

using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace KB.OpticalReader.SyncfusionApp.Views
{
    partial class ShellWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellWindow));
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "NEW");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();   
this.Main = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
this.Charts = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
this.DataGrid = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
this.Spreadsheet = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFrameBarManager1
            // 
            
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("MENU");
            this.mainFrameBarManager1.CurrentBaseFormType = "";
            this.mainFrameBarManager1.EnableMenuMerge = true;
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            parentBarItem1,
            this.Main,
            this.Charts,
            this.DataGrid,
            this.Spreadsheet,
            });
            this.mainFrameBarManager1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.UseBackwardCompatiblity = false;
            comboBox.Items.Add("Office2019Colorful");
            comboBox.Items.Add("HighContrastBlack");
            this.mainFrameBarManager1.ItemClicked += MainFrameBarManager1_ItemClicked;
            parentBarItem1.Text = "File";

            parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]
            {

            });

            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] { parentBarItem1 });


            this.Main.Text = "Main";

            this.Charts.Text = "Charts";

            this.DataGrid.Text = "DataGrid";

            this.Spreadsheet.Text = "Spreadsheet";

            parentBarItem2.Text = "Views";

            parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[]
            {

               this.Main,
               this.Charts,
               this.DataGrid,
               this.Spreadsheet,
            });

            // Add ParentBarItem to Bar
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] { parentBarItem2 });



            leftPanel.Dock = DockStyle.Fill;

            rightPanel.Dock = DockStyle.Right;
            rightPanel.Height = 800;
            rightPanel.Width = 300;
            leftPanel.Location = new Point(10, 800);
            leftPanel.Width = 1445;

            this.Controls.Add(leftPanel);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Height = 800;
            this.Width = 1000;
	    ResourceManager rm = new ResourceManager("KB.OpticalReader.SyncfusionApp.Properties.Resources", typeof(Resources).Assembly);
            string appName= rm.GetString("AppDisplayName");
            this.Name = appName;
            this.Text = appName;
            this.FormClosing += Form1_FormClosing;
	    this.Resize += ShellWindow_Resize;
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.ResumeLayout(false);
        }


        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex == 0)
            {
                this.mainFrameBarManager1.ThemeName = "Office2019Colorful";   
            }
            else
            {
                this.mainFrameBarManager1.ThemeName = "HighContrastBlack";
            }
        }

        private void barItem2_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
        ParentBarItem parentBarItem1 = new ParentBarItem();
        ParentBarItem parentBarItem2 = new ParentBarItem();   
        BarItem Main = new BarItem();
        BarItem Charts = new BarItem();
        BarItem DataGrid = new BarItem();
        BarItem Spreadsheet = new BarItem();
        Panel panel1 = new Panel();
        Panel leftPanel = new Panel();
        Panel rightPanel = new Panel();
        ComboBox comboBox = new ComboBox();
    }
}

