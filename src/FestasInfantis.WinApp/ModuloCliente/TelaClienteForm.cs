namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        public Cliente Cliente { get { return cliente; } }

        public TelaClienteForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string cpf = txtCpf.Text;

            cliente = new Cliente(nome, telefone, cpf);
        }
    }
}
