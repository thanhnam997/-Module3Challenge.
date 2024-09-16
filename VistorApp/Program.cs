using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the animal's hunger level (1-10): ");
            int hungerLevel = int.Parse(Console.ReadLine());
            //Add code here for your if-else statement.
       if ( hungerLevel >= 8)
       {
               Console.WriteLine("Lion: Roar! I need a big meal ");
       }
       
       else if(hungerLevel >5) 
         {  
             Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
         }
         else
         {
            Console.WriteLine("Tortoise: Slow and steady—I'll have some lettuce.");
         }
            // Ternary operator to output an animal sound
          string animalSound = hungerLevel >= 8 ? "Listen to the Lion: Roar!" : hungerLevel 
          > 5  ? "Listen to the Monkey: Ooh ooh!"   : "Listen to the Tortoise: Slow and steady—I'll have some lettuce.";
          
           Console.WriteLine(animalSound);
         
     // Prompt the user to enter a day of the week
     Console.Write("Enter a day of the week (1-7,1 = Sunday, 2 = Monday, etc.): ");
            int dayOfWeek = int.Parse(Console.ReadLine());
    // Switch statement to display Zoo-themed messages
    switch (dayOfWeek)
    {
        case 1 :
                    Console.WriteLine("Sunday: Family Fun Day at the Zoo!");
                    break;
        case 2 : 
                    Console.WriteLine("Monday: Happy Monday");
                    break;
        case 3 :
                    Console.WriteLine("Tuesday:10% discount for everyone");
                    break;
        case 4:   
                     Console.WriteLine("Wednesday:Aminals Shows");
                     break;
        case 5:     
                     Console.WriteLine("Thursday:Secret game ");
                     break;
        case 6:     
                     Console.WriteLine("Friday:Free foods for everyone");
                     break;
        case 7:     
                     Console.WriteLine("Sarturday: Big prize for Winer of special game");
                     break;
         
    }
        
         }
    }
}