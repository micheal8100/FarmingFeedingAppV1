using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmingFeedingAppV1
{
    class SheepManager
    {

        // All Sheep Breeds My Program Acounts For
        private List<string> sheepBreeds = new List<String>() { "Australian whites NZ", "Border Leicester", "Charollais"
            , "Corriedale", "Awassi" };

        //grain cost per 20kg
        private float grainCost = 30;

        // list of all animals 
        private List<Sheep> sheeps = new List<Sheep>();



        //constructor - cronstructs an object of this class
        public SheepManager()
        {

        }
        // Check Age 0 < x > 40
        public bool CheckAge(int age)
        {
            if (age > 0 && age < 30)
            {
                return true;
            }
            return false;
        }
        //based on foodPerDay List Determines if a sheep is healthy
        public string determineHealth(float overWeeksFood)
        {
            if (overWeeksFood > 4500)
            {
                return "Eating to much food";
            }
            else if (overWeeksFood < 2100)
            {
                return "Eating to little food";
            }
            else
            {
                return "Eating average food";
            }

        }
        // checks to see if any value out of the range 
        public bool checkFoodPerDay(List<int> foodPerDay)
        {
            for (int i = 0; i < 6; i++)
            {
                if (foodPerDay[i] >= 0 && foodPerDay[i] < 5000)
                {
                    
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
        // return sheepbreed list
        public List<string> GetSheepBreeds()
        {
            return sheepBreeds;
        }
        // calculates the cost per 1g
        public float CostPerGram()
        {
            return grainCost / 20000;
        }
        // adds Sheep To The List Sheep list and runs the CalculattotalCostPerBreed() method
        public void addSheep(Sheep Sheep)
        {
            sheeps.Add(Sheep);
        }
        // populates the weeklyCostPerBreed list with the cost per breed 
        public List<float> CalculattotalCostPerBreed(float costPerGram)
        {
            List<float> weeklyCostPerBreed = new List<float>() { 0, 0, 0, 0, 0 };
            int sheepCount = 0;

            foreach (Sheep sheep in sheeps)
            {
                for (int i = 0; i < sheepBreeds.Count(); i++)
                {
                    if (sheeps[sheepCount].getBreed() == sheepBreeds[i])
                    {
                        weeklyCostPerBreed[i] += sheeps[sheepCount].costSum(costPerGram);
                    }
                }
                sheepCount++;
            }
            return weeklyCostPerBreed;
        }

        // counts the number of sheep in order to give a number on the id
        public int NumberOfSheep()
        {
            return sheeps.Count();
        }

        // returns a cost sumary for all breeds 
        public string allBreedCostSum(float costPerGram)
        {
            
            string breedSum ="";

            for (int i = 0; i < sheepBreeds.Count; i++)
            {
                breedSum += $"{sheepBreeds[i]}: ${CalculattotalCostPerBreed(costPerGram)[i]}\n";
            }

            return breedSum;
        }
        // calculates the over cost for all sheep
        public float overAllCost(float costPerGram)
        {
            float totalCost = 0;
            foreach (float breedCost in CalculattotalCostPerBreed(costPerGram))
            {
                totalCost += breedCost;
            }
            return totalCost;
        }
        // Retruns a overall sumary of all added sheep
        public string allSummary(float costPerGram)
        {
            return "Weekly Feeding Cost Summary\n\n" + allBreedCostSum(costPerGram) + "\nOverall Cost: $" + overAllCost(costPerGram);
        }
    }
}
