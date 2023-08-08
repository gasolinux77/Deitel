using DeitelConsolePrograms.Programs;
using System;
using static DeitelConsolePrograms.Enumeraciones;

namespace DeitelConsolePrograms
{
    public class Menu
    {
        //Bienvenido a GitHub
        public void TextoMenu() 
        {
            Console.WriteLine("*********EJERCICIOS DE DEITEL**********" + Environment.NewLine);
            Console.WriteLine("Seleccione una opcion de Menú: " + Environment.NewLine);

            //Aqui añadir nombre de las clases y funciones
            Console.WriteLine("1.- Hola Mundo " + Environment.NewLine);
            Console.WriteLine("2.- Hola Mundo Con Saltos De Línea " + Environment.NewLine);
            Console.WriteLine("3.- Hola Mundo Con Distintos Saltos De Línea " + Environment.NewLine);
            Console.WriteLine("4.- Hola Mundo Otros Saltos De Línea " + Environment.NewLine);
            Console.WriteLine("5.- Sumar dos números " + Environment.NewLine);
            Console.WriteLine("6.- Restar dos números " + Environment.NewLine);
            Console.WriteLine("7.- Multiplicar dos números " + Environment.NewLine);
            Console.WriteLine("8.- Dividir dos números " + Environment.NewLine);
            Console.WriteLine("9.- Comparar dos números " + Environment.NewLine);
            Console.WriteLine("10.-Dibujar división " + Environment.NewLine);
            Console.WriteLine("0.- Salir " + Environment.NewLine);
        }

        public void PintaMenu() 
        {
            bool salir = false;
           
            while (!salir)
            {
                try
                {
                    TextoMenu();
                    var seleccion = Console.ReadLine().Trim();
                    HolaMundo claseHolaMundo = new HolaMundo();
                    Operaciones claseOperaciones = new Operaciones();

                    switch (seleccion)
                    {
                        //Añadir las opciones de los programas a ejecutar
                        case "0":
                            salir = true;
                            break;
                        case "1":
                            claseHolaMundo.PintaMensaje();
                            break;
                        case "2":
                            claseHolaMundo.PintaMensajeConSaltoLinea();
                            break;
                        case "3":
                            claseHolaMundo.PintaMensajeSaltosLinea();
                            break;
                        case "4":
                            claseHolaMundo.PintaMensajeOtrosTiposSaltoLinea();
                            break;
                        case "5":
                            claseOperaciones.OperacionesBasicas((int)TiposOperaciones.Suma);
                            break;
                        case "6":
                            claseOperaciones.OperacionesBasicas((int)TiposOperaciones.Resta);
                            break;
                        case "7":
                            claseOperaciones.OperacionesBasicas((int)TiposOperaciones.Multiplicación);
                            break;
                        case "8":
                            claseOperaciones.OperacionesBasicas((int)TiposOperaciones.División);
                            break;
                        case "9":
                            claseOperaciones.Comparacion();
                            break;
                        case "10":
                            claseOperaciones.DibujarDivision();
                            break;
                        default:
                            Console.WriteLine("Opción de programa no disponible");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
