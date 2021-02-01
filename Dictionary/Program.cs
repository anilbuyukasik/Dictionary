using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> aylar = new MyDictionary<int, string>();
            aylar.Add(1, "Ocak");
            aylar.Add(2, "Şubat");
            aylar.Add(3, "Mart");

            Console.WriteLine(aylar.Length);
        }
    }
}
