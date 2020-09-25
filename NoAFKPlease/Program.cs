using System;
using System.Threading;
using System.Windows.Forms;

namespace NoAFKPlease
{
    class Program
    {
        private static int TimerMin = 3;

        private static Random RandomGen;

        private static int AntalPress = 0;

        static void Main(string[] args)
        {
            RandomGen = new Random();
            IntroBitch();

            while (true)
            {
                int _delay = RandomGen.Next(1100, 53000);

                int _timeToSleep = TimerMin * 60000 + _delay;
                Console.WriteLine($"Næste hop om: {_timeToSleep / 60000}min");
                Thread.Sleep(_timeToSleep);

                SendKeys.SendWait(" ");
                AntalPress++;
                Console.WriteLine($"hoppet: {AntalPress} gange");
            }
            Console.ReadLine();
        }



        private static void IntroBitch()
        {
            Console.ForegroundColor = ConsoleColor.Red;
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
            Console.ResetColor();
            Console.WriteLine(_intro);
        }
    }
}
