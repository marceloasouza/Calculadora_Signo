using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Signo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            string mes;

            Console.WriteLine("Em que dia você nasceu?");
            dia = Console.ReadLine();

            Console.WriteLine("Em que mes você nasceu?");
            mes = Console.ReadLine();

            int diaInt = 0;
            int mesInt = 0;

            try
            {
                diaInt = Convert.ToInt32(dia);
                mesInt = Convert.ToInt32(mes);
            }
            catch (FormatException ex)
            {

               Console.WriteLine(ex.Message);
                
                Console.ReadLine();
                Environment.Exit(1);
            }


            InterpregadorSigno interpretador = new InterpregadorSigno();
            Signo signo = interpretador.Interpretar(diaInt, mesInt );

            if(signo != null)
            {
                Console.WriteLine("Seu signo é " + signo.nome + " -- " + signo.caracteristicas);
                
            }
            else
            {
                Console.WriteLine("Dia ou mês invalido.");
            }
            Console.ReadLine();

        }
    }
}
