using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the animal's hunger level (1-10): ");
            int hungerLevel = int.Parse(Console.ReadLine());
            
            if(hungerLevel >= 8){
                Console.WriteLine("Lion: Roar! I need a big meal!");

            } else if (hungerLevel >= 5){
                Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
            } else{
                Console.WriteLine("Tortoise: Slow and steady-I'll have some lettuce.");
            }//end else

            //Ternary operator
            string message = (hungerLevel >= 8) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";

            //Switch
            Console.Write("Enter the day of the week 1-7: ");
            int dayOfTheWeek = int.Parse(Console.ReadLine());
            string dailyMessage = "";
            switch(dayOfTheWeek){
                case 1:
                    dailyMessage = "Monday is Moo-vie Day at the Cow Enclosure!";
                    break;
                case 2:
                    dailyMessage = "Tuesday is Two-for-One admission!";
                    break;
                case 3: 
                    dailyMessage = "Wednesdays are wet & wild at the aquarium!";
                    break;
                case 4:
                    dailyMessage = "Thursdays are senior day! Zoo admission is 20% off for 65+ patrons!";
                    break;
                case 5:
                    dailyMessage = "Friday is Fry-yay! Buy-one-get-one-free small fries at Zooper Food Cafe!";   
                    break;
                case 6:
                    dailyMessage = "Super Saturdays! Free Zoo stickers for kids ten and under!";
                    break;
                case 7:
                    dailyMessage = "Sunday Funday! Enjoy a picnic in the picnic area near the pengiuns.";
                    break;
            }//end switch

            //Output the daily message
            Console.WriteLine(dailyMessage);
        }
    }
}
 