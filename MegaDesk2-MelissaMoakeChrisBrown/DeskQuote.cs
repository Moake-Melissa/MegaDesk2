using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2_MelissaMoakeChrisBrown
{
    class DeskQuote
    {
        public String CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public int RushDays { get; set; }
        public Desk Desk = new Desk();
        public decimal QuotePrice { get; set; }
        private int[,] RushDayPrices = new int[,] { { 60, 70, 80 }, { 40, 50, 60 }, { 30, 35, 40 } };

        private decimal SurfaceArea = 0;

        //Constrants go here
        private const int BASE_PRICE = 200;
        private const int BASE_SIZE_MAX = 1000;
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_SQUAREAREA = 1; // Apply for square area above the base_size_max
        private const int RUSH_OPTION_1 = 3;
        private const int RUSH_OPTION_2 = 5;
        private const int RUSH_OPTION_3 = 7;
        private const int RUSH_LARGE_SIZE = 2000; // Use to help with rush prices


        public DeskQuote(string name, DateTime quoteDate, decimal width, decimal depth, 
            int drawers, MaterialType material, int rushDays)
        {
            CustomerName = name;
            QuoteDate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.MaterialType = material;
            Desk.NumOfDrawers = drawers;
            RushDays = rushDays;

            SurfaceArea = Desk.Width * Desk.Depth;
        }

        public decimal CalculateQuoteTotal()
        {
            return BASE_PRICE + surfaceAreaCost() + DrawerCost() + (int)Desk.MaterialType + RushOrderCost();
        }

        private decimal surfaceAreaCost()
        {
            decimal extraSurfaceCost = 0;
            if (SurfaceArea > BASE_SIZE_MAX)
            {
                extraSurfaceCost = (SurfaceArea - BASE_SIZE_MAX) * PRICE_PER_SQUAREAREA;
               
            }
            return extraSurfaceCost;
        }

        private decimal DrawerCost()
        {
            return Desk.NumOfDrawers * PRICE_PER_DRAWER;
        }

        private int RushOrderCost()
        {
            int rushPrice = 0;

            switch (RushDays)
            {
                case RUSH_OPTION_1:
                    if (SurfaceArea < BASE_SIZE_MAX)
                    {
                        rushPrice = RushDayPrices[0, 0];
                    }
                    else if (SurfaceArea <= RUSH_LARGE_SIZE){
                        rushPrice = RushDayPrices[0, 1];
                    }
                    else
                    {
                        rushPrice = RushDayPrices[0, 2];
                    }
                break;

                case RUSH_OPTION_2:
                    if (SurfaceArea < BASE_SIZE_MAX)
                    {
                        rushPrice = RushDayPrices[1, 0];
                    }
                    else if (SurfaceArea <= RUSH_LARGE_SIZE)
                    {
                        rushPrice = RushDayPrices[1, 1];
                    }
                    else
                    {
                        rushPrice = RushDayPrices[1, 2];
                    }
                break;

                case RUSH_OPTION_3:
                    if (SurfaceArea < BASE_SIZE_MAX)
                    {
                        rushPrice = RushDayPrices[2, 0];
                    }
                    else if (SurfaceArea <= RUSH_LARGE_SIZE)
                    {
                        rushPrice = RushDayPrices[2, 1];
                    }
                    else
                    {
                        rushPrice = RushDayPrices[2, 2];
                    }
                break;
            }
            return rushPrice;
        }
    }
    
}
