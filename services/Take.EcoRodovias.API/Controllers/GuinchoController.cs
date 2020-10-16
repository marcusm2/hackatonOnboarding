using Microsoft.AspNetCore.Mvc;
using Take.EcoRodovias.API.AppService.ViewModels;
using Take.EcoRodovias.API.Domain.Models;

namespace Take.EcoRodovias.API.Controllers
{
    public class GuinchoController : MainController
    {
        [HttpGet("ecorodovias/api/guinco/{rodovia}/{origem}/{destino}/{quilometro}")]
        public ServiceViewModel GetGuincho(string rodovia, string origem, string destino, string quilometro)
        {
            var guincho = new Guincho(rodovia, origem, destino, quilometro);
            guincho.SetTempoMedio();
           
            return new ServiceViewModel
            {
                Origem = origem,
                Destino = destino,
                Distancia = quilometro,
                TempoMedio = guincho.TempoMedio
            };
        }
    }
}
