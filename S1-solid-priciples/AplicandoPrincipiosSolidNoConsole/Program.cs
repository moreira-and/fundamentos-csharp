using System;
using System.Collections.Generic;
using AplicandoPrincipiosSolidNoConsole;

class Program
{
    static void Main()
    {
        // Criando um cliente
        // A classe cliente tem apenas a responsabilidade de retornar o tempo de relacionamento
        var cliente = new Cliente("João Silva", ETipoDeCliente.Vip, new DateTime(2015, 6, 10));

        // Criando as estratégias de desconto
        var estrategiasDeDesconto = new List<IDescontoStrategy>
        {
            new DescontoPorTipoDeCliente(),
            new DescontoPorTempoDeRelacionamento()
        };

        // Criando o serviço de desconto com as estratégias configuradas
        // Detalhe, o serviço de desconto está aberto para extenção, mas fechado para modificação
        var servicoDeDesconto = new ServicoDeDesconto(estrategiasDeDesconto);

        // Definindo o valor original do produto/serviço
        decimal valorOriginal = 100m;

        // Calculando o valor com desconto
        // O serviço de desconto é responsável por calcular o desconto
        decimal valorFinal = servicoDeDesconto.ObterValorComDesconto(cliente, valorOriginal);

        // Exibindo o resultado
        Console.WriteLine($"Valor original: R$ {valorOriginal:F2}");
        Console.WriteLine($"Valor com desconto: R$ {valorFinal:F2}");
    }
}