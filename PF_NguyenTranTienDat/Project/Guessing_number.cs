using System;
using System.Collections.Generic;

namespace PriceGuessingGame
{
    class Program
    {
        // A sample product structure
        public class Product
        {
            public string Name { get; set; }
            public decimal ListedPrice { get; set; }
            public decimal SalePrice { get; set; }
            public DateTime SaleStartTime { get; set; }
            public TimeSpan SaleDuration { get; set; }
            public bool IsAvailable { get; set; }
        }

        // Buyer and ticket information
        public class Buyer
        {
            public string Name { get; set; }
            public string TicketType { get; set; } // Standard, Silver, Gold
            public int GuessLimit { get; set; }
            public bool HintAvailable { get; set; }
            public decimal TicketPrice { get; set; }
            public bool GiftEligible { get; set; }
        }

        //static void Main(string[] args)
        //{
        //    // Sample product for the game
        //    Product product = new Product
        //    {
        //        Name = "Smartphone",
        //        ListedPrice = 1000,
        //        SalePrice = 800, // Sale Price set to meet 10% minimum discount
        //        SaleStartTime = DateTime.Now.AddHours(1),
        //        SaleDuration = TimeSpan.FromHours(2),
        //        IsAvailable = true
        //    };

        //    // Seller rule validation
        //    if (product.ListedPrice > 1100) // Cannot exceed 10% of market price
        //    {
        //        Console.WriteLine("Listed price exceeds 10% of market price. Cannot start the game.");
        //        return;
        //    }

        //    Console.WriteLine("Welcome to the Price Guessing Game!");
        //    Console.WriteLine($"Product: {product.Name}, Listed Price: {product.ListedPrice:C}");
        //    Console.WriteLine($"Game starts at {product.SaleStartTime} and lasts for {product.SaleDuration}.");

        //    // Buyer ticket selection and settings
        //    Console.Write("Choose your ticket type (Standard, Silver, Gold): ");
        //    string ticketType = Console.ReadLine();
        //    Buyer buyer = ConfigureTicket(ticketType, product);

        //    if (buyer == null)
        //    {
        //        Console.WriteLine("Invalid ticket type. Exiting.");
        //        return;
        //    }

        //    // Game Loop for guessing
        //    decimal guessedPrice;
        //    int attempts = 0;

        //    while (attempts < buyer.GuessLimit)
        //    {
        //        Console.WriteLine($"\nAttempt {attempts + 1}/{buyer.GuessLimit}. Enter your guessed price:");
        //        guessedPrice = decimal.Parse(Console.ReadLine());

        //        if (guessedPrice == product.SalePrice)
        //        {
        //            Console.WriteLine("Congratulations! You guessed the price correctly!");
        //            if (buyer.GiftEligible)
        //                Console.WriteLine("You also win a gift as a Gold ticket holder!");
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Incorrect guess.");
        //            if (buyer.HintAvailable)
        //            {
        //                Console.WriteLine($"Hint: The price is {(guessedPrice < product.SalePrice ? "higher" : "lower")} than your guess.");
        //            }
        //        }

        //        attempts++;
        //        if (attempts == buyer.GuessLimit)
        //        {
        //            Console.WriteLine("You've used all your guesses. Game over.");
        //        }
        //    }
        //}

        //// Configures ticket-specific properties
        //public static Buyer ConfigureTicket(string ticketType, Product product)
        //{
        //    Buyer buyer = new Buyer { TicketType = ticketType };

        //    switch (ticketType.ToLower())
        //    {
        //        case "standard":
        //            buyer.GuessLimit = 3;
        //            buyer.TicketPrice = product.ListedPrice * 0.05m;
        //            buyer.HintAvailable = false;
        //            buyer.GiftEligible = false;
        //            break;

        //        case "silver":
        //            buyer.GuessLimit = 4;
        //            buyer.TicketPrice = product.ListedPrice * 0.07m;
        //            buyer.HintAvailable = true;
        //            buyer.GiftEligible = false;
        //            break;

        //        case "gold":
        //            buyer.GuessLimit = 5;
        //            buyer.TicketPrice = product.ListedPrice * 0.10m;
        //            buyer.HintAvailable = true;
        //            buyer.GiftEligible = true;
        //            break;

        //        default:
        //            return null;
        //    }

        //    Console.WriteLine($"Ticket Type: {buyer.TicketType}");
        //    Console.WriteLine($"Ticket Price: {buyer.TicketPrice:C}");
        //    Console.WriteLine($"Guess Limit: {buyer.GuessLimit}");
        //    if (buyer.HintAvailable) Console.WriteLine("Hint: Available");
        //    if (buyer.GiftEligible) Console.WriteLine("Gift Eligibility: Yes");

        //    return buyer;
        //}
    }
}
