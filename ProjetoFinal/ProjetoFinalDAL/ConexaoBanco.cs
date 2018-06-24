using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalDAL
{
    public class ConexaoBanco
    {

        private static ProjetoFinalDataContext conexao_Banco;

        public static ProjetoFinalDataContext Conexao_Banco
        {
            get
            {
                if (conexao_Banco == null)
                    conexao_Banco = new ProjetoFinalDataContext();

                return conexao_Banco;

            }
        }


    }
}
