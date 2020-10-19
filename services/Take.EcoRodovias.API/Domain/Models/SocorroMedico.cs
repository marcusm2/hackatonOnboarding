using System;
using Take.EcoRodovias.API.Domain.ValuesObjects;

namespace Take.EcoRodovias.API.Domain.Models
{
    public class SocorroMedico : Services
    {
        public SocorroMedico(string rodovia, string distancia)
        {
            Rodovia = rodovia;
            Distancia = distancia;
            Validate();
        }

        public override void SetTempoMedio()
        {
            var tempo = new Random().Next(15, 30);
            
            TempoMedio = $"{tempo}";
        }
    }
}
