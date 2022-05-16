using System;

class MainClass {
  public static int MDC(int x, int y){
    while (y != 0){
      int resultado = x % y;
      x = y;
      y = resultado;
    }
    return x;
  }
  public static int MMC(int x, int y){
    return x * (y / MDC(x, y));
  }
  public static void Main (string[] args) {
    int x = 60;
    int y = 100;
    int resultadoMDC = MDC(x, y);
    int resultadoMMC = MMC(x, y);
    Console.WriteLine($"resultado pra mdc é {resultadoMDC} e pra mmc é {resultadoMMC}.");
  }
}