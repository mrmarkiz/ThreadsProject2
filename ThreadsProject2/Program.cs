using System.Reflection;

namespace ThreadsProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowTime();
            while (Console.ReadLine() != "end")
            { }
        }

        private static async Task<string> Time()
        {
            var res = $"\n{DateTime.Now.ToShortDateString()} | {DateTime.Now.ToLocalTime()}";
            return res;
        }

        private static async Task ShowTime()
        {
            while(true)
            {
                string res = await Time();
                Console.WriteLine(res);
                await Task.Delay(5000);
            }
        }
    }
}