// See https://aka.ms/new-console-template for more information


bool CheckPrime(int userInt)
{
    for (int i = 2; i < userInt; i++)
    {
        if ((userInt % i) == 0) return false;
    }
    return true;
}

void FibSeq(int userInt)
{
    int temp = 0, temp2 = 1, temp3 = 0;
    for (int i = 0; i < userInt; i++)
    {
        if ( i == 0 )
        {
            Console.Write("0, ");
        }
        if (i == 1)
        {
            Console.Write("1, ");
        }
        else
        {
            temp3 = temp + temp2;
            Console.Write($"{temp3}, ");
            temp = temp2;
            temp2 = temp3;
        }
    }
}

