using verexponente.Servidores;

namespace verexponente
{
    /// <summary>
    /// clase donde se encuentra nuestro metodo main
    /// <author>241023-jpr</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// metodo principal donde se encuentra todos nuestro esqueleto del programa
        /// <author>241023-jpr</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {            
            PedirNumInterfaz pn = new PedirNumImplementacion();
            OperacionNumInterfaz on = new OperacionNumImplementacion();

            int numero1 = pn.PedirNum();
            on.Operacion(numero1);

        }
    }
}