int Cube (int a) // methode to find a Square
{
    return a*a*a;
}

Console.WriteLine ("Input number N: ");
int n = Convert.ToInt32 (Console.ReadLine());
int count = 1;
while (count < n)
{
    int cb = Cube(count);
    count ++;
    Console.Write($"{cb}");

}
Console.WriteLine (Cube(n));