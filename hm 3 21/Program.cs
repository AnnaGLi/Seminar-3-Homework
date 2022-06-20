// Exercise number 21
int x1 = Input("Input coordinate of X1: ");
int y1 = Input("Input coordinate of y1: ");
int z1 = Input("Input coordinate of z1: ");
int x2 = Input("Input coordinate of X2: ");
int y2 = Input("Input coordinate of y2: ");
int z2 = Input("Input coordinate of z2: ");

int distanceX = CalculateDistance(x1,x2);
int distanceY = CalculateDistance(y1,y2);
int distanceZ = CalculateDistance(z1,z2);

double distance = Math.Sqrt(Quadro(distanceX) + Quadro(distanceY) + Quadro(distanceZ));

Console.WriteLine ("Distance between 3 coordinates is " + distance);

int Quadro(int a)
{
    return a * a;
}
int CalculateDistance (int a, int b)
{
    return a-b;
}
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}