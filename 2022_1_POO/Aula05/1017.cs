using System;

class Program {
  public static void Main(){
    int valor1 = int.Parse(Console.ReadLine());
    int valor2 = int.Parse(Console.ReadLine());
    double valor3 = valor2 * valor1;
    double litros = valor3 / 12;
    Console.WriteLine($"{litros:0.000}");
  }
}
