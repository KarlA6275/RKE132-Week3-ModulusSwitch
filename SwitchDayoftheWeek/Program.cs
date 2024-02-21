
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //Väärtused on vahemikus 0-6

switch (weekDay) //Väärtus, mida kontrollitakse. Saab kontrollida vaid 1 väärtust!
{
    case 0:  //case 0: == if(weekDay == 0)
        Console.WriteLine("It's Sunday,");
        break;
    case 1:
        Console.WriteLine("It's Monday");
        break;
    case 2:
        Console.WriteLine("Its Tuesday,");
        break;
    case 3:
        Console.WriteLine("Its Wednesday,");
        break;
    case 4:
        Console.WriteLine("Its Thursday,");
        break;
    case 5:
        Console.WriteLine("Its Friday,");
        break;
    case 6:
        Console.WriteLine("Its Saturday,");
        break;
    default:
        Console.WriteLine("Oops. Your calender package is outdated, to update your calender please pay 5 euro.");
        break;
}


Console.WriteLine("Have a wounderful day!");