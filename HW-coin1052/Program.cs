using System;
public class Program{

    public static void Main(string[] args){
        Console.WriteLine("Please input your money :");
        string money_input;
        money_input = Console.ReadLine();
        double money = Convert.ToDouble(money_input);
        if (money<=0)
                throw new ArgumentException("Where your money? :Please Try again");
            double ans = money%0.25;
        if (ans!=0)
                throw new ArgumentException("Cant Change money :Please Try again");
    CalculationAndPrint(money);

    }
    static void CalculationAndPrint(double money) {
       double amout;
        if (money>1000){    
            amout = Math.Floor(money/1000);
            Console.WriteLine("1000 : {0}",amout);
            money = money%1000;
        }
        if (money>500){    
            amout = Math.Floor(money/500);
            Console.WriteLine("500 : {0}",amout);
            money = money%500;
        }
        if (money>100){    
            amout = Math.Floor(money/100);
            Console.WriteLine("100 : {0}",amout);
            money = money%100;
        }
        if (money>50){    
            amout = Math.Floor(money/50);
            Console.WriteLine("1000 : {0}",amout);
            money = money%50;
        }
        if (money>20){    
            amout = Math.Floor(money/20);
            Console.WriteLine("20 : {0}",amout);
            money = money%20;
        }
        if (money>10){    
            amout = Math.Floor(money/10);
            Console.WriteLine("10 : {0}",amout);
            money = money%10;
        }
        if (money>5){    
            amout = Math.Floor(money/5);
            Console.WriteLine("5 : {0}",amout);
            money = money%5;
        }
        if (money>2){    
            amout = Math.Floor(money/2);
            Console.WriteLine("2 : {0}",amout);
            money = money%2;
        }
        if (money>1){    
            amout = Math.Floor(money/1);
            Console.WriteLine("1 : {0}",amout);
            money = money%1;
        }
        if (money>0.5){    
            amout = Math.Floor(money/0.5);
            Console.WriteLine("0.5 : {0}",amout);
            money = money%0.5;
        }if (money>=0.25){    
            amout = Math.Floor(money/0.25);
            Console.WriteLine("0.25 : {0}",amout);
        }
    }

}