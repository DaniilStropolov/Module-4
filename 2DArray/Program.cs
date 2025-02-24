namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = {{1, 2, 3}, {4, 5, 6}};
            Console.WriteLine("Третий элемент второй строки: " + numbers[1, 2] + "\n");
            Console.Write("Все элементы массива: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n\nДлина массива: " + numbers.Length + " элементов");
        }
    }
}
