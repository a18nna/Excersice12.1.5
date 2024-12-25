using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Excersice12._1._5
{
    internal class Program
    {
        class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }

            public User(string login, string name, bool isPremium)
            {
                Login = login;
                Name = name;
                IsPremium = isPremium;
            }

            public void Greetings()
            {
                Console.WriteLine("Привет, " + Name + "!");
            }

        }

        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                 new User("a18nna", "Alena", true),
                 new User("Santa", "Anatoly", false),
                 new User("crasavheg", "Stepan", true),
                 new User("lilyRey", "Lily", false)
        };
            while(true)
            {
                Console.WriteLine("Введите логин");
                string log = Console.ReadLine();

                User foundUser = users.FirstOrDefault(user => user.Login == log);

                if (foundUser != null)
                {
                    foundUser.Greetings();
                    if (foundUser.IsPremium)
                    {
                        Console.WriteLine("Спасибо за подписку, вы премиум пользователь!");
                    }
                    else
                    {
                        ShowAds();
                    }
                }
                else
                {
                    Console.WriteLine("Пользователь с таким логином не найден.");
                }
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
