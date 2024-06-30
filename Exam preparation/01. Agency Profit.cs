using System;

namespace AgencyProfit {
    class Program {
        static void Main(string[] args) {
            string companyName = Console.ReadLine();
            int adultTicketsNumber = int.Parse(Console.ReadLine());
            int kidsTicketsNumber = int.Parse(Console.ReadLine());
            double adultTicketPrice = double.Parse(Console.ReadLine());
            double serviceFeeCost = double.Parse(Console.ReadLine());

            double priceKids = (adultTicketPrice * 0.3) + serviceFeeCost;   
            double priceAdult = adultTicketPrice + serviceFeeCost;         

            double totalPrice = ((adultTicketsNumber * priceAdult) + (kidsTicketsNumber * priceKids)) * 0.2; 

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {totalPrice:F2} lv."); 
        }
    }
}
