using System.ComponentModel.DataAnnotations;
using System;
namespace Simulator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Simulator!\n");
		Lab4a();

//    Early tests
        //    Creature c = new Creature("Shrek", 7);
        //    c.SayHi();
        //    Console.WriteLine(c.Info);
        //    Creature d = new Creature("Fiona");
        //    d.SayHi();
        //    Console.WriteLine(d.Info);
        //    Creature e = new Creature();
        //    e.SayHi();
        //    Console.WriteLine(d.Info);
        //    Animals rats = new() { Description = "Rats", Size = 10 };
        //    Console.WriteLine(rats.Info);
        //    Animals mice = new() { Description = "Mice", Size = 40 };
        //    Console.WriteLine(mice.Info);
        //    Animals cats = new() { Description = "Cats" }; // cats.Size == 3
        //    Console.WriteLine(cats.Info);
    }
    // Copied function 1

    static void Lab4a()
    {
       Console.WriteLine("HUNT TEST\n");
        var o = new Orc() { Name = "Gorbag", Rage = 7 };
        o.SayHi();
        for (int i = 0; i < 10; i++)
        {
            o.Hunt();
            o.SayHi();
        }
        Console.WriteLine("\nSING TEST\n");
        var e = new Elf("Legolas", agility: 2);
        e.SayHi();
        for (int i = 0; i < 10; i++)
        {
            e.Sing();
            e.SayHi();
        }
        Console.WriteLine("\nPOWER TEST\n");
        Creature[] creatures = {
        o,
        e,
        new Orc("Morgash", 3, 8),
        new Elf("Elandor", 5, 3);
    }
    	foreach (Creature creature in creatures)
        {
            Console.WriteLine($"{creature.Name,-15}: {creature.Power}");
        }
    }
}
