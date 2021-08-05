using System;

namespace URI_1155
{
	class Program
	{
		static void Main(string[] args)
		{
			float s = 0;
			for(int i = 1; i <= 100; i++)
			{
				s += ((float)1 / (float)i);
			}
			Console.WriteLine($"{s:F2}");
		}
	}
}
