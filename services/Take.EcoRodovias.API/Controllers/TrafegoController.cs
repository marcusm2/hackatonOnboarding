using Microsoft.AspNetCore.Mvc;
using Take.EcoRodovias.API.AppService.ViewModels;
using Take.EcoRodovias.API.Domain.Models;

namespace Take.EcoRodovias.API.Controllers
{
    public class TrafegoController : MainController
    {
        [HttpGet("ecorodovias/api/trafego/{rodovia}/{origem}/{destino}")]
        public TrafegoViewModel GetTrafego(string rodovia, string origem, string destino)
        {
            var trafego = new Trafego(rodovia, origem, destino);
            trafego.SetFluxo();
            trafego.SetPedagio();
            trafego.SetTempoViagem();


            return new TrafegoViewModel
            {
                Rodovia = rodovia,
                Origem = origem,
                Destino = destino,
                Fluxo = trafego.Fluxo,
                TempoDeViagem = trafego.TempoDeViagem,
                Pedagio = trafego.Pedagio
            };


        }
    }
}
