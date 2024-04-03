using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int L = int.Parse(input[1]);

        string[] items = new string[N];

        for (int i = 0; i < N; i ++)
        {
            string line = Console.ReadLine();
            items[i] = line;
        }

        Array.Sort(items);

        StringBuilder sb = new StringBuilder("", N * L);

        for (int i = 0; i < N; i ++)
        {
            sb.Append(items[i]);
        }

        Console.WriteLine(sb);
    }
}