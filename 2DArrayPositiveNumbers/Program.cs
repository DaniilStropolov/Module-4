namespace _2DArrayPositiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int positiveNumbers = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    positiveNumbers++;
                }
            }
            Console.WriteLine("Количество положительных чисел в двумерном массиве: " + positiveNumbers);
        }
    }
}
