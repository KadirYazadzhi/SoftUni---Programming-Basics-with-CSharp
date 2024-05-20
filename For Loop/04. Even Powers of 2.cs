using System;
class EvenPowers {
  static void Main() {
      int num = int.Parse(Console.ReadLine());
    for(int i = 0; i <= num; i++) {
        if (i % 2 == 0) {
            int answer = (int)Math.Pow(2, i);;
            Console.WriteLine(answer);
        }
    }
  }
}