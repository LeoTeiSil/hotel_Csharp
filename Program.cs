using ProjetoHotel.Models;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var hospede1 = new Pessoa { Nome = "Leonardo", Idade = 16 };
        var hospede2 = new Pessoa { Nome = "Isabella", Idade = 15 };

        var suite = new Suite { Tipo = "Luxo", Capacidade = 2, ValorDiaria = 150 };

        var reserva = new Reserva
        {
            Suite = suite,
            DiasReservados = 12
        };

        reserva.CadastrarHospedes(new List<Pessoa> { hospede1, hospede2 });

        Console.WriteLine("Quantidade de hóspedes: " + reserva.ObterQuantidadeHospedes());
        Console.WriteLine("Valor total da reserva: R$ " + reserva.CalcularValorReserva());
    }
}