using System;

namespace EquivalenciasPies
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Pie, Tpulg, yardas;
            byte pulgadas = 12;
            byte yarda = 3;
            double Apulgada = 2.54;
            byte Ametros = 100;
            double centimetros, metros;
            Console.Write("Ingrese una distancia medida en pies: ");
            Pie = Convert.ToUInt16(Console.ReadLine());
            Tpulg = Pie * pulgadas;
            yardas = Pie * yarda;
            centimetros = Tpulg * Apulgada;
            metros = centimetros * Ametros;
            Console.WriteLine("Equivalencia en Pulgadas: " + Tpulg);
            Console.WriteLine("Equivalencia en Yardas: " + yardas);
            Console.WriteLine("Equivalencia en Centímetros: " + centimetros);
            Console.WriteLine("Equivalencia en Metros: " + metros);
        }
    }
}