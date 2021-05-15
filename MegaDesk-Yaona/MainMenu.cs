﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Yaona
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddNewQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Tag = this;
            addQuoteForm.Show(this);
            this.Hide();
        }

        private void ViewQuotesBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show(this);
            this.Hide();
        }

        private void SearchQuotesBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show(this);
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
