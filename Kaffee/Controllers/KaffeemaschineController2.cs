using Microsoft.AspNetCore.Mvc;
using KaffeemaschinenVar;

namespace Kaffee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeemaschinenController2 : ControllerBase
    {
        private KaffeemaschineClass Kaffeemaschine;

        public KaffeemaschinenController2(KaffeemaschineClass Kaffeemaschine)
        {
            this.Kaffeemaschine = Kaffeemaschine;
        }


        [HttpGet, Route("WasserMenge")]
        public double getWasser()
        {
            return Kaffeemaschine.Wasser;
        }
    }
}