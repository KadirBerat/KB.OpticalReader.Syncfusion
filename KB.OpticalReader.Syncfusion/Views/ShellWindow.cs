using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KB.OpticalReader.SyncfusionApp.Contracts.Services;
using KB.OpticalReader.SyncfusionApp.Contracts.Views;

using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.WinForms.Controls;

namespace KB.OpticalReader.SyncfusionApp.Views
{
    public partial class ShellWindow : SfForm,IShellWindow
    {
        private INavigationService navigationService;
        public ShellWindow(INavigationService navigation)
        {
            InitializeComponent();
            navigationService=navigation;
        }
         public void CloseWindow()
        {
           
        }

        public Panel GetNavigationFrame()
            => this.leftPanel;

        public void ShowWindow()
            => Show();

        private void MainFrameBarManager1_ItemClicked(object sender, BarItemClickedEventArgs args)
        {
            if (args != null)
            {
                navigationService.NavigateTo(args.ClickedBarItem.Text);
            }
        }
	
	private void ShellWindow_Resize(object sender, System.EventArgs e)
        {
            if (this.leftPanel.Controls.Count > 0)
            {
                var selectedControl = this.leftPanel.Controls[0];
                if (selectedControl != null)
                {
                    int x = (this.leftPanel.Width - selectedControl.Width) / 2;
                    int y = (this.leftPanel.Height - selectedControl.Height) / 2;
                    selectedControl.Location = new System.Drawing.Point(x, y);
                }
            }
        }	

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
