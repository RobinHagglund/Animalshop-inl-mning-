using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animalshop
{
    public class Bird : Animal
    {
        public string birdType { get; set; }
        private bool canFly { get; set; }
        private bool mustHaveFriend { get; set; }
        public Bird(string birdType, bool canFly, bool mustHaveFriend, float price, int age, string sex)
        {
            this.birdType = birdType;
            this.canFly = canFly;
            this.mustHaveFriend = mustHaveFriend;

            this.price = price;
            this.age = age;
            this.sex = sex;
            this.Id = personId.ToString();
            personId++;
        }
    }
}