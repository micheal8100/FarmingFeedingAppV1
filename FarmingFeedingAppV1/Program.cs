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
            bool alive = true;
            List<int> FoodPerDay = new List<int>() {500, 490, 600, 530, 400, 600, 560 };
            
            

            // frist sheep
            SM.addSheep(new Sheep(age, breed, FoodPerDay));
            Sheep testSheep1 = (new Sheep(age, breed, FoodPerDay));

            //secound sheep
            Sheep testSheep2 = (new Sheep(age, breed, FoodPerDay));
            SM.addSheep(new Sheep(age, breed, FoodPerDay));

            Console.WriteLine(testSheep1.summary(SM.CostPerGram(), SM.NumberOfSheep()));

            
            Console.WriteLine(testSheep2.summary(SM.CostPerGram(), SM.NumberOfSheep()));

            Console.WriteLine(SM.allSummary(SM.CostPerGram()));

            Console.WriteLine();
        }
    }
}
