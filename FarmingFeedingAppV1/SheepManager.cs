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

            foreach (Sheep sheep in sheeps )
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

        // returns a cost sumary for all breeds and runs the  CalculattotalCostPerBreed() method
        public string allBreedCostSum(float costPerGram)
        {
            
            string breedSum ="";

            for (int i = 0; i < sheepBreeds.Count; i++)
            {
                breedSum += $"{sheepBreeds[i]}: ${CalculattotalCostPerBreed(costPerGram)[i]}\n";
            }

            return breedSum;
        }
        public float overAllCost(float costPerGram)
        {
            float totalCost = 0;
            foreach (float breedCost in CalculattotalCostPerBreed(costPerGram))
            {
                totalCost += breedCost;
            }
            return totalCost;
        }
        // Retruns a sumary of all added sheep and adds the 
        public string allSummary(float costPerGram)
        {
            return "Weekly Feeding Cost Summary\n\n" + allBreedCostSum(costPerGram);
        }
    }
}
