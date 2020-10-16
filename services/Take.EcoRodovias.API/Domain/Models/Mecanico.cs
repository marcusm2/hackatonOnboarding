using System;
using Take.EcoRodovias.API.Domain.ValuesObjects;

namespace Take.EcoRodovias.API.Domain.Models
{
    public class Mecanico : Services
    {
    
        public Mecanico(string rodovia, string origem, string destino, string distancia)
        {
            Rodovia = rodovia;
            Origem = origem;
            Destino = destino;
            Distancia = distancia;
        }

        public override void SetTempoMedio()
        {
            var tempo = new Random().Next(60, 180);

            TempoMedio = $"O tempo médio para chegada do mecânico é de {tempo} minutos";
        }
    }
}
