using System;
using System.Collections.Generic;
using Take.EcoRodovias.API.Domain.ValuesObjects;

namespace Take.EcoRodovias.API.Domain.Models
{
    public class Trafego : Entity
    {
       
        public string TempoDeViagem { get; private set; }
        public string Fluxo { get; private set; }
      
        public string Pedagio { get; private set; }

        public Trafego(string rodovia, string origem, string destino)
        {
            Rodovia = rodovia;
            Origem = origem;
            Destino = destino;
            Validate();
        }

        public void SetFluxo()
        {
            Random randNum = new Random();

            var fluxos = new List<string> 
            {
                "Normal",
                "Excesso de Veículos",
                "Acidente na Pista"
            };

            Fluxo = fluxos[randNum.Next(0, 2)];
            
        }

        public void SetTempoViagem()
        {
            Random randNum = new Random();

            var tempo = new List<string>
            {
                "2h 45m",
                "1h 32m",
                "1h 12m",
                "3h 44m",
                "0h 39m",
                "3h 25m",
                "2h 07m",
                "03h 56m",
                "0h 22m",
            };

            TempoDeViagem = tempo[randNum.Next(0, 8)];
        }

        public void SetPedagio()
        {
            Random randNum = new Random();

            var pedagios = new List<string>
            {
                "R$ 4,25",
                "R$ 8,44",
                "R$ 3,99",
                "R$ 2,50",
                "R$ 5,87",
                "R$ 18,20"
            };

            Pedagio = pedagios[randNum.Next(0, 5)];
        }

    }
}
