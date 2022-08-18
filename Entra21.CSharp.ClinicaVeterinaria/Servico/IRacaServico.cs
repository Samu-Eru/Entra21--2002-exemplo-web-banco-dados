using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico
{
    public interface IRacaServico
    {
        void Cadastrar(RacaCadastrarViewModel racaCadastrarViewModel);
        List<Raca> ObterTodos();
        void Editar(RacaEditarViewModel racaEditarViewModel);
        void Apagar (int id);
        Raca ObterPorId(int id);
    }
}
