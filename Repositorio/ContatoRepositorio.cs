using SistemaDeCadastros.Data;
using SistemaDeCadastros.Models;

namespace SistemaDeCadastros.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        { 
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> BuscarTodos()
        {
                return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            //Adicionar no Banco de Dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}
