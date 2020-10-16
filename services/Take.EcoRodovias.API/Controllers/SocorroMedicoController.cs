using Microsoft.AspNetCore.Mvc;
using Take.EcoRodovias.API.AppService.ViewModels;
using Take.EcoRodovias.API.Domain.Models;

namespace Take.EcoRodovias.API.Controllers
{
    public class SocorroMedicoController : MainController
    {
        [HttpGet("ecorodovias/api/socorromedico/{rodovia}/{origem}/{destino}")]
        public ServiceViewModel GetSocorroMedico(string rodovia, string origem, string destino, string quilometro)
        {
            var socorro = new SocorroMedico(rodovia, origem, destino, quilometro);
            socorro.SetTempoMedio();

            return new ServiceViewModel
            {
                Origem = origem,
                Destino = destino,
                Distancia = quilometro,
                TempoMedio = socorro.TempoMedio
            };
        }
    }
}
