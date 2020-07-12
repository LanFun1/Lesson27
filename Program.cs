using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = "Убийца - дворецкий";
            string pass = "2351235";
            Console.WriteLine("Введите пароль, для получения доступа к сообщению");
            string userPass = "";// пароль, который введёт пользователь
            while(userPass != pass)
            {
                userPass = Console.ReadLine();
                if (userPass == pass)
                    Console.WriteLine(secretMessage);
                else
                    Console.WriteLine("Пароль неверный, попробуйте снова");
            }
        }
    }
}
