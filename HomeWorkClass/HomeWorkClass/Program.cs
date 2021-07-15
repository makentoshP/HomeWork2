using System;
using System.Collections.Generic;

namespace HomeWorkClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = Console.InputEncoding;

            List<string> carList = new List<string>();
            chooseCar(carList);
            if (carList.Count == 0)
            {
                Console.WriteLine("Ви залишили список пустим!");
            }
            else
            {
                for (int i = 0; i <= carList.Count - 1; ++i)
                {
                    Console.WriteLine(carList[i]);
                }
            }
        }
        static void chooseCar(List<string> carList)
        {
            Console.WriteLine("Виберіть вашу мафину чи вивести результат:");
            Console.WriteLine("1. Опель \n2. Лада \n3. Кінець");
            string answerName = Console.ReadLine();
            Console.Clear();
            if (answerName == "Кінець")
            {
                return;
            }

            Console.WriteLine("Виберіть тип кузова:");
            Console.WriteLine("1. Седан  \n2. Універсал");
            string kusov = Console.ReadLine();
            Console.Clear();

            switch (answerName)
            {
                case "Опель":
                    Car opel = new Opel(kusov);
                    addCustParams(opel);

                    Console.WriteLine("Інформація про машину");
                    Console.WriteLine(opel);
                    carList.Add(opel.ToString());

                    Console.WriteLine("\nНажміть будь яку кнопку...");
                    Console.ReadKey();
                    Console.Clear();
                    
                    chooseCar(carList);
                    break;
                case "Лада":
                    Car lada = new Lada(kusov);
                    addCustParams(lada);

                    Console.WriteLine("Інформація про машину");
                    Console.WriteLine(lada);
                    carList.Add(lada.ToString());

                    Console.WriteLine("\nНажміть будь яку кнопку...");
                    Console.ReadKey();
                    Console.Clear();

                    chooseCar(carList);
                    break;
                default:
                    Console.WriteLine("Немає такої мафини");
                    chooseCar(carList);
                    break;
            }
        }

        static void addCustParams(Car car)
        {
            Console.WriteLine("Додаємо ще параметрів?  y/n");
            string a = Console.ReadLine();
            Console.Clear();

            switch (a)
            {
                case "y":
                    startAdding(car);
                    break;
                case "n":
                    break;
                default:
                    Console.WriteLine("Я ж написав y/n");
                    addCustParams(car);
                    break;
            }
        }

        static void startAdding(Car car)
        {
            Console.WriteLine("Назва  параметру:");
            string a = Console.ReadLine();
            car.AddProp(a);
            addCustParams(car);
        }

        
    }
}
