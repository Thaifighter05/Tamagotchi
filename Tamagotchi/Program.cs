using Namespace;

Console.WriteLine("Hi i'm Tamagotchi");

Tamagotchi Tama = new Tamagotchi();

Console.WriteLine("What's your tamagotchi name");
Tama.name = Console.ReadLine();

Console.WriteLine($"{Tama.name} Is a very cute name ");

// while (Tama.GetAlive()==true)
// {
// Tama.printstats
// }



Console.ReadLine();