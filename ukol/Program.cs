class Program
{
    static void Main()
    {
        int size = 7;         
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
            
                if (j == 0 || j == size - 1 || j == size - 1 - i )
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");                 }
            }
            Console.WriteLine();         }
    }
}
