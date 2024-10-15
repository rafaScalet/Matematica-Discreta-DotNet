namespace Matematica_Discreta.func;

public class Fibonacci {
  public static int calc (int quantity) {
    return calc(quantity, 0, 1);
  }

  private static int calc (int quantity, int first, int second) {
    Console.WriteLine($"{first} + {second} = {first + second}");

    if (quantity == 2) {
      return first + second;
    }

    return calc(quantity - 1, second, first + second);
  }
}