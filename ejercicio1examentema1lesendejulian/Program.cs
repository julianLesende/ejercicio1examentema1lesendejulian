using System;

namespace ejercicio1examentema1lesendejulian
{
    class Program
    {
		static void Main(string[] args)
		{
			double convercion;
			double distancia;
			double tiempo;
			double velocidad;
			Console.Write("ingrese la velocidad en m/s");
			velocidad = Double.Parse(Console.ReadLine());
			Console.Write("ingrese el tiempo en S:");
			tiempo = Double.Parse(Console.ReadLine());
			distancia = velocidad * tiempo;
			convercion = distancia * 0.001;
			Console.WriteLine("la distancia recorrida es:" + distancia + "metros");
			Console.WriteLine("la distancia convertida es:" + convercion + "km");
		}

	}
}
