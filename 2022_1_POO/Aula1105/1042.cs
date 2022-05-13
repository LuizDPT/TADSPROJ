using System;

class MainClass {
  public static void Main (string[] args) {
    string[] valores = Console.ReadLine().Split(" ");
    int valorUm = int.Parse(valores[0]);
    int valorDois = int.Parse(valores[1]);
    int valorTres = int.Parse(valores[2]);
    int valor;
    if (valorUm > valorDois){
      valor = valorUm;
      valorUm = valorDois;
      valorDois = valor;
    }
    if (valorUm > valorTres){
      valor = valorUm;
      valorUm = valorTres;
      valorTres = valor;
    }
    if (valorDois > valorTres){
      valor = valorDois;
      valorDois = valorTres;
      valorTres = valor;
    }
    Console.WriteLine($"{valorUm}\r\n{valorDois}\r\n{valorTres}");
    Console.WriteLine();
    Console.WriteLine($"{valores[0]}\r\n{valores[1]}\r\n{valores[2]}");
  }
}