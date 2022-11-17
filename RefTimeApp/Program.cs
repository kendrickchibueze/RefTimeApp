namespace RefTimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PomoTimer timer = new PomoTimer();
            timer.PrintColorMessage(ConsoleColor.Cyan, "**********Welcome To Pomodoro Timer************");
            timer.PrintColorMessage(ConsoleColor.Blue, "Please enter a work time duration in minutes:");
            int workTime = Convert.ToInt32(Console.ReadLine());
            timer.PrintColorMessage(ConsoleColor.Blue, "Please enter a Rest time duration in minutes:");
            int restTime = Convert.ToInt32(Console.ReadLine());
            timer.WorkRestDuration(workTime, restTime);
            Console.ReadLine();
        }
    }
}