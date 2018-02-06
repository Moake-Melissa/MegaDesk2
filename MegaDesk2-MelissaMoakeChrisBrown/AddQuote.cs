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
    public partial class AddQuote : Form
    {
        #region Declarations

        string CustomerName = String.Empty;
        decimal DeskWidth = 0;
        decimal DeskDepth = 0;
        int Drawers = 0;
        MaterialType MaterialType;
        string RushOrderInput = String.Empty;
        int RushOrderDays = 0;
        decimal DeskQuotePrice = 0;

        #endregion

        public AddQuote()
        {
            InitializeComponent();

            //Create list of Material Types from Enum
            List<MaterialType> MaterialTypeList = Enum.GetValues(typeof(MaterialType))
                .Cast<MaterialType>().ToList();
            materialTypeBox.DataSource = MaterialTypeList;
            materialTypeBox.Text = "Select an Option...";
        }

        private void AddQuote_FormClosed(Object sender, FormClosedEventArgs e)
        {
            var ReturnMainMenu = (MainMenu)Tag;
            ReturnMainMenu.Show();
            this.Close();
        }

        private void cancelQuoteButton_Click(object sender, MouseEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        //Validating width and depth

        private void width_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(width.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                width.Select(0, width.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.widthErrorProvider.SetError(width, errorMsg);
                width.BackColor = Color.LightCoral;
            }
        }

        private void width_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            widthErrorProvider.SetError(width, "");
            width.BackColor = default(Color);
        }

        private void depth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepth(depth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                depth.Select(0, depth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.depthErrorProvider.SetError(depth, errorMsg);
                depth.BackColor = Color.LightCoral;
            }
        }

        private void depth_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            depthErrorProvider.SetError(depth, "");
            depth.BackColor = default(Color);
        }

        public bool ValidWidth(string width, out string errorMessage)
        {
            // Confirm that the width field is not empty.
            if (width.Length == 0)
            {
                errorMessage = "Width is required.";
                return false;
            }

            // check that the width is between 24 and 96 inches
            if (Convert.ToDecimal(width) >= Desk.MIN_WIDTH &&
                Convert.ToDecimal(width) <= Desk.MAX_WIDTH)
            {
                errorMessage = "";
                return true;

            }

            errorMessage = "Width must be between " + Desk.MIN_WIDTH +
                 " inches and " + Desk.MAX_WIDTH + " inches.";
            return false;
        }

        public bool ValidDepth(string depth, out string errorMessage)
        {
            // Confirm that the width field is not empty.
            if (depth.Length == 0)
            {
                errorMessage = "Depth is required.";
                return false;
            }

            // check that the width is between 24 and 96 inches
            if (Convert.ToDecimal(depth) >= Desk.MIN_DEPTH &&
                Convert.ToDecimal(depth) <= Desk.MAX_DEPTH)
            {
                errorMessage = "";
                return true;

            }

            errorMessage = "Depth must be between " + Desk.MIN_DEPTH +
                " inches and " + Desk.MAX_DEPTH + " inches.";
            return false;
        }

        private void charValidation(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        //End Validation


        private void AddDeskQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerName = customerName.Text;
                DeskWidth = decimal.Parse(width.Text);
                DeskDepth = decimal.Parse(depth.Text);
                Drawers = int.Parse(numOfDrawers.SelectedItem.ToString());

                string Material = materialTypeBox.SelectedItem.ToString();
                Enum.TryParse(Material, out MaterialType);

                //rush order selection
                RushOrderInput = rushOptions.SelectedItem.ToString();

                switch (RushOrderInput)
                {
                    case "3 Days":
                        RushOrderDays = 3;
                        break;
                    case "5 Days":
                        RushOrderDays = 5;
                        break;
                    case "7 Days":
                        RushOrderDays = 7;
                        break;
                    default:
                        RushOrderDays = 0;
                        break;
                }

                DeskQuote NewOrder = new DeskQuote(CustomerName, DateTime.Now, DeskWidth, 
                    DeskDepth, Drawers, MaterialType, RushOrderDays);
                DeskQuotePrice = NewOrder.CalculateQuoteTotal();
                DeskQuotePrice = Math.Round(DeskQuotePrice, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check input methods");
            }

            string QuoteDate = DateTime.Now.ToString("dd MMMMM yyyy");
            //save to a file
            try
            {
                var DeskRecord = CustomerName + ", " + QuoteDate + ", " + DeskWidth + ", " + DeskDepth
                    + ", " + Drawers + ", " + MaterialType + ", " + RushOrderDays + ", " + DeskQuotePrice;
                string cFile = @"quotes.txt";
                if (!File.Exists(cFile))
                {
                    using (StreamWriter sw = File.CreateText(cFile))
                    {
                    }
                }
                using (StreamWriter sw = File.AppendText(cFile))
                {
                    sw.WriteLine(DeskRecord);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "There is a problem");
            }

            //Show quote into on new page
            var MainMenu = (MainMenu)Tag;
            DisplayQuote newOrderView = new DisplayQuote(CustomerName, QuoteDate, DeskWidth,
                DeskDepth, Drawers, MaterialType, RushOrderDays, DeskQuotePrice)
            {
                Tag = MainMenu
            };
            newOrderView.Show();
            this.Close();
        }


        

    }
}
