using Matematica_Discreta.func;

while (true) {
  Console.WriteLine("\n|-----------------------------|");
  Console.WriteLine("| Chose an option:            |");
  Console.WriteLine("| [1] Multiplication [4] Sum  |");
  Console.WriteLine("| [2] Fibonacci      [5] Exit |");
  Console.WriteLine("| [3] Factorial               |");
  Console.WriteLine("|-----------------------------|");
  Console.Write("↳ ");

  int option = int.Parse(Console.ReadLine() ?? "0");

  switch (option) {
    case 1:
      Console.Write("\nEnter the first number: ");
      int firstNumberToMultiplication = int.Parse(Console.ReadLine() ?? "0");

      Console.Write("Enter the second number: ");
      int secondNumberToMultiplication = int.Parse(Console.ReadLine() ?? "0");

      int resultOfMultiplication = Multiplication.calc(firstNumberToMultiplication, secondNumberToMultiplication);

      Console.WriteLine($"\nThe result is: {resultOfMultiplication}");
      break;
    case 2:
      Console.Write("\nType a number: ");
      int numberForFibonacci = int.Parse(Console.ReadLine() ?? "0");

      Fibonacci.calc(numberForFibonacci);
      break;
    case 3:
      Console.Write("\nType a number: ");
      int numberForFactorial = int.Parse(Console.ReadLine() ?? "0");

      int resultOfFactorial = Factorial.calc(numberForFactorial);

      Console.WriteLine(resultOfFactorial);
      break;
    case 4:
      Console.Write("\nType a number: ");
      int numberForSum = int.Parse(Console.ReadLine() ?? "0");

      int resultOfSum = Sum.calc(numberForSum);

      Console.WriteLine(resultOfSum);
      break;
    case 5:
      Console.WriteLine("\nExiting...");
      return;
    default:
      Console.WriteLine("\nType a valid option...");
      break;
  }
}
