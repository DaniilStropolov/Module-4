namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;
            //Инициализация временной переменной, помогающей поменять местами значения в массиве
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                sum += number;
            }
            Console.WriteLine($"Сумма всех элементов массива: {sum}");
        }
    }
}
