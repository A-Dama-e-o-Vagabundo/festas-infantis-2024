using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private RepositorioCliente repositorioCliente;
        private ListagemClienteControl listagemCliente;

        public ControladorCliente(RepositorioCliente repositorio)
        {
            repositorioCliente = repositorio;
        }

        public override string TipoCadastro { get { return "Clientes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo cliente"; } }

        public override string ToolTipEditar { get { return "Editar um cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um cliente existente"; } }

        public override void Adicionar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;
            
            Cliente novoCliente = telaCliente.Cliente;

            repositorioCliente.Cadastrar(novoCliente);

            CarregarClientes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoCliente.Nome}\" foi criado com sucesso!");
        }
        public override void Editar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            Cliente clienteSelecionado = listagemCliente.ObterRegistroSelecionado();

            telaCliente.Cliente = clienteSelecionado;
            
            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente clienteEditado = telaCliente.Cliente;

            repositorioCliente.Editar(clienteSelecionado.Id, clienteEditado);

            CarregarClientes();
        }

        public override void Excluir()
        {
            Cliente clienteSelecionado = listagemCliente.ObterRegistroSelecionado();

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{clienteSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioCliente.Excluir(clienteSelecionado.Id);

            CarregarClientes();
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            listagemCliente.AtualizarRegistros(clientes);
        }

        public override UserControl ObterListagem()
        {
            if (listagemCliente == null)
            {
                listagemCliente = new ListagemClienteControl();
            }

            CarregarClientes();

            return listagemCliente;
        }
    }
}
