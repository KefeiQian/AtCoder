class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        if (a == 5 && b == 5 && c == 7 || a == 5 && b == 7 && c == 5 || a == 7 && b == 5 && c == 5)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}