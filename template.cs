using System;
class Program
{
	static void Main(string[] args)
	{
		// get a integer
		int a = int.Parse(Console.ReadLine());
		// get two integers separated with half-width break
		string[] input = Console.ReadLine().Split(' ');
		int b = int.Parse(input[0]);
		int c = int.Parse(input[1]);
		// get a string
		string s = Console.ReadLine();
		//output
		Console.WriteLine((a+b+c) + " " + s);
	}
}