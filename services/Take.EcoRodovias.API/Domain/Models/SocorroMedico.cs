using System;
using Take.EcoRodovias.API.Domain.ValuesObjects;

namespace Take.EcoRodovias.API.Domain.Models
{
    public class SocorroMedico : Services
    {
        public SocorroMedico(string rodovia, string origem, string destino, string distancia)
        {
            Rodovia = rodovia;
            Origem = origem;
            Destino = destino;
            Distancia = distancia;
            Validate();
        }

        public override void SetTempoMedio()
        {
            var tempo = new Random().Next(30, 90);
            
            TempoMedio = $"O tempo médio para chegada do socorro é de {tempo} minutos";
        }
    }
}
