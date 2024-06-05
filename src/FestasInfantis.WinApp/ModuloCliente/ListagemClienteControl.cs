namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class ListagemClienteControl : UserControl
    {
        public ListagemClienteControl()
        {
            InitializeComponent();

            //listClientes.Items.Add(new Cliente("Eduardo", "(49)999362871", "123.456.789-10"));
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            listClientes.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                listClientes.Items.Add(cliente);
            }
        }
    }
}
