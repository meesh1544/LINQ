using System;
namespace LINQ
{
    class famousPeople
    {
        public string Name { get; set; }
        public int? BirthYear { get; set; } = null;
        public int? DeathYear { get; set; } = null;
    }
    class Program { 
        static void Main(string[] args)
           {
            IList<famousPeople> famousList = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
     };
    var nineteenHundred = famousList.Where(n => n.BirthYear > 1899)
        .OrderBy(n => n.BirthYear).ToList<famousPeople>();
            Console.WriteLine("Stem influencers born after the 1900's");
            foreach (var n in nineteenHundred)
            {
                Console.WriteLine($"{n.Name}\nBorn: {n.BirthYear}");
                Console.WriteLine("---------------------------");
            }

    var nineteenHundred2 = famousList.Where(n => (n.BirthYear >1920 && n.BirthYear <2000))
        .OrderBy(n => n.BirthYear).ToList<famousPeople>();
            Console.WriteLine("Stem influencers born beween 1920 and 2000");
            foreach (var n in nineteenHundred2)
            {
                Console.WriteLine($"{n.Name}\nBorn: {n.BirthYear}");
                Console.WriteLine("---------------------------");
            }

    var nineteenHundred3 = famousList.Where(n=>n.Name.Contains("ll"))
         .OrderBy(n => n.Name);
            Console.WriteLine("Stem influencers with ll in their name.");
            foreach (var n in nineteenHundred3)
            {
            Console.WriteLine($"{n.Name}");
            Console.WriteLine("---------------------------");
            }
    var nineteenHundred4 = famousList.Where(n => n.BirthYear > 1950)
            .OrderBy(n => n.BirthYear).ToList<famousPeople>();
            Console.WriteLine("Stem influencers born after the 1950's");
            foreach (var n in nineteenHundred4)
            {
                Console.WriteLine($"{n.Name}\nBorn: {n.BirthYear}");
                Console.WriteLine("---------------------------");
            }

    var nineteenHundred5 = famousList.Where(n=> n.DeathYear >1960 && n.DeathYear < 2015)
            .OrderByDescending(n=> n.DeathYear).ToList<famousPeople>();
            Console.WriteLine("Stem influencers who died between 1960 and 2015");
            foreach (var n in nineteenHundred5)
            {
                Console.WriteLine($"{n.Name}\nDied: {n.DeathYear}");
                Console.WriteLine("---------------------------");
            }
        }
    }
}