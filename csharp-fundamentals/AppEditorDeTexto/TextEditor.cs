struct TextEditor 
{
    public void Menu()
    {
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Abrir");
        Console.WriteLine("2 - Editar ou Criar novo arquivo");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Selecione uma opção...");
        short opcao = short.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1: Abrir(); break;
            case 2: Criar(); break;
            case 0: Environment.Exit(0); break;
            default: Console.WriteLine("Opção inválida"); break;
        }
    }

    private void Abrir()
    {
        Console.Clear();
        Console.WriteLine("Qual o nome do arquivo?");
        var patch = Path.Combine(Environment.CurrentDirectory, "files", $"{Console.ReadLine()}.txt");

        using (var arquivo = new StreamReader(patch))
        {
            string texto = arquivo.ReadToEnd();
            Console.WriteLine("");
            Console.WriteLine(texto);
            Menu();
        }
    }

    
    private void Criar()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        Console.WriteLine("------------------------");
        string texto = "";
        do
        {
            texto += Console.ReadLine();
            texto += Environment.NewLine;
        }
        while(Console.ReadKey().Key != ConsoleKey.Escape);

        Console.Clear();
        Console.WriteLine(texto);
        Salvar(texto);
    }

    private void Salvar(string texto)
    {
        Console.Clear();
        //Console.WriteLine("Qual caminho deseja salvar o arquivo?");
        var patch = Path.Combine(Environment.CurrentDirectory, "files");
        Console.WriteLine("Qual o nome do arquivo?");
        var nome = Console.ReadLine();

        // Abre o arquivo, salva e fecha.
        using (var arquivo = new StreamWriter(Path.Combine(patch,$"{nome}.txt")))
        {
            arquivo.Write(texto);
        }
        Console.WriteLine($"Arquivo {nome}.txt salvo com sucesso em {patch}!");
        Menu();
    }
}