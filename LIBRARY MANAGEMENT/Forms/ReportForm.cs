using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRARY_MANAGEMENT.Data;
using LIBRARY_MANAGEMENT.Models;
using ClosedXML.Excel;


namespace LIBRARY_MANAGEMENT.Forms
{
    public partial class ReportForm : Form
    {
        private readonly LibraryDbContext _context;
        public ReportForm()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            FillOrderReport();
        }

        private void FillOrderReport()
        {
            var ShowReport = _context.Orders
                                            .Include("Books")
                                            .Include("Customers")
                                            .Where(r => r.Status != false)
                                            .ToList();

            foreach (var item in ShowReport)
            {
                DgvReport.Rows.Add(item.Id,
                                         item.Customers.Name,
                                         item.Customers.Surname,
                                         item.Books.Name,
                                         item.BookCount,
                                         item.OrderTime.ToString("dd.MM.yyyy"),
                                         item.DeadLine.ToString("dd.MM.yyyy"),
                                         item.ReturnTime.ToString("dd.MM.yyyy"),
                                         item.TotalPrice);
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var StartDate = DtpStart.Value.Date;
            var EndaDate = DtpEnd.Value.Date;
            DgvReport.Rows.Clear();
            var ShowReport = _context.Orders
                                            .Include("Books")
                                            .Include("Customers")
                                            .ToList();

            foreach (var item in ShowReport)
            {
                if (item.Status == true && StartDate <= item.ReturnTime && item.ReturnTime <= EndaDate)
                {
                    DgvReport.Rows.Add(item.Id,
                                         item.Customers.Name,
                                         item.Customers.Surname,
                                         item.Books.Name,
                                         item.BookCount,
                                         item.OrderTime.ToString("dd.MM.yyyy"),
                                         item.DeadLine.ToString("dd.MM.yyyy"),
                                         item.TotalPrice,
                                         item.ReturnTime.ToString("dd.MM.yyyy"));
                }
            }


        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (DgvReport.Rows.Count > 0)
            {

                try
                {

                    var workbook = new XLWorkbook();
                    var workSheet = workbook.Worksheets.Add("Hesabat sheet");
                    for (int i = 1; i < DgvReport.Columns.Count; i++)
                    {
                        workSheet.Cell(1, i).SetValue(DgvReport.Columns[i].HeaderText);
                        workSheet.Column(i).Width = 15;
                    }
                    for (int i = 1; i < DgvReport.Columns.Count - 1; i++)
                    {
                        for (int j = 1; j < DgvReport.Columns.Count; j++)
                        {
                            workSheet.Cell(i + 2, j).SetValue(DgvReport.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    workbook.SaveAs(@"C:\Users\Hilal\Desktop\Excell.xlsx");
                    MessageBox.Show("Excell waas created");
                }
                catch (System.IO.IOException)
                {

                    MessageBox.Show("Bu fayl açıqdı, zəhmət olmasa faylı bağlıyannan sonra bir daha təkrar edin");
                    return;
                }

            }
        }
    }
}
