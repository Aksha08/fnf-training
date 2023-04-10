using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasics
{
    public delegate void ChangeNavPrice(object sender, PriceChangedEvent events);

    // Define a class for the event arguments
    public class PriceChangedEvent : EventArgs
    {
        public int Nav { get; set; }

        public PriceChangedEvent(int nav)
        {
            Nav = nav;
        }

    }

    // Define the Stock class as the event source
    public class MutualFunds
    {
        public event ChangeNavPrice PriceChanged;

        private int nav;

        public MutualFunds(int initialPrice)
        {
            nav = initialPrice;
        }

        public int Price
        {
            get { return nav; }
            set
            {
                nav = value;
                OnPriceChanged(new PriceChangedEvent(nav));
            }
        }

        protected virtual void OnPriceChanged(PriceChangedEvent events)
        {
            PriceChanged.Invoke(this, events);
        }
    }

    // Define the MarketWatch class as the event handler
    public class MarketInsights
    {
        private Random random = new Random();

        public void VaryPrice(MutualFunds stock)
        {
            int newPrice = random.Next(0, 1001);
            stock.Price = newPrice;
        }
    }

    // Define the Portfolio class as the event observer
    public class Dashboard
    {
        public void DisplayPriceStatus(object sender, PriceChangedEvent events)
        {
            if (events.Nav < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The nav Price is: " + events.Nav + " (Less than 40)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The nav price is: " + events.Nav + " (Greater than or equal to 40)");
            }
            Console.ResetColor();
        }
    }

    // Main program
    class stockmarket
    {
        static void Main(string[] args)
        {
            // Create instances of the classes
            MutualFunds stock = new MutualFunds(40);
            MarketInsights marketinsights = new MarketInsights();
            Dashboard dashboard = new Dashboard();

            // Register the event handler
            stock.PriceChanged += dashboard.DisplayPriceStatus;

            // Change the stock price randomly and see the portfolio display the status
            for (int i = 0; i < 100; i++)
            {
                marketinsights.VaryPrice(stock);
                Console.WriteLine("-----");
            }
        }
    }
}
