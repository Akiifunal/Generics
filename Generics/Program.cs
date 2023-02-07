// See https://aka.ms/new-console-template for more information
namespace Generics
{
    class Program
    {


        static void Main(string[] args)
        {
            MyDictionary <string> sehirler = new MyDictionary <string>();
            sehirler.Add("Maraş");
            sehirler.Add("Antep");
            sehirler.Add("Hatay");
            Console.WriteLine(sehirler.Length);
            Console.WriteLine("Dualarımız sizlerle");
        }
    }
}

