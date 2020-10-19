using System;
using Take.EcoRodovias.API.Domain.ValuesObjects;

namespace Take.EcoRodovias.API.Domain.Models
{
    public class Guincho : Services
    {
        public Guincho(string rodovia, string distancia)
        {
            Rodovia = rodovia;
            Distancia = distancia;
        }

        public override void SetTempoMedio()
        {
            var tempo = new Random().Next(30, 60);

            TempoMedio = $"{tempo}";
        }
    }
}
