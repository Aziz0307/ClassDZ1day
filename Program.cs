using System;

namespace Class1dayDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.PrintInfo();
            Animal animal2 = new Animal(){  name="Doggie", age = 23, gender = "Male", weight = 40};
            animal2.PrintInfo();
            Animal animal3 = new Animal("Tom",48);
            animal3.PrintInfo();
        }
        public class Animal
        {
            public string name;
            private string type;
            public int age;
            public  string gender;
            public double weight;
            
            public Animal() { name = "Mavi"; type = "Cat"; age = 12; gender = "Male"; weight = 3.5;}
            public Animal(string n, int a)
            {
                name = n; type = "Dog"; age = a; gender = "Male"; weight = 3.5;
                
            }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, Type {type} Age: {age}, Gender: {gender}, Weight: {weight}");
        }
        }
    }
}