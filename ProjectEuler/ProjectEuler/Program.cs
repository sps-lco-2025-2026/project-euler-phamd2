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
    int currenttotal = 0;
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
        currenttotal = 0;

        for (int k = j; k < primes.Count; k++)
        {
            currenttotal += primes[k];
            int length = k - j + 1;

            if (currenttotal > n)
                break;

            if (primes.Contains(currenttotal) && length > maxLength)
            {
                maxLength = length;
                highest = currenttotal;
            }
        }
    }
    Console.WriteLine(maxLength);
    Console.WriteLine(highest);
}


// Question 67
void maxpathsum()
{
    List<List<int>> numLine = new List<List<int>>();

    foreach (string line in File.ReadAllLines("0067_triangle.txt"))
    {
        List<int> valueLine = new List<int>();

        string[] split = line.Split(' ');
        foreach (string number in split)
        {
            valueLine.Add(Convert.ToInt32(number));
        }

        numLine.Add(valueLine); 
    }

    for (int row = numLine.Count - 2; row >= 0; row--)
    {
        for (int col = 0; col < numLine[row].Count; col++)
        {
            numLine[row][col] += Math.Max(
                numLine[row + 1][col],
                numLine[row + 1][col + 1]
            );
        }
    }

    Console.WriteLine(numLine[0][0]);
}

// Question 25
void fibonacci()
{
    BigInteger a = 1;
    BigInteger b = 1;
    BigInteger next = 0;

    int index = 2;

    while (b.ToString().Length < 1000)
    {
        next = a + b;
        a = b;
        b = next;
        index++;
    }
    Console.WriteLine(index);
}

// Question 6
void sumsquare()
{
    int total = 0;
    int sumupsquare = 0;
    int squaresum = 0;
    for (int i =0; i<=100; i++)
    {
        sumupsquare += i;
    }
    sumupsquare = sumupsquare*sumupsquare;
    for (int j=0; j<=100; j++)
    {
        squaresum += j*j;
    }

    total = sumupsquare - squaresum;
    Console.WriteLine(total);
}



// Problem 10
void sumofprimes()
{

    int total = 0;
    int n = 2000000;

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
            total += i;
        }
    }
    Console.WriteLine(total);
}

sumofprimes();