using System;
using TestClient;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test client=new Test(new Uri("http://localhost:49204/"));

            var res = client.Hello.Get("World");

            Console.WriteLine("res={0}", res.Result);
        }
    }
}
