using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("while");
    int x = 1;
    while (x <= 10) {
      Console.WriteLine(x);
      x++;
    }

    Console.WriteLine("for");
    for (x = 1; x <= 10; x++){
      Console.WriteLine(x);
    }
    
    Console.WriteLine("do-while");
    x = 15;
    do {
      Console.WriteLine(x);
      x++;
    } while (x <= 10);

    
  }
}