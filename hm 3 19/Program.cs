// Exercise 19
Console.Write("Input 5 digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

string X = Convert.ToString(number);
int yes=(X[0]+X[1]+X[2]);
int yes1=(X[2]+X[3]+X[4]);

if ((number> 4) &&(yes == yes1))
{
    Console.WriteLine($"the number {number} is palindrome");
}
else {
    Console.WriteLine($"the number {number} is not palindrome");
}