// See https://aka.ms/new-console-template for more information
class demo
{
    public static void Main(string[] args)
    {
        
        int s = 4;
        int coef;
        for (int i = 1; i <= 5; i++)
        {
            for (s = 4; s >= i; s--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i ; j++)
            {
                coef = 0;

                if (j == 0 || i-1 == j) { coef = 1; }


                else
                {
                    coef = coef + (i - j + 1);


                }
                Console.Write(coef + " ");


            }
            Console.WriteLine();

        }
    }
}