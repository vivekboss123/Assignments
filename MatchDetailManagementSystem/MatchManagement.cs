using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchDetailManagementSystem
{
    internal class MatchManagement {
        public List<MatchDetails> matches = new List<MatchDetails>()
        {
            new MatchDetails(1, "cricket", new DateTime(2023, 06, 22, 22, 05, 27), "Mumbai", "Mumbai Indians", "Chennai super Kings", 150, 151),
            new MatchDetails(2, "football", new DateTime(2023, 06, 22, 22, 05, 27), "Kolkata", "Bengaluru fc", "Chennai super Kings", 150, 151),
            new MatchDetails(3, "table tennis", new DateTime(2023, 06, 22, 22, 05, 27), "Chennai", "redbull master", "Chennai medu vada sambhar", 150, 151),
            new MatchDetails(4, "chess", new DateTime(2023, 06, 22, 22, 05, 27), "Mumbai", "Delhi", "Chennai super Kings", 150, 151),
            new MatchDetails(5, "cricket", new DateTime(2023, 06, 22, 22, 05, 27), "patna", "Mumbai Indians", "Chennai super Kings", 150, 151),
            new MatchDetails(6, "hockey", new DateTime(2023, 06, 22, 22, 05, 27), "Gorakhpur", "Mumbai Indians", "Chennai super Kings", 150, 151)
        };
        

        public void display() { 
            foreach(var m in matches)
            {
                Console.WriteLine($"player id : {m.matchId} sports : {m.sport} date time : {m.Location} home team :{m.HomeTeam} away team : {m.AwayTeam} home team score : {m.HomeTeamScore} away home score : {m.AwayTeamScore}" );
            }
        }
        public void displaywithid(int Id)
        {
            foreach(MatchDetails m in matches)
            {
                if (m.matchId == Id)
                {
                    Console.WriteLine($"player id : {m.matchId} sports : {m.sport} date time : {m.Location} home team :{m.HomeTeam} away team : {m.AwayTeam} home team score : {m.HomeTeamScore} away home score : {m.AwayTeamScore}");
                }
            }
        }
        public void updatescore()
        {
            Console.WriteLine("Enter the id of the player you want to update info of :");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (MatchDetails m in matches)
            {
                if (m.matchId == id)
                {
                    Console.WriteLine("--------------------------MENU-------------------------------");
                    Console.WriteLine("Press 1 to update HomeTeamScore");
                    Console.WriteLine("Press 2 to update awayhomeScore");
                    int choice1 = Convert.ToInt32(Console.ReadLine());
                    switch (choice1)
                    {
                        case 1:
                            Console.WriteLine("Enter the updated HomeTeamScore");
                            int updatescore = Convert.ToInt32(Console.ReadLine());
                            m.HomeTeamScore = updatescore;
                            break;
                        case 2:
                            Console.WriteLine("Enter the updated AwayTeamScore");
                            int updateHomeScore = Convert.ToInt32(Console.ReadLine());
                            m.HomeTeamScore = updateHomeScore;
                            break;
                        default:
                            Console.WriteLine("wrong input");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Enter the correct match id");
                }

            }
        }
                
                
                   
              
        public void deleteMatch(int matchid)
        {
            foreach(MatchDetails m in matches)
            {
                if(m.matchId == matchid)
                {
                    matches.Remove(m);
                }
            }
        }



    };
        
}
