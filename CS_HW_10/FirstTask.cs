using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_10
{
    public static class FirstTask
    {
        public static void Init()
        {
            Task task1 = Task.Run(() => PrintMessage("Hello guys"));
            Task task2 = Task.Run(() => CalcSum(2, 5));
            Task task3 = Task.Run(() => Sleeper(2));
            Task.WaitAll(task1, task2, task3);
        }   
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void CalcSum(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine($"Sum: {sum}");
        }

        public static void Sleeper(int timeseconds)
        {
            Task.Delay(timeseconds*1000).Wait();
            Console.WriteLine($"Slept for {timeseconds * 1000} seconds!");
        }

    }
}
