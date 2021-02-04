using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchStop
{
    public class Program
    {
        static void Main(string[] args)
        {

            var theWatch = new TheWatch();
            Console.WriteLine("napiste 'START' pro spusteni stopek, nebo 'EXIT' pro ukonceni stopek.");

            while (true)
            {
                var inputStart = Console.ReadLine().ToUpper();

                if (inputStart == "START")
                {
                    theWatch.StartTheWatch();

                    while (true)
                    {
                        Console.WriteLine("napiste 'STOP' pro ukonceni odpoctu.");
                        var inputStop = Console.ReadLine().ToUpper();
                        if (inputStop == "STOP")
                        {
                            theWatch.EndTheWatch();
                            Console.WriteLine("stopky bezely: " + theWatch.Result());
                            Console.WriteLine("pro dalsi spusteni stopek napiste 'START', pro ukonceni stopek napiste 'EXIT'.");
                            break;
                        } 
                        else if (inputStart == "START")
                        {
                            theWatch.StartTheWatch();
                        }
                    }
                }
                else if (inputStart == "EXIT")
                {
                    Console.WriteLine("dekujeme ze vyuyziti, nashledanou.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("zadan spatny vyraz, ocekaval se 'START' nebo 'EXIT'");
                }
            }
        }
    }
}
