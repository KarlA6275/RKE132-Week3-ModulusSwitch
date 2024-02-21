
Console.WriteLine("Mis hinde te saite?");
string userHinne = Convert.ToString(Console.ReadLine().ToLower());

switch (userHinne)
{
    case "a":
        Console.WriteLine("Suurepärane!");
        break;
    case "b":
        Console.WriteLine("Väga hea!");
        break;
    case "c":
        Console.WriteLine("Hea!");
        break;
    case "d":
        Console.WriteLine("Rahuldav!");
        break;
    case "e":
        Console.WriteLine("Käsin!");
        break;
    case "f":
        Console.WriteLine("Puudulik");
        break;
    default:
        Console.WriteLine("Vale väärtus");
        break;
}