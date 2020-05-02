using System;

namespace CotizacionTerreno
{
		public class Program
		{
			public static void Main (string[] args)
			{
				int largo,ancho,area;
				float precio;
				Console.WriteLine("Ingrese el largo del terreno: ");
							largo=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese el ancho del terreno: ");
							ancho= Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Precio por metro cuadrado:");
							precio=Convert.ToInt32(Console.ReadLine());
				area= largo*ancho;
				Console.WriteLine("El precio total es de:" +area*precio+"$");

			}
		}
}