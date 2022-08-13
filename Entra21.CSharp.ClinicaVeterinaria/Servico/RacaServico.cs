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
        private readonly RacaRepositorio _racaRepositorio;


        // Contrutor: construir o objeto de RacaServico com o mínimo para a correta execução
        public RacaServico(ClinicaVeterinariaContexto contexto)
        {
            _racaRepositorio = new RacaRepositorio(contexto);
        }

        public void Alterar(int id, string nome, string especie)
        {
            var raca = new Raca();
            raca.Id = id;
            raca.Nome = nome.Trim();
            raca.Especie = especie.Trim();

                _racaRepositorio.Atualizar(raca);
        }

        public void Apagar(int id)
        {
            _racaRepositorio.Apagar(id);
        }

        public void Cadastrar(string nome, string especie)
        {
            var raca = new Raca();
            raca.Nome = nome;
            raca.Especie = especie;

            _racaRepositorio.Cadastrar(raca);
            Console.WriteLine($"Nome: {nome} especie: {especie}");
        }

        public Raca ObterPorId(int id)
        {
            var raca = _racaRepositorio.ObterPorId(id);

            return raca;
        }

        public List<Raca> ObterTodos()
        {
            var racasDoBanco = _racaRepositorio.ObterTodos();
            
            return racasDoBanco;
        }
    }
}
