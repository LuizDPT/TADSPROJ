using System;

class MainClass {
  public static int MenorValor(int a, int b, int c) {
    int menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;
    return menor;
  }
  public static int MenorValor(int a, int b) {
    int menor = a;
    if (b < menor) menor = b;
    return menor;
  }
  public static void Main (string[] args) {
    int x = MenorValor(10, 3, 4);
    Console.WriteLine(x);
    Console.WriteLine(MenorValor(1, 3));
  }
}