using System;

namespace EquivalenciasHoras
{
		public class Program
		{
			public static void Main (string[] args)
			{
				int minuto,segundo,division;
				double dia;
				Console.WriteLine("Ingrese las horas: ");
							division=Convert.ToInt32(Console.ReadLine());
					segundo=division*3600;
				Console.WriteLine("los segundos son: "+segundo);
					minuto=division*60;
				Console.WriteLine("los minutos son: "+minuto);
					dia=division/24;
				Console.WriteLine("Los dias son: "+dia);
			}
		}
}