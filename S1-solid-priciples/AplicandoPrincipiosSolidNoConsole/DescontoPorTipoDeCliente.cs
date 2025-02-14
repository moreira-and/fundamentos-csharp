namespace AplicandoPrincipiosSolidNoConsole
{
    // Implementa a interface IDescontoStrategy, que permite selecionar a estratégia de desconto em tempo de execução
    public class DescontoPorTipoDeCliente : IDescontoStrategy
    {
        public decimal CalcularDesconto(Cliente cliente, decimal valorOriginal)
        {
            return new CalculadoraDeDescontoPorTipoDeClienteFactory(cliente.Tipo).ObterValorDoDesconto(valorOriginal);
        }
    }


}
