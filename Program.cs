using System;
using UrbanPlanner.Buildings;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            var TwentyOneEight = new Building("21 8th Ave North");
            TwentyOneEight.Width = 100;
            TwentyOneEight.Depth = 300;
            TwentyOneEight.Stories = 4;

            TwentyOneEight.Construct();
            TwentyOneEight.Purchase("Matt");
        }
    }
}
