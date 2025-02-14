
## 🚀 Desafio  

O desafio deste exercício é **aplicar os princípios SOLID** no código abaixo, refatorando-o para torná-lo mais aderente a boas práticas de engenharia de software.

```csharp
namespace Aplicando_Principios_SOLID
{
    public class GerDesc
    {
        public decimal Calcular(decimal valor, int tipo, int anos)
        {
            decimal resultado = 0;
            decimal desc = (anos > 5) ? (decimal)5 / 100 : (decimal)anos / 100;
            if (tipo == 1)
            {
                resultado = valor;
            }
            else if (tipo == 2)
            {
                resultado = (valor - (0.1m * valor)) - desc * (valor - (0.1m * valor));
            }
            else if (tipo == 3)
            {
                resultado = (0.7m * valor) - desc * (0.7m * valor);
            }
            else if (tipo == 4)
            {
                resultado = (valor - (0.5m * valor)) - desc * (valor - (0.5m * valor));
            }
            return resultado;
        }
    }
}

```