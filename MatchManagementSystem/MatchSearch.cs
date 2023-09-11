using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Details_Management_System
{
    internal class MatchSearch
    {
        MatchManagement m = new MatchManagement();
        public List<MatchDetails> SearchMatches(string keyword, List<MatchDetails> matches)
        {
            return matches.Where(match =>
                match.Sport.ToLower().Contains(keyword) ||
                match.HomeTeam.ToLower().Contains(keyword) ||
                match.AwayTeam.ToLower().Contains(keyword) ||
                match.Location.ToLower().Contains(keyword)
            ).ToList();
        }
        public void SearchMatch()
        {
            while (true)
            {
                Console.Write("Enter keywords to search (or 'exit' to quit): ");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                    break;

                List<MatchDetails> searchResults = SearchMatches(input,m.Matches );

                if (searchResults.Count == 0)
                {
                    Console.WriteLine("No matches found.");
                }
                else
                {
                    Console.WriteLine("Search Results:");
                    foreach (var match in searchResults)
                    {
                        Console.WriteLine($"{match.Sport}: {match.HomeTeam} vs. {match.AwayTeam} at {match.Location}");
                    }
                }
            }
        }

      
    }
}
