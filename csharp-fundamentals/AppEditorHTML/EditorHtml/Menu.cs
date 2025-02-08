using System;
using System.Diagnostics;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            DrawScreen();
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        private static void DrawLimitScreen(int lengthLine = 30)
        {
            Console.Write("+");
            for(int i=0;i<=lengthLine;i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        private static void DrawMidScreen(int lengthLine = 30, int countLines = 10)
        {
            for(int lines = 0; lines <= countLines; lines++)
            {
                Console.Write("|");
                for(int i=0;i<=lengthLine;i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void DrawScreen(int lengthLine = 30, int countLines = 10)
        {
            DrawLimitScreen(lengthLine);
            DrawMidScreen(lengthLine, countLines);
            DrawLimitScreen(lengthLine);
        }
    
        private static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("===========================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3,5);
            Console.WriteLine("1 - Editar ou Criar arquivo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3,8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,9);
            Console.Write("Opção: ");
        }
    
        private static void HandleMenuOption(short option)
        {
            switch(option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(); break;
                case 0: 
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}