using System;

class MainClass {
  public static void Ordenar(ref int x, ref int y, ref int z) {
    int aux = x;
    if (aux > y){
      aux = y;
      x = y;
      y = aux;
    }
    if (aux > z){
      aux = z;
      x = z;
      z = aux;
    }
    if (y > z){
      int valorTroca = z;
      z = y;
      y = valorTroca;
    }
    
  }
  public static void Main (string[] args) {
    ref int a = 5;
    ref int b = 1;
    ref int c = 7;
    Ordenar(a, b , c);
    Console.WriteLine("teste");
  }
}