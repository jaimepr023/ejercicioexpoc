using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verexponente.Servidores
{
    internal class OperacionNumImplementacion : OperacionNumInterfaz
    {
        public void Operacion(int n1, int n2)
        {
            Console.WriteLine("Los numeros dados te dara si el primero es cuadrado o no del segundo numero \n");
           if(n1== n2*n2 )
            {
                Console.WriteLine("Este primer numero: " + n1 + " es el cuadrado del segundo numero: " + n2);
            }
            else
            {
                Console.WriteLine("Este primer numero: " + n1 + " no es el cuadrado del segundo numero: " + n2);
            }
        }
    }
}
