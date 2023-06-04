using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Exo.WebApi.Controllers
{

    /*  Controlador da API. Ela trabalha com a classe ProjetoRepository.cs e com as operações de manipulação do banco de dados. */

    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {

// Alterado _projeto
        private readonly ProjetoRepository _projetoRepository;

        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        // Método responsável por listar todos os cadastros
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_projetoRepository.Listar());
        }
    }
}


