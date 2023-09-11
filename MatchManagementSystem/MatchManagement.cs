namespace Match_Details_Management_System
{
    internal class MatchManagement
    {
        UserInterface ui = new UserInterface();
        public List<MatchDetails> Matches = new List<MatchDetails>()
        {
        new MatchDetails(1,  "Cricket",    new DateTime(2009, 3, 8, 14, 30, 0),"Christchurch",           "New Zealand", "India",   334,392),
        new MatchDetails(2,  "Cricket",    new DateTime(2020,9,30,10,0,0),     "Wankhade",               "India",       "Srilanka",330,310),
        new MatchDetails(100,"Hockey",     new DateTime(2023,9,7,20,0,0),      "HC Rotterdam",           "Netherlands", "India",   2,  2),
        new MatchDetails(200,"FootBall",   new DateTime(2023,7,4,18,0,0),      "Sree Kanteerava Stadium","India",       "Kuwait",  5,  4),
        new MatchDetails(300,"Basketball", new DateTime(2023,2,24,15,0,0),     "Bengaluru",              "India",       "Jordan"  ,63, 98)
        };
        public void DisplayMatches()
        {
            Console.WriteLine("---------------------------------------Match List-------------------------------------------");
            Console.WriteLine("==============================================================================================");
            Matches.ForEach(p => Console.WriteLine(p + "\n" + "========================================="));
        }
        public void AddMatch()
        {
            MatchDetails m = new MatchDetails(ui.getId(), ui.getSport(), new DateTime(ui.getYear(), ui.getMonth(), ui.getDay(), 12, 0, 0), ui.getLocation(),ui.getHomeTeam(), ui.getAwayTeam(), ui.getNewHomeTeamScore(),ui.getNewAwayTeamScore());
            Matches.Add(m);
        }
        public void GetMatchById()
        {
            int id = ui.getId();
            MatchDetails MatchById = Matches.Find(m => m.MatchId.Equals(id));
            Console.WriteLine("\n" + MatchById);
        }

        public void UpdateMatchScoreById()
        {
            int id = ui.getId();
            MatchDetails MatchById =  Matches.Find(m => m.MatchId.Equals(id));
            MatchById.HomeTeamScore = ui.getNewHomeTeamScore();
            MatchById.AwayTeamScore = ui.getNewAwayTeamScore();
            ui.UpdateSuccessfully();
        }


        public void RemoveMatchById()
        {
            int id = ui.getId();
            MatchDetails MatchById = Matches.Find(m => m.MatchId.Equals(id));
            Matches.Remove(MatchById);
        }


    }
}
