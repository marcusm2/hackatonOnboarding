using System;
using Take.EcoRodovias.API.Domain.ValuesObjects;

namespace Take.EcoRodovias.API.Domain.Models
{
    public class Guincho : Services
    {
        public Guincho(string rodovia, string origem, string destino, string distancia)
        {
            Rodovia = rodovia;
            Origem = origem;
            Destino = destino;
            Distancia = distancia;
        }

        public override void SetTempoMedio()
        {
            var tempo = new Random().Next(150, 180);

            TempoMedio = $"O tempo médio para chegada do guincho é de {tempo} minutos";
        }
    }
}
