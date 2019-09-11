//Himanshi allang
//9/10/2019
//Create a program that emulates the CoinStar machine.The program accepts a monetary amount of cents.  It then determines how many quarters, dimes, nickels, and pennies you provided.It should then determine how much you earn in dollars and cents after the 10.9% fee.




using System;

class coinstar {
  public static void Main () 
{
    // Declaring the variables
    double  money, fees, change, Act_change, Act_money, NumQuarter, ChangeQuarter, NumDimes, ChangeDime, numnickels, ChnageNickel, NumPennies;
    

    // promoting the user to enter the amount of money
    string Amount;
    Console.WriteLine ("Hello World");
    Console.WriteLine ("Enter the amount of money($) that machine will be processed");
    Amount = Console.ReadLine ();
    money = double.Parse(Amount);
     

    
    fees = 0.109 ;
    change = money*100;
    Act_change = (int)change;
    
    Act_money = (money - (Act_change*fees)/100);
    //finding the number of quarters in money
    NumQuarter = Act_change / 25;
    ChangeQuarter = Act_change % 25;
    
    //finding the number of nickels in money
    NumDimes = ChangeQuarter / 10;
    ChangeDime = ChangeQuarter % 10;

    //finding the number of dimes in money

    numnickels = ChangeDime/ 5;
    ChnageNickel = ChangeDime % 5;
    
    //finding the number of pennies in money
    NumPennies = ChnageNickel;
    
    //telling user about the change in money
    Console.WriteLine("No. of quarters in change " + NumQuarter +  "No. of dimes in change" + NumDimes +  "No. of nickels in change" + numnickels +  "No. of pennies " + NumPennies );
     
  
    Console.WriteLine("amount of dollar you entered was "+ money +" and total dollar after the 10.9% fee is $ {0:0.00}", Act_money );
}

}
