using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmingFeedingAppV1
{
    class Sheep
    {
        //attributes or fields
        private int age;
        private string breed;
        private string id;
        //List for the total food over a week per day 
        private List<int> FoodPerDay = new List<int>();

        //constructor - cronstructs an object of this class
        public Sheep(int age, string breed, List<int> FoodPerDay)
        {
            this.age = age;
            this.breed = breed;
            this.FoodPerDay = FoodPerDay;
        }

        // Returns the value in the private age varible
        public int getAge()
        {
            return this.age;
        }
        // returns the value in the breed variable
        public string getBreed()
        {
            return this.breed;
        }
        // creates an ID 
        public string idGenorater(int NumberOfSheep)
        {
            id = breed.Substring(0, 2).ToUpper() + NumberOfSheep + $"#{age}";
            return id;
        }
        //based on foodPerDay List Determines if a sheep is healthy
        public string determineHealth()
        {
            if (overWeeksFood() > 4500)
            {
                return "Eating to much food";
            }
            else if (overWeeksFood() < 2100)
            {
                return "Eating to little food";
            }
            else
            {
                return "Eating average food"; 
            } 
            
        }
        // returns total food over the week
        public float overWeeksFood()
        {
            float OverWeek = 0;
            for (int i = 0; i < FoodPerDay.Count; i++)
            {
                OverWeek += FoodPerDay[i];
            }
            return OverWeek;
        }
        //Creates a Food Summary for the week
        public string foodSum()
        {
            string foodSum = "";
            for (int i = 0; i < FoodPerDay.Count; i++)
            {
                foodSum += $"Day {i + 1}: {FoodPerDay[i]}g\n";
            }
            return foodSum;
        }
        // creats a summary of the cost per sheep
        public float costSum(float costPerGram)
        { 
            return (float)Math.Round((overWeeksFood() * costPerGram), 2);
        }
        //Creates a over all food and Cost summary
        public string summary(float costPerGram, int NumberOfSheep)
        {
            return "Breed: "+breed + "\n" + "ID: " + idGenorater(NumberOfSheep) + "\n" + determineHealth() + "\n\n" + foodSum() + "\n" +
               "Total Food Consumed: " + overWeeksFood() + "\nCost: $" + costSum(costPerGram) + "\n";
        }
        public override string ToString()
        {
            return "";
        }
    }
}
