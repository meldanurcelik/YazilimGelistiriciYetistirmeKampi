using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ornekSozluk = new Dictionary<string, string>();
            ornekSozluk.Add("pzt", "Pazartesi");
            ornekSozluk.Add("sal", "Salı");
            ornekSozluk.Add("çar", "Çarşamba");
            ornekSozluk.Add("per", "Perşembe");
            ornekSozluk.Add("cu", "Cuma");
            ornekSozluk.Add("cmt", "Cumartesi");
            ornekSozluk.Add("paz", "Pazar");

            Console.WriteLine("Örnek sözlük: " + ornekSozluk["pzt"]);

            Console.WriteLine("Örnek anahtar kontrol: " + ornekSozluk.ContainsKey("sal"));
            Console.WriteLine("Örnek anahtar kontrol: " + ornekSozluk.ContainsKey("çrş"));
        }
    }
}
