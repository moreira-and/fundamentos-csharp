namespace AplicandoPrincipiosSolidNoConsole
{
    // Classe que calcula a porcentagem de desconto por tempo de relacionamento
    public class CalculadoraDePorcentagemDeDescontoPorTempo
    {
        public static decimal ObterPorcentagemDeDesconto(int anosDeRelacionamento)
        {
            if (anosDeRelacionamento < 0)
                throw new ArgumentException("Anos de relacionamento não pode ser negativo");

            if (anosDeRelacionamento < 5)
                return (decimal)anosDeRelacionamento / 100;

            return (decimal)5 / 100;
        }
    }

}
