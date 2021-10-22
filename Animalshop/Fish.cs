using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animalshop
{
    public class Fish : Animal
    {
        public string fishType { get; set; }
        private bool waterType { get; set; }
        private bool eatOtherFish { get; set; }

        public Fish(string fishType, bool waterType, bool eatOtherFish, float price, int age, string sex)
        {
            this.fishType = fishType;
            this.waterType = waterType;
            this.eatOtherFish = eatOtherFish;

            this.price = price;
            this.age = age;
            this.sex = sex;
            this.Id = personId.ToString();
            personId++;
        }
    }
}