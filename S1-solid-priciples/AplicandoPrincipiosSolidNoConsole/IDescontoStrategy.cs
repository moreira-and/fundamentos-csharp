namespace AplicandoPrincipiosSolidNoConsole
{
    public interface IDescontoStrategy
    {
        decimal CalcularDesconto(Cliente cliente, decimal valorOriginal);
    }
}
