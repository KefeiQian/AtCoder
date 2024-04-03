class Program
{
    static void Main(string[] args)
    {
        int meter = int.Parse(Console.ReadLine());

        if (meter < 100)
        {
            Console.WriteLine("00");
        }
        else if (meter <= 5000)
        {
            Console.WriteLine($"{meter * 10 / 1000:D2}");
        }
        else if (meter <= 30000)
        {
            Console.WriteLine(meter / 1000 + 50);
        }
        else if (meter <= 70000)
        {
            Console.WriteLine((meter - 30000) / 5000 + 80);
        }
        else
        {
            Console.WriteLine("89");
        }
    }
}