using System;
using System.Collections.Generic;

namespace Take.EcoRodovias.API.Domain.ValuesObjects
{
    public abstract class Services : Entity
    {
        public string TempoMedio { get; set; }
        public string Distancia { get; set; }

        public abstract void SetTempoMedio();
        protected virtual void SetDistancia() 
        {
            Random randNum = new Random();

            var trecho = new List<string>
            {
                "68 KM",
                "70 KM",
                "12 KM",
                "134 KM",
                "41 KM",
                "171 KM",
                "130 KM",
                "88 KM"
            };

            Distancia = trecho[randNum.Next(0, 7)];
        }

    }
}
