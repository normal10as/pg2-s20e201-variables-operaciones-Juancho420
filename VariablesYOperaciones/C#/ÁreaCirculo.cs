using System;

namespace ÁreaCirculo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radio;
            double area;
            double Pi = 3.14;

            Console.Write("Ingrese el radio de un círculo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            area = Pi * (radio * radio);

            Console.Write("El Area del Círculo es de : ");
            Console.Write(area);
            Console.WriteLine(" Unidad de Superficie.");
        }
    }
}