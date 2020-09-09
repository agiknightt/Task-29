using System;

namespace Task_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(10, 20);
            Renderer renderer = new Renderer();
            
            renderer.Render(player1.Y, player1.X);
            Console.ReadKey();
        }
    }
    class Player
    {
        public int X { get; private set; }        
        public int Y { get; private set; }
        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }        
    }
    class Renderer
    {
        public char SymbolPlayer = '@';

        public void Render(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(SymbolPlayer);
        }        
    }
}
