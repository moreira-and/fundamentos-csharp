namespace AplicandoPrincipiosSolidNoConsole
{
    // Permite retornar a lógica de desconto de acordo com o tipo de cliente, porém, fere o principio de aberto/fechado
    public class CalculadoraDeDescontoPorTipoDeClienteFactory : ICalculadoraDeDescontoPorTipoDeCliente
    {
        private readonly ICalculadoraDeDescontoPorTipoDeCliente _calculadoraDeDesconto;

        public CalculadoraDeDescontoPorTipoDeClienteFactory(ETipoDeCliente tipoDeCliente)
        {
            switch (tipoDeCliente)
            {
                case ETipoDeCliente.Comum:
                    _calculadoraDeDesconto = new CalculadoraDeDescontoDoClienteComum();
                    break;
                case ETipoDeCliente.Especial:
                    _calculadoraDeDesconto = new CalculadoraDeDescontoDoClienteEspecial();
                    break;
                case ETipoDeCliente.Vip:
                    _calculadoraDeDesconto = new CalculadoraDeDescontoDoClienteVip();
                    break;
                case ETipoDeCliente.Premium:
                    _calculadoraDeDesconto = new CalculadoraDeDescontoDoClientePremium();
                    break;
                default:
                    throw new ArgumentException("Tipo de cliente não declarado");
            }
        }

        // Delega a chamada para a classe especializada do tipo de cliente.
        public decimal ObterValorDoDesconto(decimal valor)
        {
            return _calculadoraDeDesconto.ObterValorDoDesconto(valor);
        }
    }
}
