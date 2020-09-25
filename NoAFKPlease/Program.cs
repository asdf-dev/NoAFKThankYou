using System;
using System.Threading;
using System.Windows.Forms;

namespace NoAFKPlease
{
    class Program
    {
        //min. Tid vi skal være afk før vi gør noget
        private static int TimerMin = 3;

        //vi ønsker at kunne lave random nummer til vores delay så vi ikke ligner en bot.
        private static Random RandomGen;

        //hvor mange gange har vi trykket hop
        private static int AntalPress = 0;

        //start af console program
        static void Main(string[] args)
        {
            //ny instance af random
            RandomGen = new Random();
            //printer afk intro i console
            IntroBitch();

            //starter et loop der ikke ender
            while (true)
            {
                //finder et random nummer imellem 1100, 53000
                int _delay = RandomGen.Next(1100, 53000);

                //laver en variable så vi kan refere den i det vi skriver ud samt hvor længe vi skal vente med at gøre noget..
                int _timeToSleep = TimerMin * 60000 + _delay;
                //her skriver vi ud hvor længe vi skal vente dividere med 60000 da sleep er i milisek, og vi vil gerne udskrive i minutter.
                Console.WriteLine($"Næste hop om: {_timeToSleep / 60000}min");
                //ref. til vores tid vi skal gøre ingen ting i programmet.
                Thread.Sleep(_timeToSleep);

                //sender vores hop
                SendKeys.SendWait(" ");
                //tæller antaltryk +1
                AntalPress++;
                //skriver vi er hoppe x gange
                Console.WriteLine($"hoppet: {AntalPress} gange");
            }
            //kode vi aldrig kommer til pga loop
            Console.ReadLine();
        }


        //metode til at printe afk ud i console
        private static void IntroBitch()
        {
            //skifter skrift til rød
            Console.ForegroundColor = ConsoleColor.Red;
            //hvad vi gerne vil printe ud
            string _intro = @"
 ███▄    █  ▒█████      ▄▄▄        █████▒██ ▄█▀   
 ██ ▀█   █ ▒██▒  ██▒   ▒████▄    ▓██   ▒ ██▄█▒    
▓██  ▀█ ██▒▒██░  ██▒   ▒██  ▀█▄  ▒████ ░▓███▄░    
▓██▒  ▐▌██▒▒██   ██░   ░██▄▄▄▄██ ░▓█▒  ░▓██ █▄    
▒██░   ▓██░░ ████▓▒░    ▓█   ▓██▒░▒█░   ▒██▒ █▄   
░ ▒░   ▒ ▒ ░ ▒░▒░▒░     ▒▒   ▓▒█░ ▒ ░   ▒ ▒▒ ▓▒   
░ ░░   ░ ▒░  ░ ▒ ▒░      ▒   ▒▒ ░ ░     ░ ░▒ ▒░   
   ░   ░ ░ ░ ░ ░ ▒       ░   ▒    ░ ░   ░ ░░ ░    
         ░     ░ ░           ░  ░       ░  ░      
By Team Gokkesokken                                                  
";
            //sætter farven på skrift tilbage
            Console.ResetColor();
            //udskriver det i programmet
            Console.WriteLine(_intro);
        }
    }
}
