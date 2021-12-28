using DIO.Sports.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIO.Sports.Web.Controllers
{
    [Route("[controller]")]
    public class SportsController : Controller
    {
        private readonly IRepositorio<Sports> _repositorioSports;

        public SportsController(IRepositorio<Sports> repositorioSports)
        {
            _repositorioSports = repositorioSports;
        }

        [HttpGet("")]
       public IActionResult Lista()
        {
            return Ok(_repositorioSports.Lista().Select(s => new SportsModel(s)));
        }

        [HttpPut("{id}")]
        public IActionResult Atualiza(int id, SportsModel model)
        { 
            _repositorioSports.Atualiza(id, model.ToSports());
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Exclui(int id)
        {
            _repositorioSports.Exclui(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult Consulta(int id)
        {
            return Ok(new SportsModel(_repositorioSports.Lista().FirstOrDefault(s => s.Id == id)));
        }

        [HttpPost("")]
        public IActionResult Insere([FromBody] SportsModel model)
        {
            model.Id = _repositorioSports.ProximoId();

            Sports sports = model.ToSports();

            _repositorioSports.Insere(sports);
            return Created("", sports);
        }
    }
}
