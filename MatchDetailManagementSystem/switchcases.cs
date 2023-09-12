using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MatchDetailManagementSystem
{
    internal class switchcases
    {
        Features features = new Features();
        

        public void ascendingdescending()
        {
            int choice;
            int choice1;
            do
            {
                Console.WriteLine("-------------------------MENU---------------------");
                Console.WriteLine("Press 1 to sort by match datetime");
                Console.WriteLine("Press 2 to sort by sport");
                Console.WriteLine("press 3 to sort by location ");
                Console.WriteLine("Press 4 to exit");

                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Press 1 to sort by ascending order");
                        Console.WriteLine("Press 2 to sort by descending order");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                features.sortingAsc(choice);
                                break;
                            case 2:
                                features.sortingdesc(choice);
                                break;
                        }
                        break;
                    case 2:
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                features.sortingAsc(choice);
                                break;
                            case 2:
                                features.sortingdesc(choice);
                                break;
                        }
                        break;
                    case 3:
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                features.sortingAsc(choice);
                                break;
                            case 2:
                                features.sortingdesc(choice);
                                break;
                        }
                        break;
                }



            }
            while (choice != 4);


        }
        public void filterMatches()
        {
            int choice;
            do
            {
                Console.WriteLine("-------------------------MENU---------------------");
                Console.WriteLine("Press 1 to filter by match datetime");
                Console.WriteLine("Press 2 to filter by sport");
                Console.WriteLine("press 3 to filter by location ");
                Console.WriteLine("Press 4 to exit");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        {
                            Console.WriteLine("Enter the year from which date you want to see the matches");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the month of the year you mentioned");
                            int month = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the day for which you want to see the match");
                            int day = Convert.ToInt32(Console.ReadLine());
                            features.filterdesc(year, month, day);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the sport for which you want to see the data");
                            string sport = Console.ReadLine();
                            features.filterbysport(sport);

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the location of which you want to see all the matches list");
                            string location = Console.ReadLine();
                            features.filterbylocation(location);
                            break;

                        }

                }

            }
            while (choice != 4);
        }

        public void searchMatches()
        {
            Console.WriteLine("Enter the sport  or team name or location you want to search for");
            string name = Console.ReadLine();
            features.Search(name);
            
        }
        

        }

    
}

