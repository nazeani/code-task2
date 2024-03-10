#region task1

using System.Numerics;

int n = 213;
int hasil = 1;
if (n == 0)
{
    hasil = 0;
}
else
{
    while (n != 0)
    {
        int m = n % 10;
        hasil *= m;
        n = n / 10;

    }
}
Console.WriteLine(hasil);
#endregion
#region task3
int a = 21;
BigInteger f = 1;

if (a < 0)
{
    Console.WriteLine("Düzgün eded daxil edin!");
}
else
{
    while (a > 1)
    {
        f *= a;
        a = a - 1;
    }
    Console.WriteLine(f);
}
#endregion
#region task4
int p = 213312;
int tersi = 0;
int pp = p;

while (p > 0)
{
    int r = p % 10;
    tersi = tersi * 10 + r;
    p = p / 10;

}


if (pp == tersi)
{
    Console.WriteLine("polindrom");
}
else
{
    Console.WriteLine("polindrom deyil");
}
#endregion
#region task2
int ms = 3;
int sayy = 0;
int sm = (ms - 1);
while (ms > 1 && sm!=0)
{
    if (ms % sm == 0)
    {
        sayy += 1;
    }
    else
    {
        sayy += 0;
    }
    sm --;
}
if (ms > 1)
{
    if (sayy > 1)
    {
        Console.WriteLine("murekkebdir");
    }

    else
    {
        Console.WriteLine("sadedir");
    }
}

#endregion