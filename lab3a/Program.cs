using System;

namespace lab3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кошки: ");
            Cats cat = new Cats("Экзотическая кошка", "хищный", "рыжий", 15);
            Console.WriteLine(cat.Print());

            Cats cat1 = new Cats("Гималайская кошка", "хищный", "белый", 15);
            Console.WriteLine(cat1.Print());
            Console.ReadLine();
        }
    }
}
