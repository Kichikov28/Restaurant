namespace Restaurant.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Microsoft.EntityFrameworkCore.Query.Internal;
    using Restaurant.Services;
    
    public class Program
    {
        static void Main()
        {
            // Engine engine= new Engine();
            List<int> items = new List<int>() { 20, 30, 40, 50 };
            OrderService os = new OrderService();
            string releaseDate = "09-09-2020";
            DateTime date = new DateTime();
          
        }
    }
}
