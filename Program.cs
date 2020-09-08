using System;

namespace Task_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Renderer renderer = new Renderer();

            player1.X = 20;
            player1.Y = 10;

            renderer.Render(player1.Y, player1.X);
            Console.ReadKey();
        }
    }
    class Player
    {
        public int X;
        public int Y;                
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
