using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class Viewer
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Qual o nome do arquivo que gostaria de visualizar?");
            var fileName = $"{Console.ReadLine()}.txt";
            ViewFile(fileName);
        }

        private static void ViewFile(string fileName)
        {
            var patch = System.IO.Path.Combine(Environment.CurrentDirectory, "files", fileName); 
            if(!File.Exists(patch))
            {
                Console.WriteLine("Arquivo não encontrado");
                return;
            }
            Console.Clear();
            Console.WriteLine($"Visualizando arquivo {fileName}:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
            using(var file = new System.IO.StreamReader(patch))
            {
                string line;
                while((line = file.ReadLine()) != null)
                {
                    IndentifyStrong(line);
                    Console.Write("\n");
                }
            }
        }

        private static void IndentifyStrong(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>", RegexOptions.IgnoreCase);
            var words = text.Split(' ');
            for(var i =0; i< words.Length;i++)
            {
                if(strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(words[i].Substring(words[i].IndexOf('>')+1 , (words[i].LastIndexOf('<')-1-words[i].IndexOf('>'))));
                    Console.Write(" ");
                }else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }

        }

    }
}