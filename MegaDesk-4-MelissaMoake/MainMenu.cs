using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_MelissaMoake
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //Icons made by Smashicons: https://www.flaticon.com/authors/smashicons
        //from https://www.flaticon.com/ 
        //is licensed by CC 3.0 BY: http://creativecommons.org/licenses/by/3.0/

        private void openAddQuoteButton_Click(object sender, MouseEventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void openViewQuotesButton_Click(object sender, MouseEventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show(this);
            Hide();
        }

        private void openSearchAllQuotesButton_Click(object sender, MouseEventArgs e)
        {
            DeskQuoteView searchQuotesForm = new DeskQuoteView();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show(this);
            Hide();
        }

        private void exitMenuButton_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
