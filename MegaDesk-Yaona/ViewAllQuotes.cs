using System;
using System.Collections.Generic;
using System.Threading.Channels;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Yaona
{
    public partial class ViewAllQuotes : Form
    {
        public List<DataGridView> Data { get; set; }
        public ViewAllQuotes()
        {
            InitializeComponent();
            populateDataGridView();

            // Make quote details blank
            viewQuoteCustomerNameLabel.Text = "";
            viewQuoteCostLabel.Text = "";
            viewQuoteRushDaysLabel.Text = "";
            viewQuoteSpecsLabel.Text = "";
            viewQuoteMaterialLabel.Text = "";

        }

        private void populateDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Customer");
            dt.Columns.Add("Date");
            dt.Columns.Add("Specifications");
            dt.Columns.Add("Quote Price");

            foreach(DeskQuote quote in FileManager.quotesList)
            {
                dt.Rows.Add(new object[] { quote.customerName, quote.date, quote.desk.width + "in x " + quote.desk.depth + "in", quote.totalCost });
            }

            viewQuotesGrid.DataSource = dt;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var data = this.Data;
            
            MainMenu mainMenuForm = (MainMenu)Tag;
            mainMenuForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

        }

        private void viewQuotesGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (viewQuotesGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = viewQuotesGrid.SelectedRows[0];
                // Show quote details 
                viewQuoteCustomerNameLabel.Text = selectedRow.Cells[0].Value.ToString();
                viewQuoteCostLabel.Text = selectedRow.Cells[3].Value.ToString();
                viewQuoteDateLabel.Text = selectedRow.Cells[1].Value.ToString();
                viewQuoteSpecsLabel.Text = selectedRow.Cells[2].Value.ToString();
            }
            

        }
    }
}
