using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verexponente.Servidores
{
    internal class OperacionNumImplementacion : OperacionNumInterfaz
    {
        public void Operacion(int n1)
        {
            int n2 = (int)Math.Sqrt(n1);//para tener una raiz se convierte en el tipo de numero y se pone esa expresion y dentro el numero que quiero hacerle la raiz.
            if (n1 == n2 * n2)
            {
                Console.WriteLine("El numero dado si tiene raiz entera. Y es la siguiente:");
                Console.WriteLine(n1+"="+n2+"*"+ n2);
            }
            else
            {
                Console.WriteLine("El numero dado no tiene raiz entera.");
            }
        }
    }
}
