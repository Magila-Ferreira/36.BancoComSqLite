using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoComSqLite.Servicos
{
    public static class Constantes
    {
        //nome para o banco de dados
        public const string nomeArquivoBD = "atendimento.db3";
        // características de acesso ao banco de dados
        public const SQLite.SQLiteOpenFlags Flags =
        // Abre o banco de dados no mode de leitura e gravação
        SQLite.SQLiteOpenFlags.ReadWrite |
        // cria o banco de dados se este não existir
        SQLite.SQLiteOpenFlags.Create |
        // habilita o acesso ao banco de dados por múltiplas threads
        SQLite.SQLiteOpenFlags.SharedCache;
        // caminho para o banco de dados
        public static string CaminhoBD
        { // método para obter o caminho
            get
            { // atributo local deste método
                var caminhoBase = Environment.GetFolderPath(Environment.
                SpecialFolder.LocalApplicationData);
                // retorna o caminho completo _ nome do banco de dados.
                return Path.Combine(caminhoBase, nomeArquivoBD);
            }
        }
    }
}
