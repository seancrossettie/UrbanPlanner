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


            var ThirtyFiveTwentyOne = new Building("35 21st Ave S");
            ThirtyFiveTwentyOne.Width = 500;
            ThirtyFiveTwentyOne.Depth = 30;
            ThirtyFiveTwentyOne.Stories = 2;

            ThirtyFiveTwentyOne.Construct();
            ThirtyFiveTwentyOne.Purchase("Jack");
        }
    }
}
