using Newtonsoft.Json;
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

namespace MegaDesk2_MelissaMoakeChrisBrown
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            viewAllQuotesBox.View = View.Details;
            viewAllQuotesBox.Columns.Add("Name", -2, HorizontalAlignment.Left);
            viewAllQuotesBox.Columns.Add("Quote Date", -2, HorizontalAlignment.Left);
            viewAllQuotesBox.Columns.Add("Width", -2, HorizontalAlignment.Left);
            viewAllQuotesBox.Columns.Add("Depth", -2, HorizontalAlignment.Left);
            viewAllQuotesBox.Columns.Add("# of Drawers", -2, HorizontalAlignment.Left);
            viewAllQuotesBox.Columns.Add("Material Type", -2, HorizontalAlignment.Left);
            viewAllQuotesBox.Columns.Add("Rush Days", -2, HorizontalAlignment.Left);
            viewAllQuotesBox.Columns.Add("Quote Price", -2, HorizontalAlignment.Left);

            try
            {
                string cFile = @"quotes.json";
                using (StreamReader sr = new StreamReader(cFile))
                {
                    string line;
                    //string display;
                    while ((line = sr.ReadLine()) != null)
                    {
                        DeskQuote fromFile = JsonConvert.DeserializeObject<DeskQuote>(line);
                        //display = fromFile.CustomerName + ", " + fromFile.QuoteDate.ToString("dd MMMMM yyyy") + ", "
                        //+ fromFile.Desk.Width + ", " + fromFile.Desk.Depth + ", " + fromFile.Desk.NumOfDrawers + ", "
                        //+ fromFile.Desk.MaterialName + ", " + fromFile.RushDays + ", " + fromFile.QuotePrice;

                        viewAllQuotesBox.Items.Add(new ListViewItem(new[]
                            {
                                fromFile.CustomerName, fromFile.QuoteDate.ToString("dd MMMMM yyyy"), fromFile.Desk.Width.ToString(),
                                fromFile.Desk.Depth.ToString(), fromFile.Desk.NumOfDrawers.ToString(), fromFile.Desk.MaterialName, fromFile.RushDays.ToString(),
                                fromFile.QuotePrice.ToString()
                             }
                            ));
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
