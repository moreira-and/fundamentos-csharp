using System.Data;
using System.Drawing;

namespace AplicandoPrincipiosSolidNoConsole
{
    class ServicoDeDesconto
    {
        private readonly List<IDescontoStrategy> _estrategias;

        public ServicoDeDesconto(List<IDescontoStrategy> estrategias)
        {
            _estrategias = estrategias;
        }

        public decimal ObterValorComDesconto(Cliente cliente, decimal valorOriginal)
        {
            decimal descontoTotal = 0;

            foreach (var estrategia in _estrategias)
            {
                descontoTotal += estrategia.CalcularDesconto(cliente, valorOriginal);
            }

            return valorOriginal - descontoTotal;
        }
    }
}
