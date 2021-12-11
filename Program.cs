using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal name1 = new Animal("Джейран", "А", "Азiя", 30000);
            Animal name2 = new Animal("Гну", "В", "Африка", 560000);
            Animal name3 = new Animal("Бейза", "Н", "Африка", 2500);
            Console.WriteLine("Назва     Група    Житло    Численнiсть популяцiї");
            Console.WriteLine(name1.Details());
            Console.WriteLine(name2.Details());
            Console.WriteLine(name3.Details());
        }
    }

    class Animal
    {
        public string name { get; set; }

        public string group { get; set; }

        public string house { get; set; }

        public double population { get; set; }

    public Animal (Animal previousAnimal)
        {
            name = previousAnimal.name;
            group = previousAnimal.group;
            house = previousAnimal.house;
            population = previousAnimal.population;
        }

        public Animal(string Name, string Group, string House, double Population)
        {
            name = Name;
            group = Group;
            house = House;
            population = Population;
        }

        public string Details()
        {
            return name + "       " + group + "        " + house.ToString() + "              " + population.ToString();
        }
    }
}