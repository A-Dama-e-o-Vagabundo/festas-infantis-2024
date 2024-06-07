using eAgenda.WinApp.Compartilhado;

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

            CarregarItem();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoItem.Descricao}\" foi criado com sucesso!");
            
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if (listagemItem == null)
            {
                listagemItem = new ListagemItemControl();
            }

            CarregarItem();

            return listagemItem;
        }

        public void CarregarItem()
        {
            List<Item> itens = repositorioItem.SelecionarTodos();

            listagemItem.AtualizarRegistros(itens);
        }
    }
}