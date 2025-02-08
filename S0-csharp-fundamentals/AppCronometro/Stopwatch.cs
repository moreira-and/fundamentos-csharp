using System.Threading;
using Microsoft.VisualBasic;
struct StopWatch
{
    private DateTime _startTime;
    private DateTime _endTime;

    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("Quanto tempo você gostaria de medir?");
        Console.WriteLine("Em segundos - ex: 10s");
        Console.WriteLine("Em minutos - ex: 3m");
        Console.WriteLine("Em horas - ex: 2h");
        Console.WriteLine("Qualquer outro valor para sair.");
        Console.Write("Digite a opção desejada: ");
        var userInput = Console.ReadLine();
        char userOption = char.Parse(userInput.Substring(userInput.Length - 1, 1));
        double userValue = double.Parse(userInput.Substring(0, userInput.Length - 1));

        switch (userOption)
        {
            case 's':
                Run(userValue);
                break;
            case 'm':
                Run(userValue * 60);
                break;
            case 'h':
                Run(userValue * 3600);
                break;
            default:
                Console.WriteLine("Saindo...");
                System.Environment.Exit(0);
                break;
        }
    }


    public void Run(double totalSeconds)
    {
        Start(); // Inicializa _startTime
        Stop(); // Inicializa _endTime para evitar problemas no primeiro loop
        
        while (GetInterval().TotalSeconds < totalSeconds) // Atualiza _endTime continuamente
        {
            Console.WriteLine($"{((int)GetInterval().TotalSeconds)} s"); // Mostra o tempo decorrido
            Thread.Sleep(1000); // 1 segundo
            Stop(); // atualiza _endTime
        }
        Console.WriteLine($"{((int)GetInterval().TotalSeconds)} s, Stopwatch finalziado."); // Mostra o tempo decorrido
    }

    public void Start()
    {
        _startTime = DateTime.Now; 
    }

    public void Stop()
    {
        _endTime = DateTime.Now;
    }

    public TimeSpan GetInterval()
    {
        return (_endTime - _startTime);
    }
}