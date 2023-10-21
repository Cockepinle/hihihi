using ConsoleApp24;
using System;


namespace ConsoleApp24
{

    class Program
    {
        static void Main(string[] args)

        {
            DateTime currentDate = DateTime.Now;
            int money = 0;
            Console.WriteLine("  Форма");
            Console.WriteLine("  Размер");
            Console.WriteLine("  Вкус");
            Console.WriteLine("  Количество");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            while (true)
            {
                int pos = Class1.Strelka();
                int moneyCheck = Class1.Zapisi(pos);
                if (moneyCheck == -5)
                {
                    string filee = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Тортики.txt");
                    if (!File.Exists(filee))
                    {
                        File.Create(filee).Close();
                    }
                    File.AppendAllText(filee, "\nДата заказа:" + DateTime.Now +  "\nСтоимость заказа:" + money +"p" );


                    Console.Clear();
                        Console.WriteLine("Благодарим вас за покупку в нашем магазине!");
                        
                        Console.ReadKey();
                    money = 0;
                    moneyCheck = 0;
                }
                else if (moneyCheck == -10)
                {
                    continue;
                }




                money += moneyCheck;


                    Console.Clear();

                    Console.WriteLine("  Форма");
                    Console.WriteLine("  Размер");
                    Console.WriteLine("  Вкус");
                    Console.WriteLine("  Количество");
                    Console.WriteLine("  Глазурь");
                    Console.WriteLine("  Декор");
                    Console.WriteLine("  Конец заказа");

                    Console.WriteLine("Стоимость заказа: " + money + "p");
                    Console.WriteLine("Нажмите ctrl+c для завершения всех ваших заказов!");



                }
            }

        }
    }
