using System.ComponentModel.DataAnnotations;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Racas
{
    public class RacaViewModel
    {
        //Required Obriga a preencher
        [Display(Name = nameof(Nome))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(4, ErrorMessage = "Nome deve conter no mínimo {1} caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve conter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Espécie Animal")]
        [Required(ErrorMessage = "{0} deve ser preenchida")]
        public string Especie { get; set; }
    }
}