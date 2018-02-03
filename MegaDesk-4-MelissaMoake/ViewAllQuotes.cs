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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            try
            {
                string cFile = @"quotes.txt";
                using (StreamReader sr = new StreamReader(cFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                            viewAllQuotesBox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "There is a problem");
            }
        }

        private void cancelViewAllQuotesButton_Click(object sender, MouseEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
