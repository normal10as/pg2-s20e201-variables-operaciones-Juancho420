using System;

namespace GradosFahrenheit
{
		public class Program
		{
			public static void Main (string[] args)
			{
				int tempG,tempF;
				Console.WriteLine("Ingrese la temperatura en grados: " );
				tempG=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Caculando.......");
				tempF=(9/5*tempG+32);
				Console.WriteLine("La temperatura en Fahrenheit es :"+tempF+"°");
			}
		}
}