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
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = (MainMenu) Tag;
            mainMenuForm.Show();
            this.Hide();
        }

        private void widthTextbox_Validating(object sender, CancelEventArgs e)
        {
            int width;
            bool isNum = int.TryParse(widthTextbox.Text, out width);
            if (!isNum || width > 96 || width < 24) 
            {
                e.Cancel = true;
                widthTextbox.Focus();
                errorProvider1.SetError(widthTextbox, "Please enter a number between 24 and 96");
            } else
            {
                e.Cancel = false;
                errorProvider1.SetError(widthTextbox, null);
            }
        }

        private void depthTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
                if ((!Char.IsControl(e.KeyChar) && Char.IsDigit(e.KeyChar)) || e.KeyChar == (Char)Keys.Back)
                {
                    e.Handled = false;
                    errorProvider1.SetError(depthTextbox, null);
                    errorProvider1.Clear();
                } else
                {
                    e.Handled = true;
                    errorProvider1.SetError(depthTextbox, "Please enter numbers only.");
                    depthTextbox.Text = "";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void depthTextbox_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(depthTextbox.Text, out int depth);
            if ( depth < 12 || depth > 48)
            {
                e.Cancel = true;
                depthTextbox.Focus();
                errorProvider1.SetError(depthTextbox, "Please enter a number between 12 and 48");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(depthTextbox, null);
            }
        }

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextbox.Text;
            int width = int.Parse(widthTextbox.Text);
            int depth = int.Parse(depthTextbox.Text);
            int drawers = Convert.ToInt32(Math.Round(drawersNumberInput.Value, 0));
            // string material = surfaceMaterialTextbox.Text;
            string material = desktopMaterialComboBox.SelectedItem.ToString();

            bool is_rush = rushCheckbox.Checked;
            int days;
            if (is_rush)
            {
                days = int.Parse(rushOrderDaysTextbox.Text);
            } else
            {
                days = 0;
            }
            

            Desk desk = new Desk(width, depth, drawers, material);
            DeskQuote quote = new DeskQuote(customerName, desk, is_rush, days);

            DisplayQuote displayQuoteForm = new DisplayQuote(quote);
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            this.Hide();

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            // List for surface materials
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            desktopMaterialComboBox.DataSource = materials;
        }
    }
}
