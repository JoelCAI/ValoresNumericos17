using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericos17
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            decimal cadenaUno;

            Validador.Bienvenida();

            cadenaUno = Validador.PedirDecimal("\n Ingrese un valor numérico.");

            Validador.MostrarDecimal(cadenaUno);

            int dos = 2;

            decimal suma = cadenaUno + dos;

            Console.WriteLine("La suma es: " + suma);

            

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
