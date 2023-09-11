using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Match_Details_Management_System
{
    internal class MatchFilter
    {
        MatchManagement m = new MatchManagement();


        public void FilterMatchesBySport(string sportname)
        {
            var result = (from sport in m.Matches where sport.Sport == sportname  select sport).ToList();
            foreach (var sport in result) { Console.WriteLine(sport + "\n" + "========================================="); }

        }

        public void FilterMatchesByLocation(string locationname)
        {
            var result = (from location in m.Matches where location.Sport == locationname select location).ToList();
            foreach (var location in result) { Console.WriteLine(location+"\n" + "========================================="); }
        }

        public void FilterMatchesBySportDate(int year,int month,int day,string beforeOrafter)
        {   if (beforeOrafter == "after")
            {
                var result = (from date in m.Matches where date.MatchDateTime > new DateTime(year, month, day, 12, 0, 0) select date).ToList();
                foreach (var match in result) { Console.WriteLine(match + "\n" + "========================================="); }
            }
        else if (beforeOrafter == "before")
            {
                var result = (from date in m.Matches where date.MatchDateTime < new DateTime(year, month, day, 12, 0, 0) select date).ToList();
                foreach (var match in result) { Console.WriteLine(match + "\n" + "========================================="); }
            }
        }

      
    }
}
