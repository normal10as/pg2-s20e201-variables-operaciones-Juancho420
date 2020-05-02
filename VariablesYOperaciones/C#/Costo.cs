using System;

namespace Costo
{
		public class Program
		{
			public static void Main (string[] args)
			{
				string descripcion;
				Double material , numero;
					material= 3.5 ;
				Console.WriteLine("Ingrese la descripcion del producto: ");
							descripcion=Console.ReadLine();
				Console.WriteLine("Ingrese la candtidad del producto: ");
							numero= Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("El costo total de los productos Ingresados es de : "+ numero * material+10.700);
			}
		}
}