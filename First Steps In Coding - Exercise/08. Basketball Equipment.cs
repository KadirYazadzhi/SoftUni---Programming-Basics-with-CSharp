using System;

public class BasketballEquipments {
    public static void Main(string[] args) {
        double moneyForOneYear = double.Parse(Console.ReadLine());
        
        double boots = moneyForOneYear * 0.6;
        double ekip = boots * 0.8;
        double ball = ekip / 4;
        double accessories = ball / 5;
        
        double sum = moneyForOneYear + boots + ekip + ball + accessories;
        
        Console.WriteLine(sum);
    }
}