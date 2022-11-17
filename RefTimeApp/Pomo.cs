using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTimeApp
{
     class Pomo
    {
       //data field members
        bool worksession = true;
     
        //methods
        public void TimerForWorkAndRestDurations()
        {
            while (worksession)
            {
                Stopwatch stopwatch = new();

                using (new Timer(ExecutesForWork, null, TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(1)))
                {
                    while (true)
                    {
                        if (Console.ReadLine() == "quit")
                        {
                            stopwatch.Stop();
                            break;
                        }
                    }
                  
                }

            }
               
        }

        //Every 1 minute, it tells you that Alex s still working and Every 10 minute, it gives you the time remaining!

        private static void ExecutesForWork(object state)
        {
            Stopwatch stopwatch = new();

            //count down from 25 minutes for every one minutes
            for (int a = 24; a >= 0; a--)
            {
                //Console.CursorLeft = 22;
                
                
                Console.WriteLine("Alex is still working...");

                //after every 10 minutes show the amount of time remaining
                Thread.Sleep(600000);

                Console.Write("{0} Minutes Left ", a-10);
                

                //System.Threading.Thread.Sleep(1000);

                if (a == 0)
                {
                    Console.Beep();
                    //TimeSpan ts = stopwatch.Elapsed;
                    Console.WriteLine("Your WorkTime has completed");
                    Console.WriteLine("Now Counting down Rest Time...");
                    System.Threading.Thread.Sleep(1000);
                    TimeSpan ts = stopwatch.Elapsed;
                    Console.WriteLine("Your Session Time is {0:00}:{1:00}:{2:00}",
                       ts.Hours, ts.Minutes, ts.Seconds);

                    Stopwatch stopwatch2 = new();
                    for (int b = 5; b >= 0; b--)
                    {
                        stopwatch2.Start();
                        Console.CursorLeft = 22;
                        Console.WriteLine("Alex is resting");
                        Console.Write("{0} ", b);    // Add space to make sure to override previous contents
                        System.Threading.Thread.Sleep(60000);
                        if (b==0)
                        {
                            stopwatch2.Stop();
                            

                        }
                        TimeSpan rts = stopwatch.Elapsed;
                        Console.WriteLine("Your Session Time is {0:00}:{1:00}:{2:00}",
                        rts.Hours,  rts.Minutes,  rts.Seconds);
                    }
                    //TimeSpan rts = stopwatch.Elapsed;
                   // Console.WriteLine("Your Session Time is {0:00}:{1:00}:{2:00}",
                        //ts.Hours + rts.Hours, ts.Minutes + rts.Minutes, ts.Seconds + rts.Seconds);
                }
            
            }

        }
      
    }   
}
