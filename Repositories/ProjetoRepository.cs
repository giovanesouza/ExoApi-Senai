using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Exo.WebApi.Repositories
{

    // Responsável direta pela manipulação com o banco de dados.
    public class ProjetoRepository
    {

        private readonly ExoContext _context;

        // Construtor
        public ProjetoRepository(ExoContext context)
        {
            _context = context;
        }

        // Lista todos os cadastros
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

    }
}