namespace Matematica_Discreta.func;

public class Sum {
  public static int calc (int number) {
    if (number == 1) {
      Console.Write(number + " = ");
      return number;
    }

    Console.Write(number + " + ");
    return number + calc(number - 1);
  }
}