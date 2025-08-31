using System;
using System.Collections.Generic;

namespace ProjetoHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public required Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
                Hospedes = hospedes;
            else
                throw new Exception("Número de hóspedes maior que a capacidade da suíte.");
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorReserva()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados > 10)
                valor *= 0.9m;

            return valor;
        }
    }
}