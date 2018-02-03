using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_MelissaMoake
{
    public partial class DeskQuoteView : Form
    {
        public DeskQuoteView()
        {
            InitializeComponent();
            List<MaterialType> MaterialTypeList = Enum.GetValues(typeof(MaterialType))
                .Cast<MaterialType>().ToList();
            materialSearchBox.DataSource = MaterialTypeList;
        }

        private void cancelSearchQuotesButton_Click(object sender, MouseEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void searchByMaterial(object sender, EventArgs e)
        {
            searchResults.Items.Clear();
            MaterialType MaterialType;
            string searchInput = materialSearchBox.SelectedItem.ToString();
            Enum.TryParse(searchInput, out MaterialType);

            try
            {
                string cFile = @"quotes.txt";
                using (StreamReader sr = new StreamReader(cFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(MaterialType.ToString()))
                        {
                            searchResults.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "There is a problem");
            }
        }
    }
}
