using Microsoft.AspNetCore.Mvc;
using Take.EcoRodovias.API.AppService.ViewModels;
using Take.EcoRodovias.API.Domain.Models;

namespace Take.EcoRodovias.API.Controllers
{
    public class MecanicoController : MainController
    {
        [HttpGet("ecorodovias/api/mecanico/{rodovia}/{quilometro}")]
        public ServiceViewModel GetMecanico(string rodovia, string quilometro)
        {
            var mecanico = new Mecanico(rodovia, quilometro);
            mecanico.SetTempoMedio();

            return new ServiceViewModel
            {
                Distancia = quilometro,
                TempoMedio = mecanico.TempoMedio
            };
        }
    }
}
