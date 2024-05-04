using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoComSqLite.Servicos
{
    public class BancoD
    {
        private static SQLiteConnection Database;
        public BancoD()
        {
            if (Database == null)
            {
                Database = new SQLiteConnection(Constantes.CaminhoBD,
                Constantes.Flags);
            }
        }
        public SQLiteConnection Conexao()
        {
            return Database;
        }
    }
}
