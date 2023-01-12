using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Ask user for fave number */
      Console.Write("Enter your favorite number!: ");
      
      /* Attempt 3: use Convert method */
      int faveNumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(faveNumber);

    }
  }
}
