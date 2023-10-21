using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    public class Class1
    {

        public static void clear()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
        public static int Strelka()
        {
            int position = 0;
            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine(" ");

                if (key.Key == ConsoleKey.UpArrow && position != 0)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow && position != 6)
                {
                    position++;
                }
                

            } while (key.Key != ConsoleKey.Enter);

            return position;
        }
        public static int StrelkaDoug()
        {
            int position = 1;
            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine(" ");

                if (key.Key == ConsoleKey.UpArrow && position != 1)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow && position != 3)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    return -1;
                }

            } while (key.Key != ConsoleKey.Enter);

            return position;
        }
        public static int Zapisi(int position)
        {

            int money = 0;
            if (position == 0)
            {
                Console.Clear();
                Console.WriteLine("  Выберите форму:");
                Console.WriteLine("  Круглый торт - 500p");
                Console.WriteLine("  Квадратный торт - 750p");
                Console.WriteLine("  Треугольный торт - 1000p");
                money += ZapisiDoug(StrelkaDoug(), position);

            }
            else if (position == 1)
            {
                Console.Clear();
                Console.WriteLine("  Выберите размер:");
                Console.WriteLine("  Большой торт - 2000p");
                Console.WriteLine("  Средний торт - 1500p");
                Console.WriteLine("  Малый торт - 1000p");
                money += ZapisiDoug(StrelkaDoug(), position);

            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine("  Выберите вкус:");
                Console.WriteLine("  Клубничный - 1000p");
                Console.WriteLine("  Шоколадный - 800p");
                Console.WriteLine("  Ежевичный - 500p");
                money += ZapisiDoug(StrelkaDoug(), position);

            }
            else if (position == 3)
            {
                Console.Clear();
                Console.WriteLine("  Выберите кол-во коржей:");
                Console.WriteLine("  Один корж - 200p");
                Console.WriteLine("  Два коржа - 400p");
                Console.WriteLine("  Три коржа - 600p");
                money += ZapisiDoug(StrelkaDoug(), position);


            }
            else if (position == 4)
            {
                Console.Clear();
                Console.WriteLine("  Выберите глазурь:");
                Console.WriteLine("  Шоколад - 300p");
                Console.WriteLine("  Крем - 200p");
                Console.WriteLine("  Бизе - 100p");
                money += ZapisiDoug(StrelkaDoug(), position);

            }
            else if (position == 5)
            {
                Console.Clear();
                Console.WriteLine("  Выберите декор:");
                Console.WriteLine("  Декор звездочки - 150p");
                Console.WriteLine("  Декор сердечки - 300p");
                Console.WriteLine("  Декор блестки - 450p");
                money += ZapisiDoug(StrelkaDoug(), position);

            }
            else if (position == 6)
            {
                return -5;

            }
            else if (position == -1)
            {
                Console.Clear();
                return -10;

            }

            return money;
        }
        public static int ZapisiDoug(int position, int positionMain)
        {
            int money = 0;
            if (positionMain == 0)
            {
                if (position == 1)
                {
                    money += 500;
                }
                else if (position == 2)
                {
                    money += 750;
                }
                else if (position == 3)
                {
                    money += 1000;
                }
            }
            else if (positionMain == 1)
            {
                if (position == 1)
                {
                    money += 2000;
                }
                else if (position == 2)
                {
                    money += 1500;
                }
                else if (position == 3)
                {
                    money += 1000;
                }
            }
            else if (positionMain == 2)
            {
                if (position == 1)
                {
                    money += 1000;
                }
                else if (position == 2)
                {
                    money += 800;
                }
                else if (position == 3)
                {
                    money += 500;
                }
            }
            else if (positionMain == 3)
            {
                if (position == 1)
                {
                    money += 200;
                }
                else if (position == 2)
                {
                    money += 400;
                }
                else if (position == 3)
                {
                    money += 600;
                }
            }
            else if (positionMain == 4)
            {
                if (position == 1)
                {
                    money += 300;
                }
                else if (position == 2)
                {
                    money += 200;
                }
                else if (position == 3)
                {
                    money += 100;
                }
            }
            else if (positionMain == 5)
            {
                if (position == 1)
                {
                    money += 150;
                }
                else if (position == 2)
                {
                    money += 300;
                }
                else if (position == 3)
                {
                    money += 450;
                }
            }
            return money;
        }
    }
}



        
       
    




