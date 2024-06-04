using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.Cliente;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorFiltravel controladorFiltravel)
                btnFiltrar.ToolTipText = controladorFiltravel.ToolTipFiltrar;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarToolTips();

            HabilitandoBotoes();

            lblTipoCadastro.Text = "Cadastro de Clientes";

            ListagemClienteControl listagemClienteControl = new ListagemClienteControl();
            listagemClienteControl.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemClienteControl);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void HabilitandoBotoes()
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnAdicionarItens.Enabled = true;
            btnConcluirAluguel.Enabled = true;
            btnFiltrar.Enabled = true;
            btnVisualizarAlugueis.Enabled = true;
            btnConfigurarDescontos.Enabled = true;
        }

        private void ConfigurarToolTips()
        {
            controlador = new ControladorCliente();

            btnAdicionar.ToolTipText = controlador.ToolTipAdicionar;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;

            btnAdicionarItens.ToolTipText = "Adicionar item";
            btnConcluirAluguel.ToolTipText = "Concluir Aluguel";
            btnFiltrar.ToolTipText = "Filtrar";
            btnVisualizarAlugueis.ToolTipText = "Visualizar aluguéis";
            btnConfigurarDescontos.ToolTipText = "Configurar descontos";
        }

    }
}
