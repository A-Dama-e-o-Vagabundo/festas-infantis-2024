using System;
using System.Collections.Generic;
using eAgenda.ConsoleApp.Compartilhado;

public class Tema : EntidadeBase
{
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public List<string> ItensNecessarios { get; set; }
    public List<string> ItensAluguel { get; set; }

    public Tema(string nome, decimal valor, List<string> itensNecessarios, List<string> itensAluguel)
    {
        Nome = nome;
        Valor = valor;
        ItensNecessarios = itensNecessarios;
        ItensAluguel = itensAluguel;
    }

    public override List<string> Validar()
    {
        var erros = new List<string>();
        if (string.IsNullOrEmpty(Nome))
            erros.Add("O nome do tema nao pode ser vazio.");
        if (Valor <= 0)
            erros.Add("O valor deve ser maior que zero.");
        if (ItensNecessarios == null || ItensNecessarios.Count == 0)
            erros.Add("Deve haver ao menos um item.");
        if (ItensAluguel == null || ItensAluguel.Count == 0)
            erros.Add("Deve haver ao menos um item de aluguel.");
        return erros;
    }

    public override void AtualizarRegistro(EntidadeBase novoRegistro)
    {
        var temaAtualizado = novoRegistro as Tema;
        if (temaAtualizado != null)
        {
            Nome = temaAtualizado.Nome;
            Valor = temaAtualizado.Valor;
            ItensNecessarios = temaAtualizado.ItensNecessarios;
            ItensAluguel = temaAtualizado.ItensAluguel;
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Tema: {Nome}");
        Console.WriteLine($"Valor: R$ {Valor}");
        Console.WriteLine("Itens Necessários: ");
        foreach (var item in ItensNecessarios)
        {
            Console.WriteLine($"- {item}");
        }
        Console.WriteLine("Itens de Aluguel: ");
        foreach (var item in ItensAluguel)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
