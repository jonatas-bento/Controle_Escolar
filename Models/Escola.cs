namespace ControleEscolar_WebAPI.Models
{
    public class Escola
    {
        public Escola() { }
        public Escola(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;

        }
        public int Id { get; set; }
        public string Nome { get; set; }

    }
}