using System;
using System.Threading.Tasks;

namespace Item27
{
    public class Item27Tester
    {
        public static async Task Run()
        {
            System.Console.WriteLine("Enter SomeMethodAsync");
            System.Console.WriteLine("In SomeMethodAsync, before the await");
            await SomeMethodReturningTask();
            System.Console.WriteLine("In SomeMethodAsync, after the await");
        }

        private static async Task SomeMethodReturningTask()
        {
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Run(() =>
            {
                System.Console.WriteLine("SomeMethodReturningTask");
            });
            await Task.Delay(1000);
        }
    }
}