using System;

namespace DeitelConsolePrograms.Programs
{
    public class Decoraciones
    {
        public string Cabecera() 
        {
            return Environment.NewLine + "____________________PROGRAMA___________________" + Environment.NewLine;
        }

        public string Pie()
        {
            return Environment.NewLine + "_______________________________________________" + Environment.NewLine;
        }

        public string MensajeConDosSaltos(string mensaje)
        {
            return Environment.NewLine + mensaje + Environment.NewLine;
        }
    }
}
