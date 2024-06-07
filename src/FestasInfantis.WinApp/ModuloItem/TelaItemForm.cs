using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        public Item item;

        public Item Item
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtDescricao.Text = value.Descricao;
                txtTema.Text = value.Tema;
                txtValor.Text = value.Valor;
            }
            get
            {
                return item;
            }
        }

        public TelaItemForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            string tema = txtTema.Text;
            string valor = txtValor.Text;

            item = new Item(descricao, tema, valor);

            List<string> erros = item.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
