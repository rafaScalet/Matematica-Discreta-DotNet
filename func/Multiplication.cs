namespace Matematica_Discreta.func;

public class Multiplication {
  public static int calc (int first, int second) {
    if (second == 0) {
      return 0;
    }

    return first + calc(first, second - 1);
  }
}