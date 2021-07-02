namespace ControleEscolar_WebAPI.Models
{
    public class TurmaEscola
    {
        public TurmaEscola() { }

        public TurmaEscola(int turmaId, string turma, int escolaId, int escola)
        {
            this.TurmaId = turmaId;
            this.EscolaId = escolaId;
        }
        public int TurmaId { get; set; }
        public string Turma { get; set; }
        public int EscolaId { get; set; }
        public int Escola { get; set; }

    }
}
