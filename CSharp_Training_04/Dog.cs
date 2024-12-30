using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    class Dog
    {
        public int NumberOfLegs { get; set; }
        public string Breed { get; set; }
        public Dog()
        {
        }
        public Dog(int number)
        {
            NumberOfLegs = number;
        }
        public void SetDogsBreed(string breed)
        {
            this.Breed = breed;
            Console.WriteLine("Reflection: breed: {0}", breed);
        }
        public void SetLegsNumber(int number)
        {
            this.NumberOfLegs = number;
        }
        public void Display()
        {
            Console.Write("Number of legs: {0}", NumberOfLegs);
            Console.WriteLine("Dog breed: {0}", Breed);
        }
    }
}
