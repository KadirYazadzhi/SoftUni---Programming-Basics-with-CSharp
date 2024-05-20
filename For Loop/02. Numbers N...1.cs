using System;
class Number {
  static void Main() {
      int num = int.Parse(Console.ReadLine());
    for(int i = num; i >= 1; i--) {
        Console.WriteLine(i);
    }
  }
}