// See https://aka.ms/new-console-template for more information
class demo
{
    public static void Main(string[] args)
    {
        int item = 0;
        //loop for rows
        for (int i = 0; i < 5; i++)
        {
            //loop for spaces
            for (int space = 4; space >= i; space--)
            {
                Console.Write(" ");
            }
            //loop for columns
            for (int j = 0; j <= i; j++)
            {
                if (j == 0)
                { item = 1; }
                else
                {
                    item = item * (i - j + 1) / j;
                }
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}