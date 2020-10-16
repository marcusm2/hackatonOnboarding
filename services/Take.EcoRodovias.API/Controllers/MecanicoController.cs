using Microsoft.AspNetCore.Mvc;
using Take.EcoRodovias.API.AppService.ViewModels;
using Take.EcoRodovias.API.Domain.Models;

namespace Take.EcoRodovias.API.Controllers
{
    public class MecanicoController : MainController
    {
        [HttpGet("ecorodovias/api/mecanico/{rodovia}/{origem}/{destino}")]
        public ServiceViewModel GetMecanico(string rodovia, string origem, string destino, string quilometro)
        {
            var mecanico = new Mecanico(rodovia, origem, destino, quilometro);
            mecanico.SetTempoMedio();

            return new ServiceViewModel
            {
                Origem = origem,
                Destino = destino,
                Distancia = quilometro,
                TempoMedio = mecanico.TempoMedio
            };
        }
    }
}
