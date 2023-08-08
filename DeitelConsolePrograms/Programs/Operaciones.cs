using System;
using static DeitelConsolePrograms.Enumeraciones;

namespace DeitelConsolePrograms.Programs
{
    public class Operaciones
    {
        public void OperacionesBasicas(int operacion)
        {
            int numero1; // declara el primer número a sumar
            int numero2; // declara el segundo número a sumar
            int resultado = 0; ; // declara la suma de numero1 y numero2

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("____________________PROGRAMA___________________");
            Console.WriteLine(Environment.NewLine);

            //Se añade comprobación para saber si escribe un entero       
            Console.Write("Escriba el primer entero: "); // mensaje para el usuario
                                                         // lee el primer número del usuario
            if (!(int.TryParse(Console.ReadLine(), out numero1)))
            {
                Console.WriteLine(Environment.NewLine);
                Console.Write("No ha introducido un número entero ");
                Console.WriteLine(Environment.NewLine);
                return;
            }


            Console.Write("Escriba el segundo entero: "); // mensaje para el usuario
                                                          // lee el segundo número del usuario
            if (!(int.TryParse(Console.ReadLine(), out numero2)))
            {
                Console.WriteLine(Environment.NewLine);
                Console.Write("No ha introducido un número entero ");
                Console.WriteLine(Environment.NewLine);
                return;
            }

            switch (operacion)
            {
                case (int)TiposOperaciones.Suma:
                    resultado = numero1 + numero2;
                    break;
                case (int)TiposOperaciones.Resta:
                    resultado = numero1 - numero2;
                    break;
                case (int)TiposOperaciones.Multiplicación:
                    resultado = numero1 * numero2;
                    break;
                case (int)TiposOperaciones.División:
                    if (numero2 == 0) 
                    { 
                    Console.Write("Error, imposible dividir entre 0...");
                    Console.WriteLine(Environment.NewLine); 
                    }
                    else
                        resultado = numero1 / numero2;

                    break;
            }


            
            if (operacion == (int)TiposOperaciones.División && numero2 == 0)
                return;
            else
                Console.WriteLine("El resultado es {0}", resultado); 

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(Environment.NewLine);
        }

        public void Comparacion() 
        {
            int numero1; // declara el primer número a comparar
            int numero2; // declara el segundo número a comparar

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("____________________PROGRAMA___________________");
            Console.WriteLine(Environment.NewLine);

            //pide al usuario y lee el primer número
            Console.Write("Escriba el primer entero: ");
            if (!(int.TryParse(Console.ReadLine(), out numero1)))
            {
                Console.WriteLine(Environment.NewLine);
                Console.Write("No ha introducido un número entero ");
                Console.WriteLine(Environment.NewLine);
                return;
            }

            //pide al usuario y lee el segundo número
            Console.Write("Escriba el segundo entero: ");
            if (!(int.TryParse(Console.ReadLine(), out numero2)))
            {
                Console.WriteLine(Environment.NewLine);
                Console.Write("No ha introducido un número entero ");
                Console.WriteLine(Environment.NewLine);
                return;
            }

            if (numero1 == numero2)
                Console.WriteLine("{0} == {1}", numero1, numero2);

            if (numero1 != numero2)
                Console.WriteLine("{0} != {1}", numero1, numero2);

            if (numero1 < numero2)
                Console.WriteLine("{0} < {1}", numero1, numero2);

            if (numero1 > numero2)
                Console.WriteLine("{0} > {1}", numero1, numero2);

            if (numero1 <= numero2)
                Console.WriteLine("{0} <= {1}", numero1, numero2);

            if (numero1 >= numero2)
                Console.WriteLine("{0} >= {1}", numero1, numero2);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(Environment.NewLine);
        }

        //Programa creado a traves de un promt del chat de bing, pendiente de revisar **GitHub
        public void DibujarDivision() 
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("____________________PROGRAMA___________________");
            Console.WriteLine(Environment.NewLine);

            // Pedir al usuario que ingrese el dividendo y el divisor
            Console.WriteLine("Ingrese el dividendo:");
            int dividendo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el divisor:");
            int divisor = int.Parse(Console.ReadLine());

            // Validar que el divisor no sea cero
            if (divisor == 0)
            {
                Console.WriteLine("Error: El divisor no puede ser cero.");
                return;
            }

            // Calcular el cociente y el residuo de la división
            int cociente = dividendo / divisor;
            int residuo = dividendo % divisor;

            // Dibujar la división con los residuos usando cadenas de texto
            string linea1 = " " + dividendo + " |" + divisor; // La primera línea muestra el dividendo y el divisor separados por una barra vertical
            string linea2 = " -" + (divisor * cociente) + " |" + cociente; // La segunda línea muestra el producto del divisor y el cociente, y el cociente separados por una barra vertical
            string linea3 = "  " + residuo; // La tercera línea muestra el residuo

            // Calcular la longitud máxima de las líneas para alinearlas correctamente
            int maxLongitud = Math.Max(linea1.Length, Math.Max(linea2.Length, linea3.Length));

            // Añadir espacios en blanco al final de cada línea para igualar su longitud a la máxima
            linea1 = linea1.PadRight(maxLongitud);
            linea2 = linea2.PadRight(maxLongitud);
            linea3 = linea3.PadRight(maxLongitud);

            // Mostrar las líneas en la consola usando un bucle for para recorrer cada carácter
            for (int i = 0; i < maxLongitud; i++)
            {
                Console.WriteLine(linea1[i] + "   " + linea2[i] + "   " + linea3[i]);
                if (i == 0 || i == 1) // Si es la primera o la segunda posición, dibujar una línea horizontal debajo del carácter
                {
                    Console.WriteLine("___   ___   ___");
                }

                if (i == maxLongitud - 1) // Si es la última posición, dibujar un signo igual debajo del carácter
                {
                    Console.WriteLine("=     =     =");
                }

            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
