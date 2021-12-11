using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Seeds culture1 = new Seeds("Соя", "Б", 13000, 45);
            Seeds culture2 = new Seeds("Чумиза", "З", 8000, 17);
            Seeds culture3 = new Seeds("Рис", "З", 25650, 24);
            Console.WriteLine("Найменування     Тип    Посiвна площа(га)    Врожайнiсть(ц/га)");
            Console.WriteLine(culture1.Details());
            Console.WriteLine(culture2.Details());
            Console.WriteLine(culture3.Details());
        }
    }

    class Seeds
    {
        public string name { get; set; }

        public string type { get; set; }

        public short sownarea { get; set; }

        public double yields { get; set; }

        public Seeds(Seeds previousSeeds)
        {
            name = previousSeeds.name;
            type = previousSeeds.type;
            sownarea = previousSeeds.sownarea;
            yields = previousSeeds.yields;
        }

        public Seeds(string Name, string Type, short Sownarea, double Yields)
        {
            name = Name;
            type = Type;
            sownarea = Sownarea;
            yields = Yields;
        }

        public string Details()
        {
            return name + "       " + type + "        " + sownarea.ToString() + "              " + yields.ToString();
        }
    }
}
