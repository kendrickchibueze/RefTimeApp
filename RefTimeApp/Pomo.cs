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
        public bool TimerCount = true;
        public void WorkRestDuration(int workTime, int restTime)
        {
            DateTime startTime = DateTime.Now;
            while (TimerCount)
            {
                Stopwatch workStopwatch = new();
                if (workTime > 0)
                {
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
                TimeSpan workDurationstop = workStopwatch.Elapsed;
                PrintColorMessage(ConsoleColor.Yellow, "Your workTime has completed...");
                Console.WriteLine("\n");
                Stopwatch RestStopwatch = new();
                if (restTime > 0)
                {
                    int restTimeMin = restTime * 1000 * 60;
                    RestStopwatch.Start();
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
                string CheckTimer = Console.ReadLine();
                if (CheckTimer == "y")
                {
                    TimerCount = true;

                }

                else if (CheckTimer == "n")
                {
                    TimerCount = false;

                }

                else
                {
                    TimerCount = true;
                }


            }

            DateTime EndTime = DateTime.Now;
            PrintColorMessage(ConsoleColor.Yellow, "Your Session has Ended:");
            PrintColorMessage(ConsoleColor.Yellow, $"Start Time:{startTime}, \n EndTime:{EndTime.ToShortTimeString()}");
        }
        //Get and display app Info
        public void GetAppInfo()
        {
            // Set app vars
            string appName = "Pomodoro Timer App";
            string appVersion = "1.0.0";
            string appAuthor = "kendrck";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();
        }


        // print color message
        public void PrintColorMessage(ConsoleColor color, string message)
        {
            //tell user it is the wrong number
            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }
    }
}
