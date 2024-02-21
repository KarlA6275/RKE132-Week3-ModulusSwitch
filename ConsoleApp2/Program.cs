
Console.WriteLine("Mis hinde te saite?");
string userHinne = Convert.ToString(Console.ReadLine().ToLower());

if (userHinne == "a")
{
    Console.WriteLine("Suurepärane!");
}
else if (userHinne == "b")
{
    Console.WriteLine("Väga hea!");
}
else if (userHinne == "c")
{
    Console.WriteLine("Hea!");
}
else if (userHinne == "d")
{
    Console.WriteLine("Rahuldav!");
}
else if (userHinne == "e")
{
    Console.WriteLine("Kasin!");
}
else if (userHinne == "f")
{
    Console.WriteLine("Puudulik!");
}
else
{
    Console.WriteLine("Vale Väärtus");
}