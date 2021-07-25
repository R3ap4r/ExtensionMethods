using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
  // Holds the methods for the Person class we're going to extend
  public static class PersonExtensionMethods
  {
    /// <summary>
    /// Checks if the annual income is at least that of the supplied limit
    /// </summary>
    /// <param name="person"></param>
    /// <param name="limit"></param>
    /// <returns></returns>
    public static bool HasMoreThan(this Person person, double limit)
    {
      return person.AnnualIncome >= limit;
    }

    /// <summary>
    /// Checks if the name provided is shared by anyone else
    /// </summary>
    /// <param name="person"></param>
    /// <param name="toCheckFor"></param>
    /// <returns></returns>
    public static bool IsCommon(this Person person, string toCheckFor)
    {
      return string.Equals(person.FirstName, toCheckFor, StringComparison.CurrentCultureIgnoreCase);
    }
  }
}