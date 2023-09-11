using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Details_Management_System
{
    internal class BigInterface
    {
        UserInterface ui = new UserInterface();
        MatchFilter matchFilter = new MatchFilter();    
        MatchSearch matchSearch = new MatchSearch();    
        MatchSort matchSort = new MatchSort();  


        public void  BigInterfaceui() {
            string c;
            do
            {
                int choice = ui.getMatchDisplayFeature();

                switch (choice)
                {
                    case 1:
                        {

                            string c1;
                            do
                            {
                                int choice2 = ui.getSort();
                                switch (choice2)
                                {
                                    case 1:
                                        {
                                            matchSort.SortMatchesBySport(ui.getOrder());
                                            break;
                                        }
                                    case 2:
                                        {
                                            matchSort.SortMatchesByLocation(ui.getOrder());
                                            break;
                                        }
                                    case 3:
                                        {
                                            matchSort.SortMatchesByDate(ui.getOrder());
                                            break;
                                        }

                                }
                                c1 = ui.continueui("Do you want to continue with Sort Menu Y/N:");
                            } while (c1 == "Y" || c1 == "y");

                        }
                        break; 
                        
                    case 2:
                        {
                            string c2;
                            do
                            {
                                int choice3 = ui.getFilter();
                                switch (choice3)
                                {
                                    case 1:
                                        {
                                            matchFilter.FilterMatchesBySport(ui.getSportFilter());
                                            break;
                                        }
                                    case 2:
                                        {
                                            matchFilter.FilterMatchesByLocation(ui.getLocationFilter());
                                            break;
                                        }
                                    case 3:
                                        {
                                            matchFilter.FilterMatchesBySportDate(ui.getYear(), ui.getMonth(), ui.getDay(),ui.getBeforeOrAfter());
                                            break;
                                        }

                                }
                                c2=ui.continueui("Do you want to continue with Filter Menu Y/N:");
                            } while (c2 == "Y" || c2 == "y");

                        }
                        break;
                        
                    case 3:
                        {
                            matchSearch.SearchMatch();
                            break;
                        }

                }
                c=ui.continueui("Do you want to continue with Extra Feature Menu Y/N:");
            } while (c == "Y" || c == "y");

        }


    }

}
