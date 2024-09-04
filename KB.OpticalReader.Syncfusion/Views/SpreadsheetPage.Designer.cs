using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Spreadsheet;
namespace KB.OpticalReader.SyncfusionApp.Views
{
    partial class SpreadsheetPage
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
            spreadsheet = new Spreadsheet();
            SpreadsheetRibbon ribbon = new SpreadsheetRibbon() { Spreadsheet = spreadsheet };
            spreadsheet.Dock = DockStyle.Fill;
            spreadsheet.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            // Perform Filtering
            spreadsheet.AllowFiltering = true;
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Dock = System.Windows.Forms.DockStyle.Fill;;
            this.Controls.Add(spreadsheet);
            this.Controls.Add(ribbon);
            this.Text = "Form1";
        }
        private Spreadsheet spreadsheet;
        #endregion
    }
}
