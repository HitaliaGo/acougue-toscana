class Pedidos
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Produto { get; set; }
    public DateTime DataPedido { get; set; }
    public enum StatusPedido
    {
        AguardandoPagamento,
        PagamentoConfirmado,
        EmSeparacao,
        Enviado,
        Entregue,
        Cancelado
    }
    public StatusPedido Status { get; set; }
    public double FormaPagamento { get; set; }
    public double ValorPedido { get; set; }
    public double Troco { get; set; }
    public DateTime DataValidade { get; set; }
    public string Vendedor { get; set; }



    public Pedidos(string nome, string endereco, string produto, DateTime dataPedido, StatusPedido status, double formaPagamento, double valorPedido, double troco, DateTime dataValidade, string vendedor)
    {
        Nome = nome;
        Endereco = endereco;
        Produto = produto;
        DataPedido = dataPedido;
        Status = status;
        FormaPagamento = formaPagamento;
        ValorPedido = valorPedido;
        Troco = troco;
        DataValidade = dataValidade;
        Vendedor = vendedor;
    }
}

