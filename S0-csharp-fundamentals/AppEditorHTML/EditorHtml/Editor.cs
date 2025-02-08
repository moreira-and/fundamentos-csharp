using System;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR (ESC para sair)");
            Console.WriteLine("---------------------------");
            Start();
        }

        private static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while(Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("------------");
            SaveMenu(file.ToString());
        }

        private static void SaveMenu(string text)
        {
            Console.Clear();
            Console.WriteLine("Deseja salvar o arquivo? (S/N)");
            var option = Console.ReadLine();
            switch(option)
            {
                case "S": SaveFile(text); break;
                case "N": Environment.Exit(0);break;
                default: SaveMenu(text); break;
                    
            }
        }
        private static void SaveFile(string text)
        {
            Console.WriteLine("Qual o nome do arquivo?");
            string userInputFileName = $"{Console.ReadLine()}.txt";
            string patch = Path.Combine(Environment.CurrentDirectory,"files" ,userInputFileName);
            using(var file = new StreamWriter(patch))
            {
                file.Write(text);
            }
        }
    }
}