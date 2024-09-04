using System.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
namespace KB.OpticalReader.SyncfusionApp.Views
{
    partial class DataGridPage
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
            this.sfDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid
            // 
            this.sfDataGrid.AccessibleName = "Table";
            this.sfDataGrid.AllowDraggingColumns = true;
            this.sfDataGrid.AllowSorting = true;
            this.sfDataGrid.AllowFiltering = true;
            this.sfDataGrid.AllowEditing  = true;
            this.sfDataGrid.AllowGrouping = true;
            this.sfDataGrid.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.sfDataGrid.AllowResizingColumns = true;
            this.sfDataGrid.AllowResizingHiddenColumns = true;
            this.sfDataGrid.AutoGenerateColumns = false;
            this.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.sfDataGrid.BackColor = System.Drawing.SystemColors.Window;
            this.sfDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid.RowHeight = (int)DpiAware.LogicalToDeviceUnits(21.0f);
            this.sfDataGrid.Name = "sfDataGrid";
            this.sfDataGrid.ShowGroupDropArea = true;
            this.sfDataGrid.Size = new System.Drawing.Size(900, 400);
            this.sfDataGrid.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(this.sfDataGrid);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Getting Started";
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid)).EndInit();
            this.ResumeLayout(false); 
        }
        #endregion
        private SfDataGrid sfDataGrid;
    }
}
