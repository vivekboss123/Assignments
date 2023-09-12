using System.Dynamic;

namespace MatchDetailManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matchid = 6;
            int choice;
            int choice1;
            MatchDetails details = new MatchDetails();
            MatchManagement matchManagement = new MatchManagement();
            switchcases s = new switchcases();
            do
            {

                Console.WriteLine("-----------------------------MENU--------------------------------");
                Console.WriteLine("Press 1 for Match management releated activity");
              
                Console.WriteLine("Press 2 for feature related activity");
                Console.WriteLine("Press 3 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Press 1 to Add MatchDetail");
                        Console.WriteLine("Press 2 to Display list of all MatchDetails");
                        Console.WriteLine("Press 3 to Display detail of the match based on match id");
                        Console.WriteLine("Press 4 to Update match detail");
                        Console.WriteLine("Press 5 to Remove match detial");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            
                            case 1:
                                Console.WriteLine("Enter the Sport name");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter the date time in YYYY/MM/DD HH:MM:SS");
                                DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                                Console.WriteLine("Enter the location of the match");
                                string location = Console.ReadLine();
                                Console.WriteLine("Enter the home team name");
                                string HTeam = Console.ReadLine();
                                Console.WriteLine("Enter the Away team name");
                                string ATeam = Console.ReadLine();
                                Console.WriteLine("Enter Home team score");
                                int HScore = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Enter Away team score");
                                int AScore =Convert.ToInt16(Console.ReadLine());
                                matchid++;
                                /*details.CreateInstance(name, dateTime, location, HTeam, ATeam, HScore, AScore);*/
                                matchManagement.matches.Add(new MatchDetails(matchid,name, dateTime, location, HTeam, ATeam, HScore, AScore));
                                break;
                            case 2:
                                matchManagement.display();
                                break;
                            case 3:
                                Console.WriteLine("Enter the match id for which you want to see the details of ");
                                int match_id = Convert.ToInt32(Console.ReadLine());
                                matchManagement.displaywithid(match_id); 
                                break;
                            case 4:
                                Console.WriteLine("Enter the match id for which you want to update the detail of ");
                                int matchId = Convert.ToInt32(Console.ReadLine());
                                matchManagement.updatescore();
                                break;

                        }
                        break;
                    case 2:
                        Console.WriteLine("Press 1 to sort Matches");
                        Console.WriteLine("Press 2 to filter matches");
                        Console.WriteLine("Press 3 to to search matcehs");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        switch (choice2)
                        {
                            case 1:
                                s.ascendingdescending();
                                break;
                            case 2:
                                s.filterMatches(); 
                                break;
                            case 3:
                                s.searchMatches();
                                break;
                                
                        }
                        break;
                }

            }
            while (choice != 4);
        }
    }
}