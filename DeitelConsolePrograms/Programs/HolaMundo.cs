using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeitelConsolePrograms.Programs
{
    public class HolaMundo
    {
        Decoraciones decoraciones = new Decoraciones();
        public void PintaMensaje()
        {
            Console.WriteLine(decoraciones.Cabecera());
            Console.WriteLine("Hola Mundo");
            Console.WriteLine(decoraciones.Pie());            
        }

        public void PintaMensajeConSaltoLinea()
        {
            Console.WriteLine(decoraciones.Cabecera());
            Console.WriteLine("Hola" + Environment.NewLine + "Mundo");
            Console.WriteLine(decoraciones.Pie());
        }

        public void PintaMensajeSaltosLinea()
        {
            Console.WriteLine(decoraciones.Cabecera());
            Console.WriteLine("¡Bienvenido " + Environment.NewLine + " a la" + Environment.NewLine + "programación en" + Environment.NewLine + "C#!" + Environment.NewLine);
            Console.WriteLine("¡Bienvenido\na la\nprogramación en\nC#!" + Environment.NewLine);
            Console.WriteLine(decoraciones.Pie());
        }

        public void PintaMensajeOtrosTiposSaltoLinea()
        {
            Console.WriteLine(decoraciones.Cabecera());
            Console.WriteLine("{0}\n{1}", "¡Bienvenido a", "la programación en C#!" + Environment.NewLine);
            Console.WriteLine(decoraciones.Pie());
        }
    }
}
