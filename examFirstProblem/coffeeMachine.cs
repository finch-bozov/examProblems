using System;
class Program
{
    static void Main()
    {
        int coinsFive = int.Parse(Console.ReadLine());
        int coinsTen = int.Parse(Console.ReadLine());
        int coinsTwenty = int.Parse(Console.ReadLine());
        int coinsFifty = int.Parse(Console.ReadLine());
        int coinsLev = int.Parse(Console.ReadLine());
        double moneyGiven = double.Parse(Console.ReadLine());
        double drinkPrice = double.Parse(Console.ReadLine());

        if (moneyGiven < drinkPrice)
        {
            Console.WriteLine("More {0: 0.00}", drinkPrice - moneyGiven);
            return;
        }

        if (moneyGiven == drinkPrice)
        {
            Console.WriteLine("Yes 0.00");
            return;
        }

        double difference = moneyGiven - drinkPrice;
        double totalOfFive = coinsFive * 0.05;
        double totalOfTen = coinsTen * 0.10;
        double totalOfTwenty = coinsTwenty * 0.20;
        double totalOfFifty = coinsFifty * 0.50;
        double totalOfLev = coinsLev * 1.00;
        double sumOfMoney = totalOfFive + totalOfTen + totalOfTwenty + totalOfFifty + totalOfLev;

        if (moneyGiven > drinkPrice)
        {
            double change = moneyGiven - drinkPrice;
            if (change <= sumOfMoney)
            {
                Console.WriteLine("Yes {0:0.00}", sumOfMoney - change);
            }
            else
            {
                Console.WriteLine("No {0:0.00}", change - sumOfMoney);
            }
        }
    }
}