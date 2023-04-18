using System;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Xml;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        // Приклад роботи з API System.IO
        File.WriteAllText("example.txt", "Hello, world!"); 
        string content = File.ReadAllText("example.txt"); 
        Console.WriteLine("Змiст файлу: " + content);

        // Приклад роботи з API System.Xml
        string xmlContent = "<person><name>John</name><age>30</age></person>";
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(xmlContent);
        XmlNode nameNode = xmlDoc.SelectSingleNode("//name");
        XmlNode ageNode = xmlDoc.SelectSingleNode("//age");
        Console.WriteLine("Iм'я особи: " + nameNode.InnerText);
        Console.WriteLine("Вiк особи: " + ageNode.InnerText);
        // Приклад роботи з API System.Security.Cryptography
        string plainText = "This is a secret message.";
        using (var md5 = MD5.Create())
        {
            byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            string hash = BitConverter.ToString(hashBytes).Replace("-", "");
            Console.WriteLine("MD5 hash: " + hash);
        }
        // Приклад роботи з API System.Linq
        int[] numbers = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Парнi числа:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
        // Приклад роботи з API System.Threading
        Mutex mutex = new Mutex();
        mutex.WaitOne();
        Console.WriteLine("Початок 20-ти секундної секцiї");
        Thread.Sleep(20000);
        Console.WriteLine("Кiнець секцiї");
        mutex.ReleaseMutex();
        Console.ReadLine();
    }
}