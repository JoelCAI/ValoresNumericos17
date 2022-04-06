using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericos17
{
    public class Validador
    {

        public static decimal PedirDecimal(string mensaje)
        {

            
            decimal valor;
            bool valido = false;

            Console.WriteLine(mensaje);
            string mensajeDos = mensaje.Replace('.', ',');
            mensajeDos = Console.ReadLine();
            bool ok = decimal.TryParse(mensajeDos, out valor);

            string mensajeError = "\n El valor no puede ser vacio y tiene que estar entre el rango del Menu solicitado. ";

            do
            {


                if (!ok)
                {
                    Console.Clear();
                    Console.WriteLine(mensajeError);
                    return PedirDecimal(mensaje);
                }
                else if (valor < 1)
                {
                    Console.Clear();
                    Console.WriteLine(mensajeError);
                    return PedirDecimal(mensaje);
                }
               
                else
                {
                    valido = true;

                }

            } while (!valido);

            return valor;
        }

        public static void MostrarDecimal(decimal numero)
        {

            Console.WriteLine("\n Usted escribio " + "*" + numero + "*");

        }



        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }

    }
}
