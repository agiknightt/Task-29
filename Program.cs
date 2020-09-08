using System;

namespace Task_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(20, 10);
            Renderer renderer = new Renderer();

            renderer.Render(player1.PlayerY, player1.PlayerX);
            Console.ReadKey();
        }
    }
    class Player
    {
        public int PlayerX;
        public int PlayerY;

        public Player(int x, int y)
        {
            PlayerX = x;
            PlayerY = y;
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
