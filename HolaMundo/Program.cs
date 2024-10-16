using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void t1Eje01()
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

        static void t1Eje02() {
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

        static void t1Eje03() {
            Console.Write("Introduce un número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor absoluto: " + (Math.Abs(n)));
            Console.WriteLine("Potencia al cubo: " + (Math.Pow(n, 3)));
            Console.WriteLine("Raíz cuadrada: " + (Math.Sqrt(n)));
            Console.WriteLine("Raíz cuadrada: " + (Math.Sqrt(n)));
            Console.WriteLine("Seno: " + (Math.Sin(n)));
            Console.WriteLine("Coseno: " + (Math.Cos(n)));
        }

        static void t1Eje04() {
            Console.Write("Introduzca el lado del cuadrado: ");
            int l = Convert.ToInt32(Console.ReadLine());

            int perimetro = 0;
            for(int i=0; i<4; i++) {
                perimetro += l;
            }

            Console.WriteLine("El perímertro es " + perimetro);
            Console.ReadLine();
        }

        static void t1Eje05() {
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

        static void t1Eje06() {
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

        static void t1Eje07() {
            Console.Write("¿Cuántos cuesta el producto?: ");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Cuántos productos llevará?: ");
            int product = Convert.ToInt32(Console.ReadLine());

            int total = price * product;

            Console.WriteLine($"El coste total es de {total}");
            Console.ReadLine();
        }

        static void t1Eje08() {
            double parcial1, parcial2, examen, trabajoFinal, notaFinal;

            Console.Write("Introduce la calificación del primer examen: ");
            parcial1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la calificación del segundo examen: ");
            parcial2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la calificación del examen: ");
            examen = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la calificación del trabajo final: ");
            trabajoFinal = Convert.ToDouble(Console.ReadLine());

            double promedioParciales = (parcial1 + parcial2) / 2;
            notaFinal = (promedioParciales * 0.50) + (examen * 0.30) + (trabajoFinal * 0.20);

            Console.WriteLine("\nTu calificación es: " + notaFinal);
            Console.ReadLine();
        }

        static void t1Eje09() {
            double aporte1, aporte2, aporte3, totalAporte;

            Console.Write("Introduce la aportación del socio 1: ");
            aporte1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la aportación del socio 2: ");
            aporte2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la aportación del socio 3: ");
            aporte3 = Convert.ToDouble(Console.ReadLine());

            totalAporte = aporte1 + aporte2 + aporte3;

            double porcentaje1 = (aporte1 / totalAporte) * 100;
            double porcentaje2 = (aporte2 / totalAporte) * 100;
            double porcentaje3 = (aporte3 / totalAporte) * 100;

            Console.WriteLine($"El porcentaje del socio 1 es {porcentaje1}, del socio 2 es {porcentaje2}, y del socio 3 es {porcentaje3}");
            Console.ReadLine();
        }

        static bool t1Eje10() {
            bool inicio = false;
            string letras = "";

            Console.Write("Introduzca su dirección web: ");
            string web = Console.ReadLine();

            for(int i = 0; i < 3; i++) {
                letras += web[i];
            }

            if (letras.Equals("www")) {
                inicio = true;
            }

            Console.Write(inicio);
            Console.ReadLine();
            return inicio;
        }

        static void t2Eje01() {
            Console.Write("Introduzca un número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca otro número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 >= n2) {
                Console.WriteLine($"{n1} es mayor que {n2}");
            }
            else
            {
                Console.WriteLine($"{n2} es mayor que {n1}");
            }

            Console.ReadLine();
        }

        static void t2Eje02(){
            Console.WriteLine("Cuantos kw has consumido anteriormente?: ");
            int kw = Convert.ToInt32(Console.ReadLine());

            double total = 0;  

            if (kw < 1000)
            {
                total = kw * 0.14;  
            }
            else if (kw >= 1000 && kw < 1800)
            {  
                total = kw * 0.12;
            }
            else
            {
                total = kw * 0.08;  
            }

            Console.WriteLine("El total es: " + total);
            Console.ReadLine();
        }

        static void t2Eje03()
        {
            Console.Write("Introduca usted si esta:\nCasado: C\nSoltero: S\nViudo: V\nDivorciado: D\nOpción: ");
            string opc = Console.ReadLine();

            switch (opc)
            {
                case "C":
                    {
                        Console.WriteLine("Tu estado Civil es Casado");
                    }
                break;

                case "S":
                    {
                        Console.WriteLine("Tu estado Civil es Soltero");
                    }
                break;

                case "V":
                    {
                        Console.WriteLine("Tu estado Civil es Viudo");
                    }
                break;

                case "D":
                    {
                        Console.WriteLine("Tu estado Civil es Divorciado");
                    }
                break;

                default: 
                {
                    Console.WriteLine("Opción no válida");    
                }
                break;
            }

            Console.ReadLine();
        }

        static void t2Eje04()
        {
            Console.Write("Introduzca un número del 1 al 9: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0 || n > 9) {
                while (n <= 0 || n > 9)
                {
                    Console.Write("Número no válido\nIntroduzca un número del 1 al 9:  ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }

            Console.ReadLine();
        }

        static void t2Eje05() {
            Console.Write("Introduzca una palabra: ");
            string word = Console.ReadLine();

            Console.WriteLine(word.Length);
            Console.WriteLine(word.ToUpper());
            Console.WriteLine(word.ToLower());
            Console.WriteLine(word.Remove(0, 1));
            Console.WriteLine(word.Replace("a", "*"));

            Console.ReadLine();
        }

        static void t2Eje06()
        {
            Console.Write("Calcular el factorial de: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for(int i = n; i>0; i--)
            {
                fact *= i;
            }

            Console.WriteLine($"El factorial de {n} es {fact}");
            Console.ReadLine();
        }

        static void t2Eje07() { 
        }
        static void Main(string[] args)
        {
            t2Eje06();
        }
    }
}
