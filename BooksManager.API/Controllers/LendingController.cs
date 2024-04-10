using BaseLibraryData.Entities;
using GerenciadorLivros.API.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorLivros.API.Controllers
{
    [Route("api/lendings")]
    [ApiController]
    public class LendingController : ControllerBase
    {
        private readonly LendingsDbContext _lendingsContext;

        public LendingController(LendingsDbContext lendingsContext)
        {
            _lendingsContext = lendingsContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var lendings = _lendingsContext.Lendings.ToList();
            return Ok(lendings);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var lending = _lendingsContext.Lendings.SingleOrDefault(e => e.Id == id);
            
            if(lending is null)
            {
                return NotFound();
            }

            return Ok(lending);
        }

        [HttpPost]
        public IActionResult Post(Lending lending)
        {
            _lendingsContext.Lendings.Add(lending);

            return CreatedAtAction(nameof(GetById), new { id = lending.Id }, lending);
        }

    }
}
