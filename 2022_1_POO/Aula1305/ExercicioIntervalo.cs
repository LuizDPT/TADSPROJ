using System;

class MainClass {
  public static void Intervalo(double x, out int inicio, out int fim){
    inicio = int.Parse(Math.Floor(x));
    fim = int.Parse(Math.Ceiling(x));
  }
  public static void Main (string[] args) {
    double x = 3.2;
    Intervalo(x, out int inicio, out int fim);
    Console.WriteLine(inicio, fim);
  }
}