using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Veterinarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico.MapeamentoEntidades
{
    public class VeterinarioMapeamentoEntidade : IVeterinarioMapeamentoEntidade
    {
        public Veterinario ConstruirCom(VeterinarioCadastrarViewModel viewModel)
        {
            return new Veterinario
            {
                Nome = viewModel.Nome,
                Crmv = viewModel.Crmv
            };
        }
    }
}
