namespace Match_Details_Management_System
{
    internal class UserInterface
    {
 
        public int getId()
        {

            Console.WriteLine("Enter Match Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public string getSport()
        {

            Console.WriteLine("Enter Sport:");
             string sport =Console.ReadLine();
            return sport;
        }

        public string getLocation()
        {
            Console.WriteLine("Enter Match Location:");
            string location =Console.ReadLine();
            return location;
        }
        public int getNewHomeTeamScore()
        {
            Console.WriteLine("Enter Score:");
            int score = Convert.ToInt32(Console.ReadLine());
            return score;
        }
        public string getHomeTeam()
        {
            Console.WriteLine("Enter Home Team Name");
            string homeTeam = Console.ReadLine();
            return homeTeam;
        }
        public string getAwayTeam()
        {
            Console.WriteLine("Enter Away Team Name");
            string awayTeam = Console.ReadLine();
            return awayTeam;
        }
        public int getNewAwayTeamScore()
        {
            Console.WriteLine("Enter  Score:");
            int score = Convert.ToInt32(Console.ReadLine());
            return score;
        }

        public void UpdateSuccessfully()
        {
            Console.WriteLine("Updated Successfully.");
        }

        public int getSort()
        {
            Console.WriteLine("Enter your type of Match sorting: ");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Sort By Sport: \n" +
                              "2. Sort By Location:\n" +
                              "3. Sort By Date\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;

        }

        public string getOrder()
        {
            Console.WriteLine("          Order By\n" +
                              "==============================\n" +
                              "1. Order By Ascending  (Asc)\n" +
                              "2. Order By Descending (Dsc)\n");
            string order = Console.ReadLine();
            return order;
        }

        public string getBeforeOrAfter()
        {
            Console.WriteLine("Enter if you want to see matches before or after");
            string beforeOrafter= Console.ReadLine();
            return beforeOrafter;
        }
        public int getMatchDisplayFeature()
        {
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Sort Match\n" +
                              "2. Filter Match\n" +
                              "3. Search Match\n");

            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public int getFilter()
        {
            Console.WriteLine("Enter your type of Match sorting: ");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Filter By Sport: \n" +
                              "2. Filter By Location: \n" +
                              "3. Filter By Date\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public string getSportFilter()
        {
            Console.WriteLine("Enter the Sport you want to Filter:");
            string sport = Console.ReadLine();
            return sport;
        }

        public string getLocationFilter()
        {
            Console.WriteLine("Enter the Location you want to Filter:");
            string location = Console.ReadLine();
            return location;
        }

        public int getYear()
        {
            Console.WriteLine("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine()); 
            return year;
        }

        public int getMonth()
        {
            Console.WriteLine("Enter Month: ");
            int Month = Convert.ToInt32(Console.ReadLine());
            return Month;
        }

        public int getDay()
        {
            Console.WriteLine("Enter Day: ");
            int Day = Convert.ToInt32(Console.ReadLine());
            return Day;
        }

        public static void getSportsManagementSystem()
        {
            Console.WriteLine("===============================Sports Management System===================================");
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("1. Display Matches\n" +
                              "2. Display Matche By Id\n" +
                              "3. Update Score By Id\n" +
                              "4. Remove Match By Id\n" +
                              "5. Extra Feature\n" +
                              "6. Exit\n");
        }

        public string continueui(string inputString)
        {
            Console.WriteLine("\n");
            Console.WriteLine(inputString);
            string c = Console.ReadLine();
            return c;
        }
        

    }
}
