using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verexponente.Servidores
{
    internal class PedirNumImplementacion : PedirNumInterfaz
    {
        public int PedirNum()
        {
            int num1;

            Console.WriteLine("Dame un numero:");
            num1 = Int32.Parse(Console.ReadLine());
            return num1;
        }
    }
}
