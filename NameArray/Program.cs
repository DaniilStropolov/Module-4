namespace NameArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам:");
            foreach (char letter in name)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine($"\nПоследняя буква вашего имени: {name[name.Length - 1]}");
            Console.WriteLine("Ваше имя в обратном порядке:");
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }
        }
    }
}
