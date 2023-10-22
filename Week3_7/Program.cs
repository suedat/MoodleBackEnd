using System;
using System.Reflection;
using Week3_7.Entities;
using Week3_7.Enums;
namespace Week3_7;

class Program
{
    static void Main(string[] args)
    {
        #region All
        Console.WriteLine("Linq Methods");

        List<int> numbers = new() { 100, 150, 160, 45 };

        bool allItemsGreater = numbers.All(number => number > 40);

        
        /* The alternative and long way of 'All' 
        bool allItemsGreater = true;
        foreach (int number in numbers)
        {
            if (number <= 40)
            {
                allItemsGreater = false;
                break;
            }
        }*/
        Console.WriteLine(allItemsGreater);
        Console.ReadLine();
        #endregion

        #region Any
        List<User> userList = new List<User>
        { 
            new User("TravelExplorer_", 100),
            new User("FoodieAdventures", 10),
            new User("FitnessFreak101", 170),
            new User("ArtisticSoul_", 300),
            new User("FashionistaStyle", 1800)
        };
        Console.WriteLine(userList.Any(x => x.FollowerCount >= 1000 && x.Username.Contains("Style")));
        #endregion

        #region Where
        List<Person> people = new List<Person>
           {
            new Person("Alice", "Smith", 30, Gender.Female),
            new Person("Bob", "Johnson", 25, Gender.Male),
            new Person("Charlie", "Brown", 40, Gender.Male),
            new Person("David", "Wilson", 28, Gender.Male),
            new Person("Emma", "Lee", 35, Gender.Female),
            new Person("Frank", "Davis", 45, Gender.Male),
            new Person("Grace", "Taylor", 22, Gender.Female),
            new Person("Hannah", "White", 32, Gender.Female),
            new Person("Isaac", "Clark", 27, Gender.Male),
            new Person("Jack", "Hall", 38, Gender.Male)
        };

        //List<Person> filterResult = people.Where(x => x.Age < 30 && x.Gender == Gender.Male).ToList();
        //people.Any(x => x.Age < 30 && x.Gender == Gender.Male);
        bool filterResult = people
             .Where(x => x.Age > 40)
             .Any(x => x.Gender == Gender.Female);
           
            Console.WriteLine(filterResult);
            Console.ReadLine();
        }
#endregion
}


