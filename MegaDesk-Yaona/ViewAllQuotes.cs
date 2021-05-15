using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Yaona
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = (MainMenu)Tag;
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
