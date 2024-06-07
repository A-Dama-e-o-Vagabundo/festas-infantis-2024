using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        private RepositorioItem repositorioItem;
        private ListagemItemControl listagemItem;

        public ControladorItem(RepositorioItem repositorioItem)
        {
            this.repositorioItem = repositorioItem;
        }

        public override string TipoCadastro { get { return "Itens"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo item"; } }

        public override string ToolTipEditar { get { return "Editar um item existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um item existente"; } }

        public override void Adicionar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            DialogResult resultado = telaItem.ShowDialog();
            
            if (resultado != DialogResult.OK)
                return;

            Item novoItem = telaItem.Item;

            repositorioItem.Cadastrar(novoItem);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoItem.Descricao}\" foi criado com sucesso!");
            
        }

        public override void Editar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            Item itemSelecionado = listagemItem.ObterRegistroSelecionado();

            telaItem.Item = itemSelecionado;

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item itemEditado = telaItem.Item;

            repositorioItem.Editar(itemSelecionado.Id, itemEditado);

            CarregarItens();
        }

        public override void Excluir()
        {
            Item clienteSelecionado = listagemItem.ObterRegistroSelecionado();

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{clienteSelecionado.Descricao}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioItem.Excluir(clienteSelecionado.Id);

            CarregarItens();
        }

        public override UserControl ObterListagem()
        {
            if (listagemItem == null)
            {
                listagemItem = new ListagemItemControl();
            }

            CarregarItens();

            return listagemItem;
        }

        public void CarregarItens()
        {
            List<Item> itens = repositorioItem.SelecionarTodos();

            listagemItem.AtualizarRegistros(itens);
        }
    }
}