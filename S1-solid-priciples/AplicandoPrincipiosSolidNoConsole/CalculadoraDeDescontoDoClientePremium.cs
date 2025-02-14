namespace AplicandoPrincipiosSolidNoConsole
{
    public class CalculadoraDeDescontoDoClientePremium : ICalculadoraDeDescontoPorTipoDeCliente
    {
        private const decimal PORCENTAGEM_DE_DESCONTO = 0.4m;

        public decimal ObterValorDoDesconto(decimal valor)
        {
            return PORCENTAGEM_DE_DESCONTO * valor;
        }
    }
}
