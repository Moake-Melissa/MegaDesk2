using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2_MelissaMoakeChrisBrown
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string customerName, string quoteDate, decimal width, decimal depth, int drawers, MaterialType material,
            int rushOptions, decimal quotePrice)
        {
            InitializeComponent();

            customerNameSpot.Text = customerName;
            quoteDateSpot.Text = quoteDate;
            widthSpot.Text = width.ToString() + " inches";
            depthSpot.Text = depth.ToString() + " inches";
            numOfDrawersSpot.Text = drawers.ToString();
            materialTypeSpot.Text = material.ToString();
            if (rushOptions == 0)
            {
                rushOrderSpot.Text = "none";
            }
            else
            {
                rushOrderSpot.Text = rushOptions.ToString() + " Days";
            }
            quotePriceSpot.Text = "$" + quotePrice.ToString();
        }

        private void closeQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
