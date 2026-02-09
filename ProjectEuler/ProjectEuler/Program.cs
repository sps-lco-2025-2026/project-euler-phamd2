// Problem 31
using System.Numerics;

void coinsum()
{
    int target = 200;
    int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };

    long[] ways = new long[target + 1];
    ways[0] = 1;

    foreach (int coin in coins)
    {
        for (int amount = coin; amount <= target; amount++)
        {
            ways[amount] += ways[amount - coin];
        }
    }
    Console.WriteLine(ways[target]);
}


// Problem 50
void consecutiveprimesum()
{
    int highest = 0;
    int maxLength = 0;
    int currentTotal = 0;
    int n = 1000000;

    List<int> primes = new List<int>();

    for (int i = 2; i <= n; i++)
    {
        bool isPrime = true;

        for (int a = 2; a * a <= i; a++)
        {
            if (i % a == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            primes.Add(i);
        }
    }
    for (int j = 0; j < primes.Count; j++)
    {
        currentTotal = 0;

        for (int k = j; k < primes.Count; k++)
        {
            currentTotal += primes[k];
            int length = k - j + 1;

            if (currentTotal > n)
                break;

            if (primes.Contains(currentTotal) && length > maxLength)
            {
                maxLength = length;
                highest = currentTotal;
            }
        }
    }

    Console.WriteLine(highest);
}

consecutiveprimesum();
