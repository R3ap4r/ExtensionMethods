using System.Collections.Generic;

namespace ExtensionMethods
{
  public class Person
  {
    public Person()
    {
    }

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
  }
}