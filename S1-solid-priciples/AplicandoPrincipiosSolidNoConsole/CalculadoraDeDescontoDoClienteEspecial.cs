namespace AplicandoPrincipiosSolidNoConsole
{
    public class CalculadoraDeDescontoDoClienteEspecial : ICalculadoraDeDescontoPorTipoDeCliente
    {
        private const decimal PORCENTAGEM_DE_DESCONTO = 0.1m;

        public decimal ObterValorDoDesconto(decimal valor)
        {
            return PORCENTAGEM_DE_DESCONTO * valor;
        }
    }
}
