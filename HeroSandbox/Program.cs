using DataAccess;
using System;

namespace HeroSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroRepository repo = new HeroRepository();
            var allHeroes = repo.GetAllHeroes();

            foreach (var hero in allHeroes)
            {
                Console.WriteLine($"Id: {hero.Id}, Name: {hero.Name}");
            }

            Console.ReadLine();
        }
    }
}
