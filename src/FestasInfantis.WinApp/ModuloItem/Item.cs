using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public string Valor { get; set; }

        public Item(string descricao,string valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Descricao))
                erros.Add("O campo \"descricao\" é obrigatório");
            if (string.IsNullOrEmpty(Valor))
                erros.Add("O campo \"valor\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item atualizado = (Item)novoRegistro;

            Descricao = atualizado.Descricao;
            Valor = atualizado.Valor;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Descricao: {Descricao}, Valor: {Valor}";
        }
    }
}
