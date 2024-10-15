using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void piramide()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("n debe ser mayor o igual a 0");
                n = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n - i; k++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        static void eje01()
        {
            Console.Write("Introduzca un número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca otro número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            while (n2 == 0) { 
                Console.WriteLine("Este número debe ser distinto de 0");
                Console.Write("Introduzca otro número: ");
                n2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("La suma es " + (n1+n2));
            Console.WriteLine("La resta es " + (n1 - n2));
            Console.WriteLine("La multiplicación es " + (n1 * n2));
            Console.WriteLine("La división es " + (n1 / n2));
            Console.WriteLine("El módulo es " + (n1 % n2));
        }

        static void eje02() {
            const double precioHamburguesa = 10.5;
            const double precioPatata = 1.7;
            const double precioBebida = 2.6;

            Console.Write("Cantidad de hamburguesas: ");
            int nHam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad de papas: ");
            int nPapa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad de bebidas: ");
            int nBebida = Convert.ToInt32(Console.ReadLine());

            double total = (precioHamburguesa * nHam) + (precioPatata * nPapa) + (precioBebida * nBebida);
            Console.WriteLine("Cantidad a pagar: " + total + " $");
        }

        static void eje03() {
            Console.Write("Introduce un número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor absoluto: " + (Math.Abs(n)));
            Console.WriteLine("Potencia al cubo: " + (Math.Pow(n, 3)));
            Console.WriteLine("Raíz cuadrada: " + (Math.Sqrt(n)));
            Console.WriteLine("Raíz cuadrada: " + (Math.Sqrt(n)));
            Console.WriteLine("Seno: " + (Math.Sin(n)));
            Console.WriteLine("Coseno: " + (Math.Cos(n)));
        }

        static void eje04() {
            Console.Write("Introduzca el lado del cuadrado: ");
            int l = Convert.ToInt32(Console.ReadLine());

            int perimetro = 0;
            for(int i=0; i<4; i++) {
                perimetro += l;
            }

            Console.WriteLine("El perímertro es " + perimetro);
            Console.ReadLine();
        }

        static void eje05() {
            int suma = 0;
            int producto = 1;

            for(int i = 0; i<4; i++) {
                Console.Write("Introduzca un número: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (i <= 1) {
                    suma += n;
                }
                else
                {
                    producto *= n;
                }
            }

            Console.WriteLine("La suma es: " + suma + "\nEl producto es: " + producto);
            Console.ReadLine();
        }

        static void eje06() {
            int suma = 0;

            for(int i = 0; i < 4; i++) {
                Console.Write("Intrduzca un número: ");
                int n = Convert.ToInt32(Console.ReadLine());

                suma += n;
            }

            double promedio = suma / 4;

            Console.WriteLine("La suma es: " + suma + "\nEl promedio es: " + promedio);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            eje06();
        }
    }
}
