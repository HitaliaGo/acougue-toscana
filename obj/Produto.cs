public class Produto
{
  public int id { get; set; }
  public string Nome { get; set; }
  public string Descricao { get; set; }
  public Datetime DataValidade { get; set; }
  public int Preco { get; set; }
  public Datetime dataCompraProduto { get; set; }

  public Produto(string nome, string descricao, datetime dataValidade, int preco, datetime dataCompraProduto)
  {
    Nome = nome;
    Descricao = descricao;
    DataValidade = dataValidade;
    Preco = preco;
    DataCompraProduto = dataCompraProduto;
  }
}

