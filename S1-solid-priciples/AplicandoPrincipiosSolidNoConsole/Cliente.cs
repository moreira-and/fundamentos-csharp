// See https://aka.ms/new-console-template for more information
using AplicandoPrincipiosSolidNoConsole;
// Armazena as informações do cliente e implementa o método de obter anos de relacionamento
public class Cliente
{
    public string Nome { get; private set; }
    public ETipoDeCliente Tipo { get; private set; }
    public DateTime DataDeCadastro { get; private set; }

    public Cliente(string nome, ETipoDeCliente tipo, DateTime dataDeCadastro)
    {
        Nome = nome;
        Tipo = tipo;
        DataDeCadastro = dataDeCadastro;
    }

    public int ObterAnosDeRelacionamento()
    {
        return DateTime.Now.Year - DataDeCadastro.Year;
    }
}