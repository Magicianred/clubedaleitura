using System;
using ClubeLeitura.ConsoleApp.Util;

namespace ClubeLeitura.ConsoleApp.Dominio
{
    public class Emprestimo : Entidade
    {
        public int id;
        public Amigo amiguinho;
        public Revista revista;
        public DateTime data;
        public DateTime dataDevolucao;

        public Emprestimo()
        {
            id = GerarIdEmprestimo();
        }

        public Emprestimo(int id)
        {
            this.id = id;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            Emprestimo emp = (Emprestimo)obj;

            if (emp != null && emp.id == this.id)
                return true;

            return false;
        }
    }
}
