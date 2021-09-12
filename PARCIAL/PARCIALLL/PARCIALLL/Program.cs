using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
	class Program
	{
		static void Main(string[] args)
		{
			const int oportunidades = 3;
			int numero, entrada;
			byte i, adivinado;
			string linea;
			numero = 10;
			i = 1; adivinado = 0;
			do
			{
				Console.WriteLine("ADIVINA EL NUMERO");
				Console.WriteLine("********");
				Console.Write("Seleccione un numero entre el 1 y el 10:");
				linea = Console.ReadLine();
				entrada = int.Parse(linea);
				if ((entrada == numero))
				{
					Console.WriteLine("FELICIDADES ADIVINASTE EL NUMERO!!");
					adivinado = 1;
				}
				else
				{
					if ((entrada > numero))
					{
						Console.WriteLine("El numero que ingresaste es incorrecto intenta nuevamente");
					}
					else
					{
						Console.WriteLine("El numero que ingresaste es incorrecto intenta nuevamente");
					}
				}
				i++;
			} while (((i <= oportunidades) & (adivinado == 0)));
			if ((adivinado == 0))
			{
				Console.Write("Sus intentos se agotaron, El numero era: " + numero);
			}

			Console.WriteLine();
			Console.Write("Presione cualquier Tecla:");
			Console.ReadLine();
		}
	}
}
