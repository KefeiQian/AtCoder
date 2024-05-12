using System.Text;

class Program
{
    static string f(int p, bool prevLarger, string target, HashSet<int> hs)
    {
        if (p == target.Length)
        {
            return "";
        }

        int currentValue = int.Parse(target[p].ToString());

        for (int i = 0; i < 10; i += 1)
        {
            if (hs.Contains(i) && (prevLarger || i >= currentValue))
            {
                if (p == target.Length - 1)
                {
                    return i.ToString();
                }
                else
                {
                    string next = f(p + 1, prevLarger ? prevLarger : i > currentValue, target, hs);
                    if (next.Length != 0)
                    {
                        return i.ToString() + next;
                    }
                }
            }
        }

        return "";
    }

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        string N = input[0];

        var dislikeDigits = new HashSet<string>(Console.ReadLine().Split(" "));
        var canUseDigits = new HashSet<int>();

        for (int i = 0; i < 10; i ++)
        {
            if (!dislikeDigits.Contains(i.ToString())) {
                canUseDigits.Add(i);
            }
        }

        string res = f(0, false, N, canUseDigits);
        if (res.Length != 0)
        {
            Console.WriteLine(res);
            return;
        }

        string newRes = "";
        while (newRes.Length <= N.Length)
        {
            for (int i = 0; i < 10; i++) {
                if (newRes.Length == 0 && i == 0)
                {
                    continue;
                }

                if (canUseDigits.Contains(i))
                {
                    newRes += i.ToString();
                    break;
                }
            }
        }
        Console.WriteLine(newRes);
    }
}