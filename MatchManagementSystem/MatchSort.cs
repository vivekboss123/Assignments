using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Details_Management_System
{
    internal class MatchSort
    {
        MatchManagement m= new MatchManagement();
        public void SortMatchesBySport(string s)
        {if (s == "Asc")
            {
                var ascedingMatchList = m.Matches.OrderBy(p => p.Sport).ToList();
                foreach (var match in ascedingMatchList) { Console.WriteLine(match + "\n" + "========================================="); }
            }
            else { 
                var descedingMatchList = m.Matches.OrderByDescending(p => p.Sport).ToList();
                foreach (var match in descedingMatchList) { Console.WriteLine(match + "\n" + "========================================="); }
            }
        }
        public void SortMatchesByDate(string s)
        {
            {
                if (s == "Asc")
                {
                    var ascedingMatchList = m.Matches.OrderBy(p => p.MatchDateTime).ToList();
                    foreach (var match in ascedingMatchList) { Console.WriteLine(match + "\n" + "========================================="); }
                }
                else{
                    var descedingMatchList = m.Matches.OrderByDescending(p => p.MatchDateTime).ToList();
                    foreach (var match in descedingMatchList) { Console.WriteLine(match + "\n" + "========================================="); }
                }
            }
        }

        public void SortMatchesByLocation(string s)
        {
            {
                if (s == "Asc")
                {
                    var ascedingMatchList = m.Matches.OrderBy(p => p.Location).ToList();
                    foreach (var match in ascedingMatchList) { Console.WriteLine(match + "\n" + "========================================="); }
                }
                else{
                    var descedingMatchList = m.Matches.OrderByDescending(p => p.Location).ToList();
                    foreach (var match in descedingMatchList) { Console.WriteLine(match + "\n" + "========================================="); }
                }
            }
        }

        
    }
}
    