using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp.Util
{
    public class Entidade
    {
        private static int idCaixa = 0;
        private static int idAmigo = 0;
        private static int idEmprestimo = 0;
        private static int idRevista = 0;

        protected static int GerarIdCaixa()
        {
            return ++idCaixa;
        }

        protected static int GerarIdAmigo()
        {
            return ++idAmigo;
        }

        protected static int GerarIdEmprestimo()
        {
            return ++idEmprestimo;
        }

        protected static int GerarIdRevista()
        {
            return ++idRevista;
        }
    }
}
