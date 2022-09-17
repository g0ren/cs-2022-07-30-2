using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Введите первое число");
    Int32 a= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите второе число");
    Int32 b= Convert.ToInt32(Console.ReadLine());
    if(b>a){
      Int32 t = a;
      a = b;
      b = t;
    }
    Console.Write ("НОД чисел {0} и {1}", a, b);
    Int32 R;
    while ((a % b) > 0)  {
      R = a % b;
      a = b;
      b = R;
    }
    Console.WriteLine (" равен {0}", b);
  }
}