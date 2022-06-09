using Microsoft.AspNetCore.Mvc;
using KaffeemaschinenVar;

namespace Kaffee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeemaschinenController : ControllerBase
    {
        private KaffeemaschineClass Kaffeemaschine;
        
        public KaffeemaschinenController(KaffeemaschineClass Kaffeemaschine)
        {
            this.Kaffeemaschine = Kaffeemaschine;
        }

        [HttpGet, Route("WasserMenge")]
        public double getWasser()
        {
            return Kaffeemaschine.Wasser;
        }

        [HttpGet, Route("BohnenMenge")]
        public double getBohnen()
        {
            return Kaffeemaschine.Bohnen;
        }

        [HttpPost, Route("WasserAuffuellen")]
        public string WasserAuffuellen(double menge)
        {
            return Kaffeemaschine.WasserAuffuellen(menge);
        }

        [HttpPost, Route("BohnenAuffüllen")]
        public string BohnenAuffuellen(double menge)
        {
            return Kaffeemaschine.BohnenAuffuellen(menge);
        }

        [HttpPost, Route("KaffeeMachen")]
        public IActionResult KaffeeMachen(double menge, double verhaeltnisWasserBohnen)
        {
            bool worked = Kaffeemaschine.machKaffee(menge, verhaeltnisWasserBohnen);
            if (worked)
            {
                return Ok("Kaffee gemacht, " + Kaffeemaschine.Wasser + "kg Wasser sind übrig und " + Kaffeemaschine.Bohnen + "kg Bohnensind übrig");
            }
            return Problem("Kaffee konnte nicht gemacht werden");
        }
    }
}