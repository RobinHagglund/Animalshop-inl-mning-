using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animalshop
{
    public class Snake : Animal
    {
        public string snakeType { get; set; }
        private bool isVenom { get; set; }
        private bool isAgressive { get; set; }

        public Snake(string snakeType, bool isVenom, bool isAgressive, float price, int age, string sex)
        {
            this.snakeType = snakeType;
            this.isVenom = isVenom;
            this.isAgressive = isAgressive;

            this.price = price;
            this.age = age;
            this.sex = sex;
            this.Id = personId.ToString();
            personId++;

        }
    }
}