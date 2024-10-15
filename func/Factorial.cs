namespace Matematica_Discreta.func;

public class Factorial {
  public static int calc (int number) {
    if (number == 1) {
      Console.Write(number + " = ");
      return number;
    }

    Console.Write(number + " x ");
    return number * calc(number - 1);
  }
}