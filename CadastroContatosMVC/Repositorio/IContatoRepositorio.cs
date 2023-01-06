using CadastroContatosMVC.Models;
using System.Collections.Generic;

namespace CadastroContatosMVC.Repositorio
{
    public interface IContatoRepositorio
    {

        ContatoModel ListarPorId(int id);
        List<ContatoModel> TodosRegistros();
        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Editar(ContatoModel contato);

        bool Apagar(int id);


    }
}
