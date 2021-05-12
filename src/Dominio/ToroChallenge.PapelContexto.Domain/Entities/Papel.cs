namespace ToroChallenge.PapelContexto.Domain.Entities
{
    public class Papel
    {
        public Papel(string codigo, double valor)
        {
            Codigo = codigo;
            Valor = valor;
        }

        public string Codigo { get; private set; }
        public double Valor { get; private set; }
    }
}
