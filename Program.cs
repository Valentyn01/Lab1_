using System;
namespace LAB1
{
	public class Program
	{

		public static int Swap1(int a, int b, int c)
		{
			int d = a;
			a = b;
			b = c;
			c = d;
			int sum = a + b + c;
			Console.WriteLine("Вихiднi данi a = " + a + ", b = " + b + ", c = " + c);
			return sum;
		}

		static void Main(String[] args)
		{

			int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine()), d = a;
			Console.WriteLine("Вхiднi данi a = " + a + ", b = " + b + ", c = " + c);

			Swap1(a, b, c);
		}
	}
}