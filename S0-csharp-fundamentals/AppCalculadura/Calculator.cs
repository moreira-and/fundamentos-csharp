using System.Diagnostics;

struct Calculator
{
    private float PrimeiroValor;
    private float SegundoValor;

    public Calculator()
    {
        Console.WriteLine("Digite o primeiro número: ");
        PrimeiroValor = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        SegundoValor = float.Parse(Console.ReadLine());
    }

    public void Menu(){
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Resto");
        Console.WriteLine("6 - Contas gerais");
        Console.WriteLine("7 - Sair");
        Console.WriteLine("------------------");        
        Console.WriteLine("Digite a opção desejada:");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Soma: " + Soma());
                Menu();
                break;
            case "2":
                Console.WriteLine("Subtração: " + Subtracao());
                Menu();
                break;
            case "3":
                Console.WriteLine("Multiplicação: " + Multiplicacao());
                Menu();
                break;
            case "4":
                Console.WriteLine("Divisão: " + Divisao());
                Menu();
                break;
            case "5":
                Console.WriteLine("Resto: " + Resto());
                Menu();
                break;
            case "6":
                ContasGerais();
                Menu();
                break;
            case "7":
                System.Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida");
                Menu();
                break;
        }
    }

    public float Soma()
    {
        return PrimeiroValor + SegundoValor;
    }

    public float Subtracao()
    {
        return PrimeiroValor - SegundoValor;
    }

    public float Multiplicacao()
    {
        return PrimeiroValor * SegundoValor;
    }

    public float Divisao()
    {
        return PrimeiroValor / SegundoValor;
    }

    public float Resto()
    {
        return PrimeiroValor % SegundoValor;
    }

    public void ContasGerais()
    {
        Console.Clear();
        Console.WriteLine("Contas gerais: ");
        Console.WriteLine("Soma: " + Soma());
        Console.WriteLine("Subtração: " + Subtracao());
        Console.WriteLine("Multiplicação: " + Multiplicacao());
        Console.WriteLine("Divisão: " + Divisao());
        Console.WriteLine("Resto: " + Resto());
    }
}