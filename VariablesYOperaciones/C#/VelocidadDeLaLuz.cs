using System;

namespace VelocidadDeLaLuz
{
		public class Program
		{
			public static void Main (string[] args)
			{
				int Seg_Recorridos,Distancia_Recorrida;
				Console.WriteLine("Ingrese los segundos: ");
							Seg_Recorridos=Convert.ToInt32(Console.ReadLine());
					Distancia_Recorrida=Seg_Recorridos*300000;
				Console.WriteLine("La distancia Recorrida es de: "+Distancia_Recorrida);
			}
		}
}