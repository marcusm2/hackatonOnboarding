using Microsoft.AspNetCore.Mvc;
using Take.EcoRodovias.API.AppService.ViewModels;
using Take.EcoRodovias.API.Domain.Models;

namespace Take.EcoRodovias.API.Controllers
{
    public class GuinchoController : MainController
    {
        [HttpGet("ecorodovias/api/guinco/{rodovia}/{quilometro}")]
        public ServiceViewModel GetGuincho(string rodovia, string quilometro)
        {
            var guincho = new Guincho(rodovia, quilometro);
            guincho.SetTempoMedio();
           
            return new ServiceViewModel
            {
                Distancia = quilometro,
                TempoMedio = guincho.TempoMedio
            };
        }
    }
}
