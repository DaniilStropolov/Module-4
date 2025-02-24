namespace ArrayPositiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -1, 2, 3, -5, 6, 7, 8, 9, -8, 11, 0, -13 };
            int positiveNumbers = 0;
            foreach (int number in numbers)
            {
                if (number >= 0)
                {
                    positiveNumbers++;
                }
            }
            Console.WriteLine("Количество положительных чисел в массиве: " + positiveNumbers);
        }
    }
}
