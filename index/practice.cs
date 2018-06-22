
using System;

class DivideIt
{
  static void Main()
  {
    Console.WriteLine("Hello how are you doing today please give me a number to divide it by two ");
    string stringNumber = Console.Readline();


    int yourNumber = int.Parse(stringNumber);
    int numberDivided = yourNumber * 2;

    string stringBackNumber = numberDivided.ToString();
    Console.WriteLine("I divided your number by two for you: " + stringBackNumber);
  }
}
