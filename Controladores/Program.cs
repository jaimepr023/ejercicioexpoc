using verexponente.Servidores;

namespace verexponente
{
    class program
    {
        public static void Main(String[] args)
        {            
            PedirNumInterfaz pn = new PedirNumImplementacion();
            OperacionNumInterfaz on = new OperacionNumImplementacion();

            int numero1 = pn.PedirNum();
            on.Operacion(numero1);

        }
    }
}