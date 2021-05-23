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
        
        private FileManager filemanager;

        public SearchQuotes()
        {
            InitializeComponent();

            // Read data from json file
            filemanager.ReadFile();
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
        }
    }
}
