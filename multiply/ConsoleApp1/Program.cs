// See https://aka.ms/new-console-template for more information
int a = 1;
int b = 2;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(a);
    int n = a * b;
    a = b;
    b = n;
}
