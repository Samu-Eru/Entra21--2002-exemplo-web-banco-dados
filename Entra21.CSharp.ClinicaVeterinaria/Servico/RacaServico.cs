using Entra21.CSharp.ClinicaVeterinaria.Repositorio;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{
    //A classe RacaServico irá implementar a interface IRacaServico
    // Ou seja, deverá honrar as clausulas definidos na interface (contratos)
    public class RacaServico : IRacaServico
    {
        private RacaRepositorio racaRepositorio;


        // Contrutor: construir o objeto de RacaServico com o mínimo para a correta execução
        public RacaServico(ClinicaVeterinariaContexto contexto)
        {
            racaRepositorio = new RacaRepositorio(contexto);
        }

        public void Cadastrar(string nome, string especie)
        {
            var raca = new Raca();
            raca.Nome = nome;
            raca.Especie = especie;

            racaRepositorio.Cadastrar(raca);
            Console.WriteLine($"Nome: {nome} especie: {especie}");
        }
    }
}
