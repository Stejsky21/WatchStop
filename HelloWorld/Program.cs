using System;
using System.Collections.Generic;

namespace StopWatch_Ex

{

    class Program

    {

        static void Main()

        {

            var theWatch = new StopWatch();

            Console.WriteLine("Please type start to begin");

            while (true)

            {

                var inputToStart = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(inputToStart) && inputToStart.ToLower() == "start")

                {

                    theWatch.StartTheWatch();

                    while (true)

                    {

                        Console.WriteLine("If you would like to stop the watch please type stop");

                        var inputToStop = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(inputToStop) && inputToStop.ToLower() == "stop")

                        {

                            theWatch.StopTheWatch();

                            break;

                        }

                        else if (inputToStop == "start")

                        {

                            throw new InvalidOperationException("Please follow directions");

                        }

                    }



                    Console.WriteLine($"The stop watch reads: {theWatch.ResultOfEntry()}");

                    Console.WriteLine("Would you like to make another entry?");

                    var inputToDoAgain = Console.ReadLine();

                    if (inputToDoAgain.ToLower() == "no")

                    {

                        Console.WriteLine("Goodbye");

                        Environment.Exit(0);

                    }

                }

            }

        }

    }

}