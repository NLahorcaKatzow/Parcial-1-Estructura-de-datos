using System;
using System.Collections.Generic;
using System.Linq;

namespace Race
{
    public class ListMethods
    {

        public static List<RaceResults> SortResults(List<RaceResults> results)
        {
            return results.OrderBy(r => r.position).ToList();
        }


        public static RaceResults? GetFastestCar(List<RaceResults> results)
        {
            return results.OrderBy(r => r.fastestLap).FirstOrDefault();
        }

        public static RaceResults[] GetPodium(List<RaceResults> results)
        {
            return results.OrderBy(r => r.position).Take(3).ToArray();
        }

        public static string GetRacerDataFormat(RaceResults result)
        {
            return $"{result.position} | {result.carNumber} - {result.racerName} | {FormatTime(result.totalTime)}";
        }

        public static string GetRacerTable(List<RaceResults> results)
        {
            string table = "";
            foreach (var result in results)
            {
                table += GetRacerDataFormat(result) + "\n";
            }
            return table;
        }

        public static string GetPodiumTable(RaceResults[] podium)
        {
            string table = "";
            foreach (var result in podium)
            {
                table += GetRacerDataFormat(result) + "\n";
            }
            return table;
        }

        public static string FormatTime(float seconds)
        {
            int minutes = (int)seconds / 60;
            float secs = seconds % 60;
            return $"{minutes}m : {secs:00.000}s";
        }



    }

}