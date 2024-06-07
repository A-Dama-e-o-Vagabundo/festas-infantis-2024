namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class ListagemItemControl : UserControl
    {
        public ListagemItemControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Item> itens)
        {
            listItens.Items.Clear();

            foreach (Item item in itens)
            {
                listItens.Items.Add(item);
            }
        }

        public Item ObterRegistroSelecionado()
        {
            if (listItens.SelectedItem == null)
                return null;

            return (Item)listItens.SelectedItem;
        }
    }
}
