﻿using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote Logic changed.");
        }
        
    }
    
}
