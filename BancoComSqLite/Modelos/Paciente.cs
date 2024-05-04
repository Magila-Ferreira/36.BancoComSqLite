using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoComSqLite.Modelos
{
    public class Paciente
    {
        private long id;
        private string nome;
        private int idade;
        private string cor;

        [PrimaryKey, AutoIncrement]
        public long Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Cor { get => cor; set => cor = value; }
    }
}
