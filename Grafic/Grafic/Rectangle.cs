using System;
using System.Collections.Generic;
using System.Text;

namespace Grafic
{
    class Rectangle : Square
    {        
        int Widht;
        public Rectangle(ConsoleColor _color, char _symbol, int _lenght, int _x, int _y, int _widht) : base(_color, _symbol, _lenght, _x, _y)
        {
            Widht = _widht;
            Color = _color;
            Symbol = _symbol;
            Lenght = _lenght;
            X = _x;
            Y = _y;
        }

        public new void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            for(int i = 1; i <= Lenght; i++)
            {
                Console.SetCursorPosition(X + i - 1,Y);
                Console.WriteLine(Symbol);
                Console.SetCursorPosition(X + i - 1, Y + Widht - 1);
                Console.WriteLine(Symbol);
            }

            for(int i = 0;i < Widht; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(Symbol);
                Console.SetCursorPosition(X + Lenght - 1, Y + i);
                Console.WriteLine(Symbol);
            }           
        }
    }
}
