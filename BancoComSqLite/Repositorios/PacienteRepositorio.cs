using BancoComSqLite.Modelos;
using BancoComSqLite.Servicos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoComSqLite.Repositorios
{
    public class PacienteRepositorio
    {
        // Variável que guardará o tipo de conexão: contexto
        private SQLiteConnection _contexto;

        // Acesso com o banco de dados - com construtor
        public PacienteRepositorio()
        {
            _contexto = new BancoD().Conexao();

            // Verifica se já existe uma tabela paciente
            if (! _contexto.GetTableInfo("Paciente").Any())
            {
                // Cria a tabela paciente
                _contexto.CreateTable<Paciente>();

                // Insere informação no repositório, de forma estática
                _contexto.Insert(new Paciente() { Nome = "Mágila", Idade = 30, Cor = "Vermelho" });
                _contexto.Insert(new Paciente() { Nome = "Gustavo", Idade = 20, Cor = "Amarelo" });
                _contexto.Insert(new Paciente() { Nome = "Lucas", Idade = 28, Cor = "Vermelho" });
            }
        }

        // Devolve uma lista de pacientes em ordem decrescente de cor e crescente de Id
        // p representa o objeto paciente

        public List<Paciente> listarTodos()
        {
            return _contexto.Table<Paciente>().OrderByDescending(p => p.Cor).ThenBy(p => p.Id).ToList();
        }

        // Permite filtrar pacientes por cor
        public List<Paciente> listarPorCor(String cor)
        {
            return _contexto.Table<Paciente>().Where(p => p.Cor == cor).ToList();
        }

        // Permite inserir o objeto paciente no banco de dados 
        public int inserir(Paciente p)
        {
            return _contexto.Insert(p);
        }

        // Buscar informações no banco sobre um Paciente, pelo Id
        public Paciente buscaId(long id)
        {
            return _contexto.Table<Paciente>().FirstOrDefault(p => p.Id == id);
        }

        // Atualizar as informações do paciente
        public int update(Paciente p)
        {
            return _contexto.Update(p);
        }

        // Remover informações do paciente
        public int remove(Paciente p)
        {
            return _contexto.Delete(p);
        }


    }
}
