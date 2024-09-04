using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KB.OpticalReader.SyncfusionApp.Models;
using KB.OpticalReader.SyncfusionApp.ViewModels;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.Input.Enums;
namespace KB.OpticalReader.SyncfusionApp.Views
{
    public partial class DataGridPage : UserControl
    {
        #region Constructor
        public DataGridPage()
        {
            InitializeComponent();
            var data = new EmployeeCollection();
            sfDataGrid.DataSource = data.EmployeeDetails;
            this.sfDataGrid.Columns.Add(new GridImageColumn() { MappingName = "EmployeeName", HeaderText = "Employee Name", ImageLayout = ImageLayout.None });
            this.sfDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Designation", HeaderText = "Designation" });
            this.sfDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Mail", HeaderText = "Mail" });
            this.sfDataGrid.Columns.Add(new GridImageColumn() { MappingName = "Location", TextImageRelation = TextImageRelation.ImageBeforeText, Width = 100 });
            this.sfDataGrid.Columns.Add(new GridTextColumn { MappingName = "Status", HeaderText = "Status" });
            this.sfDataGrid.Columns.Add(new GridImageColumn() { MappingName = "Trustworthiness", HeaderText = "Trustworthiness" }); 
            this.sfDataGrid.Columns.Add(new GridNumericColumn { MappingName = "Salary", HeaderText = "Salary", FormatMode = FormatMode.Currency });
            this.sfDataGrid.Columns.Add(new GridTextColumn() { MappingName = "Address", HeaderText = "Address" });
            this.sfDataGrid.Columns.Add(new GridProgressBarColumn() { MappingName = "SoftwareProficiency", HeaderText = "Software Proficiency", Maximum = 100, Minimum = 0, ValueMode = ProgressBarValueMode.Percentage });
            this.sfDataGrid.Style.ProgressBarStyle.ForegroundColor = Color.CadetBlue;
            sfDataGrid.QueryImageCellStyle += SfDataGrid_QueryImageCellStyle;
            sfDataGrid.QueryCellStyle += SfDataGrid_QueryCellStyle; 
        }
        private void SfDataGrid_QueryCellStyle(object sender, QueryCellStyleEventArgs e)
        {
            if (e.Column.MappingName == "Status")
            {
                if (e.DisplayText.ToString() == "Active")
                    e.Style.TextColor = Color.Green;
                else
                    e.Style.TextColor = Color.Red;
            }
        }
          private void SfDataGrid_QueryImageCellStyle(object sender, QueryImageCellStyleEventArgs e)
        {
            var employee = (Employee)e.Record;
            if (e.Column.MappingName == "Trustworthiness")
            {
                if (employee.Trustworthiness.ToString() == "Sufficient")
                {
                    e.Image = (Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+"Resources\\Sufficient.png"));
                    e.DisplayText = (e.Record as Employee).Trustworthiness.ToString();
                    e.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
                else if (employee.Trustworthiness.ToString() == "Insufficient")
                {
                    e.Image = (Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+"Resources\\Insufficient.png"));
                    e.DisplayText = (e.Record as Employee).Trustworthiness.ToString();
                    e.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
                else if (employee.Trustworthiness.ToString() == "Perfect")
                {
                    e.Image = (Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Perfect.png"));
                    e.DisplayText = (e.Record as Employee).Trustworthiness.ToString();
                    e.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
            }
            else if (e.Column.MappingName == "EmployeeName")
            {
                e.Image = employee.Gender == "1" ? (Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Male.png")) : (Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+"Resources\\Female.png"));
                e.DisplayText = (e.Record as Employee).EmployeeName.ToString();
                e.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            else
            {
                e.Image = (Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\location.png"));
                e.DisplayText = (e.Record as Employee).Location.ToString();
                e.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }
        #endregion
    }
}
