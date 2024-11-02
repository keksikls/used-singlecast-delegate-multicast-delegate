using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_delegate_multi_delegate
{
    internal class singlecast_delegate
    {
        class Program
        {
            public delegate string Parametrs(string name_1, string name_2);

            static void Main(string[] args)
            {
                //ссылается на 1 метод
                Parametrs MyParam = new(WriteMassage);

                string value = MyParam("Ejik", "Krosh");

                Console.WriteLine(value);

                Console.ReadLine();
            }

            private static string WriteMassage(string name_1, string name_2)
            {
                Console.WriteLine($"{name_1} , {name_2} - using delegate great");
                return "from me";
            }
        }
    }
}
