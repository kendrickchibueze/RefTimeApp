namespace RefTimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To our Pomodoro Timer App");
            Console.WriteLine("\nAlex has started to work at 25 Minutes Interval!");
            Pomo pm = new Pomo();
            pm.TimerForWorkAndRestDurations();
        }
    }
}