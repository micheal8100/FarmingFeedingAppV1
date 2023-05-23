using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmingFeedingAppV1
{
    class Program
    {
        static void Main(string[] args)
        {
            SheepManager SM = new SheepManager();
           
            string breed = SM.GetSheepBreeds()[2];
            int age = 10;
            List<int> FoodPerDay = new List<int>() {500, 900, 600, 530, 400, 600, 560 };

            if (SM.CheckAge(age))
            {
                if (SM.checkFoodPerDay(FoodPerDay))
                {
                    // frist sheep
                    SM.addSheep(new Sheep(age, breed, FoodPerDay));
                    Sheep testSheep1 = (new Sheep(age, breed, FoodPerDay));
                    Console.WriteLine(testSheep1.summary(SM.CostPerGram(), SM.NumberOfSheep(), SM.determineHealth(testSheep1.overWeeksFood())));
                    Console.WriteLine(SM.allSummary(SM.CostPerGram()));
                }
                else
                {
                    Console.WriteLine("ERROR: Your sheep couldn't of eating this much");
                }
            }
            else
            {
                Console.WriteLine("ERROR: Its imposable for a sheep to be this age");
            }

            

            Console.WriteLine();
        }
    }
}
