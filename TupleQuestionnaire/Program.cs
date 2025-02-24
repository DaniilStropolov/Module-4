namespace TupleQuestionnaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tuple = (name : " ", age : 0);
            Console.WriteLine("Кортеж изначально: " + tuple);
            Console.Write("Введите ваше имя: ");
            tuple.name = Console.ReadLine(); 
            Console.Write("Введите ваш возраст: ");
            tuple.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итоговый кортеж: " + tuple);
        }
    }
}
