using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Calculate;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
namespace KB.OpticalReader.SyncfusionApp.Views
{
    public partial class SpreadsheetPage : UserControl
    {
        public SpreadsheetPage()
        {
            InitializeComponent();
            spreadsheet.WorkbookLoaded += Spreadsheet_WorkbookLoaded;
        }
        private void Spreadsheet_WorkbookLoaded(object sender, Syncfusion.Windows.Forms.Spreadsheet.Helpers.WorkbookLoadedEventArgs args)
        {
            for (int row = 1; row <= 20; row++)
            {
                for (int col = 1; col <= 25; col++)
                {
                    var range = spreadsheet.ActiveSheet.Range[row, col];
                    int value = row * col;
                    spreadsheet.ActiveGrid.SetCellValue(range, value.ToString());
                }
            }
            // Performing Selection
            spreadsheet.ActiveGrid.AllowSelection = true;
            spreadsheet.ActiveGrid.AllowEditing = true;
            //To Freeze 4 rows and 4 columns
			spreadsheet.ActiveGrid.FrozenRows = 3;
            spreadsheet.ActiveGrid.FrozenColumns = 2;
            //To hide the Header cells visibility
            spreadsheet.SetRowColumnHeadersVisibility(true);
        }
    }
}
