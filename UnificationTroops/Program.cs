using System;
using System.Collections.Generic;
using System.Linq;

namespace UnificationTroops
{
    class Progam
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers1 = new List<Soldier>()
            {
                new Soldier("Борис"),
                new Soldier("Антон"),
                new Soldier("Андрей"),
                new Soldier("Биткоин"),
                new Soldier("Арсен"),
            };

            List<Soldier> soldiers2 = new List<Soldier>();
            char letterSearch = 'б';

            soldiers2 = soldiers2.Union(soldiers1.Where(solider => solider.Name.ToLower().StartsWith(letterSearch))).ToList();

            foreach (var soldier in soldiers2)
            {
                soldier.ShowInfo();
            }
        }
    }

    class Soldier
    {
        public string Name { get; private set; }

        public Soldier(string name)
        {
            Name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Солдат - {Name}");
        }
    }
}