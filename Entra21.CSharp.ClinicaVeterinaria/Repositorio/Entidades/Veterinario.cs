namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades
{
    public class Veterinario : EntidadeBase
    {
        // prop + tab + tab
        public string Nome { get; set; }
        public string Crmv { get; set; }
        public int? Idade { get; set; }
        public decimal? Salario { get; set; }
        public bool Empregado { get; set; }

        //public Veterinario ConstruirCom(RacaView)
        //{
        //    Nome = 
        //}
    }
}
