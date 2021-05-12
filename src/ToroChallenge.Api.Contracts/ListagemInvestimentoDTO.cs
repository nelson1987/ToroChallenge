namespace ToroChallenge.Api.Contracts
{
    public class ListagemInvestimentoDTO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public double Compra { get; set; }
        public double Venda { get; set; }
    }
}
