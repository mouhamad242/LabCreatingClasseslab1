using System;
using System.Collections.Generic;
using System.Linq;

namespace LabCreatingClasses
{
    public class Person
    {
        // Attributes
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }

        // Methods
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{PersonId}: {FirstName} {LastName}'s favorite colour is {FavoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            FavoriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            return Age + 10;
        }

        public override string ToString()
        {
            return $"PersonId: {PersonId}\nFirstName: {FirstName}\nLastName: {LastName}\nFavoriteColour: {FavoriteColour}\nAge: {Age}\nIsWorking: {IsWorking}";
        }
    }

    public class Relation
    {
        // Attribute
        public string RelationshipType { get; set; }

        // Method
        public void ShowRelationship(Person person1, Person person2)
        {
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {RelationshipType}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Create Person objects
            Person person1 = new Person { PersonId = 1, FirstName = "Ian", LastName = "Brooks", FavoriteColour = "Red", Age = 30, IsWorking = true };
            Person person2 = new Person { PersonId = 2, FirstName = "Gina", LastName = "James", FavoriteColour = "Green", Age = 18, IsWorking = false };
            Person person3 = new Person { PersonId = 3, FirstName = "Mike", LastName = "Briscoe", FavoriteColour = "Blue", Age = 45, IsWorking = true };
            Person person4 = new Person { PersonId = 4, FirstName = "Mary", LastName = "Beals", FavoriteColour = "Yellow", Age = 28, IsWorking = true };

            // Display Gina's information
            person2.DisplayPersonInfo();

            // Display Mike's information as a list
            Console.WriteLine(person3);

            // Change Ian's favorite colour to white and display his information
            person1.ChangeFavoriteColour();
            person1.DisplayPersonInfo();

            // Display Mary's age in 10 years
            Console.WriteLine($"{person4.FirstName} {person4.LastName}'s Age in 10 years is: {person4.GetAgeInTenYears()}");

            // Create Relation objects
            Relation relation1 = new Relation { RelationshipType = "Sisterhood" };
            Relation relation2 = new Relation { RelationshipType = "Brotherhood" };

            // Display relationships
            relation1.ShowRelationship(person2, person4);
            relation2.ShowRelationship(person1, person3);

            // Add all Person objects to a list
            List<Person> people = new List<Person> { person1, person2, person3, person4 };

            // Calculate average age
            double averageAge = people.Average(p => p.Age);
            Console.WriteLine($"Average age is: {averageAge}");

            // Find youngest and oldest person
            Person youngest = people.OrderBy(p => p.Age).First();
            Person oldest = people.OrderByDescending(p => p.Age).First();
            Console.WriteLine($"The youngest person is: {youngest.FirstName}");
            Console.WriteLine($"The oldest person is: {oldest.FirstName}");

            // Find people whose first names start with 'M'
            var namesStartingWithM = people.Where(p => p.FirstName.StartsWith("M"));
            foreach (var person in namesStartingWithM)
            {
                Console.WriteLine(person);
            }

            // Display information of the person who likes the color blue
            var likesBlue = people.FirstOrDefault(p => p.FavoriteColour == "Blue");
            if (likesBlue != null)
            {
                Console.WriteLine(likesBlue);
            }
        }
    }
}
