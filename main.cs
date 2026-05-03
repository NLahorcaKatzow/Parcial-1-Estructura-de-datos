using System;
using Race;
public class main
{
    public static void Main(string[] args)
    {
        List<RaceResults> results = new List<RaceResults>
        {
            new RaceResults { position = 7,  carNumber = 4,  racerName = "Lando Norris",          totalTime = 5459.135f, fastestLap = 85.001f },
            new RaceResults { position = 12, carNumber = 31, racerName = "Esteban Ocon",          totalTime = 5491.873f, fastestLap = 86.134f },
            new RaceResults { position = 3,  carNumber = 55, racerName = "Carlos Sainz",          totalTime = 5435.672f, fastestLap = 84.012f },
            new RaceResults { position = 15, carNumber = 77, racerName = "Valtteri Bottas",       totalTime = 5511.038f, fastestLap = 86.801f },
            new RaceResults { position = 1,  carNumber = 1,  racerName = "Max Verstappen",        totalTime = 5423.847f, fastestLap = 83.124f },
            new RaceResults { position = 9,  carNumber = 14, racerName = "Fernando Alonso",       totalTime = 5471.056f, fastestLap = 85.456f },
            new RaceResults { position = 5,  carNumber = 63, racerName = "George Russell",        totalTime = 5448.991f, fastestLap = 84.567f },
            new RaceResults { position = 13, carNumber = 23, racerName = "Alexander Albon",       totalTime = 5498.247f, fastestLap = 86.356f },
            new RaceResults { position = 2,  carNumber = 16, racerName = "Charles Leclerc",       totalTime = 5431.219f, fastestLap = 83.891f },
            new RaceResults { position = 10, carNumber = 18, racerName = "Lance Stroll",          totalTime = 5478.329f, fastestLap = 85.678f },
            new RaceResults { position = 6,  carNumber = 11, racerName = "Sergio Perez",          totalTime = 5452.774f, fastestLap = 84.789f },
            new RaceResults { position = 14, carNumber = 2,  racerName = "Logan Sargeant",        totalTime = 5504.591f, fastestLap = 86.578f },
            new RaceResults { position = 4,  carNumber = 44, racerName = "Lewis Hamilton",        totalTime = 5441.308f, fastestLap = 84.345f },
            new RaceResults { position = 11, carNumber = 10, racerName = "Pierre Gasly",          totalTime = 5485.614f, fastestLap = 85.912f },
            new RaceResults { position = 8,  carNumber = 81, racerName = "Oscar Piastri",         totalTime = 5463.482f, fastestLap = 85.234f },
        };
        
        Console.WriteLine("Podium:");
        //crea el podio
        RaceResults[] podium = ListMethods.GetPodium(results);
        Console.WriteLine(ListMethods.GetPodiumTable(podium));

        Console.WriteLine("Results sorted by position:");
        //crea la tabla de resultados
        List<RaceResults> sortedResults = ListMethods.SortResults(results);
        Console.WriteLine(ListMethods.GetRacerTable(sortedResults));

        Console.WriteLine("Fastest car:");
        //crea la tabla de resultados
        RaceResults fastestCar = ListMethods.GetFastestCar(results);
        Console.WriteLine("The fastest car is: " + fastestCar.racerName + " with a time of " + ListMethods.FormatTime(fastestCar.totalTime));
    }
}
