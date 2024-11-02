using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace single_delegate_multi_delegate
{
    class Multicast_delegate
    {
        public delegate void NoParametrs();

        static void Main(string[] args) 
        {
            NoParametrs NoPar = new(ShowMassage_1);

            // multi cast delegated
            NoPar += ShowMassage_2;

            NoPar();

            Console.ReadLine();
        }

        private static void ShowMassage_1() => Console.WriteLine("Im used");

        private static void ShowMassage_2() => Console.WriteLine("Im used two");

    }
}
