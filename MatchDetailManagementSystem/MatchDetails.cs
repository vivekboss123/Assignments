using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchDetailManagementSystem
{
    internal class MatchDetails
    {
        public int matchId { get; set; }
        public string sport { get; set; }
        public DateTime MatchDateTime { get; set; }
        public string Location { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set;}

        //constructor
        public MatchDetails() { }
        public MatchDetails(int MatchId , string Sport , DateTime MatchDate , string location ,string hometeam, string awayTeam, int homeTeamScore , int awayTeamScore)
        {
            this.matchId = MatchId;
            this.sport = Sport;
            this.MatchDateTime = MatchDate;
            this.Location = location;
            this.HomeTeam = hometeam;
            this.AwayTeam = awayTeam;
            this.HomeTeamScore = homeTeamScore;
            this.AwayTeamScore = awayTeamScore;
        }

       /* public void CreateInstance(int MatchId, string Sport, DateTime MatchDate, string location, string hometeam, string awayTeam, int homeTeamScore, int awayTeamScore)
        {

        }*/


    }
}
