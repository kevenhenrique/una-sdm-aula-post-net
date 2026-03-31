using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulasMetodosHttp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulasMetodosHttp.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private static List<Produto> _produtos = new();


        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return Ok(_produtos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto novoProduto)
        {
            _produtos.Add(novoProduto);

            return CreatedAtAction(nameof(Get), new { id = novoProduto.Id }, novoProduto);
        }
    }
}