string str = "Bienvenidos a el mundo de la programacion";
string[] substr = str.Split(' ');
Console.WriteLine($"{substr[0]} {substr[1]} {substr[2]} {substr[3]} {substr[4]} {substr[5]} {substr[6]}");
Console.WriteLine($"{substr[0]} {substr[1]}");
Console.WriteLine($"{substr[2]} {substr[3]} {substr[4]}");
Console.WriteLine($"{substr[5]} {substr[6]}");
Console.ReadKey(true);
