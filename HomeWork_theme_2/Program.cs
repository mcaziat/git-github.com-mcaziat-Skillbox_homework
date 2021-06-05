using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_theme_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //вспомогательные строки для данных//
            int minPoint = 0;
            int maxPoint = 100;


            //приветственный заголовок//
            string Hello = ("Записная книжка vr.0.1");
            Console.WriteLine(Hello);

            //Ввод данных первым сотрудником
            Console.Write("Введите свое имя: ");
            string name1 = Console.ReadLine();

            Console.Write("Введите свой возраст (полных лет): ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            // в случае если данные будут введены в отрицательной величине либо превышающей максимальный возраст//
            if(age1 <= 0 && age1 >= 100) {
                Console.WriteLine("Вы ввели недопустимое значение, будьте внимательнее ");

                Console.Write("Введите свой возраст (полных лет): ");
                age1 = Convert.ToInt32(Console.ReadLine());
            }
                

            Console.Write("Введите свой рост (м): ");
            double stature1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваши баллы по русскому языку (по 100-бальной системе): ");
            int ruPoint1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваши баллы по истории (по 100-бальной системе): ");
            int historyPoint1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваши баллы по математике (по 100-бальной системе): ");
            int mathPoint1 = Convert.ToInt32(Console.ReadLine());



            Console.Clear();

            string pattern = "Имя: {0} Возраст: {1} Рост: {2} Русский язык: {3} История: {4} Математика: {5}";

            Console.WriteLine(pattern,
                              name1,
                              age1,
                              stature1,
                              ruPoint1,
                              historyPoint1,
                              mathPoint1);

            Console.ReadKey();

            Console.Clear();

        }
    }
}
