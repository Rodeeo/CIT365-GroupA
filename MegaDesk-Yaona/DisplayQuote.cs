using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Yaona
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();

            Desk desk = deskQuote.getDesk();
            quoteNameLabel.Text = deskQuote.customerName;
            dateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            dimensionsLabel.Text = desk.width + "in x " + desk.depth + "in";
            materialLabel.Text = desk.material.ToString();
            priceLabel.Text = String.Format("{0:C}",deskQuote.getTotalCost());

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = (AddQuote) Tag;
            addQuoteForm.Show();
            this.Hide();
        }
    }
}
