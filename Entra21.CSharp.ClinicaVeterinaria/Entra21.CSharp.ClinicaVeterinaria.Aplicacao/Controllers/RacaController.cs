//git config --global core.editor "code --wait"

using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Enums;
using Entra21.CSharp.ClinicaVeterinaria.Servico;
using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplicacao.Controllers
{
    //dois pontos Herença (EXPLICADO)
    public class RacaController : Controller
    {
        private readonly IRacaServico _racaServico;


        //construtor: objetivo construir o objeto de RacaController.
        //com o mínimo necessário para o funcionamento correto
        public RacaController(ClinicaVeterinariaContexto contexto )
        {
            _racaServico = new RacaServico(contexto);
        }


        /// <summary>
        /// Endpoint que permite listar todas as raças
        /// </summary>
        /// <returns>Retorna a página html com as raças</returns>
        //[Route("/raca")]
        [HttpGet ("/raca")]

        public IActionResult ObterTodos()
        {
            var racas = _racaServico.ObterTodos();

            //Passar informações do C# para o HTML
            ViewBag.Racas = racas;

            return View("Index");
        }



        //EXEMPLO DE OVERLOAD
        //[Route("/raca/cadastrar")]
        [HttpGet("/raca/cadastrar")]

        public IActionResult Cadastrar()    
        {
            var especies = ObterEspecies();

            
            ViewBag.Especies = especies;
            var racaCadastrarViewModel = new RacaCadastrarViewModel();

            return View(racaCadastrarViewModel);
        }

        // [Route("/raca/cadastrar")]
        [HttpPost("/raca/cadastrar")]
        public IActionResult Cadastrar(
            [FromForm] RacaCadastrarViewModel racaCadastrarViewModel)
        {
            //Valida o parametro recebido na Action se é inválido
            if (!ModelState.IsValid)
            {
                ViewBag.Especies = ObterEspecies();
                return View(racaCadastrarViewModel);
            }
            _racaServico.Cadastrar(racaCadastrarViewModel);
            return RedirectToAction("Index");
        }





        //[Route ("/raca/apagar")]
        [HttpGet("/raca/apagar")]
        //https://localhost:porta/raca/apagar?id-4
        public IActionResult Apagar([FromQuery] int id)
        {
            _racaServico.Apagar(id);

            return RedirectToAction("Index");
        }

        [HttpGet("/raca/editar")]
        //[Route("/raca/editar")]

        //'Método' para permitir modificar as infos 
        public IActionResult Editar([FromQuery] int id)
        {
            var raca = _racaServico.ObterPorId(id);
            List<string> especies = ObterEspecies();

            ViewBag.Raca = raca;
            ViewBag.Especies = especies.ToList();

            return View("Editar");
        }

        [HttpPost("/raca/editar")]
        //[Route("/raca/editar")]
        //Método para salvar já com as infos modificadas
        public IActionResult Editar(
            [FromForm] RacaEditarViewModel racaEditarViewModel)
        {
            _racaServico.Editar(racaEditarViewModel);

            return RedirectToAction("Index");
        }

        private List<string> ObterEspecies()
        {
            return Enum.GetNames<Especie>()
                .OrderBy(x => x)
                .ToList();
        }
    }
}
