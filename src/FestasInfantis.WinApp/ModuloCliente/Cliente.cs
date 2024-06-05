using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, string telefone, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Cliente atualizado = (Cliente)novoRegistro;

            Nome = atualizado.Nome;
            Telefone = atualizado.Telefone;
            Cpf= atualizado.Cpf;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O tampo \"nome\" é obrigatório");
            if (string.IsNullOrEmpty(Telefone))
                erros.Add("O campo \"telefone\" é obrigatório");
            if (string.IsNullOrEmpty(Cpf))
                erros.Add("O campo \"CPF\" é obrigatório ");

            return erros;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Telefone: {Telefone}, CPF: {Cpf}";
        }
    }
}
