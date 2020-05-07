using System;
using System.Collections.Generic;
using System.Text;

namespace Grafic
{
    class Square : Form
    {
        ConsoleColor Color;
        char Symbol;
        int Lenght;
        int X;
        int Y;
        public Square(ConsoleColor _color, char _symbol, int _lenght, int _x, int _y) : base(_color, _symbol, _lenght, _x, _y)
        {
            Color = _color;
            Symbol = _symbol;
            Lenght = _lenght;
            X = _x;
            Y = _y;
        }

        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Lenght; i++)
            {
                Console.SetCursorPosition(X + i + i, Y);
                Console.WriteLine(Symbol);
                Console.SetCursorPosition(X + i + i, Y + Lenght - 1);
                Console.WriteLine(Symbol);
            }
            for (int i = 0; i < Lenght; i++)
            { 
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(Symbol);
                Console.SetCursorPosition(2 * Lenght - 2 + X, Y + i);
                Console.WriteLine(Symbol);
            }
        }
    }
}
