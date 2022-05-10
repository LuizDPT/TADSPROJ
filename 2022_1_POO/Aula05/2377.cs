using System;

class Program {
  public static void Main(){
    string[] a = Console.ReadLine().Split();
    string[] b = Console.ReadLine().Split();

    int l = int.Parse(a[0]);
    int d = int.Parse(a[1]);

    int k = int.Parse(b[0]);
    int p = int.Parse(b[1]);

    int pedagio = (l / d);
    int valor_pedagio = pedagio * p;

    int custo = (valor_pedagio + (k * l));
    Console.WriteLine($"{custo}");
  }
}
