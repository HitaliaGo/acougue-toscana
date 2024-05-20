
public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public DateTime DataRegistro { get; set; }

    public Usuario(string nome, string telefone, string endereco, DateTime dataRegistro)
    {
        Nome = nome;
        Telefone = telefone;
        Endereco = endereco;
        DataRegistro = dataRegistro;
    }
}


