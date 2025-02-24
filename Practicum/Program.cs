namespace Practicum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                (string name, string lastName, string login, int loginLength, bool pet, double age, string[] favoriteColors) User;
                Console.Write("Введите имя: ");
                User.name = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                User.lastName = Console.ReadLine();
                Console.Write("Введите логин: ");
                User.login = Console.ReadLine();
                User.loginLength = User.login.Length;
                Console.WriteLine("Есть ли у вас животные? (Да / Нет): ");
                if (Console.ReadLine() == "Да")
                {
                    User.pet = true;
                }
                else
                {
                    User.pet = false;
                }
                Console.Write("Введите возраст: ");
                User.age = Convert.ToDouble(Console.ReadLine());
                User.favoriteColors = new string[3];
                Console.WriteLine("Введите три любимых цвета:");
                for (int j = 0; j < User.favoriteColors.Length; j++)
                {
                    User.favoriteColors[j] = Console.ReadLine();
                }
                Console.WriteLine("Готовая анкета: " + User);
            }
        }
    }
}
