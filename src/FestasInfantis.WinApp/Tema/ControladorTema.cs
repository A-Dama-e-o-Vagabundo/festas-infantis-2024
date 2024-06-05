using System;
using System.Collections.Generic;
using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.Compartilhado;

public class ControladorTema : ControladorBase
{
    private RepositorioBase<Tema> repositorio;

    public ControladorTema(RepositorioBase<Tema> repositorio)
    {
        this.repositorio = repositorio;
    }

    public override string TipoCadastro => "Cadastro de Tema de Festa Infantil";
    public override string ToolTipAdicionar => "Adicionar novo tema de festa infantil";
    public override string ToolTipEditar => "Editar tema de festa infantil existente";
    public override string ToolTipExcluir => "Excluir tema de festa infantil existente";

    public override UserControl ObterListagem()
    {
        throw new NotImplementedException();
    }

    public override void Adicionar()
    {
        Console.Write("Nome do Tema: ");
        string nome = Console.ReadLine();

        Console.Write("Valor: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Itens Necessários (digite 'fim' para terminar):");
        List<string> itensNecessarios = new List<string>();
        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "fim")
            {
                break;
            }
            itensNecessarios.Add(item);
        }

        Console.WriteLine("Itens de Aluguel (digite 'fim' para terminar):");
        List<string> itensAluguel = new List<string>();
        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "fim")
            {
                break;
            }
            itensAluguel.Add(item);
        }

        Tema tema = new Tema(nome, valor, itensNecessarios, itensAluguel);
        var erros = tema.Validar();
        if (erros.Count > 0)
        {
            foreach (var erro in erros)
            {
                Console.WriteLine(erro);
            }
            return;
        }

        repositorio.Cadastrar(tema);
        Console.WriteLine("Tema cadastrado com sucesso!");
    }

    public override void Editar()
    {
        Console.Write("Digite o ID do tema que deseja editar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (!repositorio.Existe(id))
        {
            Console.WriteLine("ID nao encontrado!");
            return;
        }

        Console.Write("Nome do Tema: ");
        string nome = Console.ReadLine();

        Console.Write("Valor: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Itens Necessarios (digite 'fim' para terminar):");
        List<string> itensNecessarios = new List<string>();
        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "fim")
            {
                break;
            }
            itensNecessarios.Add(item);
        }

        Console.WriteLine("Itens de Aluguel (digite 'fim' para terminar):");
        List<string> itensAluguel = new List<string>();
        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "fim")
            {
                break;
            }
            itensAluguel.Add(item);
        }

        Tema temaAtualizado = new Tema(nome, valor, itensNecessarios, itensAluguel);
        var erros = temaAtualizado.Validar();
        if (erros.Count > 0)
        {
            foreach (var erro in erros)
            {
                Console.WriteLine(erro);
            }
            return;
        }

        if (repositorio.Editar(id, temaAtualizado))
        {
            Console.WriteLine("Tema editado com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro ao editar o tema.");
        }
    }

    public override void Excluir()
    {
        Console.Write("Digite o ID do tema que deseja excluir: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (!repositorio.Existe(id))
        {
            Console.WriteLine("ID não encontrado!");
            return;
        }

        if (repositorio.Excluir(id))
        {
            Console.WriteLine("Tema excluido com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro ao excluir o tema.");
        }
    }
}
