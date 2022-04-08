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
            decimal numeroUno;
            decimal numeroDos;

            

            Validador.Bienvenida();

            numeroUno = Validador.PedirNumeroDecimal("\n Ingrese el primero valor numérico.");

            Console.Clear();
            numeroDos = Validador.PedirNumeroDecimal("\n Ingrese el segundo valor numérico.");

  
            decimal suma = numeroUno + numeroDos;
            decimal resta = numeroUno - numeroDos;
            decimal multiplicacion = numeroUno * numeroDos;
            decimal division = numeroUno / numeroDos;
            decimal resto = numeroUno % numeroDos;

            double numeroUnoPotencia = Convert.ToDouble(numeroUno);
            double numeroDosPotencia = Convert.ToDouble(numeroDos);

            double potencia = Math.Pow(numeroUnoPotencia, numeroDosPotencia);

            Console.Clear();
            Console.WriteLine(" \n La suma de *" + numeroUno + "* más" + " *" + numeroDos + "* es: *" + suma + "*");
            Console.WriteLine(" \n La Resta de *" + numeroUno + "* menos" + " *" + numeroDos + "* es: *" + resta + "*");
            Console.WriteLine(" \n La Multiplicación de *" + numeroUno + "* por" + " *" + numeroDos + "* es: *" + multiplicacion + "*");
            Console.WriteLine(" \n La División de *" + numeroUno + "* entre" + " *" + numeroDos + "* es: *" + division + "*");
            Console.WriteLine(" \n El Resto de *" + numeroUno + "* entre" + " *" + numeroDos + "* es: *" + resto + "*");
            Console.WriteLine(" \n La Potencia de *" + numeroUno + "* elevado a la" + " *" + numeroDos + "* es: *" + potencia + "*");

            Console.WriteLine(" \n Si el resultado no fue el esperado es porque ignoró la recomendación e ingreso" +
                              " un punto en vez de una coma");


            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
