using System;

class MainClass {
  public static void Main (string[] args) {
    string[] tempo = Console.ReadLine().Split(' ');
    int A,B,C,D;
    A = int.Parse(tempo[0]);
    B = int.Parse(tempo[1]);
    C = int.Parse(tempo[2]);
    D = int.Parse(tempo[3]);
    if ((B > C) & (D > A) & ((C+D)>(A+B)) & (C > 0) & (D > 0) & ((A%2)==0)) {
      Console.WriteLine("Valores aceitos");
    }
    else {
      Console.WriteLine("Valores nao aceitos");
    }
  }
}