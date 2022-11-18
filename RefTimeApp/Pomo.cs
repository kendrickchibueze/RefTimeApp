using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTimeApp
{
    public class PomoTimer
    {
        private bool _TimerCount = true;


        public void WorkRestDuration(int workTime, int restTime)
        {
            DateTime startTime = DateTime.Now;


            while (_TimerCount)
            {
                Stopwatch workStopwatch = new();
                if (workTime > 0)
                {
                    //convert to milliseconds
                    int workTimeMin = workTime * 1000 * 60;

                    workStopwatch.Start();

                    PrintColorMessage(ConsoleColor.Yellow, "Work Time is active...");

                    Thread.Sleep(workTimeMin);

                    workStopwatch.Stop();
                }
                else
                {
                    PrintColorMessage(ConsoleColor.Red, "please change your worktime");
                }


                //A TimeSpan object represents a time interval (duration of time or elapsed time)
                //that is measured as a positive or negative number of days, hours, minutes,
                TimeSpan workDurationstop = workStopwatch.Elapsed;

                PrintColorMessage(ConsoleColor.Yellow, "Your workTime has completed...");

                Console.WriteLine("\n");

                Stopwatch RestStopwatch = new();

                if (restTime > 0)
                {
                    //convert to milliseconds
                    int restTimeMin = restTime * 1000 * 60;

                    RestStopwatch.Start();

                    Console.Beep();

                    PrintColorMessage(ConsoleColor.Cyan, "Rest Timer Active...");

                    Thread.Sleep(restTimeMin);

                    RestStopwatch.Stop();
                }
                else
                {
                    PrintColorMessage(ConsoleColor.Red, "Please change your rest time");

                }
                TimeSpan restDurationstop = RestStopwatch.Elapsed;

                PrintColorMessage(ConsoleColor.Cyan,"Your restTime has completed...");

                Console.WriteLine("\n");

                PrintColorMessage(ConsoleColor.Yellow, "Do you want to continue this cycle? (y/n)");

                string CheckRound = Console.ReadLine().ToLower();

                if (CheckRound == "y")
                {
                    _TimerCount = true;

                }

                else if (CheckRound == "n")
                {
                    _TimerCount = false;

                }

                else
                {
                    _TimerCount = true;
                }


            }

            DateTime EndTime = DateTime.Now;

            PrintColorMessage(ConsoleColor.Yellow, "Your Session has Ended:");

            PrintColorMessage(ConsoleColor.Yellow, $"Start Time:{startTime}, \n EndTime:{EndTime.ToShortTimeString()}");
        }


        public class Application
        {
             public static void Run()
            {
                PomoTimer timer = new PomoTimer();
                timer.PrintColorMessage(ConsoleColor.Cyan, "**********Welcome To Pomodoro Timer************");

                timer.PrintColorMessage(ConsoleColor.Blue, "Please enter a work time duration in minutes:");

                try
                {
                    int workTime = Convert.ToInt32(Console.ReadLine());

                    timer.PrintColorMessage(ConsoleColor.Blue, "Please enter a Rest time duration in minutes:");

                    int restTime = Convert.ToInt32(Console.ReadLine());

                    timer.WorkRestDuration(workTime, restTime);

                    Console.ReadLine();

                }
                catch (Exception e)
                {
                    timer.PrintColorMessage(ConsoleColor.Red, "invalid input, enter an integer in minutes");

                }

            }
        }



        // print color message
        public void PrintColorMessage(ConsoleColor color, string message)
        {
            
            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }
    }
}
