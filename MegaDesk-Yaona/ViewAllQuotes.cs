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
            Data = GetData();
            InitializeComponent();
        }

        private List<DataGridView> GetData()
        {
            var list = new List<DataGridView>();
            list.Add(new DataGridView()
            {
                Customer = ,
                DateOrdered =,
                Dimension =,
                Material =,
                Price = 
            }) ;

            return list;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var data = this.Data;
            
            MainMenu mainMenuForm = (MainMenu)Tag;
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
