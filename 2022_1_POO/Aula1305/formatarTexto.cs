using System;

class MainClass {
  public static string FormatarTexto(string texto){
    string[] separarTexto = texto.Split(' ');
    string textoSemEspaco;
    foreach (string valor in separarTexto){
      textoSemEspaco += valor;
    }
    return textoSemEspaco;
  }
  public static void Main (string[] args) {
    string texto = "dois reis riam";
    Console.WriteLine(FormatarTexto(texto));
  }
}