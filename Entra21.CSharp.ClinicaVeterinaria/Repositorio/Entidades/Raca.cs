using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades
{
    // Entidades: são representações das tabelas para classe de objetos
    public class Raca
    {
        public int Id { get; set; }

        public string Nome { get; set;}
        public string Especie { get; set; }
    }
}
