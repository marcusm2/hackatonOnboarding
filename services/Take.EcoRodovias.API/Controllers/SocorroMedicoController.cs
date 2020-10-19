using Microsoft.AspNetCore.Mvc;
using Take.EcoRodovias.API.AppService.ViewModels;
using Take.EcoRodovias.API.Domain.Models;

namespace Take.EcoRodovias.API.Controllers
{
    public class SocorroMedicoController : MainController
    {
        [HttpGet("ecorodovias/api/socorromedico/{rodovia}/{quilometro}")]
        public ServiceViewModel GetSocorroMedico(string rodovia, string quilometro)
        {
            var socorro = new SocorroMedico(rodovia, quilometro);
            socorro.SetTempoMedio();

            return new ServiceViewModel
            {
                Distancia = quilometro,
                TempoMedio = socorro.TempoMedio
            };
        }
    }
}
