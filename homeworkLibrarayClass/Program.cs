
using System;
using CityLibrary;

string arrayStr;
int array;
do
{
    Console.WriteLine("City sayi:");
    arrayStr = Console.ReadLine();

} while (!int.TryParse(arrayStr, out array) || array < 0);

ChinaCity[] chinaCity  = new ChinaCity[array];

for (int i = 0; i < chinaCity.Length; i++)
{
    string name;

    do
    {
        Console.WriteLine($"{i + 1}.City Name:");
        name = Console.ReadLine();
    } while (!CityName(name));


    string popStr;
    int pop;
    do
    {
        Console.WriteLine($"{i + 1}.Population:");
        popStr = Console.ReadLine();
    } while (!int.TryParse(popStr, out pop) || pop < 100000);

    ChinaCity city = new ChinaCity()
    {
        Name = name,
        Population = pop
    };

    chinaCity[i] = city;
}
Console.WriteLine(CountPopulationAvg(chinaCity));

static bool CityName(string? name)
{
    if (String.IsNullOrWhiteSpace(name)) return false;

    if (name.Length < 3 || name.Length > 20) return false;

    for (int i = 0; i < name.Length; i++)
    {
        if (!char.IsLetter(name[i]))
        {
            return false;
        }
    }
    return true;

}

static int CountPopulationAvg(ChinaCity[] cities)
{
    int sum = 0;
    int result = 0;
    for (int i = 0; i < cities.Length; i++)
    {
        sum += cities[i].Population;
    }
    result = cities.Length == 0 ? 0 : sum / cities.Length;
    return result;
}
