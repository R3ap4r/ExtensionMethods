using System.Collections.Generic;
using System;

namespace ExtensionMethods
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      // Create the Person class and populate it with dummy data

      List<Person> people = new List<Person>
      {
        new Person("John", "Wick", 49, 26000),
        new Person("James", "Gandolfini", 57, 490000),
        new Person("John", "Gotti", 68, 890000),
        new Person("James", "Last", 77, 645000)
      };

      // Show the data to the user before we start using it

      foreach (var person in people)
      {
        Console.WriteLine($"{person.FullName} aged {person.Age} annual earning {person.AnnualIncome}");
      }

      // Show the data again, but this time use the extension method for an additional check
      // We introduce a limit that has to be checked for and determine if the person earns atleast just that

      double personLimit = 500000;

      foreach (var person1 in people)
      {
        Console.WriteLine($"{person1.FullName} earning at least {personLimit} is {person1.HasMoreThan(personLimit)}");
      }

      // Now we compare their firstnames with a given name and only print out the ones we need

      string checkName = "james";

      foreach (var person2 in people)
      {
        if (person2.IsCommon(checkName))
        {
          Console.WriteLine($"{person2.FullName}");
        }
      }
    }

    //Here we're going to extend the Person Class with some methods

    //Checks if the annual income is at least that of the supplied limit
    public static bool HasMoreThan(this Person person, double limit)
    {
      return person.AnnualIncome >= limit;
    }

    //Checks if the name provided is shared by anyone else

    public static bool IsCommon(this Person person, string toCheckFor)
    {
      return string.Equals(person.FirstName, toCheckFor, StringComparison.CurrentCultureIgnoreCase);
    }
  }
}