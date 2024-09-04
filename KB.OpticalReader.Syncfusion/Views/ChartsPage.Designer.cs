using System.Drawing;
using KB.OpticalReader.SyncfusionApp.Models;
using KB.OpticalReader.SyncfusionApp.ViewModels;
using Syncfusion.Windows.Forms.Chart;
namespace KB.OpticalReader.SyncfusionApp.Views
{
    partial class ChartsPage
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
			SuspendLayout();
			// 
			// ChartsPage
			// 
			Name = "ChartsPage";
			Size = new Size(1856, 857);
			ResumeLayout(false);
		}
		#endregion
		private Syncfusion.Windows.Forms.Chart.ChartControl columnChart;
    }
}
