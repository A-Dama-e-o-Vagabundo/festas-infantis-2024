namespace FestasInfantis.WinApp.ModuloItem
{
    public interface IRepositorioItem
    {
        void Cadastrar(Item novoCliente);
        bool Editar(int id, Item clienteEditado);
        bool Excluir(int id);
        Item SelecionarPorId(int id);
        List<Item> SelecionarTodos();
    }
}
