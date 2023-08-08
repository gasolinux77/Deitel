using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeitelConsolePrograms.Programs
{
    public class HolaMundo
    {
        public void PintaMensaje()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("____________________PROGRAMA___________________");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Hola Mundo");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(Environment.NewLine);
        }

        public void PintaMensajeConSaltoLinea()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("____________________PROGRAMA___________________");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Hola" + Environment.NewLine + "Mundo");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(Environment.NewLine);
        }

        public void PintaMensajeSaltosLinea()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("____________________PROGRAMA___________________");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("¡Bienvenido " + Environment.NewLine + " a la" + Environment.NewLine + "programación en" + Environment.NewLine + "C#!" + Environment.NewLine);
            Console.WriteLine("¡Bienvenido\na la\nprogramación en\nC#!" + Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(Environment.NewLine);
        }

        public void PintaMensajeOtrosTiposSaltoLinea()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("____________________PROGRAMA___________________");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("{0}\n{1}", "¡Bienvenido a", "la programación en C#!" + Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
