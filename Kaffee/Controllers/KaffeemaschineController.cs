using Microsoft.AspNetCore.Mvc;
using KaffeemaschinenVar;

namespace Kaffee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Kaffee : ControllerBase
    {
        public static Kaffeemaschine Kaffeemaschine = new Kaffeemaschine();

        [HttpPut, Route("WasserAuffuellen")]
        public string WasserAuffuellen(double menge)
        {
            return Kaffeemaschine.WasserAuffuellen(menge);
        }

        [HttpPut, Route("BohnenAuffüllen")]
        public string BohnenAuffuellen(double menge)
        {
            return Kaffeemaschine.BohnenAuffuellen(menge);
        }
    }
}