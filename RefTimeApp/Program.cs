namespace RefTimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alex has started to work at 25 Minutes Interval!");
            Pomo pm = new Pomo();
            pm.TimerForWorkAndRestDurations();
        }
    }
}