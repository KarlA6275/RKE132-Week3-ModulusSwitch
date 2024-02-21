using System.Globalization;

string TT = DateTime.Now.ToString("tt", CultureInfo.InvariantCulture).ToLower();
Console.WriteLine(TT);
