using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
  public class Person
  {
    public Person(string firstName, string lastName, int age, double annualIncome)
    {
      FirstName = firstName;
      LastName = lastName;
      Age = age;
      AnnualIncome = annualIncome;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public int Age { get; set; }
    public double AnnualIncome { get; set; }

    public void Populate()
    {
      List<Person> people = new List<Person>();

      people.Add(new Person("John", "Wick", 49, 26000));
      people.Add(new Person("James", "Gandolfini", 57, 490000));
      people.Add(new Person("John", "Gotti", 68, 890000));
      people.Add(new Person("James", "Last", 77, 645000));
    }
  }
}