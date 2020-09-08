using System;
 
namespace Lab0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
 
            Console.Write("Введите возраст: ");
            string age = Console.ReadLine();
 
            Console.Write("Введите номер группы: ");
            string gruppa = Console.ReadLine();
 
            Console.Write("Введите название кафедры: ");
            string stud = Console.ReadLine();
 
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Группа: {gruppa}  Кафедра: {stud}");
 
            Console.ReadKey();
        }
    }
}