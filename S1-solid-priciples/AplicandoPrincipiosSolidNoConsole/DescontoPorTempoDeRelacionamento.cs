namespace AplicandoPrincipiosSolidNoConsole
{
    // Implementa a interface IDescontoStrategy, que permite selecionar a estratégia de desconto em tempo de execução
    public class DescontoPorTempoDeRelacionamento : IDescontoStrategy
    {
        public decimal CalcularDesconto(Cliente cliente, decimal valorOriginal)
        {
            // Obtém a porcentagem de desconto separadamente
            decimal porcentagemDeDesconto = CalculadoraDePorcentagemDeDescontoPorTempo.ObterPorcentagemDeDesconto(cliente.ObterAnosDeRelacionamento());

            // Aplica o desconto
            return valorOriginal * porcentagemDeDesconto;
        }
    }
}
