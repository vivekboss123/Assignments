using System.Net.Sockets;

namespace Match_Details_Management_System
{
    internal class MatchDetails
    {
        List<string> Sports = new List<string>();
        string[] sportz = { "Football", "Basketball", "American Football", "Rugby", "Cricket", "Hockey", "Volleyball", "Baseball", "Softball", "Handball", "Water Polo", "Lacrosse", "Ultimate Frsibee",
            "Synchronized Swimming","Rowing","Curling","Wetball","Kabaddi" };


        private int matchId;
        private string sport;
        private DateTime matchDateTime;
        private string location;
        private string homeTeam;
        private string awayTeam;
        private int homeTeamScore;
        private int awayTeamScore;


        public int MatchId
        {
            get { return this.matchId; }
            set { if (this.matchId > 0) { this.matchId = value; }
                else { Console.WriteLine("MatchId Should be Positive"); } }
        }

        public string Sport
        {
            get { return this.sport; }
            set { if (sportz.Contains(this.sport)) { this.sport = value; }
                else
                {
                    Console.WriteLine("Please Enter Correct spealling ");
                }; }
            //public string MyProperty { get; set; } = "Default Value"; // Initialize with a non-null value

        } 

    public DateTime MatchDateTime
        {
            get { return this.matchDateTime; }
            set { this.matchDateTime = value; }
        }
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public string HomeTeam
        {
            get { return this.homeTeam; }
            set { this.homeTeam = value; }
        }

        public string AwayTeam
        {
            get { return this.awayTeam; }
            set { this.awayTeam = value; }
        }

        public int HomeTeamScore
        {
            get { return this.homeTeamScore; }
            set { this.HomeTeamScore = value; }
        }

        public int AwayTeamScore
        {
            get { return this.awayTeamScore; }
            set { this.awayTeamScore = value; }
        }

       
        public MatchDetails(int matchId, string sport, DateTime matchDateTime, string location, string homeTeam, string awayTeam, int homeTeamScore, int awayTeamScore)
        {
            this.matchId = matchId;
            this.sport = sport;
            this.matchDateTime = matchDateTime;
            this.location = location;
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.homeTeamScore = homeTeamScore;
            this.awayTeamScore = awayTeamScore;
        }
        public override string ToString()
        {
            //return $"Match_Id:{MatchId}  Sport:{Sport}  Match_Date:{MatchDateTime}  Venue:{Location}  Home_Team:{HomeTeam}  Away_Team:{AwayTeam}  Home_Team_Score:{HomeTeamScore}  Away_Team_Score:{AwayTeamScore}";

            return $"Match_Id:        {MatchId}\nSport:           {Sport}\nMatch_Date:      {MatchDateTime}\nVenue:           {Location}\nHome_Team:       {HomeTeam}\nAway_Team:       {AwayTeam}\nHome_Team_Score: {HomeTeamScore}\nAway_Team_Score: {AwayTeamScore}";
        }

       /* public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                MatchDetails other = obj as MatchDetails;
                if (this.matchId == other.matchId)
                {
                    return true;
                }
            }
            return false;

        }
        public override int GetHashCode()
        {
            return MatchId;
        }*/

    }
}


