using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ParseCSV
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = @"Top100ChessPlayers.csv";
            var playersList = new List<Player>();

            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    int index = 0;
                    string ln;

                    string[] parts;

                    while ((ln = file.ReadLine()) != null)
                    {
                        parts = ln.Split(';');
                        index++;

                        if (index <= 1) continue;

                        playersList.Add(new Player()
                        {
                            Rank = int.Parse(parts[0]),
                            Name = parts[1],
                            Title = parts[2],
                            Country = parts[3],
                            Rating = int.Parse(parts[4]),
                            Games = int.Parse(parts[5]),
                            BYear = int.Parse(parts[6])
                        });
                    }

                    file.Close();  
                }
            }

            IEnumerable<Player> query = playersList
                .Where(p => p.BYear > 1980).Take(10);

            foreach (var player in query)
            {
                Console.WriteLine(player);
            }

            Console.ReadKey();
        }
    }
}
