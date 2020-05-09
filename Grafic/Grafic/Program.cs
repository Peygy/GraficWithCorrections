using System;

namespace Grafic
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle;
            Rectangle rectangle;
            Square square;
            int counter1 = 0;
            bool success = false;
            while(success != true)
            {
                Console.ForegroundColor = ConsoleColor.White;              
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите фигуру(! Введите stop для завершения(Закончится выбора коорд. Y))");
                Console.WriteLine("1.Треугольник                                                             ");
                Console.WriteLine("2.Прямоугольник                                                           ");
                Console.WriteLine("3.Квадрат");
                string mainInput = Console.ReadLine();

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите цвет:                                                            ");
                Console.WriteLine("1.Красный               ");
                Console.WriteLine("2.Зеленый               ");
                Console.WriteLine("3.Синий                 ");
                Console.Write("    ");
                Console.SetCursorPosition(0, 4);
                string input = Console.ReadLine();
                ConsoleColor formColor = ConsoleColor.White;
                switch (input)
                {
                    case "1":
                        formColor = ConsoleColor.Red;
                        break;
                    case "2":
                        formColor = ConsoleColor.Green;
                        break;
                    case "3":
                        formColor = ConsoleColor.DarkBlue;
                        break;
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите символ:");
                Console.WriteLine("               ");
                Console.WriteLine("               ");
                Console.WriteLine("               ");
                Console.SetCursorPosition(0, 4);
                Console.Write("  ");
                Console.SetCursorPosition(0, 1);
                char symbol = Console.ReadKey().KeyChar;

                if(mainInput == "1")
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Введите выстоу:   ");
                }
                else
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Введите длину:  ");
                }
                Console.WriteLine("               ");
                Console.WriteLine("               ");
                Console.WriteLine("               ");
                Console.SetCursorPosition(0, 1);
                Console.Write("  ");
                Console.SetCursorPosition(0, 1);
                int.TryParse(Console.ReadLine(), out int lenght);

                Console.SetCursorPosition(0, 0); 
                Console.WriteLine("Введите координату Х:");
                Console.WriteLine("! Главное, чтобы фигура не заходила на меню выбора");
                Console.WriteLine("                             ");
                Console.WriteLine("                             ");
                Console.SetCursorPosition(0, 4);
                Console.Write("  ");
                Console.SetCursorPosition(0, 2);                
                int.TryParse(Console.ReadLine(), out int coordinateX);
                if(mainInput == "1")
                {
                    while (counter1 != 1)
                    {
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("Ошибка! Фигура выходит за рамки консоли!" +
                            " Координата должна быть больше длины, введите координату заново. Нажмите Enter");
                        Console.ReadLine();
                        Console.SetCursorPosition(0, 2);
                        Console.Write("                                                       " +
                            "                                                                 ");
                        Console.SetCursorPosition(0, 2);
                        int.TryParse(Console.ReadLine(), out int checking);
                        if (checking > lenght)
                        {
                            counter1 = 1;
                        }
                    }
                }


                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Введите координату Y:                                ");
                Console.WriteLine("! Главное, чтобы фигура не заходила на меню выбора");
                Console.WriteLine("                                                                  " +
                    "                                                  ");
                Console.WriteLine(" ");
                Console.SetCursorPosition(0, 2);
                Console.Write("  ");
                Console.SetCursorPosition(0, 2);
                int.TryParse(Console.ReadLine(), out int coordinateY);


                switch (mainInput)
                {
                    case "1":
                        triangle = new Triangle(formColor, symbol, lenght, coordinateX, coordinateY);
                        triangle.Draw();
                        break;
                    case "2":
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Введите ширину:                 ");
                        Console.WriteLine("                                                   ");
                        Console.WriteLine("               ");
                        Console.WriteLine("               ");
                        Console.SetCursorPosition(0, 2);
                        Console.Write("  ");
                        Console.SetCursorPosition(0, 1);
                        int.TryParse(Console.ReadLine(), out int widht);
                        rectangle = new Rectangle(formColor, symbol, lenght, coordinateX, coordinateY, widht);
                        rectangle.Draw();
                        break;
                    case "3":
                        square = new Square(formColor, symbol, lenght, coordinateX, coordinateY);
                        square.Draw();
                        break;
                    case "stop":
                        success = true;
                        break;
                }
            }
        }
    }
}