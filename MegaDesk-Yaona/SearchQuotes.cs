using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Yaona
{
    public partial class SearchQuotes : Form
    {
   
        public SearchQuotes()
        {
            InitializeComponent();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = (MainMenu)Tag;
            mainMenuForm.Show();
            this.Hide();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            // List for surface materials
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            searchMaterialComboBox.DataSource = materials;

            // Initialize datagridview
            populateDataGridView();

        }

        private void populateDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Customer");
            dt.Columns.Add("Date");
            dt.Columns.Add("Specifications");
            dt.Columns.Add("Quote Price");
            dt.Columns.Add("Material");

            foreach (DeskQuote quote in FileManager.quotesList)
            {
                dt.Rows.Add(new object[] { quote.customerName, quote.date, quote.desk.width + "in x " + quote.desk.depth + "in", quote.totalCost, quote.desk.material.ToString() });
            }

            searchQuoteDataGridView.DataSource = dt;
        }



        private void searchMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Customer");
            dt.Columns.Add("Date");
            dt.Columns.Add("Specifications");
            dt.Columns.Add("Quote Price");
            dt.Columns.Add("Material");

            foreach (DeskQuote quote in FileManager.quotesList)
            {
                if (quote.desk.material.ToString() == searchMaterialComboBox.SelectedItem.ToString())
                {
                    dt.Rows.Add(new object[] { quote.customerName, quote.date, quote.desk.width + "in x " + quote.desk.depth + "in", quote.totalCost, quote.desk.material.ToString() });
                }
                
            }
            searchQuoteDataGridView.DataSource = dt;

            
        }
    }
}
