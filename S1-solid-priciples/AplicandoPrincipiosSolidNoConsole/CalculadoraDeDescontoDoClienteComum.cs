namespace AplicandoPrincipiosSolidNoConsole
{
    public class CalculadoraDeDescontoDoClienteComum : ICalculadoraDeDescontoPorTipoDeCliente
    {
        private const decimal PORCENTAGEM_DE_DESCONTO = 0;

        public decimal ObterValorDoDesconto(decimal valor)
        {
            return PORCENTAGEM_DE_DESCONTO * valor;
        }
    }
}
