using System;

namespace Cuadratica
{
		public class Program
		{
			public static void Main (string[] args)
			{
				int a,b,c;
				Double x;
				a=1;
				b=5;
				c=2;
				Console.WriteLine("Valores obtenidos de la cuadratica= "+" A="+a+" B="+b+" C="+c);
            	x = Convert.ToDouble((b * b) - (4 * a * c)) / (2 * a);
            		Console.WriteLine("Resultado de la Funcion Cuadratica es:" + x);
			}
		}
}