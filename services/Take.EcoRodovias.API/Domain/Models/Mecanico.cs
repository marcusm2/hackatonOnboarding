using System;
using Take.EcoRodovias.API.Domain.ValuesObjects;

namespace Take.EcoRodovias.API.Domain.Models
{
    public class Mecanico : Services
    {
    
        public Mecanico(string rodovia,  string distancia)
        {
            Rodovia = rodovia;
            Distancia = distancia;
        }

        public override void SetTempoMedio()
        {
            var tempo = new Random().Next(40, 115);

            TempoMedio = $"{tempo}";
        }
    }
}
