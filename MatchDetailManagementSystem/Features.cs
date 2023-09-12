using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchDetailManagementSystem
{
    internal class Features
    {
        MatchManagement management = new MatchManagement();
        /*switchcases switchcase = new switchcases();*/
        public void sortingAsc(int choice)
        {
            
            switch (choice)
            {

               
                case 1:
                    
                    var sortedList = management.matches.OrderBy(x => x.MatchDateTime).ToList();
                    foreach (var item in sortedList)
                    {
                        Console.WriteLine($"Sport: {item.sport}, Team1: {item.HomeTeam}, Team2: {item.AwayTeam}, Location: {item.Location}");
                    }
                    break;
                case 2:
                    var sportsortasc = management.matches.OrderBy(x=>x.sport).ToList();
                    foreach (var item in sportsortasc) 
                    {
                        Console.WriteLine($"Sport: {item.sport}, Team1: {item.HomeTeam}, Team2: {item.AwayTeam}, Location: {item.Location}");
                    }
                    break;

                case 3:
                    var locationsortasc = management.matches.OrderBy(x => x.Location).ToList();
                    foreach (var item in locationsortasc)
                    {
                        Console.WriteLine($"Sport: {item.sport}, Team1: {item.HomeTeam}, Team2: {item.AwayTeam}, Location: {item.Location}");
                    }
                    break;
                default: Console.WriteLine("Enter correct key");
                        /* switchcase.ascendingdescending();*/
                         break;

            }
            
            

        }
        public void sortingdesc(int choice)
        {
            switch (choice)
            {
                case 1:
                    var sortedListdesc = management.matches.OrderByDescending(x => x.MatchDateTime).ToList();
                    foreach (var item in sortedListdesc)
                    {
                        Console.WriteLine($"Sport: {item.sport}, Team1: {item.HomeTeam}, Team2: {item.AwayTeam}, Location: {item.Location}");
                    }
                    break;
                case 2:
                    var sportsortdsc = management.matches.OrderBy(x => x.sport).ToList();
                    foreach (var item in sportsortdsc)
                    {
                        Console.WriteLine($"Sport: {item.sport}, Team1: {item.HomeTeam}, Team2: {item.AwayTeam}, Location: {item.Location}");
                    }
                    break;
                 case 3:
                    var locationsortdsc = management.matches.OrderBy(x => x.Location).ToList();
                    foreach (var item in locationsortdsc)
                    {
                        Console.WriteLine($"Sport: {item.sport}, Team1: {item.HomeTeam}, Team2: {item.AwayTeam}, Location: {item.Location}");
                    }
                    break;
                default:
                    Console.WriteLine("Enter correct key");
                    /*switchcase.ascendingdescending();*/
                    break;

            }
        }
        
            
        public void filterdesc(int year , int month , int day)
        {
            var filterbydatedesc = management.matches.Where(x => x.MatchDateTime == new DateTime(year, month, day, 12, 0, 0)).ToList();
            foreach (var item in filterbydatedesc)
            {
                Console.WriteLine($"Sport: {item.sport}, Team1: {item.HomeTeam}, Team2: {item.AwayTeam}, Location: {item.Location}");
            }
        }

        public void filterbysport(string sport)
        {
            var filterbysport = management.matches.Where(x=>x.sport == sport).ToList();
            foreach(var item in filterbysport)
            {
                Console.WriteLine($"Sport: {item.sport}, Team1: {item.HomeTeam}, Team2: {item.AwayTeam}, Location: {item.Location}");
            }
        }
        public void filterbylocation(string location)
        {
            var filterbylocation = management.matches.Where(x=> x.Location == location).ToList();
            foreach (var item in filterbylocation)
            {
                Console.WriteLine($"Sport: {item.sport}, Team1: {item.HomeTeam}, Team2: {item.AwayTeam}, Location: {item.Location}");
            } 
        }

        public void Search(string searchTerm)
        {
            var searchMatches = management.matches
                .Where(x =>
                    x.sport.ToLower().Contains(searchTerm.ToLower()) ||
                    x.AwayTeam.ToLower().Contains(searchTerm.ToLower()) ||
                    x.HomeTeam.ToLower().Contains(searchTerm.ToLower()) ||
                    x.Location.ToLower().Contains(searchTerm.ToLower()))
                .ToList();

            if (searchMatches.Count > 0)
            {
                Console.WriteLine("Matching Matches:");
                foreach (var match in searchMatches)
                {
                    Console.WriteLine($"Sport: {match.sport}, Team1: {match.HomeTeam}, Team2: {match.AwayTeam}, Location: {match.Location}");
                }
            }
            else
            {
                Console.WriteLine("No matches found.");
            }
        }





    }
}
