using System;
using System.Collections.Generic;

namespace Take.EcoRodovias.API.Domain.ValuesObjects
{
    public abstract class Entity
    {
        public string Rodovia { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }

        public List<string> Rodovias { get; set; }
        public List<string> Localidades { get; set; }

        protected Entity()
        {
            Rodovias = new List<string>();
            Localidades = new List<string>();

            SetRodovias();
            SetCidades();
        }

        protected void Validate()
        {
            CheckRodovia();
        }

        private void CheckDestino()
        {
            if (!Localidades.Contains(Destino))
                throw new Exception("Não foi possível identificar o destino da Viagem");
        }

        private void CheckOrigem()
        {
            if (!Localidades.Contains(Origem))
                throw new Exception("Não foi possível identificar a origem da Viagem");
        }

        private void CheckRodovia()
        {
            if (!Rodovias.Contains(Rodovia))
                throw new Exception("A rodovia informada não faz parte da EcoRodovias");
        }

        private void SetRodovias() 
        {
            var rodovias = new List<string> { 
                "SP 160",
                "SP 150",
                "SP 040",
                "SP 059",
                "SP 055",
                "SP 248",
                "Rodovia Helio Smidt",
                "Rodovia Ayrton Senna",
                "Rodovia Governador Carvalho Pinto",
                "Rodovia dos Tamoios",
                "Interligação SPI 117/060",
                "BR 277",
                "PR 407",
                "PR 508",
                "BR 116",
                "BR 392",
                "Rodvia Governador Mario Covas",
                "Ponte Rio-Niteroi",
            };

            Rodovias.AddRange(rodovias);
        }

        private void SetCidades()
        {
            var localidades = new List<string>
            {
                "São Paulo",
                "Litoral",
                "Anchieta",
                "Imigrantes",
                "Guarujá",
                "Praia Grande",
                "Aeroporto",
                "Ayrton Senna",
                "Interior",
                "São José",
                "Campos do Jordão",
                "Taubaté",
                "Paranaguá",
                "Curitiba",
                "Praia de Leste",
                "Matinhos",
                "Foz do Iguaçu",
                "Guarapuava",
                "Jaguarão",
                "Camaquã"
            };

            Localidades.AddRange(localidades);
        }


    }
}
