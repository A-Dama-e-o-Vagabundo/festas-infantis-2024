using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private RepositorioCliente repositorioCliente;
        private ListagemClienteControl listagemCliente;

        public ControladorCliente(RepositorioCliente repositorio)
        {
            this.repositorioCliente = repositorio;
        }

        public override string TipoCadastro { get { return "Clientes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo cliente"; } }

        public override string ToolTipEditar { get { return "Editar um cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um cliente existente"; } }

        public override void Adicionar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Cliente novoCliente = telaCliente.Cliente;

                repositorioCliente.Cadastrar(novoCliente);

                CarregarClientes();
            }
        }
        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
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
