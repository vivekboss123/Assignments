namespace Match_Details_Management_System
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MatchManagement matchManagement = new MatchManagement();
            //SwitchInterface si = new SwitchInterface();
            UserInterface ui = new UserInterface();
            BigInterface bigInterface = new BigInterface(); 
            string c;
            do
            {
                Console.WriteLine("===============================Sports Management System===================================");
                Console.WriteLine("==========================================================================================");
                Console.WriteLine("1. Display Matches\n" +
                                  "2. Add Match\n"+
                                  "3. Display Matche By Id\n" +
                                  "4. Update Score By Id\n" +
                                  "5. Remove Match By Id\n" +
                                  "6. Extra Feature\n" +
                                  "7. Exit\n");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            matchManagement.DisplayMatches();
                            break;
                        }

                    case 2:
                        {
                            matchManagement.AddMatch();
                            break;
                        }
                    case 3:
                        {
                            matchManagement.GetMatchById();
                            break;
                        }

                    case 4:
                        {
                            matchManagement.UpdateMatchScoreById();
                            break;
                        }
                    case 5:
                        {
                            matchManagement.RemoveMatchById();
                            break;
                        }
                    case 6:
                         {
                            bigInterface.BigInterfaceui(); 
                         break;
                        }
                    case 7:
                        {

                          break;
                        }
                }
                c = ui.continueui("Do you want to continue with Matches Management System Menu Y/N:");
            }
            while (c == "Y" || c=="y");
        }


    }

    }


/*   do
            {
            Console.WriteLine("===============================Sports Management System===================================");
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("1. Display Matches\n" +
                              "2. Display Matche By Id\n" +
                              "3. Update Score By Id\n" +
                              "4. Remove Match By Id\n" +
                              "5. Extra Feature\n" +
                              "6. Exit\n");

            int choice = Convert.ToInt32(Console.ReadLine());
             switch (choice)
             {
                 case 1:
                     {
                         matchManagement.DisplayMatches();
                         break;
                     }
                 case 2:
                     {
                         matchManagement.GetMatchById();
                         break;
                     }

                 case 3:
                     {
                         matchManagement.UpdateMatchScoreById();
                         break;
                     }
                 case 4:
                     {
                         matchManagement.RemoveMatchById();
                         break;
                     }
                // case 5:
                  //   {
                    //     ui.DisplayFeatureInterface();
                      //   break;
                     //}
                 //case 6:
                     //{

                       //  break;
                     //}
             }
             Console.WriteLine("\n");
            Console.WriteLine("Do you want to continue with Matches Management System Menu Y/N:");
            c = Console.ReadLine();
            }
            while (c == "Y");
             }
*/





