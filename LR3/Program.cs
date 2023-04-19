using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Thread t1 = new Thread(WriteNumbers);
        t1.Start();
        t1.Join();
        Console.WriteLine("Counting numbers in a separate thread:");
        CountNumbers(10);
        Console.WriteLine("Done counting.");
        var task = DoAsyncWork();
        Console.WriteLine("Очiкування завершення асинхронної роботи...");
        task.Wait();
        Console.WriteLine("Виконання завершено.");
    }
    static void CountNumbers(int n)
    {
        Thread t = new Thread(() =>
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        });

        t.Start();
    }
    static void WriteNumbers()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write(i + " ");
            Thread.Sleep(500);
        }
    }

    static async Task DoAsyncWork()
    {
        Console.WriteLine($"Початок асинхронної роботи в потоцi {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(3000); 
        Console.WriteLine($"Завершення асинхронної роботи в потоцi {Thread.CurrentThread.ManagedThreadId}");
    }
}