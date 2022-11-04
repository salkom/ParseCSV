using System;
using System.Collections.Generic;
using System.Text;

namespace ParseCSV
{
    public class Player
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Country { get; set; } 
        public int Rating { get; set; } 
        public int Games { get; set; }
        public int BYear { get; set; }

        public override string ToString()
        {
            return string.Format($"Rank: {Rank}\nName: {Name}\nTitle: {Title}\nCountry: {Country}\nRating: {Rating}\nGames: {Games}\nB-Year: {BYear}\n");
        }
    }
}
