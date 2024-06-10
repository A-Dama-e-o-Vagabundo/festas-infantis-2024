using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    internal class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public string ValorTotal { get; set; }
        public Item Itens { get; set; }

        public Tema(string nome, string valorTotal, Item itens)
        {
            Nome = nome;
            ValorTotal = valorTotal;
            Itens = itens;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizado = (Tema)novoRegistro;

            Nome = atualizado.Nome;
            ValorTotal = atualizado.ValorTotal;
            Itens = atualizado.Itens;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo \"nome\" é obrigatório");
            if (string.IsNullOrEmpty(ValorTotal))
                erros.Add("O campo \"valor\" é obrigatório");
            if (Itens == null)
                erros.Add("O campo \"itens\" é obrigatório ");

            return erros;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Valor: {ValorTotal}";
        }
    }
}
